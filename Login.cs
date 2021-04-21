using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinProjektlabor
{
    public partial class Login : Form
    {
        UsbDetect usbDetect;
        Drive drive = new Drive();
        Dbase db = new Dbase("projektlabor");
        string driveName;
        string driveLabel;
        string iButtonID;
        string M_ID;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usbDetect = new UsbDetect();
            usbDetect.DriveDetected += UsbDetect_DriveDetected;
            usbDetect.DriveRemoved += UsbDetect_DriveRemoved;
            cmbx_LoginMaschine.Select();
            cmbx_LoginMaschine.DataSource = db.TableToListOne("maschine","Bezeichnung");
        }


        private void UsbDetect_DriveDetected(object sender, EventArgs e)
        {
            driveName = ((DriveInfoEventArgs)e).DriveName;
            driveLabel = ((DriveInfoEventArgs)e).DriveLabel;

            iButtonID = drive.Start(driveName);

            // Ausgelesene iButtonID abgleichen ob diese existiert.
            bool result = db.QueryToBool($"SELECT * from ibutton WHERE iButtonID = '{iButtonID}'");

            // Wenn die iButtonID existiert wird der Login freigegeben
            if (result) {
                this.Invoke(new Action(() => lbl_Passwort.Visible = true));
                this.Invoke(new Action(() => txtbx_Passwort.Visible = true));
                this.Invoke(new Action(() => btn_Anmelden.Visible = true));
                this.Invoke(new Action(() => lbl_Anmelden.Visible = true));
                this.Invoke(new Action(() => lbl_StatusNachricht.Text = $"USB Stick {driveName} {driveLabel} wurde eingesteckt!"));
                this.Invoke(new Action(() => lbl_StatusNachricht.ForeColor = Color.Green));
            }
            else
            {
                this.Invoke(new Action(() => lbl_StatusNachricht.Text = "Kein valider USB-Stick gefunden."));
                this.Invoke(new Action(() => lbl_StatusNachricht.ForeColor = Color.Red));
            }
        }

        private void UsbDetect_DriveRemoved(object sender, EventArgs e)
        {
            driveName = ((DriveInfoEventArgs)e).DriveName;
            //MessageBox.Show($"Drive {driveName} removed");
            this.Invoke(new Action(() => lbl_Passwort.Visible = false));
            this.Invoke(new Action(() => txtbx_Passwort.Visible = false));
            this.Invoke(new Action(() => btn_Anmelden.Visible = false));
            this.Invoke(new Action(() => lbl_Anmelden.Visible = false));
            this.Invoke(new Action(() => lbl_StatusNachricht.Text = "Bitte USB Stick einstecken!"));
            this.Invoke(new Action(() => lbl_StatusNachricht.ForeColor = Color.Red));
        }

        // Abgleichen des Passworts + der iButtonID
        private void btn_Anmelden_Click(object sender, EventArgs e)
        {
            string EnteredPassword = txtbx_Passwort.Text;

            bool result = db.QueryToBool($"SELECT * from user WHERE Passwort = '{EnteredPassword}' AND iButtonID = '{iButtonID}'");

            if(result)
            {
                if (db.QueryToBool($"SELECT * from zuweisung WHERE MaschinenID = '{M_ID}' AND iButtonID = '{iButtonID}'"))
                {
                    this.Hide();
                    Panel panel = new Panel();
                    panel.M_ID = M_ID;
                    panel.iButtonID = iButtonID;
                    panel.Show();
                }
                else
                {
                    MessageBox.Show("Maschine ist ihnen nicht zugewiesen!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               
            }
            else
            {
                txtbx_Passwort.Text = "";
                MessageBox.Show("Passwort falsch!","Warnung",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        
        //AdminLogin Panel
        private void btn_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            

        }

        //Erscheinen des USB Statuses
        private void cmbx_LoginMaschine_SelectedIndexChanged(object sender, EventArgs e)
        {
            M_ID = db.QueryToStringNew($"select MaschinenID from maschine where Bezeichnung = '{cmbx_LoginMaschine.SelectedItem}'");
            lbl_Status.Visible = true;
            lbl_StatusNachricht.Visible = true;
        }

        //Mit Enter Anmelden
        private void txtbx_Passwort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btn_Anmelden_Click(sender, e);
            }
        }
    }
}

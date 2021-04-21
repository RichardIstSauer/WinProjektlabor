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
        string Keymember;
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
            lbl_Status.Select();
        }


        private void UsbDetect_DriveDetected(object sender, EventArgs e)
        {
            driveName = ((DriveInfoEventArgs)e).DriveName;
            driveLabel = ((DriveInfoEventArgs)e).DriveLabel;

            iButtonID = drive.Start(driveName);

            // Ausgelesene iButtonID abgleichen ob diese existiert.
            bool result = db.QueryToBool($"SELECT * from ibutton WHERE iButtonID = '{iButtonID}'");

            // Wenn die iButtonID existiert und die Config existiert wird der Login freigegeben
            if (iButtonID != "0" && result)
            {
                this.Invoke(new Action(() =>
                {

                    cmbx_LoginMaschine.Items.Clear();
                    Keymember = db.QueryToStringNew($"SELECT Keymember from user WHERE iButtonID='{iButtonID}'");
                    if (Keymember == "1")
                    {
                        cmbx_LoginMaschine.Items.Add("Verwaltung");
                        cmbx_LoginMaschine.SelectedItem = "Verwaltung";
                    }

                    foreach (string row in db.TableToListOne("maschine, zuweisung", "Bezeichnung", $"zuweisung.MaschinenID=maschine.MaschinenID AND iButtonID = '{iButtonID}' AND Aktiv='1'"))
                    {
                        cmbx_LoginMaschine.Items.Add(row);
                    }
                    cmbx_LoginMaschine.Select();
                    lbl_Maschinenauswahl.Visible = true;
                    cmbx_LoginMaschine.Visible = true;
                    lbl_StatusNachricht.Text = $"USB Stick {driveName} {driveLabel} wurde eingesteckt!";
                    lbl_StatusNachricht.ForeColor = Color.Green;
                }));
            }
            else
            {
                this.Invoke(new Action(() =>
                {
                    lbl_StatusNachricht.Text = "Kein valider USB-Stick gefunden.";
                    lbl_StatusNachricht.ForeColor = Color.Red;
                }));
            }
        }

        private void UsbDetect_DriveRemoved(object sender, EventArgs e)
        {
            driveName = ((DriveInfoEventArgs)e).DriveName;
            //MessageBox.Show($"Drive {driveName} removed");
            this.Invoke(new Action(() =>
            {
                lbl_Maschinenauswahl.Visible = false;
                cmbx_LoginMaschine.Visible = false;
                lbl_Passwort.Visible = false;
                txtbx_Passwort.Visible = false;
                btn_Anmelden.Visible = false;
                lbl_Anmelden.Visible = false;
                lbl_StatusNachricht.Text = "Bitte USB Stick einstecken!";
                lbl_StatusNachricht.ForeColor = Color.Red;
            }));
        }

        // Abgleichen des Passworts + der iButtonID
        private void btn_Anmelden_Click(object sender, EventArgs e)
        {
            string EnteredPassword = txtbx_Passwort.Text;

            bool result = db.QueryToBool($"SELECT * from user WHERE Passwort = '{EnteredPassword}' AND iButtonID = '{iButtonID}'");

            if (result)
            {
                this.Hide();
                Panel panel = new Panel();
                panel.M_ID = M_ID;
                panel.Keymember = Keymember;
                panel.iButtonID = iButtonID;
                panel.Show();


            }
            else
            {
                txtbx_Passwort.Text = "";
                MessageBox.Show("Passwort falsch!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (cmbx_LoginMaschine.SelectedItem != "Verwaltung")
            {
                M_ID = db.QueryToStringNew($"select MaschinenID from maschine where Bezeichnung = '{cmbx_LoginMaschine.SelectedItem}'");
                if (M_ID != "")
                {
                    lbl_Passwort.Visible = true;
                    txtbx_Passwort.Visible = true;
                    btn_Anmelden.Visible = true;
                }
            }
            else
            {
                M_ID = "Verwaltung";
                lbl_Passwort.Visible = true;
                txtbx_Passwort.Visible = true;
                btn_Anmelden.Visible = true;
            }
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

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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usbDetect = new UsbDetect();
            usbDetect.DriveDetected += UsbDetect_DriveDetected;
            usbDetect.DriveRemoved += UsbDetect_DriveRemoved;

        }


        private void UsbDetect_DriveDetected(object sender, EventArgs e)
        {
            driveName = ((DriveInfoEventArgs)e).DriveName;
            driveLabel = ((DriveInfoEventArgs)e).DriveLabel;

            iButtonID = drive.Start(driveName);

            bool result = db.QueryToBool($"SELECT * from ibutton WHERE iButtonID = '{iButtonID}'");

            if (iButtonID != "0" && result) {
                this.Invoke(new Action(() => lbl_Passwort.Visible = true));
                this.Invoke(new Action(() => txtbx_Passwort.Visible = true));
                this.Invoke(new Action(() => btn_Anmelden.Visible = true));
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
            this.Invoke(new Action(() => lbl_StatusNachricht.Text = "Bitte USB Stick einstecken!"));
            this.Invoke(new Action(() => lbl_StatusNachricht.ForeColor = Color.Red));
        }

        private void btn_Anmelden_Click(object sender, EventArgs e)
        {
            string EnteredPassword = txtbx_Passwort.Text;

            bool result = db.QueryToBool($"SELECT * from user WHERE Passwort = '{EnteredPassword}' AND iButtonID = '{iButtonID}'");

            if(result)
            {
                MessageBox.Show("Eingeloggt");
            }
            else
            {
                MessageBox.Show("Fehler");
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
            

        }
    }
}

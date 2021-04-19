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
        string driveName;
        string driveLabel;
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

            string iButtonID = drive.Start(driveName);

            this.Invoke(new Action(() => lbl_Passwort.Visible = true));
            this.Invoke(new Action(() => txtbx_Passwort.Visible = true));
            this.Invoke(new Action(() => btn_Anmelden.Visible = true));
            this.Invoke(new Action(() => lbl_StatusNachricht.Text = $"USB Stick {driveName} {driveLabel} wurde eingesteckt!"));
            this.Invoke(new Action(() => lbl_StatusNachricht.ForeColor = Color.Green));
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

        }
    }
}

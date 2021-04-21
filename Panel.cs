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
    public partial class Panel : Form
    {
        Drive drive = new Drive();
        string driveName;
        string driveLabel;
        UsbDetect usbDetect;
        public string M_ID;
        public string iButtonID;
        public string Keymember;
        string start = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
        Dbase db = new Dbase("projektlabor");

        public Panel()
        {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            usbDetect = new UsbDetect();
            usbDetect.DriveDetected += UsbDetect_DriveDetected;
            usbDetect.DriveRemoved += UsbDetect_DriveRemoved;
            lbl_Maschine.Text = db.QueryToStringNew($"SELECT Bezeichnung from maschine WHERE MaschinenID='{M_ID}'");
            pb_Maschine.Image = db.loadImage(M_ID);

            if (Keymember == "0")
            {
                tc_Panel.TabPages.RemoveByKey("tp_Verwaltung");
            }
            else
            {
                if (M_ID == "Verwaltung" || M_ID == null)
                {
                    tc_Panel.TabPages.RemoveByKey("tp_Maschine");
                }
            }
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
                this.Invoke(new Action(() => pn_YesUSB.Visible = true));
                this.Invoke(new Action(() => lbl_StatusNachrichtUSB.Text = $"USB Stick {driveName} {driveLabel} wurde eingesteckt!"));
                this.Invoke(new Action(() => lbl_StatusNachrichtUSB.ForeColor = Color.Green));
            }
            else
            {
                this.Invoke(new Action(() => lbl_StatusNachrichtUSB.Text = "Kein valider USB-Stick gefunden."));
                this.Invoke(new Action(() => lbl_StatusNachrichtUSB.ForeColor = Color.Red));
            }
        }


        private void UsbDetect_DriveRemoved(object sender, EventArgs e)
        {
            if (M_ID != null && M_ID != "Verwaltung") {
                Application.Exit();
            }
        }



        private void Panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (M_ID != null && M_ID != "Verwaltung")
            {
                string ende = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                db.ExecuteQuery($"INSERT INTO log (iButtonID, MaschinenID, Starttime, Endtime) VALUES ('{iButtonID}', '{M_ID}', '{start}', '{ende}');");
            }
            Application.Exit();
        }

        private void tc_Verwaltung_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_USB.DataSource = db.QueryToDataTable("select * from ibutton");
            dgv_Maschinen.DataSource = db.QueryToDataTable("select MaschinenID, Bezeichnung from maschine");
            dgv_Log.DataSource = db.QueryToDataTable("select LogID, Vorname, Nachname, Bezeichnung, Starttime, Endtime from log, user, maschine where log.iButtonID=user.iButtonID and log.MaschinenID=maschine.MaschinenID;");

        }

        private void btn_LöschenMaschinen_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Wirklich Löschen", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int selectedIndex = dgv_Maschinen.SelectedRows[0].Index;
                string rowID = dgv_Maschinen[0, selectedIndex].Value.ToString();

                db.ExecuteQuery($"delete from maschine where MaschinenID='{rowID}'");
                if (!db.QueryToBool($"select * from maschine where MaschinenID='{rowID}'"))
                {
                    dgv_Maschinen.Rows.RemoveAt(selectedIndex);

                }
            }

        }

        private void btn_LöschenUSB_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Wirklich Löschen", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int selectedIndex = dgv_USB.SelectedRows[0].Index;
                string rowID = dgv_USB[0, selectedIndex].Value.ToString();

                db.ExecuteQuery($"delete from ibutton where iButtonID='{rowID}'");
                if (!db.QueryToBool($"select * from ibutton where iButtonID='{rowID}'"))
                {
                    dgv_USB.Rows.RemoveAt(selectedIndex);

                }

            }

        }

      
    }
}


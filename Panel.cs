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
        UsbDetect usbDetect;
        public string M_ID;
        public string iButtonID;
        string Keymember;
        string start = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
        Dbase db = new Dbase("projektlabor");

        public Panel()
        {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            usbDetect = new UsbDetect();
            usbDetect.DriveRemoved += UsbDetect_DriveRemoved;
            Keymember = db.QueryToStringNew($"SELECT Keymember from user WHERE iButtonID='{iButtonID}'");
            lbl_Maschine.Text = db.QueryToStringNew($"SELECT Bezeichnung from maschine WHERE MaschinenID='{M_ID}'");
            pb_Maschine.Image = db.loadImage(M_ID);

            if (Keymember == "0")
            {
                tc_Panel.TabPages.RemoveByKey("tp_Verwaltung");

            }
        }



        private void UsbDetect_DriveRemoved(object sender, EventArgs e)
        {
            string driveName = ((DriveInfoEventArgs)e).DriveName;
            Application.Exit();
        }

        private void Panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (M_ID != null)
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


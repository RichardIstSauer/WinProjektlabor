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
        string start = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss");
        Dbase db = new Dbase("projektlabor");

        public Panel()
        {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            usbDetect = new UsbDetect();
            usbDetect.DriveRemoved += UsbDetect_DriveRemoved;
            dgv_Log.DataSource = db.TableToDataTable("log");
            Keymember = db.QueryToStringNew($"SELECT Keymember from user WHERE iButtonID='{iButtonID}'");
            lbl_Maschine.Text = db.QueryToStringNew($"SELECT Bezeichnung from maschine WHERE MaschinenID='{M_ID}'");
            pb_Maschine.Image = db.loadImage(M_ID);

            if(Keymember == "0")
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
            string ende = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss");
            db.ExecuteQuery($"INSERT INTO log (iButtonID, MaschinenID, Starttime, Endtime) VALUES ('{iButtonID}', '{M_ID}', '{start}', '{ende}');");
            Application.Exit();
        }
    }
}

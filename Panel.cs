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
            Keymember = db.QueryToStringNew($"SELECT Keymember from user WHERE iButtonID='{iButtonID}'");
            lbl_Maschine.Text = db.QueryToStringNew($"SELECT Bezeichnung from maschine WHERE MaschinenID='{M_ID}'");
            pb_Maschine.Image = db.loadImage(M_ID);

            if(Keymember == "0")
            {
                tc_Panel.TabPages.RemoveByKey("tp_Verwaltung");
            }
        }

        private void btn_HinzufügenMaschinen_Click(object sender, EventArgs e)
        {
            //if (txtbx_BezeichnungMaschinen.Text != "")
            //{
            //    db.ExecuteQuery($"Insert into maschine (Bezeichnung) values ('{txtbx_BezeichnungMaschinen.Text}')");
            //}
            //else
            //{
            //    MessageBox.Show("Bitte geben sie eine Bezeichnung für die Maschine ein!");
            //}
            
        }

        private void UsbDetect_DriveRemoved(object sender, EventArgs e)
        {
            string driveName = ((DriveInfoEventArgs)e).DriveName;
            Application.Exit();
        }

        private void Panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (M_ID != null) {
                string ende = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss");
                db.ExecuteQuery($"INSERT INTO log (iButtonID, MaschinenID, Starttime, Endtime) VALUES ('{iButtonID}', '{M_ID}', '{start}', '{ende}');");
            }
            Application.Exit();
        }

        private void tc_Verwaltung_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lsbx_Maschinen.DataSource = db.TableToListOne("maschine", "Bezeichnung");
            //lsbx_USB.DataSource = db.TableToListOne("ibutton", "iButtonID");
            dgv_USB.DataSource = db.QueryToDataTable("select * from ibutton");
            dgv_Maschinen.DataSource = db.QueryToDataTable("select MaschinenID, Bezeichnung from maschine");
            dgv_Log.DataSource = db.QueryToDataTable("select LogID, Vorname, Nachname, Bezeichnung, Starttime, Endtime from log, user, maschine where log.iButtonID=user.iButtonID and log.MaschinenID=maschine.MaschinenID;");
            
        }

        private void btn_LöschenMaschinen_Click(object sender, EventArgs e)
        {
            //db.ExecuteQuery($"delete from maschine where Bezeichnung='{lsbx_Maschinen.SelectedItem}'");
            //lsbx_Maschinen.DataSource = db.TableToListOne("maschine", "Bezeichnung");
        }
    }
}

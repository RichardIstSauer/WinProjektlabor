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

            if(Keymember == "0")
            {
                tc_Panel.TabPages.RemoveByKey("tp_Verwaltung");
            }
        }

        private void btn_HinzufügenMaschinen_Click(object sender, EventArgs e)
        {
            if (txtbx_BezeichnungMaschinen.Text != "")
            {
                db.ExecuteQuery($"Insert into maschine (Bezeichnung) values ('{txtbx_BezeichnungMaschinen.Text}')");
            }
            else
            {
                MessageBox.Show("Bitte geben sie eine Bezeichnung für die Maschine ein!");
            }
            
        }

       

        private void tc_Verwaltung_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbx_Maschinen.DataSource = db.TableToListOne("maschine", "Bezeichnung");
            dgv_Log.DataSource = db.TableToDataTable("log");
            
        }

        private void btn_LöschenMaschinen_Click(object sender, EventArgs e)
        {
            db.ExecuteQuery($"delete from maschine where Bezeichnung='{lsbx_Maschinen.SelectedItem}'");
            lsbx_Maschinen.DataSource = db.TableToListOne("maschine", "Bezeichnung");
        }
    }
}

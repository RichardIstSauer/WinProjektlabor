using MySql.Data.MySqlClient;
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
        Random random = new Random();
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
            dgv_Member.DataSource = db.QueryToDataTable("select UserID, Vorname, Nachname, EMail, Keymember, iButtonID from user where Aktiv='1'");
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

            this.Invoke(new Action(() => lbl_StatusNachrichtUSB.Text = $"USB Stick {driveName} {driveLabel} wurde eingesteckt!"));
            this.Invoke(new Action(() => lbl_StatusNachrichtUSB.ForeColor = Color.Green));

            bool USBhaveUser = db.QueryToBool($"select * from user where iButtonID = '{iButtonID}' and Aktiv='1'");
            if (USBhaveUser)
            {
                this.Invoke(new Action(() => pn_YesUSB.Visible = true));

            }

            
            
           
        }


        private void UsbDetect_DriveRemoved(object sender, EventArgs e)
        {
            if (M_ID != null && M_ID != "Verwaltung") {
                Application.Exit();
            }
            this.Invoke(new Action(() => lbl_StatusNachrichtUSB.Text = "Bitte USB Stick einstecken!"));
            this.Invoke(new Action(() => lbl_StatusNachrichtUSB.ForeColor = Color.Red));
            this.Invoke(new Action(() => pn_YesUSB.Visible = false));
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
            dgv_Member.DataSource = db.QueryToDataTable("select UserID, Vorname, Nachname, EMail, Keymember, iButtonID from user where Aktiv='1'");
            dgv_Maschinen.DataSource = db.QueryToDataTable("select MaschinenID, Bezeichnung from maschine where Aktiv='1'");
            dgv_Log.DataSource = db.QueryToDataTable("select LogID, Vorname, Nachname, Bezeichnung, Starttime, Endtime from log, user, maschine where log.iButtonID=user.iButtonID and log.MaschinenID=maschine.MaschinenID;");

        }

        private void btn_LöschenMaschinen_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Wirklich Löschen", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int selectedIndex = dgv_Maschinen.SelectedRows[0].Index;
                string rowID = dgv_Maschinen[0, selectedIndex].Value.ToString();

                db.ExecuteQuery($"update maschine set Aktiv='0' where MaschinenID='{rowID}'");
                dgv_Maschinen.Rows.RemoveAt(selectedIndex);
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

        private void btn_HinzufügenMaschinen_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Images (*.JPG;*.GIF,*.PNG)|*.JPG;*.GIF;*.PNG;";

            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Bild auswählen";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                    try
                    {
                        string MaschinenID = $"pl{random.Next(5, 200)}";
                        bool result = db.QueryToBool($"select * from maschine where MaschinenID='{MaschinenID}'");
                        if (!result)
                        {
                        byte[] data = db.imageToByte(Image.FromFile(openFileDialog1.FileName));
                        MySqlParameter blob = new MySqlParameter("@Bild", MySqlDbType.MediumBlob, data.Length);
                        blob.Value = data;

                        db.ExecuteQueryImg($"Insert into maschine (MaschinenID,Bezeichnung,Bild) Values ('{MaschinenID}','{txtbx_BezeichnungMaschinen.Text}', @Bild)", blob);
                            dgv_Maschinen.DataSource = db.QueryToDataTable("select MaschinenID, Bezeichnung from maschine where Aktiv='1'");
                            txtbx_BezeichnungMaschinen.Text = "";
                        }
                        else
                        {
                            btn_HinzufügenMaschinen_Click(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
            }
        }

        //Mit Enter Maschine hinzufügen
        private void txtbx_BezeichnungMaschinen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btn_HinzufügenMaschinen_Click(sender, e);
            }
        }

        private void btn_LöschenMember_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Wirklich Löschen", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int selectedIndex = dgv_Member.SelectedRows[0].Index;
                string rowID = dgv_Member[0, selectedIndex].Value.ToString();

                db.ExecuteQuery($"update user set Aktiv='0' where UserID='{rowID}'");
                string iButtonID = db.QueryToStringNew($"select iButtonID from user where UserID='{rowID}'");
                db.ExecuteQuery($"delete from zuweisung where iButtonID='{iButtonID}'");
                dgv_Member.Rows.RemoveAt(selectedIndex);
            }
        }

       
    }
}


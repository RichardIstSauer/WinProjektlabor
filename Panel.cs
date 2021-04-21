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

            cb_iButtonID.Items.Clear();

            foreach (string row in db.TableToListOne("ibutton", "iButtonID", $"ibutton.iButtonID NOT IN (SELECT user.iButtonID FROM user WHERE Aktiv='1')"))
            {
                cb_iButtonID.Items.Add(row);
            }

            if (Keymember == "0" || (Keymember == "1" && M_ID != "Verwaltung"))
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

            bool ButtonIDexists = db.QueryToBool($"select * from ibutton where iButtonID = '{iButtonID}'");
            bool USBhaveUser = db.QueryToBool($"select * from user where iButtonID = '{iButtonID}' and Aktiv='1'");
            if (USBhaveUser)
            {
                this.Invoke(new Action(() => pn_YesUSB.Visible = true));
                string user = db.QueryToStringNew($"select Benutzername from user where iButtonID = '{iButtonID}' and Aktiv='1'");
                this.Invoke(new Action(() =>  lbl_UserUSB.Text = $"User: {user}"));

            }
            else
            {
                this.Invoke(new Action(() => pn_USBNoUser.Visible = true));
            }
            if (!ButtonIDexists)
            {
                this.Invoke(new Action(() => pn_NoUSB.Visible = true));
            }
        }


        private void UsbDetect_DriveRemoved(object sender, EventArgs e)
        {
            if (M_ID != null && M_ID != "Verwaltung")
            {
                Application.Exit();
            }
            this.Invoke(new Action(() => lbl_StatusNachrichtUSB.Text = "Bitte USB Stick einstecken!"));
            this.Invoke(new Action(() => lbl_StatusNachrichtUSB.ForeColor = Color.Red));
            this.Invoke(new Action(() => pn_YesUSB.Visible = false));
            this.Invoke(new Action(() => pn_NoUSB.Visible = false));
            this.Invoke(new Action(() => pn_USBNoUser.Visible = false));
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
            dgv_Zuweisung.DataSource = db.QueryToDataTable("select zuweisung.iButtonID, user.Benutzername, zuweisung.MaschinenID, maschine.Bezeichnung from zuweisung, maschine, user WHERE user.iButtonID=zuweisung.iButtonID AND maschine.MaschinenID=zuweisung.MaschinenID");
            dgv_Member.DataSource = db.QueryToDataTable("select UserID, Vorname, Nachname, EMail, Keymember, iButtonID from user where Aktiv='1'");
            dgv_Maschinen.DataSource = db.QueryToDataTable("select MaschinenID, Bezeichnung from maschine where Aktiv='1'");
            dgv_Log.DataSource = db.QueryToDataTable("select LogID, Vorname, Nachname, Bezeichnung, Starttime, Endtime from log, user, maschine where log.iButtonID=user.iButtonID and log.MaschinenID=maschine.MaschinenID;");

            cmbx_Zuweisungmaschine.Items.Clear();

            foreach (string row in db.TableToListOne("maschine", "Bezeichnung", $"Aktiv='1'"))
            {
                cmbx_Zuweisungmaschine.Items.Add(row);
            }

            cmbx_Zuweisunguser.Items.Clear();

            foreach (string row in db.TableToListOne("user", "Benutzername", $"Aktiv='1'"))
            {
                cmbx_Zuweisunguser.Items.Add(row);
            }

            cb_iButtonID.Items.Clear();

            foreach (string row in db.TableToListOne("ibutton", "iButtonID", $"ibutton.iButtonID NOT IN (SELECT user.iButtonID FROM user WHERE Aktiv='1')"))
            {
                cb_iButtonID.Items.Add(row);
            }
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
                    MessageBox.Show("Error: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                cb_iButtonID.Items.Clear();

                foreach (string row in db.TableToListOne("ibutton", "iButtonID", $"ibutton.iButtonID NOT IN (SELECT user.iButtonID FROM user WHERE Aktiv='1')"))
                {
                    cb_iButtonID.Items.Add(row);
                }
            }
        }

        private void btnLoeschenZuweisung_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Wirklich Löschen", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int selectedIndex = dgv_Zuweisung.SelectedRows[0].Index;
                string rowID = dgv_Zuweisung[0, selectedIndex].Value.ToString();
                string mid = dgv_Zuweisung[2, selectedIndex].Value.ToString();

                db.ExecuteQuery($"DELETE FROM zuweisung where iButtonID='{rowID}' AND MaschinenID='{mid}'");
                dgv_Zuweisung.Rows.RemoveAt(selectedIndex);
            }
        }

        private void btn_Zuweisungneu_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string button = db.QueryToStringNew($"SELECT iButtonID from user WHERE Benutzername='{cmbx_Zuweisunguser.SelectedItem}'");
            string mid = db.QueryToStringNew($"SELECT MaschinenID from maschine WHERE Bezeichnung='{cmbx_Zuweisungmaschine.SelectedItem}'");


            db.ExecuteQuery($"INSERT INTO zuweisung (iButtonID, MaschinenID, Datum) VALUES('{button}', '{mid}', '{date}');");
            dgv_Zuweisung.DataSource = db.QueryToDataTable("select zuweisung.iButtonID, user.Benutzername, zuweisung.MaschinenID, maschine.Bezeichnung from zuweisung, maschine, user WHERE user.iButtonID=zuweisung.iButtonID AND maschine.MaschinenID=zuweisung.MaschinenID");
        }

        private void btn_Memberadd_Click(object sender, EventArgs e)
        {
            if(tb_Benutzername.Text != "" && tb_EMail.Text != "" && tb_Nachname.Text != "" 
                && tb_Passwort.Text != "" && tb_Vorname.Text != "")
            {
                string button = cb_iButtonID.SelectedItem.ToString();
                string benutzer = tb_Benutzername.Text;
                string email = tb_EMail.Text;
                string nachname = tb_Nachname.Text;
                string passwort = tb_Passwort.Text;
                string vorname = tb_Vorname.Text;
                string kmember = "0";

                if(chkbx_Keymember.Checked)
                {
                    kmember = "1";
                }

                db.ExecuteQuery($"INSERT INTO user (Benutzername, EMail, Nachname, Vorname, Passwort, Keymember, iButtonID) " +
                    $"VALUES('{benutzer}', '{email}', '{nachname}', '{vorname}', '{passwort}', '{kmember}', '{button}');");
                dgv_Member.DataSource = db.QueryToDataTable("select UserID, Vorname, Nachname, EMail, Keymember, iButtonID from user where Aktiv='1'");

                tb_Benutzername.Text = "";
                tb_EMail.Text = "";
                tb_Nachname.Text = "";
                tb_Passwort.Text = "";
                tb_Vorname.Text = "";
                cb_iButtonID.Items.Remove(cb_iButtonID.SelectedItem);

                cb_iButtonID.Items.Clear();

                foreach (string row in db.TableToListOne("ibutton", "iButtonID", $"ibutton.iButtonID NOT IN (SELECT user.iButtonID FROM user WHERE Aktiv='1')"))
                {
                    cb_iButtonID.Items.Add(row);
                }
            }
            else
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!","Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_HinzufügenUSB_Click(object sender, EventArgs e)
        {
            string iButtonID = drive.New(driveName);
            lbl_USBInfo.Text = $"USB Stick erstellt iButtonID:{iButtonID}";
            db.ExecuteQuery($"insert into ibutton values ('{iButtonID}','Stick')");
            dgv_USB.DataSource = db.QueryToDataTable("select * from ibutton");
        }
    }
}



namespace WinProjektlabor
{
    partial class Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tp_Verwaltung = new System.Windows.Forms.TabPage();
            this.tc_Verwaltung = new System.Windows.Forms.TabControl();
            this.tp_Member = new System.Windows.Forms.TabPage();
            this.chkbx_Keymember = new System.Windows.Forms.CheckBox();
            this.btn_Memberadd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Passwort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Benutzername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_EMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Nachname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Vorname = new System.Windows.Forms.TextBox();
            this.cb_iButtonID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_LöschenMember = new System.Windows.Forms.Button();
            this.dgv_Member = new System.Windows.Forms.DataGridView();
            this.tb_Zuweisung = new System.Windows.Forms.TabPage();
            this.btn_Zuweisungneu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_Zuweisungmaschine = new System.Windows.Forms.ComboBox();
            this.cmbx_Zuweisunguser = new System.Windows.Forms.ComboBox();
            this.btnLoeschenZuweisung = new System.Windows.Forms.Button();
            this.dgv_Zuweisung = new System.Windows.Forms.DataGridView();
            this.tp_USB = new System.Windows.Forms.TabPage();
            this.pn_YesUSB = new System.Windows.Forms.Panel();
            this.lbl_GehörtUSB = new System.Windows.Forms.Label();
            this.lbl_UserUSB = new System.Windows.Forms.Label();
            this.btn_LoeschenUSB = new System.Windows.Forms.Button();
            this.lbl_StatusNachrichtUSB = new System.Windows.Forms.Label();
            this.lbl_StatusUSB = new System.Windows.Forms.Label();
            this.btn_LöschenUSB = new System.Windows.Forms.Button();
            this.dgv_USB = new System.Windows.Forms.DataGridView();
            this.tp_Maschinen = new System.Windows.Forms.TabPage();
            this.btn_HinzufügenMaschinen = new System.Windows.Forms.Button();
            this.lbl_BezeichnungMaschinen = new System.Windows.Forms.Label();
            this.txtbx_BezeichnungMaschinen = new System.Windows.Forms.TextBox();
            this.btn_LöschenMaschinen = new System.Windows.Forms.Button();
            this.dgv_Maschinen = new System.Windows.Forms.DataGridView();
            this.tp_Log = new System.Windows.Forms.TabPage();
            this.dgv_Log = new System.Windows.Forms.DataGridView();
            this.tp_Maschine = new System.Windows.Forms.TabPage();
            this.pb_Maschine = new System.Windows.Forms.PictureBox();
            this.lbl_Maschine = new System.Windows.Forms.Label();
            this.tc_Panel = new System.Windows.Forms.TabControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tp_Verwaltung.SuspendLayout();
            this.tc_Verwaltung.SuspendLayout();
            this.tp_Member.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Member)).BeginInit();
            this.tb_Zuweisung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Zuweisung)).BeginInit();
            this.tp_USB.SuspendLayout();
            this.pn_YesUSB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_USB)).BeginInit();
            this.tp_Maschinen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Maschinen)).BeginInit();
            this.tp_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Log)).BeginInit();
            this.tp_Maschine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Maschine)).BeginInit();
            this.tc_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_Verwaltung
            // 
            this.tp_Verwaltung.Controls.Add(this.tc_Verwaltung);
            this.tp_Verwaltung.Location = new System.Drawing.Point(4, 22);
            this.tp_Verwaltung.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tp_Verwaltung.Name = "tp_Verwaltung";
            this.tp_Verwaltung.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tp_Verwaltung.Size = new System.Drawing.Size(792, 424);
            this.tp_Verwaltung.TabIndex = 1;
            this.tp_Verwaltung.Text = "Verwaltung";
            this.tp_Verwaltung.UseVisualStyleBackColor = true;
            // 
            // tc_Verwaltung
            // 
            this.tc_Verwaltung.Controls.Add(this.tp_Member);
            this.tc_Verwaltung.Controls.Add(this.tb_Zuweisung);
            this.tc_Verwaltung.Controls.Add(this.tp_USB);
            this.tc_Verwaltung.Controls.Add(this.tp_Maschinen);
            this.tc_Verwaltung.Controls.Add(this.tp_Log);
            this.tc_Verwaltung.Location = new System.Drawing.Point(0, 2);
            this.tc_Verwaltung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tc_Verwaltung.Name = "tc_Verwaltung";
            this.tc_Verwaltung.SelectedIndex = 0;
            this.tc_Verwaltung.Size = new System.Drawing.Size(797, 427);
            this.tc_Verwaltung.TabIndex = 0;
            this.tc_Verwaltung.SelectedIndexChanged += new System.EventHandler(this.tc_Verwaltung_SelectedIndexChanged);
            // 
            // tp_Member
            // 
            this.tp_Member.BackColor = System.Drawing.Color.Transparent;
            this.tp_Member.Controls.Add(this.chkbx_Keymember);
            this.tp_Member.Controls.Add(this.btn_Memberadd);
            this.tp_Member.Controls.Add(this.label9);
            this.tp_Member.Controls.Add(this.tb_Passwort);
            this.tp_Member.Controls.Add(this.label10);
            this.tp_Member.Controls.Add(this.tb_Benutzername);
            this.tp_Member.Controls.Add(this.label5);
            this.tp_Member.Controls.Add(this.tb_EMail);
            this.tp_Member.Controls.Add(this.label4);
            this.tp_Member.Controls.Add(this.tb_Nachname);
            this.tp_Member.Controls.Add(this.label3);
            this.tp_Member.Controls.Add(this.tb_Vorname);
            this.tp_Member.Controls.Add(this.cb_iButtonID);
            this.tp_Member.Controls.Add(this.label6);
            this.tp_Member.Controls.Add(this.btn_LöschenMember);
            this.tp_Member.Controls.Add(this.dgv_Member);
            this.tp_Member.Location = new System.Drawing.Point(4, 22);
            this.tp_Member.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_Member.Name = "tp_Member";
            this.tp_Member.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp_Member.Size = new System.Drawing.Size(789, 401);
            this.tp_Member.TabIndex = 0;
            this.tp_Member.Text = "Member";
            // 
            // chkbx_Keymember
            // 
            this.chkbx_Keymember.AutoSize = true;
            this.chkbx_Keymember.Location = new System.Drawing.Point(672, 121);
            this.chkbx_Keymember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkbx_Keymember.Name = "chkbx_Keymember";
            this.chkbx_Keymember.Size = new System.Drawing.Size(81, 17);
            this.chkbx_Keymember.TabIndex = 26;
            this.chkbx_Keymember.Text = "Keymember";
            this.chkbx_Keymember.UseVisualStyleBackColor = true;
            // 
            // btn_Memberadd
            // 
            this.btn_Memberadd.Location = new System.Drawing.Point(672, 289);
            this.btn_Memberadd.Name = "btn_Memberadd";
            this.btn_Memberadd.Size = new System.Drawing.Size(91, 20);
            this.btn_Memberadd.TabIndex = 25;
            this.btn_Memberadd.Text = "Hinzufügen";
            this.btn_Memberadd.UseVisualStyleBackColor = true;
            this.btn_Memberadd.Click += new System.EventHandler(this.btn_Memberadd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(670, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Passwort";
            // 
            // tb_Passwort
            // 
            this.tb_Passwort.Location = new System.Drawing.Point(672, 195);
            this.tb_Passwort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Passwort.Name = "tb_Passwort";
            this.tb_Passwort.PasswordChar = '*';
            this.tb_Passwort.Size = new System.Drawing.Size(92, 20);
            this.tb_Passwort.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(670, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Benutzername";
            // 
            // tb_Benutzername
            // 
            this.tb_Benutzername.Location = new System.Drawing.Point(672, 157);
            this.tb_Benutzername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Benutzername.Name = "tb_Benutzername";
            this.tb_Benutzername.Size = new System.Drawing.Size(92, 20);
            this.tb_Benutzername.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "E-Mail";
            // 
            // tb_EMail
            // 
            this.tb_EMail.Location = new System.Drawing.Point(672, 98);
            this.tb_EMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_EMail.Name = "tb_EMail";
            this.tb_EMail.Size = new System.Drawing.Size(92, 20);
            this.tb_EMail.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nachname";
            // 
            // tb_Nachname
            // 
            this.tb_Nachname.Location = new System.Drawing.Point(672, 63);
            this.tb_Nachname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Nachname.Name = "tb_Nachname";
            this.tb_Nachname.Size = new System.Drawing.Size(92, 20);
            this.tb_Nachname.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vorname";
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Location = new System.Drawing.Point(672, 25);
            this.tb_Vorname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.Size = new System.Drawing.Size(92, 20);
            this.tb_Vorname.TabIndex = 11;
            // 
            // cb_iButtonID
            // 
            this.cb_iButtonID.FormattingEnabled = true;
            this.cb_iButtonID.Location = new System.Drawing.Point(672, 231);
            this.cb_iButtonID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_iButtonID.Name = "cb_iButtonID";
            this.cb_iButtonID.Size = new System.Drawing.Size(92, 21);
            this.cb_iButtonID.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "iButtonID";
            // 
            // btn_LöschenMember
            // 
            this.btn_LöschenMember.Location = new System.Drawing.Point(13, 363);
            this.btn_LöschenMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LöschenMember.Name = "btn_LöschenMember";
            this.btn_LöschenMember.Size = new System.Drawing.Size(638, 24);
            this.btn_LöschenMember.TabIndex = 2;
            this.btn_LöschenMember.Text = "Löschen";
            this.btn_LöschenMember.UseVisualStyleBackColor = true;
            this.btn_LöschenMember.Click += new System.EventHandler(this.btn_LöschenMember_Click);
            // 
            // dgv_Member
            // 
            this.dgv_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Member.Location = new System.Drawing.Point(13, 14);
            this.dgv_Member.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Member.Name = "dgv_Member";
            this.dgv_Member.ReadOnly = true;
            this.dgv_Member.RowHeadersWidth = 51;
            this.dgv_Member.RowTemplate.Height = 24;
            this.dgv_Member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Member.Size = new System.Drawing.Size(638, 332);
            this.dgv_Member.TabIndex = 1;
            // 
            // tb_Zuweisung
            // 
            this.tb_Zuweisung.Controls.Add(this.btn_Zuweisungneu);
            this.tb_Zuweisung.Controls.Add(this.label2);
            this.tb_Zuweisung.Controls.Add(this.label1);
            this.tb_Zuweisung.Controls.Add(this.cmbx_Zuweisungmaschine);
            this.tb_Zuweisung.Controls.Add(this.cmbx_Zuweisunguser);
            this.tb_Zuweisung.Controls.Add(this.btnLoeschenZuweisung);
            this.tb_Zuweisung.Controls.Add(this.dgv_Zuweisung);
            this.tb_Zuweisung.Location = new System.Drawing.Point(4, 22);
            this.tb_Zuweisung.Name = "tb_Zuweisung";
            this.tb_Zuweisung.Size = new System.Drawing.Size(789, 401);
            this.tb_Zuweisung.TabIndex = 4;
            this.tb_Zuweisung.Text = "Zuweisung";
            this.tb_Zuweisung.UseVisualStyleBackColor = true;
            // 
            // btn_Zuweisungneu
            // 
            this.btn_Zuweisungneu.Location = new System.Drawing.Point(580, 119);
            this.btn_Zuweisungneu.Name = "btn_Zuweisungneu";
            this.btn_Zuweisungneu.Size = new System.Drawing.Size(149, 24);
            this.btn_Zuweisungneu.TabIndex = 9;
            this.btn_Zuweisungneu.Text = "Hinzufügen";
            this.btn_Zuweisungneu.UseVisualStyleBackColor = true;
            this.btn_Zuweisungneu.Click += new System.EventHandler(this.btn_Zuweisungneu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Benutzer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Maschine";
            // 
            // cmbx_Zuweisungmaschine
            // 
            this.cmbx_Zuweisungmaschine.FormattingEnabled = true;
            this.cmbx_Zuweisungmaschine.Location = new System.Drawing.Point(580, 92);
            this.cmbx_Zuweisungmaschine.Name = "cmbx_Zuweisungmaschine";
            this.cmbx_Zuweisungmaschine.Size = new System.Drawing.Size(149, 21);
            this.cmbx_Zuweisungmaschine.TabIndex = 6;
            // 
            // cmbx_Zuweisunguser
            // 
            this.cmbx_Zuweisunguser.FormattingEnabled = true;
            this.cmbx_Zuweisunguser.Location = new System.Drawing.Point(580, 39);
            this.cmbx_Zuweisunguser.Name = "cmbx_Zuweisunguser";
            this.cmbx_Zuweisunguser.Size = new System.Drawing.Size(149, 21);
            this.cmbx_Zuweisunguser.TabIndex = 5;
            // 
            // btnLoeschenZuweisung
            // 
            this.btnLoeschenZuweisung.Location = new System.Drawing.Point(13, 344);
            this.btnLoeschenZuweisung.Name = "btnLoeschenZuweisung";
            this.btnLoeschenZuweisung.Size = new System.Drawing.Size(496, 24);
            this.btnLoeschenZuweisung.TabIndex = 4;
            this.btnLoeschenZuweisung.Text = "Löschen";
            this.btnLoeschenZuweisung.UseVisualStyleBackColor = true;
            this.btnLoeschenZuweisung.Click += new System.EventHandler(this.btnLoeschenZuweisung_Click);
            // 
            // dgv_Zuweisung
            // 
            this.dgv_Zuweisung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Zuweisung.Location = new System.Drawing.Point(13, 14);
            this.dgv_Zuweisung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Zuweisung.Name = "dgv_Zuweisung";
            this.dgv_Zuweisung.ReadOnly = true;
            this.dgv_Zuweisung.RowHeadersWidth = 51;
            this.dgv_Zuweisung.RowTemplate.Height = 24;
            this.dgv_Zuweisung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Zuweisung.Size = new System.Drawing.Size(496, 310);
            this.dgv_Zuweisung.TabIndex = 3;
            // 
            // tp_USB
            // 
            this.tp_USB.Controls.Add(this.pn_YesUSB);
            this.tp_USB.Controls.Add(this.lbl_StatusNachrichtUSB);
            this.tp_USB.Controls.Add(this.lbl_StatusUSB);
            this.tp_USB.Controls.Add(this.btn_LöschenUSB);
            this.tp_USB.Controls.Add(this.dgv_USB);
            this.tp_USB.Location = new System.Drawing.Point(4, 22);
            this.tp_USB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp_USB.Name = "tp_USB";
            this.tp_USB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp_USB.Size = new System.Drawing.Size(789, 401);
            this.tp_USB.TabIndex = 1;
            this.tp_USB.Text = "USB Sticks";
            this.tp_USB.UseVisualStyleBackColor = true;
            // 
            // pn_YesUSB
            // 
            this.pn_YesUSB.Controls.Add(this.lbl_GehörtUSB);
            this.pn_YesUSB.Controls.Add(this.lbl_UserUSB);
            this.pn_YesUSB.Controls.Add(this.btn_LoeschenUSB);
            this.pn_YesUSB.Location = new System.Drawing.Point(338, 79);
            this.pn_YesUSB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pn_YesUSB.Name = "pn_YesUSB";
            this.pn_YesUSB.Size = new System.Drawing.Size(200, 100);
            this.pn_YesUSB.TabIndex = 8;
            this.pn_YesUSB.Visible = false;
            // 
            // lbl_GehörtUSB
            // 
            this.lbl_GehörtUSB.AutoSize = true;
            this.lbl_GehörtUSB.Location = new System.Drawing.Point(3, 10);
            this.lbl_GehörtUSB.Name = "lbl_GehörtUSB";
            this.lbl_GehörtUSB.Size = new System.Drawing.Size(89, 13);
            this.lbl_GehörtUSB.TabIndex = 8;
            this.lbl_GehörtUSB.Text = "USB Stick gehört";
            // 
            // lbl_UserUSB
            // 
            this.lbl_UserUSB.AutoSize = true;
            this.lbl_UserUSB.Location = new System.Drawing.Point(3, 35);
            this.lbl_UserUSB.Name = "lbl_UserUSB";
            this.lbl_UserUSB.Size = new System.Drawing.Size(32, 13);
            this.lbl_UserUSB.TabIndex = 6;
            this.lbl_UserUSB.Text = "User:";
            // 
            // btn_LoeschenUSB
            // 
            this.btn_LoeschenUSB.Location = new System.Drawing.Point(95, 71);
            this.btn_LoeschenUSB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_LoeschenUSB.Name = "btn_LoeschenUSB";
            this.btn_LoeschenUSB.Size = new System.Drawing.Size(100, 24);
            this.btn_LoeschenUSB.TabIndex = 7;
            this.btn_LoeschenUSB.Text = "Löschen";
            this.btn_LoeschenUSB.UseVisualStyleBackColor = true;
            // 
            // lbl_StatusNachrichtUSB
            // 
            this.lbl_StatusNachrichtUSB.AutoSize = true;
            this.lbl_StatusNachrichtUSB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusNachrichtUSB.ForeColor = System.Drawing.Color.Red;
            this.lbl_StatusNachrichtUSB.Location = new System.Drawing.Point(335, 39);
            this.lbl_StatusNachrichtUSB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StatusNachrichtUSB.Name = "lbl_StatusNachrichtUSB";
            this.lbl_StatusNachrichtUSB.Size = new System.Drawing.Size(154, 14);
            this.lbl_StatusNachrichtUSB.TabIndex = 5;
            this.lbl_StatusNachrichtUSB.Text = "Bitte USB Stick einstecken!";
            // 
            // lbl_StatusUSB
            // 
            this.lbl_StatusUSB.AutoSize = true;
            this.lbl_StatusUSB.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusUSB.Location = new System.Drawing.Point(335, 21);
            this.lbl_StatusUSB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StatusUSB.Name = "lbl_StatusUSB";
            this.lbl_StatusUSB.Size = new System.Drawing.Size(93, 18);
            this.lbl_StatusUSB.TabIndex = 4;
            this.lbl_StatusUSB.Text = "USB Status:";
            // 
            // btn_LöschenUSB
            // 
            this.btn_LöschenUSB.Location = new System.Drawing.Point(13, 344);
            this.btn_LöschenUSB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_LöschenUSB.Name = "btn_LöschenUSB";
            this.btn_LöschenUSB.Size = new System.Drawing.Size(273, 24);
            this.btn_LöschenUSB.TabIndex = 3;
            this.btn_LöschenUSB.Text = "Löschen";
            this.btn_LöschenUSB.UseVisualStyleBackColor = true;
            this.btn_LöschenUSB.Click += new System.EventHandler(this.btn_LöschenUSB_Click);
            // 
            // dgv_USB
            // 
            this.dgv_USB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_USB.Location = new System.Drawing.Point(13, 14);
            this.dgv_USB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_USB.MultiSelect = false;
            this.dgv_USB.Name = "dgv_USB";
            this.dgv_USB.ReadOnly = true;
            this.dgv_USB.RowHeadersWidth = 51;
            this.dgv_USB.RowTemplate.Height = 24;
            this.dgv_USB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_USB.Size = new System.Drawing.Size(273, 310);
            this.dgv_USB.TabIndex = 2;
            // 
            // tp_Maschinen
            // 
            this.tp_Maschinen.Controls.Add(this.btn_HinzufügenMaschinen);
            this.tp_Maschinen.Controls.Add(this.lbl_BezeichnungMaschinen);
            this.tp_Maschinen.Controls.Add(this.txtbx_BezeichnungMaschinen);
            this.tp_Maschinen.Controls.Add(this.btn_LöschenMaschinen);
            this.tp_Maschinen.Controls.Add(this.dgv_Maschinen);
            this.tp_Maschinen.Location = new System.Drawing.Point(4, 22);
            this.tp_Maschinen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp_Maschinen.Name = "tp_Maschinen";
            this.tp_Maschinen.Size = new System.Drawing.Size(789, 401);
            this.tp_Maschinen.TabIndex = 3;
            this.tp_Maschinen.Text = "Maschinen";
            this.tp_Maschinen.UseVisualStyleBackColor = true;
            // 
            // btn_HinzufügenMaschinen
            // 
            this.btn_HinzufügenMaschinen.Location = new System.Drawing.Point(381, 77);
            this.btn_HinzufügenMaschinen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_HinzufügenMaschinen.Name = "btn_HinzufügenMaschinen";
            this.btn_HinzufügenMaschinen.Size = new System.Drawing.Size(94, 24);
            this.btn_HinzufügenMaschinen.TabIndex = 5;
            this.btn_HinzufügenMaschinen.Text = "Hinzufügen";
            this.btn_HinzufügenMaschinen.UseVisualStyleBackColor = true;
            this.btn_HinzufügenMaschinen.Click += new System.EventHandler(this.btn_HinzufügenMaschinen_Click);
            // 
            // lbl_BezeichnungMaschinen
            // 
            this.lbl_BezeichnungMaschinen.AutoSize = true;
            this.lbl_BezeichnungMaschinen.Location = new System.Drawing.Point(392, 21);
            this.lbl_BezeichnungMaschinen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BezeichnungMaschinen.Name = "lbl_BezeichnungMaschinen";
            this.lbl_BezeichnungMaschinen.Size = new System.Drawing.Size(69, 13);
            this.lbl_BezeichnungMaschinen.TabIndex = 4;
            this.lbl_BezeichnungMaschinen.Text = "Bezeichnung";
            // 
            // txtbx_BezeichnungMaschinen
            // 
            this.txtbx_BezeichnungMaschinen.Location = new System.Drawing.Point(381, 53);
            this.txtbx_BezeichnungMaschinen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_BezeichnungMaschinen.Name = "txtbx_BezeichnungMaschinen";
            this.txtbx_BezeichnungMaschinen.Size = new System.Drawing.Size(95, 20);
            this.txtbx_BezeichnungMaschinen.TabIndex = 3;
            this.txtbx_BezeichnungMaschinen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_BezeichnungMaschinen_KeyDown);
            // 
            // btn_LöschenMaschinen
            // 
            this.btn_LöschenMaschinen.Location = new System.Drawing.Point(13, 344);
            this.btn_LöschenMaschinen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LöschenMaschinen.Name = "btn_LöschenMaschinen";
            this.btn_LöschenMaschinen.Size = new System.Drawing.Size(273, 24);
            this.btn_LöschenMaschinen.TabIndex = 2;
            this.btn_LöschenMaschinen.Text = "Löschen";
            this.btn_LöschenMaschinen.UseVisualStyleBackColor = true;
            this.btn_LöschenMaschinen.Click += new System.EventHandler(this.btn_LöschenMaschinen_Click);
            // 
            // dgv_Maschinen
            // 
            this.dgv_Maschinen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Maschinen.Location = new System.Drawing.Point(13, 14);
            this.dgv_Maschinen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Maschinen.MultiSelect = false;
            this.dgv_Maschinen.Name = "dgv_Maschinen";
            this.dgv_Maschinen.ReadOnly = true;
            this.dgv_Maschinen.RowHeadersWidth = 51;
            this.dgv_Maschinen.RowTemplate.Height = 24;
            this.dgv_Maschinen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Maschinen.Size = new System.Drawing.Size(273, 310);
            this.dgv_Maschinen.TabIndex = 1;
            // 
            // tp_Log
            // 
            this.tp_Log.Controls.Add(this.dgv_Log);
            this.tp_Log.Location = new System.Drawing.Point(4, 22);
            this.tp_Log.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp_Log.Name = "tp_Log";
            this.tp_Log.Size = new System.Drawing.Size(789, 401);
            this.tp_Log.TabIndex = 2;
            this.tp_Log.Text = "Log";
            this.tp_Log.UseVisualStyleBackColor = true;
            // 
            // dgv_Log
            // 
            this.dgv_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Log.Location = new System.Drawing.Point(13, 14);
            this.dgv_Log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Log.Name = "dgv_Log";
            this.dgv_Log.ReadOnly = true;
            this.dgv_Log.RowHeadersWidth = 51;
            this.dgv_Log.RowTemplate.Height = 24;
            this.dgv_Log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Log.Size = new System.Drawing.Size(699, 361);
            this.dgv_Log.TabIndex = 0;
            // 
            // tp_Maschine
            // 
            this.tp_Maschine.Controls.Add(this.pb_Maschine);
            this.tp_Maschine.Controls.Add(this.lbl_Maschine);
            this.tp_Maschine.Location = new System.Drawing.Point(4, 22);
            this.tp_Maschine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Maschine.Name = "tp_Maschine";
            this.tp_Maschine.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Maschine.Size = new System.Drawing.Size(792, 424);
            this.tp_Maschine.TabIndex = 0;
            this.tp_Maschine.Text = "Maschine";
            this.tp_Maschine.UseVisualStyleBackColor = true;
            // 
            // pb_Maschine
            // 
            this.pb_Maschine.Location = new System.Drawing.Point(15, 36);
            this.pb_Maschine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_Maschine.Name = "pb_Maschine";
            this.pb_Maschine.Size = new System.Drawing.Size(150, 150);
            this.pb_Maschine.TabIndex = 1;
            this.pb_Maschine.TabStop = false;
            // 
            // lbl_Maschine
            // 
            this.lbl_Maschine.AutoSize = true;
            this.lbl_Maschine.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Maschine.Location = new System.Drawing.Point(8, 8);
            this.lbl_Maschine.Name = "lbl_Maschine";
            this.lbl_Maschine.Size = new System.Drawing.Size(77, 18);
            this.lbl_Maschine.TabIndex = 0;
            this.lbl_Maschine.Text = "Maschine";
            // 
            // tc_Panel
            // 
            this.tc_Panel.Controls.Add(this.tp_Maschine);
            this.tc_Panel.Controls.Add(this.tp_Verwaltung);
            this.tc_Panel.Location = new System.Drawing.Point(0, 0);
            this.tc_Panel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tc_Panel.Name = "tc_Panel";
            this.tc_Panel.SelectedIndex = 0;
            this.tc_Panel.Size = new System.Drawing.Size(800, 450);
            this.tc_Panel.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tc_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "Panel";
            this.Text = "Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Panel_FormClosed);
            this.Load += new System.EventHandler(this.Panel_Load);
            this.tp_Verwaltung.ResumeLayout(false);
            this.tc_Verwaltung.ResumeLayout(false);
            this.tp_Member.ResumeLayout(false);
            this.tp_Member.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Member)).EndInit();
            this.tb_Zuweisung.ResumeLayout(false);
            this.tb_Zuweisung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Zuweisung)).EndInit();
            this.tp_USB.ResumeLayout(false);
            this.tp_USB.PerformLayout();
            this.pn_YesUSB.ResumeLayout(false);
            this.pn_YesUSB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_USB)).EndInit();
            this.tp_Maschinen.ResumeLayout(false);
            this.tp_Maschinen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Maschinen)).EndInit();
            this.tp_Log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Log)).EndInit();
            this.tp_Maschine.ResumeLayout(false);
            this.tp_Maschine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Maschine)).EndInit();
            this.tc_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tp_Verwaltung;
        private System.Windows.Forms.TabControl tc_Verwaltung;
        private System.Windows.Forms.TabPage tp_Member;
        private System.Windows.Forms.TabPage tp_USB;
        private System.Windows.Forms.TabPage tp_Maschinen;
        private System.Windows.Forms.TabPage tp_Log;
        private System.Windows.Forms.TabPage tp_Maschine;
        private System.Windows.Forms.PictureBox pb_Maschine;
        private System.Windows.Forms.Label lbl_Maschine;
        private System.Windows.Forms.TabControl tc_Panel;
        private System.Windows.Forms.DataGridView dgv_Log;
        private System.Windows.Forms.DataGridView dgv_USB;
        private System.Windows.Forms.DataGridView dgv_Maschinen;
        private System.Windows.Forms.Button btn_LöschenUSB;
        private System.Windows.Forms.Button btn_LöschenMaschinen;
        private System.Windows.Forms.Label lbl_StatusNachrichtUSB;
        private System.Windows.Forms.Label lbl_StatusUSB;
        private System.Windows.Forms.Panel pn_YesUSB;
        private System.Windows.Forms.Label lbl_GehörtUSB;
        private System.Windows.Forms.Label lbl_UserUSB;
        private System.Windows.Forms.Button btn_LoeschenUSB;
        private System.Windows.Forms.Button btn_HinzufügenMaschinen;
        private System.Windows.Forms.Label lbl_BezeichnungMaschinen;
        private System.Windows.Forms.TextBox txtbx_BezeichnungMaschinen;
        private System.Windows.Forms.DataGridView dgv_Member;
        private System.Windows.Forms.Button btn_LöschenMember;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tb_Zuweisung;
        private System.Windows.Forms.Button btnLoeschenZuweisung;
        private System.Windows.Forms.DataGridView dgv_Zuweisung;
        private System.Windows.Forms.Button btn_Zuweisungneu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_Zuweisungmaschine;
        private System.Windows.Forms.ComboBox cmbx_Zuweisunguser;
        private System.Windows.Forms.CheckBox chkbx_Keymember;
        private System.Windows.Forms.Button btn_Memberadd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Passwort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Benutzername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_EMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Nachname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Vorname;
        private System.Windows.Forms.ComboBox cb_iButtonID;
        private System.Windows.Forms.Label label6;
    }
}

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
            this.tp_USB = new System.Windows.Forms.TabPage();
            this.tp_Maschinen = new System.Windows.Forms.TabPage();
            this.btn_LöschenMaschinen = new System.Windows.Forms.Button();
            this.btn_HinzufügenMaschinen = new System.Windows.Forms.Button();
            this.txtbx_BezeichnungMaschinen = new System.Windows.Forms.TextBox();
            this.lbl_BezeichnungMaschinen = new System.Windows.Forms.Label();
            this.lsbx_Maschinen = new System.Windows.Forms.ListBox();
            this.tp_Log = new System.Windows.Forms.TabPage();
            this.dgv_Log = new System.Windows.Forms.DataGridView();
            this.tp_Maschine = new System.Windows.Forms.TabPage();
            this.pb_Maschine = new System.Windows.Forms.PictureBox();
            this.lbl_Maschine = new System.Windows.Forms.Label();
            this.tc_Panel = new System.Windows.Forms.TabControl();
            this.btn_LöschenUSB = new System.Windows.Forms.Button();
            this.lsbx_USB = new System.Windows.Forms.ListBox();
            this.btn_HinzufügenUSB = new System.Windows.Forms.Button();
            this.lbl_TypUSB = new System.Windows.Forms.Label();
            this.cmbx_TypUSB = new System.Windows.Forms.ComboBox();
            this.tp_Verwaltung.SuspendLayout();
            this.tc_Verwaltung.SuspendLayout();
            this.tp_USB.SuspendLayout();
            this.tp_Maschinen.SuspendLayout();
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
            this.tp_Verwaltung.Location = new System.Drawing.Point(4, 25);
            this.tp_Verwaltung.Margin = new System.Windows.Forms.Padding(4);
            this.tp_Verwaltung.Name = "tp_Verwaltung";
            this.tp_Verwaltung.Padding = new System.Windows.Forms.Padding(4);
            this.tp_Verwaltung.Size = new System.Drawing.Size(1059, 525);
            this.tp_Verwaltung.TabIndex = 1;
            this.tp_Verwaltung.Text = "Verwaltung";
            this.tp_Verwaltung.UseVisualStyleBackColor = true;
            // 
            // tc_Verwaltung
            // 
            this.tc_Verwaltung.Controls.Add(this.tp_Member);
            this.tc_Verwaltung.Controls.Add(this.tp_USB);
            this.tc_Verwaltung.Controls.Add(this.tp_Maschinen);
            this.tc_Verwaltung.Controls.Add(this.tp_Log);
            this.tc_Verwaltung.Location = new System.Drawing.Point(0, 3);
            this.tc_Verwaltung.Name = "tc_Verwaltung";
            this.tc_Verwaltung.SelectedIndex = 0;
            this.tc_Verwaltung.Size = new System.Drawing.Size(1063, 526);
            this.tc_Verwaltung.TabIndex = 0;
            this.tc_Verwaltung.SelectedIndexChanged += new System.EventHandler(this.tc_Verwaltung_SelectedIndexChanged);
            // 
            // tp_Member
            // 
            this.tp_Member.Location = new System.Drawing.Point(4, 25);
            this.tp_Member.Name = "tp_Member";
            this.tp_Member.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Member.Size = new System.Drawing.Size(1055, 497);
            this.tp_Member.TabIndex = 0;
            this.tp_Member.Text = "Member";
            this.tp_Member.UseVisualStyleBackColor = true;
            // 
            // tp_USB
            // 
            this.tp_USB.Controls.Add(this.cmbx_TypUSB);
            this.tp_USB.Controls.Add(this.btn_HinzufügenUSB);
            this.tp_USB.Controls.Add(this.lbl_TypUSB);
            this.tp_USB.Controls.Add(this.btn_LöschenUSB);
            this.tp_USB.Controls.Add(this.lsbx_USB);
            this.tp_USB.Location = new System.Drawing.Point(4, 25);
            this.tp_USB.Name = "tp_USB";
            this.tp_USB.Padding = new System.Windows.Forms.Padding(3);
            this.tp_USB.Size = new System.Drawing.Size(1055, 497);
            this.tp_USB.TabIndex = 1;
            this.tp_USB.Text = "USB Sticks";
            this.tp_USB.UseVisualStyleBackColor = true;
            // 
            // tp_Maschinen
            // 
            this.tp_Maschinen.Controls.Add(this.btn_LöschenMaschinen);
            this.tp_Maschinen.Controls.Add(this.btn_HinzufügenMaschinen);
            this.tp_Maschinen.Controls.Add(this.txtbx_BezeichnungMaschinen);
            this.tp_Maschinen.Controls.Add(this.lbl_BezeichnungMaschinen);
            this.tp_Maschinen.Controls.Add(this.lsbx_Maschinen);
            this.tp_Maschinen.Location = new System.Drawing.Point(4, 25);
            this.tp_Maschinen.Name = "tp_Maschinen";
            this.tp_Maschinen.Size = new System.Drawing.Size(1055, 497);
            this.tp_Maschinen.TabIndex = 3;
            this.tp_Maschinen.Text = "Maschinen";
            this.tp_Maschinen.UseVisualStyleBackColor = true;
            // 
            // btn_LöschenMaschinen
            // 
            this.btn_LöschenMaschinen.Location = new System.Drawing.Point(14, 352);
            this.btn_LöschenMaschinen.Name = "btn_LöschenMaschinen";
            this.btn_LöschenMaschinen.Size = new System.Drawing.Size(162, 33);
            this.btn_LöschenMaschinen.TabIndex = 4;
            this.btn_LöschenMaschinen.Text = "Löschen";
            this.btn_LöschenMaschinen.UseVisualStyleBackColor = true;
            this.btn_LöschenMaschinen.Click += new System.EventHandler(this.btn_LöschenMaschinen_Click);
            // 
            // btn_HinzufügenMaschinen
            // 
            this.btn_HinzufügenMaschinen.Location = new System.Drawing.Point(231, 103);
            this.btn_HinzufügenMaschinen.Name = "btn_HinzufügenMaschinen";
            this.btn_HinzufügenMaschinen.Size = new System.Drawing.Size(131, 33);
            this.btn_HinzufügenMaschinen.TabIndex = 3;
            this.btn_HinzufügenMaschinen.Text = "Hinzufügen";
            this.btn_HinzufügenMaschinen.UseVisualStyleBackColor = true;
            this.btn_HinzufügenMaschinen.Click += new System.EventHandler(this.btn_HinzufügenMaschinen_Click);
            // 
            // txtbx_BezeichnungMaschinen
            // 
            this.txtbx_BezeichnungMaschinen.Location = new System.Drawing.Point(231, 66);
            this.txtbx_BezeichnungMaschinen.Name = "txtbx_BezeichnungMaschinen";
            this.txtbx_BezeichnungMaschinen.Size = new System.Drawing.Size(131, 22);
            this.txtbx_BezeichnungMaschinen.TabIndex = 2;
            // 
            // lbl_BezeichnungMaschinen
            // 
            this.lbl_BezeichnungMaschinen.AutoSize = true;
            this.lbl_BezeichnungMaschinen.Location = new System.Drawing.Point(250, 31);
            this.lbl_BezeichnungMaschinen.Name = "lbl_BezeichnungMaschinen";
            this.lbl_BezeichnungMaschinen.Size = new System.Drawing.Size(90, 17);
            this.lbl_BezeichnungMaschinen.TabIndex = 1;
            this.lbl_BezeichnungMaschinen.Text = "Bezeichnung";
            // 
            // lsbx_Maschinen
            // 
            this.lsbx_Maschinen.FormattingEnabled = true;
            this.lsbx_Maschinen.ItemHeight = 16;
            this.lsbx_Maschinen.Location = new System.Drawing.Point(14, 12);
            this.lsbx_Maschinen.Name = "lsbx_Maschinen";
            this.lsbx_Maschinen.Size = new System.Drawing.Size(162, 324);
            this.lsbx_Maschinen.TabIndex = 0;
            // 
            // tp_Log
            // 
            this.tp_Log.Controls.Add(this.dgv_Log);
            this.tp_Log.Location = new System.Drawing.Point(4, 25);
            this.tp_Log.Name = "tp_Log";
            this.tp_Log.Size = new System.Drawing.Size(1055, 497);
            this.tp_Log.TabIndex = 2;
            this.tp_Log.Text = "Log";
            this.tp_Log.UseVisualStyleBackColor = true;
            // 
            // dgv_Log
            // 
            this.dgv_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Log.Location = new System.Drawing.Point(35, 27);
            this.dgv_Log.Name = "dgv_Log";
            this.dgv_Log.RowHeadersWidth = 51;
            this.dgv_Log.RowTemplate.Height = 24;
            this.dgv_Log.Size = new System.Drawing.Size(773, 444);
            this.dgv_Log.TabIndex = 0;
            // 
            // tp_Maschine
            // 
            this.tp_Maschine.Controls.Add(this.pb_Maschine);
            this.tp_Maschine.Controls.Add(this.lbl_Maschine);
            this.tp_Maschine.Location = new System.Drawing.Point(4, 25);
            this.tp_Maschine.Margin = new System.Windows.Forms.Padding(4);
            this.tp_Maschine.Name = "tp_Maschine";
            this.tp_Maschine.Padding = new System.Windows.Forms.Padding(4);
            this.tp_Maschine.Size = new System.Drawing.Size(1059, 525);
            this.tp_Maschine.TabIndex = 0;
            this.tp_Maschine.Text = "Maschine";
            this.tp_Maschine.UseVisualStyleBackColor = true;
            // 
            // pb_Maschine
            // 
            this.pb_Maschine.Location = new System.Drawing.Point(15, 36);
            this.pb_Maschine.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Maschine.Name = "pb_Maschine";
            this.pb_Maschine.Size = new System.Drawing.Size(200, 185);
            this.pb_Maschine.TabIndex = 1;
            this.pb_Maschine.TabStop = false;
            // 
            // lbl_Maschine
            // 
            this.lbl_Maschine.AutoSize = true;
            this.lbl_Maschine.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Maschine.Location = new System.Drawing.Point(11, 10);
            this.lbl_Maschine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Maschine.Name = "lbl_Maschine";
            this.lbl_Maschine.Size = new System.Drawing.Size(97, 24);
            this.lbl_Maschine.TabIndex = 0;
            this.lbl_Maschine.Text = "Maschine";
            // 
            // tc_Panel
            // 
            this.tc_Panel.Controls.Add(this.tp_Maschine);
            this.tc_Panel.Controls.Add(this.tp_Verwaltung);
            this.tc_Panel.Location = new System.Drawing.Point(0, 0);
            this.tc_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.tc_Panel.Name = "tc_Panel";
            this.tc_Panel.SelectedIndex = 0;
            this.tc_Panel.Size = new System.Drawing.Size(1067, 554);
            this.tc_Panel.TabIndex = 0;
            // 
            // btn_LöschenUSB
            // 
            this.btn_LöschenUSB.Location = new System.Drawing.Point(14, 352);
            this.btn_LöschenUSB.Name = "btn_LöschenUSB";
            this.btn_LöschenUSB.Size = new System.Drawing.Size(162, 33);
            this.btn_LöschenUSB.TabIndex = 6;
            this.btn_LöschenUSB.Text = "Löschen";
            this.btn_LöschenUSB.UseVisualStyleBackColor = true;
            // 
            // lsbx_USB
            // 
            this.lsbx_USB.FormattingEnabled = true;
            this.lsbx_USB.ItemHeight = 16;
            this.lsbx_USB.Location = new System.Drawing.Point(14, 12);
            this.lsbx_USB.Name = "lsbx_USB";
            this.lsbx_USB.Size = new System.Drawing.Size(162, 324);
            this.lsbx_USB.TabIndex = 5;
            // 
            // btn_HinzufügenUSB
            // 
            this.btn_HinzufügenUSB.Location = new System.Drawing.Point(231, 103);
            this.btn_HinzufügenUSB.Name = "btn_HinzufügenUSB";
            this.btn_HinzufügenUSB.Size = new System.Drawing.Size(121, 33);
            this.btn_HinzufügenUSB.TabIndex = 9;
            this.btn_HinzufügenUSB.Text = "Hinzufügen";
            this.btn_HinzufügenUSB.UseVisualStyleBackColor = true;
            // 
            // lbl_TypUSB
            // 
            this.lbl_TypUSB.AutoSize = true;
            this.lbl_TypUSB.Location = new System.Drawing.Point(275, 32);
            this.lbl_TypUSB.Name = "lbl_TypUSB";
            this.lbl_TypUSB.Size = new System.Drawing.Size(32, 17);
            this.lbl_TypUSB.TabIndex = 7;
            this.lbl_TypUSB.Text = "Typ";
            // 
            // cmbx_TypUSB
            // 
            this.cmbx_TypUSB.FormattingEnabled = true;
            this.cmbx_TypUSB.Items.AddRange(new object[] {
            "USB Stick",
            "iButton",
            "FIDO 2"});
            this.cmbx_TypUSB.Location = new System.Drawing.Point(231, 66);
            this.cmbx_TypUSB.Name = "cmbx_TypUSB";
            this.cmbx_TypUSB.Size = new System.Drawing.Size(121, 24);
            this.cmbx_TypUSB.TabIndex = 10;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tc_Panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Panel";
            this.Text = "Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Panel_FormClosed);
            this.Load += new System.EventHandler(this.Panel_Load);
            this.tp_Verwaltung.ResumeLayout(false);
            this.tc_Verwaltung.ResumeLayout(false);
            this.tp_USB.ResumeLayout(false);
            this.tp_USB.PerformLayout();
            this.tp_Maschinen.ResumeLayout(false);
            this.tp_Maschinen.PerformLayout();
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
        private System.Windows.Forms.Button btn_HinzufügenMaschinen;
        private System.Windows.Forms.TextBox txtbx_BezeichnungMaschinen;
        private System.Windows.Forms.Label lbl_BezeichnungMaschinen;
        private System.Windows.Forms.ListBox lsbx_Maschinen;
        private System.Windows.Forms.Button btn_LöschenUSB;
        private System.Windows.Forms.ListBox lsbx_USB;
        internal System.Windows.Forms.Button btn_LöschenMaschinen;
        private System.Windows.Forms.ComboBox cmbx_TypUSB;
        private System.Windows.Forms.Button btn_HinzufügenUSB;
        private System.Windows.Forms.Label lbl_TypUSB;
    }
}
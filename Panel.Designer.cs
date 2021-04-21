
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
            this.btn_LöschenMember = new System.Windows.Forms.Button();
            this.dgv_Member = new System.Windows.Forms.DataGridView();
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
            this.tp_Verwaltung.Location = new System.Drawing.Point(4, 25);
            this.tp_Verwaltung.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tp_Verwaltung.Name = "tp_Verwaltung";
            this.tp_Verwaltung.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.tc_Verwaltung.Location = new System.Drawing.Point(0, 2);
            this.tc_Verwaltung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_Verwaltung.Name = "tc_Verwaltung";
            this.tc_Verwaltung.SelectedIndex = 0;
            this.tc_Verwaltung.Size = new System.Drawing.Size(1063, 526);
            this.tc_Verwaltung.TabIndex = 0;
            this.tc_Verwaltung.SelectedIndexChanged += new System.EventHandler(this.tc_Verwaltung_SelectedIndexChanged);
            // 
            // tp_Member
            // 
            this.tp_Member.BackColor = System.Drawing.Color.Transparent;
            this.tp_Member.Controls.Add(this.btn_LöschenMember);
            this.tp_Member.Controls.Add(this.dgv_Member);
            this.tp_Member.Location = new System.Drawing.Point(4, 25);
            this.tp_Member.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tp_Member.Name = "tp_Member";
            this.tp_Member.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_Member.Size = new System.Drawing.Size(1055, 497);
            this.tp_Member.TabIndex = 0;
            this.tp_Member.Text = "Member";
            // 
            // btn_LöschenMember
            // 
            this.btn_LöschenMember.Location = new System.Drawing.Point(17, 441);
            this.btn_LöschenMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LöschenMember.Name = "btn_LöschenMember";
            this.btn_LöschenMember.Size = new System.Drawing.Size(884, 30);
            this.btn_LöschenMember.TabIndex = 2;
            this.btn_LöschenMember.Text = "Löschen";
            this.btn_LöschenMember.UseVisualStyleBackColor = true;
            this.btn_LöschenMember.Click += new System.EventHandler(this.btn_LöschenMember_Click);
            // 
            // dgv_Member
            // 
            this.dgv_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Member.Location = new System.Drawing.Point(17, 17);
            this.dgv_Member.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_Member.Name = "dgv_Member";
            this.dgv_Member.ReadOnly = true;
            this.dgv_Member.RowHeadersWidth = 51;
            this.dgv_Member.RowTemplate.Height = 24;
            this.dgv_Member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Member.Size = new System.Drawing.Size(884, 408);
            this.dgv_Member.TabIndex = 1;
            // 
            // tp_USB
            // 
            this.tp_USB.Controls.Add(this.pn_YesUSB);
            this.tp_USB.Controls.Add(this.lbl_StatusNachrichtUSB);
            this.tp_USB.Controls.Add(this.lbl_StatusUSB);
            this.tp_USB.Controls.Add(this.btn_LöschenUSB);
            this.tp_USB.Controls.Add(this.dgv_USB);
            this.tp_USB.Location = new System.Drawing.Point(4, 25);
            this.tp_USB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_USB.Name = "tp_USB";
            this.tp_USB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_USB.Size = new System.Drawing.Size(1055, 497);
            this.tp_USB.TabIndex = 1;
            this.tp_USB.Text = "USB Sticks";
            this.tp_USB.UseVisualStyleBackColor = true;
            // 
            // pn_YesUSB
            // 
            this.pn_YesUSB.Controls.Add(this.lbl_GehörtUSB);
            this.pn_YesUSB.Controls.Add(this.lbl_UserUSB);
            this.pn_YesUSB.Controls.Add(this.btn_LoeschenUSB);
            this.pn_YesUSB.Location = new System.Drawing.Point(600, 110);
            this.pn_YesUSB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pn_YesUSB.Name = "pn_YesUSB";
            this.pn_YesUSB.Size = new System.Drawing.Size(267, 123);
            this.pn_YesUSB.TabIndex = 8;
            this.pn_YesUSB.Visible = false;
            // 
            // lbl_GehörtUSB
            // 
            this.lbl_GehörtUSB.AutoSize = true;
            this.lbl_GehörtUSB.Location = new System.Drawing.Point(4, 12);
            this.lbl_GehörtUSB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GehörtUSB.Name = "lbl_GehörtUSB";
            this.lbl_GehörtUSB.Size = new System.Drawing.Size(115, 17);
            this.lbl_GehörtUSB.TabIndex = 8;
            this.lbl_GehörtUSB.Text = "USB Stick gehört";
            // 
            // lbl_UserUSB
            // 
            this.lbl_UserUSB.AutoSize = true;
            this.lbl_UserUSB.Location = new System.Drawing.Point(4, 43);
            this.lbl_UserUSB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserUSB.Name = "lbl_UserUSB";
            this.lbl_UserUSB.Size = new System.Drawing.Size(42, 17);
            this.lbl_UserUSB.TabIndex = 6;
            this.lbl_UserUSB.Text = "User:";
            // 
            // btn_LoeschenUSB
            // 
            this.btn_LoeschenUSB.Location = new System.Drawing.Point(217, 112);
            this.btn_LoeschenUSB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_LoeschenUSB.Name = "btn_LoeschenUSB";
            this.btn_LoeschenUSB.Size = new System.Drawing.Size(100, 28);
            this.btn_LoeschenUSB.TabIndex = 7;
            this.btn_LoeschenUSB.Text = "Löschen";
            this.btn_LoeschenUSB.UseVisualStyleBackColor = true;
            // 
            // lbl_StatusNachrichtUSB
            // 
            this.lbl_StatusNachrichtUSB.AutoSize = true;
            this.lbl_StatusNachrichtUSB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusNachrichtUSB.ForeColor = System.Drawing.Color.Red;
            this.lbl_StatusNachrichtUSB.Location = new System.Drawing.Point(447, 48);
            this.lbl_StatusNachrichtUSB.Name = "lbl_StatusNachrichtUSB";
            this.lbl_StatusNachrichtUSB.Size = new System.Drawing.Size(198, 16);
            this.lbl_StatusNachrichtUSB.TabIndex = 5;
            this.lbl_StatusNachrichtUSB.Text = "Bitte USB Stick einstecken!";
            // 
            // lbl_StatusUSB
            // 
            this.lbl_StatusUSB.AutoSize = true;
            this.lbl_StatusUSB.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusUSB.Location = new System.Drawing.Point(447, 26);
            this.lbl_StatusUSB.Name = "lbl_StatusUSB";
            this.lbl_StatusUSB.Size = new System.Drawing.Size(121, 24);
            this.lbl_StatusUSB.TabIndex = 4;
            this.lbl_StatusUSB.Text = "USB Status:";
            // 
            // btn_LöschenUSB
            // 
            this.btn_LöschenUSB.Location = new System.Drawing.Point(29, 533);
            this.btn_LöschenUSB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_LöschenUSB.Name = "btn_LöschenUSB";
            this.btn_LöschenUSB.Size = new System.Drawing.Size(364, 30);
            this.btn_LöschenUSB.TabIndex = 3;
            this.btn_LöschenUSB.Text = "Löschen";
            this.btn_LöschenUSB.UseVisualStyleBackColor = true;
            this.btn_LöschenUSB.Click += new System.EventHandler(this.btn_LöschenUSB_Click);
            // 
            // dgv_USB
            // 
            this.dgv_USB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_USB.Location = new System.Drawing.Point(17, 17);
            this.dgv_USB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_USB.MultiSelect = false;
            this.dgv_USB.Name = "dgv_USB";
            this.dgv_USB.ReadOnly = true;
            this.dgv_USB.RowHeadersWidth = 51;
            this.dgv_USB.RowTemplate.Height = 24;
            this.dgv_USB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_USB.Size = new System.Drawing.Size(364, 382);
            this.dgv_USB.TabIndex = 2;
            // 
            // tp_Maschinen
            // 
            this.tp_Maschinen.Controls.Add(this.btn_HinzufügenMaschinen);
            this.tp_Maschinen.Controls.Add(this.lbl_BezeichnungMaschinen);
            this.tp_Maschinen.Controls.Add(this.txtbx_BezeichnungMaschinen);
            this.tp_Maschinen.Controls.Add(this.btn_LöschenMaschinen);
            this.tp_Maschinen.Controls.Add(this.dgv_Maschinen);
            this.tp_Maschinen.Location = new System.Drawing.Point(4, 25);
            this.tp_Maschinen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_Maschinen.Name = "tp_Maschinen";
            this.tp_Maschinen.Size = new System.Drawing.Size(1055, 497);
            this.tp_Maschinen.TabIndex = 3;
            this.tp_Maschinen.Text = "Maschinen";
            this.tp_Maschinen.UseVisualStyleBackColor = true;
            // 
            // btn_HinzufügenMaschinen
            // 
            this.btn_HinzufügenMaschinen.Location = new System.Drawing.Point(508, 95);
            this.btn_HinzufügenMaschinen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_HinzufügenMaschinen.Name = "btn_HinzufügenMaschinen";
            this.btn_HinzufügenMaschinen.Size = new System.Drawing.Size(125, 30);
            this.btn_HinzufügenMaschinen.TabIndex = 5;
            this.btn_HinzufügenMaschinen.Text = "Hinzufügen";
            this.btn_HinzufügenMaschinen.UseVisualStyleBackColor = true;
            this.btn_HinzufügenMaschinen.Click += new System.EventHandler(this.btn_HinzufügenMaschinen_Click);
            // 
            // lbl_BezeichnungMaschinen
            // 
            this.lbl_BezeichnungMaschinen.AutoSize = true;
            this.lbl_BezeichnungMaschinen.Location = new System.Drawing.Point(523, 26);
            this.lbl_BezeichnungMaschinen.Name = "lbl_BezeichnungMaschinen";
            this.lbl_BezeichnungMaschinen.Size = new System.Drawing.Size(90, 17);
            this.lbl_BezeichnungMaschinen.TabIndex = 4;
            this.lbl_BezeichnungMaschinen.Text = "Bezeichnung";
            // 
            // txtbx_BezeichnungMaschinen
            // 
            this.txtbx_BezeichnungMaschinen.Location = new System.Drawing.Point(508, 65);
            this.txtbx_BezeichnungMaschinen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_BezeichnungMaschinen.Name = "txtbx_BezeichnungMaschinen";
            this.txtbx_BezeichnungMaschinen.Size = new System.Drawing.Size(125, 22);
            this.txtbx_BezeichnungMaschinen.TabIndex = 3;
            this.txtbx_BezeichnungMaschinen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_BezeichnungMaschinen_KeyDown);
            // 
            // btn_LöschenMaschinen
            // 
            this.btn_LöschenMaschinen.Location = new System.Drawing.Point(17, 423);
            this.btn_LöschenMaschinen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LöschenMaschinen.Name = "btn_LöschenMaschinen";
            this.btn_LöschenMaschinen.Size = new System.Drawing.Size(364, 30);
            this.btn_LöschenMaschinen.TabIndex = 2;
            this.btn_LöschenMaschinen.Text = "Löschen";
            this.btn_LöschenMaschinen.UseVisualStyleBackColor = true;
            this.btn_LöschenMaschinen.Click += new System.EventHandler(this.btn_LöschenMaschinen_Click);
            // 
            // dgv_Maschinen
            // 
            this.dgv_Maschinen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Maschinen.Location = new System.Drawing.Point(17, 17);
            this.dgv_Maschinen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Maschinen.MultiSelect = false;
            this.dgv_Maschinen.Name = "dgv_Maschinen";
            this.dgv_Maschinen.ReadOnly = true;
            this.dgv_Maschinen.RowHeadersWidth = 51;
            this.dgv_Maschinen.RowTemplate.Height = 24;
            this.dgv_Maschinen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Maschinen.Size = new System.Drawing.Size(364, 382);
            this.dgv_Maschinen.TabIndex = 1;
            // 
            // tp_Log
            // 
            this.tp_Log.Controls.Add(this.dgv_Log);
            this.tp_Log.Location = new System.Drawing.Point(4, 25);
            this.tp_Log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_Log.Name = "tp_Log";
            this.tp_Log.Size = new System.Drawing.Size(1055, 497);
            this.tp_Log.TabIndex = 2;
            this.tp_Log.Text = "Log";
            this.tp_Log.UseVisualStyleBackColor = true;
            // 
            // dgv_Log
            // 
            this.dgv_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Log.Location = new System.Drawing.Point(17, 17);
            this.dgv_Log.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_Log.Name = "dgv_Log";
            this.dgv_Log.ReadOnly = true;
            this.dgv_Log.RowHeadersWidth = 51;
            this.dgv_Log.RowTemplate.Height = 24;
            this.dgv_Log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Log.Size = new System.Drawing.Size(932, 444);
            this.dgv_Log.TabIndex = 0;
            // 
            // tp_Maschine
            // 
            this.tp_Maschine.Controls.Add(this.pb_Maschine);
            this.tp_Maschine.Controls.Add(this.lbl_Maschine);
            this.tp_Maschine.Location = new System.Drawing.Point(4, 25);
            this.tp_Maschine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Maschine.Name = "tp_Maschine";
            this.tp_Maschine.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Maschine.Size = new System.Drawing.Size(1059, 525);
            this.tp_Maschine.TabIndex = 0;
            this.tp_Maschine.Text = "Maschine";
            this.tp_Maschine.UseVisualStyleBackColor = true;
            // 
            // pb_Maschine
            // 
            this.pb_Maschine.Location = new System.Drawing.Point(15, 36);
            this.pb_Maschine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tc_Panel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tc_Panel.Name = "tc_Panel";
            this.tc_Panel.SelectedIndex = 0;
            this.tc_Panel.Size = new System.Drawing.Size(1067, 554);
            this.tc_Panel.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Member)).EndInit();
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
    }
}
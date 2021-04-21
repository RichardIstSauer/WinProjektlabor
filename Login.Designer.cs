
namespace WinProjektlabor
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_StatusNachricht = new System.Windows.Forms.Label();
            this.lbl_Passwort = new System.Windows.Forms.Label();
            this.txtbx_Passwort = new System.Windows.Forms.TextBox();
            this.btn_Anmelden = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.lbl_Anmelden = new System.Windows.Forms.Label();
            this.cmbx_LoginMaschine = new System.Windows.Forms.ComboBox();
            this.lbl_Maschinenauswahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(11, 9);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(93, 18);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "USB Status:";
            // 
            // lbl_StatusNachricht
            // 
            this.lbl_StatusNachricht.AutoSize = true;
            this.lbl_StatusNachricht.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusNachricht.ForeColor = System.Drawing.Color.Red;
            this.lbl_StatusNachricht.Location = new System.Drawing.Point(11, 27);
            this.lbl_StatusNachricht.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StatusNachricht.Name = "lbl_StatusNachricht";
            this.lbl_StatusNachricht.Size = new System.Drawing.Size(154, 14);
            this.lbl_StatusNachricht.TabIndex = 1;
            this.lbl_StatusNachricht.Text = "Bitte USB Stick einstecken!";
            // 
            // lbl_Passwort
            // 
            this.lbl_Passwort.AutoSize = true;
            this.lbl_Passwort.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Passwort.Location = new System.Drawing.Point(117, 222);
            this.lbl_Passwort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Passwort.Name = "lbl_Passwort";
            this.lbl_Passwort.Size = new System.Drawing.Size(59, 18);
            this.lbl_Passwort.TabIndex = 2;
            this.lbl_Passwort.Text = "Passwort";
            this.lbl_Passwort.UseCompatibleTextRendering = true;
            this.lbl_Passwort.Visible = false;
            // 
            // txtbx_Passwort
            // 
            this.txtbx_Passwort.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Passwort.Location = new System.Drawing.Point(27, 242);
            this.txtbx_Passwort.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_Passwort.Name = "txtbx_Passwort";
            this.txtbx_Passwort.PasswordChar = '*';
            this.txtbx_Passwort.Size = new System.Drawing.Size(237, 20);
            this.txtbx_Passwort.TabIndex = 3;
            this.txtbx_Passwort.Visible = false;
            this.txtbx_Passwort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_Passwort_KeyDown);
            // 
            // btn_Anmelden
            // 
            this.btn_Anmelden.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anmelden.Location = new System.Drawing.Point(27, 277);
            this.btn_Anmelden.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Anmelden.Name = "btn_Anmelden";
            this.btn_Anmelden.Size = new System.Drawing.Size(237, 26);
            this.btn_Anmelden.TabIndex = 4;
            this.btn_Anmelden.Text = "Anmelden";
            this.btn_Anmelden.UseVisualStyleBackColor = true;
            this.btn_Anmelden.Visible = false;
            this.btn_Anmelden.Click += new System.EventHandler(this.btn_Anmelden_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.Location = new System.Drawing.Point(265, 11);
            this.btn_Admin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(20, 19);
            this.btn_Admin.TabIndex = 5;
            this.btn_Admin.Text = "!";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // lbl_Anmelden
            // 
            this.lbl_Anmelden.AutoSize = true;
            this.lbl_Anmelden.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Anmelden.Location = new System.Drawing.Point(101, 168);
            this.lbl_Anmelden.Name = "lbl_Anmelden";
            this.lbl_Anmelden.Size = new System.Drawing.Size(98, 23);
            this.lbl_Anmelden.TabIndex = 6;
            this.lbl_Anmelden.Text = "Anmelden";
            this.lbl_Anmelden.Visible = false;
            // 
            // cmbx_LoginMaschine
            // 
            this.cmbx_LoginMaschine.FormattingEnabled = true;
            this.cmbx_LoginMaschine.Location = new System.Drawing.Point(92, 102);
            this.cmbx_LoginMaschine.Margin = new System.Windows.Forms.Padding(2);
            this.cmbx_LoginMaschine.MaxDropDownItems = 32;
            this.cmbx_LoginMaschine.Name = "cmbx_LoginMaschine";
            this.cmbx_LoginMaschine.Size = new System.Drawing.Size(117, 21);
            this.cmbx_LoginMaschine.TabIndex = 7;
            this.cmbx_LoginMaschine.Visible = false;
            this.cmbx_LoginMaschine.SelectedIndexChanged += new System.EventHandler(this.cmbx_LoginMaschine_SelectedIndexChanged);
            // 
            // lbl_Maschinenauswahl
            // 
            this.lbl_Maschinenauswahl.AutoSize = true;
            this.lbl_Maschinenauswahl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Maschinenauswahl.Location = new System.Drawing.Point(65, 75);
            this.lbl_Maschinenauswahl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Maschinenauswahl.Name = "lbl_Maschinenauswahl";
            this.lbl_Maschinenauswahl.Size = new System.Drawing.Size(178, 16);
            this.lbl_Maschinenauswahl.TabIndex = 8;
            this.lbl_Maschinenauswahl.Text = "Bitte Maschine auswählen!";
            this.lbl_Maschinenauswahl.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 371);
            this.Controls.Add(this.lbl_Maschinenauswahl);
            this.Controls.Add(this.cmbx_LoginMaschine);
            this.Controls.Add(this.lbl_Anmelden);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.btn_Anmelden);
            this.Controls.Add(this.txtbx_Passwort);
            this.Controls.Add(this.lbl_Passwort);
            this.Controls.Add(this.lbl_StatusNachricht);
            this.Controls.Add(this.lbl_Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_StatusNachricht;
        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.TextBox txtbx_Passwort;
        private System.Windows.Forms.Button btn_Anmelden;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Label lbl_Anmelden;
        private System.Windows.Forms.ComboBox cmbx_LoginMaschine;
        private System.Windows.Forms.Label lbl_Maschinenauswahl;
    }
}


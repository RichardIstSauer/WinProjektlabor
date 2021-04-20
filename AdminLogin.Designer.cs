
namespace WinProjektlabor
{
    partial class AdminLogin
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
            this.txtbx_UserAdmin = new System.Windows.Forms.TextBox();
            this.txtbx_PasswortAdmin = new System.Windows.Forms.TextBox();
            this.lbl_UserAdmin = new System.Windows.Forms.Label();
            this.lbl_PasswortAdmin = new System.Windows.Forms.Label();
            this.btn_AnmeldenAdmin = new System.Windows.Forms.Button();
            this.lbl_AnmeldenAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx_UserAdmin
            // 
            this.txtbx_UserAdmin.Location = new System.Drawing.Point(86, 119);
            this.txtbx_UserAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_UserAdmin.Name = "txtbx_UserAdmin";
            this.txtbx_UserAdmin.Size = new System.Drawing.Size(125, 20);
            this.txtbx_UserAdmin.TabIndex = 0;
            // 
            // txtbx_PasswortAdmin
            // 
            this.txtbx_PasswortAdmin.Location = new System.Drawing.Point(86, 176);
            this.txtbx_PasswortAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx_PasswortAdmin.Name = "txtbx_PasswortAdmin";
            this.txtbx_PasswortAdmin.PasswordChar = '*';
            this.txtbx_PasswortAdmin.Size = new System.Drawing.Size(125, 20);
            this.txtbx_PasswortAdmin.TabIndex = 1;
            this.txtbx_PasswortAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_PasswortAdmin_KeyDown);
            // 
            // lbl_UserAdmin
            // 
            this.lbl_UserAdmin.AutoSize = true;
            this.lbl_UserAdmin.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserAdmin.Location = new System.Drawing.Point(9, 119);
            this.lbl_UserAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserAdmin.Name = "lbl_UserAdmin";
            this.lbl_UserAdmin.Size = new System.Drawing.Size(33, 14);
            this.lbl_UserAdmin.TabIndex = 2;
            this.lbl_UserAdmin.Text = "User";
            // 
            // lbl_PasswortAdmin
            // 
            this.lbl_PasswortAdmin.AutoSize = true;
            this.lbl_PasswortAdmin.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PasswortAdmin.Location = new System.Drawing.Point(9, 176);
            this.lbl_PasswortAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_PasswortAdmin.Name = "lbl_PasswortAdmin";
            this.lbl_PasswortAdmin.Size = new System.Drawing.Size(60, 14);
            this.lbl_PasswortAdmin.TabIndex = 3;
            this.lbl_PasswortAdmin.Text = "Passwort";
            // 
            // btn_AnmeldenAdmin
            // 
            this.btn_AnmeldenAdmin.Location = new System.Drawing.Point(86, 215);
            this.btn_AnmeldenAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AnmeldenAdmin.Name = "btn_AnmeldenAdmin";
            this.btn_AnmeldenAdmin.Size = new System.Drawing.Size(124, 19);
            this.btn_AnmeldenAdmin.TabIndex = 5;
            this.btn_AnmeldenAdmin.Text = "Anmelden";
            this.btn_AnmeldenAdmin.UseVisualStyleBackColor = true;
            this.btn_AnmeldenAdmin.Click += new System.EventHandler(this.btn_AnmeldenAdmin_Click);
            // 
            // lbl_AnmeldenAdmin
            // 
            this.lbl_AnmeldenAdmin.AutoSize = true;
            this.lbl_AnmeldenAdmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnmeldenAdmin.Location = new System.Drawing.Point(109, 53);
            this.lbl_AnmeldenAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AnmeldenAdmin.Name = "lbl_AnmeldenAdmin";
            this.lbl_AnmeldenAdmin.Size = new System.Drawing.Size(86, 19);
            this.lbl_AnmeldenAdmin.TabIndex = 6;
            this.lbl_AnmeldenAdmin.Text = "Anmelden";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 257);
            this.Controls.Add(this.lbl_AnmeldenAdmin);
            this.Controls.Add(this.btn_AnmeldenAdmin);
            this.Controls.Add(this.lbl_PasswortAdmin);
            this.Controls.Add(this.lbl_UserAdmin);
            this.Controls.Add(this.txtbx_PasswortAdmin);
            this.Controls.Add(this.txtbx_UserAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_UserAdmin;
        private System.Windows.Forms.TextBox txtbx_PasswortAdmin;
        private System.Windows.Forms.Label lbl_UserAdmin;
        private System.Windows.Forms.Label lbl_PasswortAdmin;
        private System.Windows.Forms.Button btn_AnmeldenAdmin;
        private System.Windows.Forms.Label lbl_AnmeldenAdmin;
    }
}

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
            this.txtbx_UserAdmin.Location = new System.Drawing.Point(114, 146);
            this.txtbx_UserAdmin.Name = "txtbx_UserAdmin";
            this.txtbx_UserAdmin.Size = new System.Drawing.Size(165, 22);
            this.txtbx_UserAdmin.TabIndex = 0;
            // 
            // txtbx_PasswortAdmin
            // 
            this.txtbx_PasswortAdmin.Location = new System.Drawing.Point(114, 217);
            this.txtbx_PasswortAdmin.Name = "txtbx_PasswortAdmin";
            this.txtbx_PasswortAdmin.PasswordChar = '*';
            this.txtbx_PasswortAdmin.Size = new System.Drawing.Size(165, 22);
            this.txtbx_PasswortAdmin.TabIndex = 1;
            this.txtbx_PasswortAdmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_PasswortAdmin_KeyDown);
            // 
            // lbl_UserAdmin
            // 
            this.lbl_UserAdmin.AutoSize = true;
            this.lbl_UserAdmin.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserAdmin.Location = new System.Drawing.Point(12, 146);
            this.lbl_UserAdmin.Name = "lbl_UserAdmin";
            this.lbl_UserAdmin.Size = new System.Drawing.Size(41, 16);
            this.lbl_UserAdmin.TabIndex = 2;
            this.lbl_UserAdmin.Text = "User";
            // 
            // lbl_PasswortAdmin
            // 
            this.lbl_PasswortAdmin.AutoSize = true;
            this.lbl_PasswortAdmin.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PasswortAdmin.Location = new System.Drawing.Point(12, 217);
            this.lbl_PasswortAdmin.Name = "lbl_PasswortAdmin";
            this.lbl_PasswortAdmin.Size = new System.Drawing.Size(72, 16);
            this.lbl_PasswortAdmin.TabIndex = 3;
            this.lbl_PasswortAdmin.Text = "Passwort";
            // 
            // btn_AnmeldenAdmin
            // 
            this.btn_AnmeldenAdmin.Location = new System.Drawing.Point(114, 254);
            this.btn_AnmeldenAdmin.Name = "btn_AnmeldenAdmin";
            this.btn_AnmeldenAdmin.Size = new System.Drawing.Size(165, 23);
            this.btn_AnmeldenAdmin.TabIndex = 5;
            this.btn_AnmeldenAdmin.Text = "Anmelden";
            this.btn_AnmeldenAdmin.UseVisualStyleBackColor = true;
            this.btn_AnmeldenAdmin.Click += new System.EventHandler(this.btn_AnmeldenAdmin_Click);
            // 
            // lbl_AnmeldenAdmin
            // 
            this.lbl_AnmeldenAdmin.AutoSize = true;
            this.lbl_AnmeldenAdmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnmeldenAdmin.Location = new System.Drawing.Point(145, 65);
            this.lbl_AnmeldenAdmin.Name = "lbl_AnmeldenAdmin";
            this.lbl_AnmeldenAdmin.Size = new System.Drawing.Size(103, 24);
            this.lbl_AnmeldenAdmin.TabIndex = 6;
            this.lbl_AnmeldenAdmin.Text = "Anmelden";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 316);
            this.Controls.Add(this.lbl_AnmeldenAdmin);
            this.Controls.Add(this.btn_AnmeldenAdmin);
            this.Controls.Add(this.lbl_PasswortAdmin);
            this.Controls.Add(this.lbl_UserAdmin);
            this.Controls.Add(this.txtbx_PasswortAdmin);
            this.Controls.Add(this.txtbx_UserAdmin);
            this.Name = "AdminLogin";
            this.Text = "Admin";
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
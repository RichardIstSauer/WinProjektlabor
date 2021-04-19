
namespace WinProjektlabor
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(66, 135);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(84, 17);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "USB Status:";
            // 
            // lbl_StatusNachricht
            // 
            this.lbl_StatusNachricht.AutoSize = true;
            this.lbl_StatusNachricht.ForeColor = System.Drawing.Color.Red;
            this.lbl_StatusNachricht.Location = new System.Drawing.Point(174, 135);
            this.lbl_StatusNachricht.Name = "lbl_StatusNachricht";
            this.lbl_StatusNachricht.Size = new System.Drawing.Size(177, 17);
            this.lbl_StatusNachricht.TabIndex = 1;
            this.lbl_StatusNachricht.Text = "Bitte USB Stick einstecken!";
            // 
            // lbl_Passwort
            // 
            this.lbl_Passwort.AutoSize = true;
            this.lbl_Passwort.Location = new System.Drawing.Point(69, 252);
            this.lbl_Passwort.Name = "lbl_Passwort";
            this.lbl_Passwort.Size = new System.Drawing.Size(60, 20);
            this.lbl_Passwort.TabIndex = 2;
            this.lbl_Passwort.Text = "Passwort";
            this.lbl_Passwort.UseCompatibleTextRendering = true;
            this.lbl_Passwort.Visible = false;
            // 
            // txtbx_Passwort
            // 
            this.txtbx_Passwort.Location = new System.Drawing.Point(150, 252);
            this.txtbx_Passwort.Name = "txtbx_Passwort";
            this.txtbx_Passwort.Size = new System.Drawing.Size(162, 22);
            this.txtbx_Passwort.TabIndex = 3;
            this.txtbx_Passwort.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 457);
            this.Controls.Add(this.txtbx_Passwort);
            this.Controls.Add(this.lbl_Passwort);
            this.Controls.Add(this.lbl_StatusNachricht);
            this.Controls.Add(this.lbl_Status);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_StatusNachricht;
        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.TextBox txtbx_Passwort;
    }
}


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
    public partial class AdminLogin : Form
    {
        Dbase db = new Dbase("projektlabor");

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btn_AnmeldenAdmin_Click(object sender, EventArgs e)
        {
            string EnteredUser = txtbx_UserAdmin.Text;
            string EnteredPassword = txtbx_PasswortAdmin.Text;
            string EnteredUserID = db.QueryToStringNew($"select AdminID from nimda where User='{EnteredUser}' AND Passwort='{EnteredPassword}'");
            bool result = db.QueryToBool($"select * from nimda where AdminID='{EnteredUserID}' AND Passwort='{EnteredPassword}'");
            if (result)
            {
                this.Hide();
                Panel Panel = new Panel();
                Panel.Show();
            }
            else
            {
                txtbx_PasswortAdmin.Text = "";
                txtbx_UserAdmin.Text = "";
                MessageBox.Show("User oder Passwort falsch!");
            }
        }

        private void txtbx_PasswortAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btn_AnmeldenAdmin_Click(sender, e);
            }
        }
    }
}

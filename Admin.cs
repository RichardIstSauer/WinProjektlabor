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
    public partial class Admin : Form
    {
        Dbase db = new Dbase("projektlabor");

        public Admin()
        {
            InitializeComponent();
        }

        private void btn_AnmeldenAdmin_Click(object sender, EventArgs e)
        {
            string EnteredUser = txtbx_UserAdmin.Text;
            string EnteredPassword = txtbx_PasswortAdmin.Text;
            string EnteredUserID = db.QueryToString($"select AdminID from nimda where user='{EnteredUser}'");

            bool result = db.QueryToBool($"SELECT * from nimda WHERE Passwort = '{EnteredPassword}' AND AdminID = '{EnteredUserID}'");

            if (result)
            {
                MessageBox.Show("Eingeloggt");
            }
        }
    }
}

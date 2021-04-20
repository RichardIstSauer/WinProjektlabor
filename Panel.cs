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
        public string M_ID;
        Dbase db = new Dbase("projektlabor");

        public Panel()
        {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            lbl_Maschine.Text = db.QueryToStringNew($"SELECT Bezeichnung from maschine WHERE MaschinenID='{M_ID}'");
        }
    }
}

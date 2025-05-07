using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login01
{
    public partial class FrmMain2 : Form
    {
        public FrmMain2()
        {
            InitializeComponent();
        }


        private void BtnSearching_Click(object sender, EventArgs e)
        {
            FrmSearching frmSearching = new FrmSearching();
            frmSearching.ShowDialog();
        }

        private void Btninterrogation_Click(object sender, EventArgs e)
        {
            Frminterrogation frminterrogation = new Frminterrogation();
            frminterrogation.ShowDialog();
        }
    }
}

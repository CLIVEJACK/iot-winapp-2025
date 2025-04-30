using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            TxtYear.Text = monthCalendar1.SelectionStart.Year.ToString();
            TxtMonth.Text = monthCalendar1.SelectionStart.Month.ToString();
            TxtDay.Text = monthCalendar1.SelectionStart.Day.ToString();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtIndex.ToString(), "¾Ë¸²", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TxtIndex_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

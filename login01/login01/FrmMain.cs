namespace login01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSing_Click(object sender, EventArgs e)
        {
            string userId = id.Text;
            string userPassword = pw.Text;

            if (userId.Equals("MyId") && userPassword.Equals("MyPassword"))
            {
                MessageBox.Show("�α��ο� �����߽��ϴ�.", "�α���" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain2 frmMain2 = new FrmMain2();
                frmMain2.Show();

            }
            else
            {
                MessageBox.Show("�α��ο� �����߽��ϴ�.", "�α���", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

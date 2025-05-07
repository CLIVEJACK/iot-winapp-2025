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
                MessageBox.Show("로그인에 성공했습니다.", "로그인" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain2 frmMain2 = new FrmMain2();
                frmMain2.Show();

            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

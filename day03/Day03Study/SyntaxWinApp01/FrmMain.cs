using System.Numerics;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 기본생성자
            Person miyabi = new Person();
            miyabi.Name = TxtName.Text.Trim();
            miyabi.Age = int.Parse(TxtAge.Text.Trim());
            miyabi.Gendaer = char.Parse(TxtGander.Text.Trim());
            miyabi.Phone = TxtPohon.Text.Trim();

            // 매개변수 생성자
            Person ashely = new Person("방부", 5,'M',"010-1111-1111");

            TxtResult.Text = miyabi.ToString();
            miyabi.GetUp();
            miyabi.GoToSchool();

            // static일 경우는 객체를 생성하지 않는다
            Person.GetNumber();
        }
    }
}

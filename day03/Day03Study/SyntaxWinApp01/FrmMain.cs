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
            // �⺻������
            Person miyabi = new Person();
            miyabi.Name = TxtName.Text.Trim();
            miyabi.Age = int.Parse(TxtAge.Text.Trim());
            miyabi.Gendaer = char.Parse(TxtGander.Text.Trim());
            miyabi.Phone = TxtPohon.Text.Trim();

            // �Ű����� ������
            Person ashely = new Person("���", 5,'M',"010-1111-1111");

            TxtResult.Text = miyabi.ToString();
            miyabi.GetUp();
            miyabi.GoToSchool();

            // static�� ���� ��ü�� �������� �ʴ´�
            Person.GetNumber();
        }
    }
}

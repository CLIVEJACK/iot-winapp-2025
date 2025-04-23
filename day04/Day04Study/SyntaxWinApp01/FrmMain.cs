using SyntaxWinApp01.Properties;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            Person person = new Person();

            try
            {
                person.Name = TxtName.Text.Trim();  // Trim()���� ����
                // int -> 4����Ʈ ����, decimal -> 16����Ʈ �Ǽ�
                // ū�������� ���������� ���� ������ �������� ���� �Ҵ�(�׳� ����ȯ �ʿ���ٴµ�)
                //person.Age = NudAge.Value;
                person.Age = Convert.ToInt32(NudAge.Value); // �̹�� �� ��ȣ
                //person.Gender = char.Parse(TxtGender.Text.Trim());  // �̷������� Parse�� ������ String���� ������ ������
                person.Gender = Convert.ToChar(TxtGender.Text.Trim());
                person.Phone = TxtPhone.Text.Trim();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("������ M/F�� �Է��ϼ���", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                float rval = 0f;
                int x = 10, y = 5;
                rval = x / y;

                MessageBox.Show(rval.ToString());
            }
            catch (DivideByZeroException ex) //DivideByZeroException�� �θ�Ŭ������ ����ص� ����
            {

                MessageBox.Show("���� 0�� ������ �����ϴ�.", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            catch (Exception ex)
            {
                MessageBox.Show("MO?LU �����Դϴ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                //���ܿ� ������� �׻� ����Ǿ�� �ϴ� ���� ���⿡ �ۼ�
            }

            // ���� Person��ü ������ ó��
            person.BirthYear = DateTime.Now.Year - person.Age;


            char korGender = person.Gender == 'M' ? '��' : '��';
            string result = $"���� Person�� {person.Name},\r\n" +
                            $"����, {person.Age}��({person.BirthYear}���)\r\n" +
                            $"����, {korGender}��\r\n" +
                            $"����, {person.Phone}";
            TxtResult.Text = result;


            if (person.Age > 0 && person.Age < 20)
            {
                if (person.Gender == 'M')
                    PicResult.Image = Resources.boy;
                else
                    PicResult.Image= Resources.girl;
            }
           
            else if (person.Age < 20 && person.Age < 45)
            {
                if (person.Gender == 'M')
                    PicResult.Image = Resources.man;
                else
                    PicResult.Image = Resources.woman;
            }
            else
            {
                if (person.Gender == 'M')
                    PicResult.Image = Resources.old_man;
                else
                    PicResult.Image = Resources.old_woman;
            }


        }
    }
}

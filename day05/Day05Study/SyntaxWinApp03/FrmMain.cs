using System.Security.Cryptography.Xml;

namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        // async �񵿱�� �����ϴ� �޼����� ����
        // async�� await�� �׻� ���� ���
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            LblCurrState.Text = "������� : ����";    // UIó��
            BtnStart.Text = "������";// UIó��
            BtnStart.Enabled = false; // ������ ��

            // ��û�� �ð��� �ɸ��� ������ ����
            long MaxVal = 200;
            long total = 0;
            PrgProcess.Minimum = 0; // UIó��
            PrgProcess.Maximum = 100;   // UIó��

            // await�� �񵿱� ���
            await Task.Run(() =>
            {
                for (int i = 0; i < MaxVal; i++)
                {
                    total += i % 3;

                    int progress = (int)((i * 100) / MaxVal) + 1;
                    Console.WriteLine(progress.ToString());
                    // Task.Run �� ���� UIó�� ������
                    this.Invoke(new Action(() =>
                    {
                        TxtLog.Text += i.ToString() + "\r\n";
                        TxtLog.SelectionStart = TxtLog.Text.Length;
                        TxtLog.ScrollToCaret(); // ��ũ�� ���� ������ 
                        PrgProcess.Value = progress;
                    }));
                   
                    
                    Thread.Sleep(50);

                    //Application.DoEvents(); // �������� ����

                }
            });

            LblCurrState.Text = "������� : ����";
            BtnStart.Text = "����"; // UIó��
            BtnStart.Enabled = true; // UIó��

        }
    }
}

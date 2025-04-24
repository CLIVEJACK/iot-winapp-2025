using System.Drawing.Drawing2D;

namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        // �븮��(delegate) ����
        delegate void MyDelegate(string msg);

        // �̺�Ʈ�ڵ�� �븮�� ����
        delegate void MyEverntHandler(object semder, EventArgs e);
        // �̺�Ʈ������
        public event EventHandler SomethingHappend;

        // �븮�ڿ��� ȣ���� �޼��� - �븮�ڿ� �Ķ���Ͱ� ��ġ
        void SayHello(string msg)
        {
            MessageBox.Show($"�ȳ�, {msg}", "�޽���",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void SayGoodbye(string msg)
        {
            MessageBox.Show($"���Ϻ� �ȳ�, {msg}", "�޽���",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public FrmMain()
        {
            InitializeComponent();
            TxtLog.Text += ("1. �� ������ ����\r\n");
        }
        private void FrmMain_Load(object sender, EventArgs e) {
            TxtLog.Text += ("2. ���ε� �̺�Ʈ ����\r\n");
        }
        private void FrmMain_Shown(object sender, EventArgs e) {
            TxtLog.Text += ("4. ���� �̺�Ʈ\r\n");
        }
        private void FrmMain_Activated(object sender, EventArgs e) {
            TxtLog.Text += ("3. ����Ƽ����Ʈ �̺�Ʈ ����\r\n");
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            TxtLog.Text += ("5. ��Ŭ��¡ �̺�Ʈ ����\r\n");
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) {
            TxtLog.Text += ("6. ��Ŭ����� �̺�Ʈ ����\r\n");
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 1. ���� ȣ��
            SayHello("���");
            SayGoodbye("���2"); // �޼��带 ���� ȣ��

            // 2. �븮��(delegat) ȣ��(���� ���� �ٽ�!!)
            MyDelegate del = SayHello; // �븮�ڿ� ȣ���� �޼��带 ������
            del += SayGoodbye;      // �߰��� ���� �̷� �θ��� �Ѵ� ������ (�븮�� ü�� �߰�)
            del -= SayGoodbye;      //(�븮�� ü�� ����)
            del("����");

            // 3. ��ȯ�� ���� �븮�� - Action
            Action<string> act = SayHello;
            act("Miyabi");

            // 4. ��ȯ�� �ִ� �븮�� - Func
            Func<int, int, int> add = (a, b) => a + b;  // ���ٽ����� ����
            int result = add(7, 8);
            Console.WriteLine(result);

            if (SomethingHappend != null)
            {
                SomethingHappend(this, new EventArgs()); // �̺�Ʈ ����
            }
        }

    }
}

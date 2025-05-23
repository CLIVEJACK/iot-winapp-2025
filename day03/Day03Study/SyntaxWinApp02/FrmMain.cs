using SyntaxWinApp02.Properties;
using System.Xml.Schema;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Computer myCom = new Computer();
            //Notebook myNotbook = new Notebook();
            //Server yourServer = new Server();   

            //Computer yourCom = new Notebook(); // 부모클래스에 자식객체 할당
            switch (CboDivision.SelectedIndex)
            {


                case 0:     // Computer
                    Computer myCom = new Computer();
                    PicComputer.Image = Resources.computer_case;

                    myCom.Boot();
                    myCom.Reset();
                    myCom.ShutDown();
                    break;

                case 1:     // NotBook

                    Notebook myBook = new Notebook();
                    PicComputer.Image = Resources.laptop;

                    myBook.Reset();
                    myBook.ShutDown();  // 부모와 다르게 동작

                    // Computer sCom = myBookl
                    // 부모클래스를 자식클래스로 형변환하면서 문제발생 소지
                    //Notebook myBook2 = (Notebook)new Computer();
                    Computer myComputer = new Notebook();

                    if (myComputer is Notebook)
                    {
                        Console.WriteLine("myComputer은 Notebook입니다.");
                        Notebook myBook2 = myComputer as Notebook;
                        Console.WriteLine("myComputer은 Notebook으로 변경!");
                    }

                    // 지문인식확인
                    bool hasFinger = myBook.HasFingerScanDevice();
                    Console.WriteLine($"최종 지문인식여부 :: {hasFinger}");
                    // 메서 드오버로드
                    hasFinger = myBook.HasFingerScanDevice(true);
                    Console.WriteLine($"최종 지문인식여부 :: {hasFinger}");
                    break;

                case 2:     // Server
                    Server yourServ = new Server();
                    PicComputer.Image = Resources.server;
                    break;

                default:
                    break;
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Server server1 = new Server();
            server1.Name = "HP서버";

            Server server2 = server1;   // 얕은 복사 : 같은 내용 참조
            server2.Name = "DELL서버";

            bool isSame = server1.Equals(server2);
            Console.WriteLine(isSame);

            MessageBox.Show($"{server1.Name}\r\n{server2.Name}", "서버명");

            //깊은 복사 ㅣ 완전 다른객체로 복사
            Server server3 = server1.DeepCopy();
            server3.Name = "INTEL서버";

            isSame = server2.Equals(server3);
            Console.WriteLine(isSame);

            MessageBox.Show($"{server1.Name}\r\n{server3.Name}", "서버명");
        }
    }
}

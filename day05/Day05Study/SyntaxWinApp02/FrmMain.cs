namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int add(int x, int y)
        {
            return x + y; // 한줄짜리
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int result = add(10, 5);

            // 대리자 = 람다식
            Func<int, int, int> add2 = (x, y) => x + y;
            TxtLog.Text += result + "\r\n";         // 딸피식
            TxtLog.Text += add2(10, 6) + "\r\n";    // 람다

            // SayHello 함수 생성대신
            Action<string> sayHello = name => MessageBox.Show($"안녕, {name}", "인사",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            sayHello("방부");

            // LINQ 사용 이전
            List<int> resList = new List<int>();
            List<int> numbers = [4, 10, 1, 5, 9, 8, 6, 2, 3, 7];
            List<string> words = ["Hello", "World"];

            // 짝수만 추출해서 오름차순 정렬 하는 로직
            foreach (int n in numbers)
            {
                if (n % 2 == 0) // 2로 나눠서 0이면 짝수
                {
                    resList.Add(n);
                }
            }

            TxtLog.Text += "틀딱 짝수리스트 >" + string.Join(" ", resList) + "\r\n";

            resList.Sort();

            TxtLog.Text += "틀딱 정렬리스트 >" + string.Join(" ", resList) + "\r\n";

            // LINQ 방식 > 3줄로 위의 틀딱 방식을 처리
            numbers = [14, 20, 11, 15, 18, 19, 16, 13, 12, 17];
            var resList2 = from n in numbers            // SQL문 처럼 코딩 가능
                           where n % 2 == 0
                           orderby n
                           select n;
            TxtLog.Text += "링큐1 정렬리스트 > " + string.Join(" ", resList2) + "\r\n";

            // LINQ Method Chaining
            numbers = [24, 30, 21, 25, 28, 29, 26, 23, 22, 27];
            var resList3 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtLog.Text += "링큐2 정렬리스트 > " + string.Join(" ", resList3) + "\r\n";


        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //UI 초기화
            TxtTest.PlaceholderText = "테스트 입니다";
            TxtTest.Size = new Size(200, 23);
            TxtTest.KeyPress += TxtTest_KeyPress; // Designer에서 작업하는 것과 동일
            TxtTest.Font = new Font("휴먼매직체", 12, FontStyle.Italic);
        }

        private void TxtTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("엔터를 클릭했씁니다.", "키프레스",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGeneric_Click(object sender, EventArgs e)
        {
            // 기본
            Print<int>(100);
            Print<float>(3.141565f);
            Print<string>("안녕 방부");
            Print<bool>(false);

            // 생략가능 
            Print(100);
            Print(3.141565f);
            Print("잘가 방부");
            Print(false);

            //제네릭 클래스 
            Box<int> intBox = new Box<int>();
            intBox.Value = 300;
            intBox.Show();

            Box<string> strBox = new Box<string>();
            strBox.Value = "웅나";
            strBox.Show();
        }

        public void Print<T>(T data) { Console.WriteLine(data); }
    }

    // 제네릭 클래스
    public class Box<T> //where T : struct 
    {
        public T Value { get; set; } // 속성
        //private T Value; // 멤버변수

        public void Show()
        {
            MessageBox.Show($"Box의 값 : {Value}", "Box값",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

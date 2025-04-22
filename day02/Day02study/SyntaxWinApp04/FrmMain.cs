namespace SyntaxWinApp04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("웅나나(값을 채워주세요.)");
                return; // 메서드 탈출
            }else
            {
                //위에 문제가 없을때 동작...
                LblResult.Text = "처리결과 : ";
                TxtResult.Text = "먼가 처리될 거임";

                string name = TxtName.Text.Trim();      //.Trim()는 앞뒤에 여백을 제거
                // Parse (파싱) -> 분석해서 형변환
                DateTime birthday = DateTime.Parse(TxtAge.Text.Trim());
                int age = DateTime.Now.Year - birthday.Year;
                // 3항식 분기
                string gender = RdoMal.Checked ? "꽈츄" : "온나";

                // 구식 포맷팅
                TxtResult.Text = "저는 " + name + "이고," + birthday + "에 태어난 " + age + "살 " + gender + "입니다.";
                // 최신방식의 문자열 포맷팅 $""
                TxtResult.Text = $"저는 {name}이고, {birthday:yyyy-MM-dd}일에 태어난 {age:F1}살 {gender}입니다!!";
            }
        }
    }
}

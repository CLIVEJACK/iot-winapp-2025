namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {   
        //var int09 = 10; // var는 전역변수 사용 불가

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("웅나~", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // 자료형
            sbyte byteVal = 127; // signed byte : -128 ~ 127 수 저장
            System.SByte sbtVal2 = System.SByte.MinValue; // -128 할당
            byte btVal = 255; // byte : 0 ~ 255 수 저장(1 byte 크기)
            System.Byte btVal2 = System.Byte.MinValue; // 0 할당
            short stval = 32767; //short : -32768 ~ 32767 수 저장
            System.Int16 stval2 = System.Int16.MinValue;    // - 32768 할당
            ushort sutVal = 65535; // unsingned short : 0 ~ 65535 저장(2 bytes 크기)
            System.UInt16 uinVal2 = System.UInt16.MinValue;   // 0 할당
            int inVal = 2147483647; // int : -21억 ~ 21억(4bytes 크기)
            System.Int32 intVal2 = System.Int32.MinValue;    // -21억 할당 
            uint uintVal = 4294967295; // usingned int : 0~ 42억 (4bytes 크기) 
            System.UInt32 uintVal2 = System.UInt32.MinValue; // 0할당
            long lngVal = 900000000000000; // long : -92경 ~ 92경
            ulong ulngVal = 1800000000000000; // unsigned long : 1800경(8bytes)
            System.Int64 longVal02;     //(8bytes)
            System.UInt128 ulngVal03;   //(16bytes)

            // 실수 자료형
            float fVal = 3.141592f; // float : 4bytes 소수점
            System.Single fVal2 = System.Single.MinValue; // +-1.5e-45 할당
            double dVal = 3.141592; // double : 8bytes 소수점
            System.Double dVal2;
            decimal dcVal = 3.141592m;  // decimal : 16bytes 소수점
            System.Decimal dcVal2;

            // 문자형 타입 
            char ch01 = 'A';
            System.Char ch03 = 'B'; 
            Console.WriteLine(ch01);
            char ch02 = '\u25b6';
            Console.WriteLine(ch02);

            string str01 = "Hello\0 World";     // \ :  end of line 그뒤로는 글이 없다 라는 뜻 
            System.String str02 = "Hello C#";

            // 불린 타입
            bool bool01 = true;
            System.Boolean bool02 = true;

            //Nullable
            //int int02 = null;   // 기본타입(정수형, 실수형, 불린/ 문자열제외)은 Null을 할당할수 없다
            int? int03 = null;  // 기본타입 뒤에 ? 붙여줄 것

            // 상수타입 
            const int int04 = 15;   // const를 만나면 상수. 한번 할당후 변경불가능
            //int04 = 26

            // 동적타입 // 컴파일 되면서 해당 타입으로 형결정
            var int05 = 50;    

            //MessageBox.Show(intVal2.ToString() + ch01 + ch02, "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(int03.ToString(), "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

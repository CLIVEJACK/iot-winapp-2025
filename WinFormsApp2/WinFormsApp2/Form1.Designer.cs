using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;

namespace CalendarProject
{
    public partial class frmCalendar : Form
    {
        private DBConn conn = new DBConn();
        private DataGridView[] dgv = new DataGridView[12];
        private Label[] lbl = new Label[12];

        private string[] days = { "일", "월", "화", "수", "목", "금", "토" };
        private int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private string[] holidays = { "신정", "설날", "3·1절", "어린이날", "석가탄신일", "현충일", "광복절", "추석", "개천절", "한글날", "성탄절" };
        public const int PRE_GROEGORY = 1582;
        public const int LEAP_YEAR_1582 = 383;

        //print fields
        private System.IO.Stream streamToPrint;
        string streamType;
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        public static extern bool BitBlt
            (
                IntPtr hdcDest,
                int nXDest,
                int nYDest,
                int nWidth,
                int nHeight,
                IntPtr hdcSrc,
                int nXSrc,
                int nYSrc,
                int dwRop
            );
        //----------------------------------------

        public frmCalendar()
        {
            InitializeComponent();
        }

        private void calendar_Load(object sender, EventArgs e)
        {
            CreateDataGridViews();

            string year = DateTime.Now.ToString("yyyy");
            int month = 1;

            tbYear.Text = year;

            foreach (DataGridView item in dgv)
            {
                DrawCalendar(item, year, month++);
                isHoliday(item);
            }
        }

        private void CreateDataGridViews()
        {
            int x = 20, y = 80;
            int a = 20, b = 60;

            for (int i = 0; i < dgv.Length; i++)
            {
                lbl[i] = new Label();
                lbl[i].Text = (i + 1).ToString() + "월";
                lbl[i].Font = new Font("Tahoma", 10, FontStyle.Bold);
                lbl[i].Location = new System.Drawing.Point(a, b);

                dgv[i] = new DataGridView();
                dgv[i].Name = "dgv" + i.ToString();
                dgv[i].Font = new Font("Tahoma", 7, FontStyle.Regular);
                dgv[i].Width = 400;
                dgv[i].Height = 290;
                dgv[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgv[i].AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv[i].AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv[i].Location = new System.Drawing.Point(x, y);

                //DataGridView 컨트롤 위치 조정
                x += 410;
                a += 410;
                if (i == 3 || i == 7)
                {
                    x = 20;
                    y += 320;
                    a = 20;
                    b += 320;
                }

                this.Controls.Add(dgv[i]);
                this.Controls.Add(lbl[i]);

                dgv[i].ColumnCount = 7;

                for (int j = 0; j < days.Length; j++)
                {
                    dgv[i].Columns[j].Name = days[j];
                }
            }
        }

        private void DrawCalendar(DataGridView grid, string year, int month)
        {
            string[] calendarRow;
            int thisYear = int.Parse(year);
            int thisMonth = month;
            int thisMonthFirstDay = FirstDayOfMonth(thisYear, thisMonth);
            int start = 1, end = months[thisMonth - 1];
            bool leap = isLeap(thisYear);

            DataTable dt = conn.getLunar(year, month);
            DataRow[] dr = dt.Select();

            //해당 연도와 월이 윤년이면서 2월인 경우 29일로 찍어준다.
            if (leap && (thisMonth == 2))
                end += 1;

            for (int i = 0; i < 6; i++)
            {
                //한 주의 길이
                calendarRow = new string[7];
                for (int j = 0; j < calendarRow.Length; j++)
                {
                    //시작일이 마지막일 보다 커지면 종료
                    if (start > end)
                        break;

                    //첫 주의 경우 j가 시작 요일과 같아지는 지점에서 시작하도록 한다. 
                    if (i == 0)
                    {
                        if (j >= thisMonthFirstDay)
                            calendarRow[j] = getDate(dr, start);
                        else
                            continue;
                    }
                    else
                    {
                        //나머지 주는 그냥 출력
                        calendarRow[j] = getDate(dr, start);
                    }
                    start++;

                    grid.Columns["토"].DefaultCellStyle.ForeColor = Color.Blue;
                    grid.Columns["일"].DefaultCellStyle.ForeColor = Color.Red;
                }
                grid.Rows.Add(calendarRow);
            }


        }

        //데이터베이스에서 가져온 정보와 날짜를 받아서 해당일의 양력/음력/공휴일 정보 가져옴
        private string getDate(DataRow[] dr, int start)
        {
            int index = start - 1;
            string luna = "lunar_date", memo = "memo";

            return string.Format("{0}\n{1}\n{2}", start.ToString(), dr[index][luna].ToString().Substring(2), dr[index][memo].ToString().Replace("<br>", "\n"));
        }

        //윤년인지 아닌지 체크
        private bool isLeap(int year)
        {
            bool isLeap = false;

            // 4로 나누어 떨어지고 100으로 나누어 떨어지지 않거나 400으로 나누어 떨어지는 해는 윤년이다.
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                isLeap = true;
                return isLeap;
            }
            return isLeap;
        }

        //1583년 1월 1일 (토요일) 보다 FirstDayOfYear의 값만큼 앞으로 이동
        private int FirstDayOfYear(int year)
        {
            int lastYear = year - 1;

            //1583년부터 직년 연도까지 몇 년이었는지 구한다.
            int totalYears = lastYear - PRE_GROEGORY;
            //해당 기간 동안 윤년이 몇 번이었는지 구한다.
            int leapYears = (lastYear / 4 - lastYear / 100 + lastYear / 400) - LEAP_YEAR_1582;
            //해당 기간 동안 평년이 몇 번이었는지 구한다.
            int nomalYears = totalYears - leapYears;

            //기준일로부터 이동 해야하는 거리
            int move = (nomalYears + (leapYears * 2)) % 7;
            //1583년 1월1일은 토요일(= days 배열 상에서 6번째), 배열에서 토요일로부터 얼마나 떨어져 있는지 구한다.
            int FirstDayOfYear = (move + Array.IndexOf(months, "토")) % 7;

            //배열 days[FirstDayOfYear]가 해당 연도 1월 1일의 요일이다.
            return FirstDayOfYear;
        }

        //올해 1월 1일의 요일보다 FirstDayOfMonth의 값만큼 앞으로 이동.
        private int FirstDayOfMonth(int year, int month)
        {
            bool leap = isLeap(year);
            int sumofLastMonth = 0;
            int firstDayOfYear = FirstDayOfYear(year);

            //해달 연도의 1월1일부터 직전 달까지의 일수를 누적한다. 
            for (int i = 0; i < month - 1; i++)
            {
                sumofLastMonth += months[i];
            }
            //윤년이면서 해당 월이 1월과 2월이 아닌 날은 2월이 하루 늘어나므로 하루를 더해준다.
            if (leap == true && (month != 1 && month != 2))
                sumofLastMonth += 1;

            int move = sumofLastMonth % 7;
            int FirstDayOfMonth = (move + firstDayOfYear) % 7;

            //days[FirstDayOfMonth]가 해당 월의 요일이다.
            return FirstDayOfMonth;
        }

        private void moveCalendar(string year, int month)
        {
            tbYear.Text = year;

            foreach (DataGridView item in dgv)
            {
                item.Rows.Clear();
                DrawCalendar(item, year, month++);
                isHoliday(item);
            }
        }

        private void isHoliday(DataGridView item)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < days.Length; j++)
                {
                    string memo = (string)item.Rows[i].Cells[j].Value;
                    foreach (string holiday in holidays)
                    {
                        if (memo == null)
                            break;
                        else if (memo.Trim().EndsWith(holiday))
                            item.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void yearLeft_Click(object sender, EventArgs e)
        {
            string year = (int.Parse(tbYear.Text) - 1).ToString();
            int month = 1;
            moveCalendar(year, month);
        }

        private void yearRight_Click(object sender, EventArgs e)
        {
            string year = (int.Parse(tbYear.Text) + 1).ToString();
            int month = 1;
            moveCalendar(year, month);
        }

        private void tbYear_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string year = tbYear.Text;
                int month = 1;
                moveCalendar(year, month);
            }
        }

        //print methods

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Image image = System.Drawing.Image.FromStream(this.streamToPrint);
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            int width = image.Width;
            int height = image.Height;
            if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
            {
                width = e.MarginBounds.Width;
                height = image.Height * e.MarginBounds.Width / image.Width;
            }
            else
            {
                height = e.MarginBounds.Height;
                width = image.Width * e.MarginBounds.Height / image.Height;
            }
            System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g1 = this.CreateGraphics();
            Image MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
            Graphics g2 = Graphics.FromImage(MyImage);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            MyImage.Save(@"C:\PrintPage.jpg", ImageFormat.Jpeg);
            FileStream fs = new FileStream(@"C:\PrintPage.jpg", FileMode.Open, FileAccess.Read);
            StartPrint(fs, "Image");
            fs.Close();
            if (System.IO.File.Exists(@"C:\PrintPage.jpg"))
            {
                System.IO.File.Delete(@"C:\PrintPage.jpg");
            }
        }


        public void StartPrint(Stream streamToPrint, string streamType)
        {
            this.printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.streamToPrint = streamToPrint;
            this.streamType = streamType;
            //System.Windows.Forms.PrintDialog printDialog1 = new PrintDialog();
            printDialog1.AllowSomePages = true;
            printDialog1.ShowHelp = true;
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }


        //----------------------------------------------------

        /*
        private void btnLeft_Click(object sender, EventArgs e)
        {
            string year, month;
            string isFirstMonth = cbMonth.Text;

            if (isFirstMonth == "1")
            {
                year = (int.Parse(tbYear.Text) - 1).ToString();
                month = (int.Parse(cbMonth.Text) + 11).ToString(); ;
            }
            else
            {
                year = tbYear.Text;
                month = (int.Parse(cbMonth.Text) - 1).ToString();
            }

            moveCalendar(year, month);
        }

        private void btnRight_Click_1(object sender, EventArgs e)
        {
            string year, month;
            string isLastMonth = cbMonth.Text;

            if (isLastMonth == "12")
            {
                year = (int.Parse(tbYear.Text) + 1).ToString();
                month = (int.Parse(cbMonth.Text) - 11).ToString(); ;
            }
            else
            {
                year = tbYear.Text;
                month = (int.Parse(cbMonth.Text) + 1).ToString();
            }

            moveCalendar(year, month);
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = tbYear.Text;
            string month = cbMonth.Text;

            moveCalendar(year, month);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string year = tbYear.Text;
            string month = cbMonth.Text;

            moveCalendar(year, month);
        }
        */
    }


    public class DBConn
    {
        private const string PATH = "server=192.168.96.232;uid=kimyong;pwd=dydwls;database=userdb;";
        private SqlConnection sconn = new SqlConnection(PATH);
        private SqlCommand scomm = new SqlCommand();

        private void OpenDB()
        {
            scomm.Connection = sconn;
            sconn.Open();
        }

        private void CloseDB()
        {
            if (sconn != null)
                sconn.Close();
        }

        public DataTable getLunar(string year, int month)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string transMonth = month.ToString();

            if (month < 10)
                transMonth = "0" + month.ToString();

            OpenDB();

            string query = string.Format("select lunar_date,memo from calendar where solar_date like '{0}-{1}-%' order by num asc", year, transMonth);

            SqlDataAdapter adp = new SqlDataAdapter(query, sconn);
            adp.Fill(ds, "calendar");

            dt = ds.Tables["calendar"];

            CloseDB();

            return dt;
        }
    }
}
using login01.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login01
{
    public partial class FrmSearching : Form
    {
        public FrmSearching()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            Person person = new Person();

            try
            {
                person.Name = TxtName.Text.Trim();
                person.Age = Convert.ToInt32(NudAge.Value);
                person.Gender = Convert.ToChar(TxtGender.Text.Trim());
                person.Phone = TxtPhone.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("성별은 M/F 한글자만 입력하세요", "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                float rval = 0f;
                int x = 10, y = 5;
                rval = x / y;

            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show("수는 0으로 나눌 수 없습니다", "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("알수 없는 예외입니다", "예외", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                // 예외와 관계없이 항상 실행되어야 하는 구문 여기에 작성
            }

            // 들어온 Person객체 값으로 처리
            person.BirthYear = DateTime.Now.Year - person.Age;

            char korGender = person.Gender == 'M' ? '남' : '여';
            string result = $"현재 Person은 {person.Name},\r\n" +
                            $"나이, {person.Age}세({person.BirthYear}년생)\r\n" +
                            $"성별, {korGender}자\r\n" +
                            $"폰번호, {person.Phone}";
            TxtResult.Text = result;

            if (person.Age > 0 && person.Age < 20)
            {
                if (person.Gender == 'M')
                    PicResult.Image = Resources.boy;
                else
                    PicResult.Image = Resources.girl;

            }
            else if (person.Age >= 20 && person.Age < 45)
            {
                if (person.Gender == 'M')
                    //PicResult.Image = Resources.man;
                else
                    //PicResult.Image = Resources.woman;
            }
            else
            {
                if (person.Gender == 'M')
                    //PicResult.Image = Resources.old_man;
                else
                    //PicResult.Image = Resources.old_woman;
            }
        }

        private void PicResult_Click(object sender, EventArgs e)
        {

        }
    }
}

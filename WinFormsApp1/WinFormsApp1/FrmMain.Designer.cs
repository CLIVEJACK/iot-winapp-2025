namespace WinFormsApp1
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtYear = new TextBox();
            TxtMonth = new TextBox();
            TxtDay = new TextBox();
            BtnIndex = new Button();
            monthCalendar1 = new MonthCalendar();
            BtnCheck = new Button();
            TxtIndex = new TextBox();
            SuspendLayout();
            // 
            // TxtYear
            // 
            TxtYear.Location = new Point(304, 33);
            TxtYear.Name = "TxtYear";
            TxtYear.Size = new Size(100, 23);
            TxtYear.TabIndex = 0;
            // 
            // TxtMonth
            // 
            TxtMonth.Location = new Point(304, 76);
            TxtMonth.Name = "TxtMonth";
            TxtMonth.Size = new Size(100, 23);
            TxtMonth.TabIndex = 1;
            // 
            // TxtDay
            // 
            TxtDay.Location = new Point(304, 122);
            TxtDay.Name = "TxtDay";
            TxtDay.Size = new Size(100, 23);
            TxtDay.TabIndex = 2;
            // 
            // BtnIndex
            // 
            BtnIndex.Location = new Point(351, 339);
            BtnIndex.Name = "BtnIndex";
            BtnIndex.Size = new Size(75, 23);
            BtnIndex.TabIndex = 3;
            BtnIndex.Text = "등록";
            BtnIndex.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(254, 339);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(75, 23);
            BtnCheck.TabIndex = 5;
            BtnCheck.Text = "보기";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // TxtIndex
            // 
            TxtIndex.Location = new Point(447, 33);
            TxtIndex.Multiline = true;
            TxtIndex.Name = "TxtIndex";
            TxtIndex.Size = new Size(275, 112);
            TxtIndex.TabIndex = 6;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtIndex);
            Controls.Add(BtnCheck);
            Controls.Add(monthCalendar1);
            Controls.Add(BtnIndex);
            Controls.Add(TxtDay);
            Controls.Add(TxtMonth);
            Controls.Add(TxtYear);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtYear;
        private TextBox TxtMonth;
        private TextBox TxtDay;
        private Button BtnIndex;
        private MonthCalendar monthCalendar1;
        private Button BtnCheck;
        private TextBox TxtIndex;
    }
}

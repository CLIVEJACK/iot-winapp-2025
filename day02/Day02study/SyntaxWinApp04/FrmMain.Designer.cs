namespace SyntaxWinApp04
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
            LblName = new Label();
            TxtName = new TextBox();
            TxtAge = new TextBox();
            LblAge = new Label();
            LblGender = new Label();
            RdoMal = new RadioButton();
            RdoFemale = new RadioButton();
            BtnMsg = new Button();
            LblResult = new Label();
            TxtResult = new TextBox();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(12, 15);
            LblName.Name = "LblName";
            LblName.Size = new Size(58, 15);
            LblName.TabIndex = 0;
            LblName.Text = "이름입력:";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(76, 12);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(192, 23);
            TxtName.TabIndex = 1;
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(76, 41);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(192, 23);
            TxtAge.TabIndex = 2;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(12, 44);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(58, 15);
            LblAge.TabIndex = 2;
            LblAge.Text = "나이입력:";
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Location = new Point(12, 73);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(58, 15);
            LblGender.TabIndex = 4;
            LblGender.Text = "성별입력:";
            // 
            // RdoMal
            // 
            RdoMal.AutoSize = true;
            RdoMal.Checked = true;
            RdoMal.Location = new Point(76, 71);
            RdoMal.Name = "RdoMal";
            RdoMal.Size = new Size(49, 19);
            RdoMal.TabIndex = 3;
            RdoMal.TabStop = true;
            RdoMal.Text = "꽈츄";
            RdoMal.UseVisualStyleBackColor = true;
            // 
            // RdoFemale
            // 
            RdoFemale.AutoSize = true;
            RdoFemale.Location = new Point(131, 71);
            RdoFemale.Name = "RdoFemale";
            RdoFemale.Size = new Size(52, 19);
            RdoFemale.TabIndex = 4;
            RdoFemale.Text = "온나!";
            RdoFemale.UseVisualStyleBackColor = true;
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(472, 259);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 6;
            BtnMsg.Text = "확인";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(12, 137);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(58, 15);
            LblResult.TabIndex = 2;
            LblResult.Text = "결      과:";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(76, 134);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(496, 23);
            TxtResult.TabIndex = 5;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnMsg);
            Controls.Add(RdoFemale);
            Controls.Add(RdoMal);
            Controls.Add(LblGender);
            Controls.Add(TxtResult);
            Controls.Add(LblResult);
            Controls.Add(TxtAge);
            Controls.Add(LblAge);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Name = "FrmMain";
            Text = "문법연습 윈앱04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private TextBox TxtAge;
        private Label LblAge;
        private Label LblGender;
        private RadioButton RdoMal;
        private RadioButton RdoFemale;
        private Button BtnMsg;
        private Label LblResult;
        private TextBox TxtResult;
    }
}

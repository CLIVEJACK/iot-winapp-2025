namespace SyntaxWinApp03
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
            BtnPain = new Button();
            LblPain = new Label();
            TxtPain = new TextBox();
            label1 = new Label();
            CboPain = new ComboBox();
            TxtResult = new TextBox();
            BtnDisplay = new Button();
            BtnWhile = new Button();
            SuspendLayout();
            // 
            // BtnPain
            // 
            BtnPain.Location = new Point(472, 259);
            BtnPain.Name = "BtnPain";
            BtnPain.Size = new Size(100, 40);
            BtnPain.TabIndex = 6;
            BtnPain.Text = "메시지";
            BtnPain.UseVisualStyleBackColor = true;
            BtnPain.Click += button1_Click;
            // 
            // LblPain
            // 
            LblPain.AutoSize = true;
            LblPain.Location = new Point(12, 25);
            LblPain.Name = "LblPain";
            LblPain.Size = new Size(64, 15);
            LblPain.TabIndex = 1;
            LblPain.Text = "통증여부 -";
            // 
            // TxtPain
            // 
            TxtPain.Location = new Point(82, 22);
            TxtPain.MaxLength = 3;
            TxtPain.Name = "TxtPain";
            TxtPain.PlaceholderText = "네 또는 아니오";
            TxtPain.Size = new Size(100, 23);
            TxtPain.TabIndex = 1;
            TxtPain.KeyPress += TxtPain_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "통증부위 -";
            // 
            // CboPain
            // 
            CboPain.FormattingEnabled = true;
            CboPain.Items.AddRange(new object[] { "머리", "목", "눈", "가슴", "배" });
            CboPain.Location = new Point(82, 54);
            CboPain.Name = "CboPain";
            CboPain.Size = new Size(121, 23);
            CboPain.TabIndex = 2;
            CboPain.Text = "부위선택";
            CboPain.SelectedIndexChanged += CboPain_SelectedIndexChanged_1;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(12, 83);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(560, 170);
            TxtResult.TabIndex = 3;
            // 
            // BtnDisplay
            // 
            BtnDisplay.Location = new Point(366, 259);
            BtnDisplay.Name = "BtnDisplay";
            BtnDisplay.Size = new Size(100, 40);
            BtnDisplay.TabIndex = 5;
            BtnDisplay.Text = "구구단";
            BtnDisplay.UseVisualStyleBackColor = true;
            BtnDisplay.Click += BtnDisplay_Click;
            // 
            // BtnWhile
            // 
            BtnWhile.Location = new Point(260, 259);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new Size(100, 40);
            BtnWhile.TabIndex = 4;
            BtnWhile.Text = "반복";
            BtnWhile.UseVisualStyleBackColor = true;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnWhile);
            Controls.Add(BtnDisplay);
            Controls.Add(TxtResult);
            Controls.Add(CboPain);
            Controls.Add(label1);
            Controls.Add(TxtPain);
            Controls.Add(LblPain);
            Controls.Add(BtnPain);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법학습 윈앱03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnPain;
        private Label LblPain;
        private TextBox TxtPain;
        private Label label1;
        private ComboBox CboPain;
        private TextBox TxtResult;
        private Button BtnDisplay;
        private Button BtnWhile;
    }
}

namespace login01
{
    partial class FrmSearching
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PicResult = new PictureBox();
            groupBox2 = new GroupBox();
            TxtPhone = new MaskedTextBox();
            NudAge = new NumericUpDown();
            TxtResult = new TextBox();
            TxtGender = new TextBox();
            TxtName = new TextBox();
            textBox10 = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BtnCheck = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicResult).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 337);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(62, 137);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 23);
            textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(62, 103);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 23);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(62, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 140);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "폰번";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 106);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "성별";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "나이";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "이름";
            // 
            // PicResult
            // 
            PicResult.Location = new Point(319, 12);
            PicResult.Name = "PicResult";
            PicResult.Size = new Size(303, 275);
            PicResult.SizeMode = PictureBoxSizeMode.StretchImage;
            PicResult.TabIndex = 1;
            PicResult.TabStop = false;
            PicResult.Click += PicResult_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtPhone);
            groupBox2.Controls.Add(NudAge);
            groupBox2.Controls.Add(TxtResult);
            groupBox2.Controls.Add(TxtGender);
            groupBox2.Controls.Add(TxtName);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 337);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox1";
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(62, 137);
            TxtPhone.Mask = "000-0000-0000";
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(177, 23);
            TxtPhone.TabIndex = 4;
            // 
            // NudAge
            // 
            NudAge.Location = new Point(62, 66);
            NudAge.Name = "NudAge";
            NudAge.Size = new Size(177, 23);
            NudAge.TabIndex = 6;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(17, 194);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(243, 127);
            TxtResult.TabIndex = 5;
            // 
            // TxtGender
            // 
            TxtGender.Location = new Point(62, 103);
            TxtGender.Name = "TxtGender";
            TxtGender.Size = new Size(177, 23);
            TxtGender.TabIndex = 3;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(62, 27);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(177, 23);
            TxtName.TabIndex = 1;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(62, 27);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(177, 23);
            textBox10.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 176);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 0;
            label9.Text = "결과";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 140);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 0;
            label5.Text = "폰번";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 106);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 0;
            label6.Text = "성별";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 69);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 0;
            label7.Text = "나이";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 30);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 0;
            label8.Text = "이름";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(522, 309);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 40);
            BtnCheck.TabIndex = 6;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // FrmSearching
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 361);
            Controls.Add(BtnCheck);
            Controls.Add(PicResult);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSearching";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "사람얼굴찾기";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicResult).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox PicResult;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox TxtResult;
        private TextBox TxtGender;
        private TextBox TxtName;
        private TextBox textBox10;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button BtnCheck;
        private NumericUpDown NudAge;
        private MaskedTextBox TxtPhone;
    }
}
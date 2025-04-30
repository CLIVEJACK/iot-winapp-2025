namespace login01
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
            label1 = new Label();
            id = new TextBox();
            pw = new TextBox();
            BtnSing = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20F);
            label1.Location = new Point(224, 32);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 0;
            label1.Text = "로그인 창";
            // 
            // id
            // 
            id.Location = new Point(194, 85);
            id.Name = "id";
            id.Size = new Size(190, 23);
            id.TabIndex = 1;
            // 
            // pw
            // 
            pw.Location = new Point(194, 153);
            pw.Name = "pw";
            pw.Size = new Size(190, 23);
            pw.TabIndex = 2;
            // 
            // BtnSing
            // 
            BtnSing.Location = new Point(249, 211);
            BtnSing.Name = "BtnSing";
            BtnSing.Size = new Size(100, 40);
            BtnSing.TabIndex = 3;
            BtnSing.Text = "로그인";
            BtnSing.UseVisualStyleBackColor = true;
            BtnSing.Click += BtnSing_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 10F);
            label2.Location = new Point(138, 87);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 4;
            label2.Text = "아이디";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 10F);
            label3.Location = new Point(123, 155);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 4;
            label3.Text = "비밀번호";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnSing);
            Controls.Add(pw);
            Controls.Add(id);
            Controls.Add(label1);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox id;
        private TextBox pw;
        public Label label1;
        private Button BtnSing;
        private Label label2;
        private Label label3;
    }
}

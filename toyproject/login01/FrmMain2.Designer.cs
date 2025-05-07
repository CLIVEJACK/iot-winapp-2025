namespace login01
{
    partial class FrmMain2
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
            BtnSearching = new Button();
            BtnIndex = new Button();
            SuspendLayout();
            // 
            // BtnSearching
            // 
            BtnSearching.Location = new Point(229, 79);
            BtnSearching.Name = "BtnSearching";
            BtnSearching.Size = new Size(100, 40);
            BtnSearching.TabIndex = 0;
            BtnSearching.Text = "사람검색";
            BtnSearching.UseVisualStyleBackColor = true;
            BtnSearching.Click += BtnSearching_Click;
            // 
            // BtnIndex
            // 
            BtnIndex.Location = new Point(229, 146);
            BtnIndex.Name = "BtnIndex";
            BtnIndex.Size = new Size(100, 40);
            BtnIndex.TabIndex = 1;
            BtnIndex.Text = "심문";
            BtnIndex.UseVisualStyleBackColor = true;
            BtnIndex.Click += Btn_Click;
            // 
            // FrmMain2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnIndex);
            Controls.Add(BtnSearching);
            Name = "FrmMain2";
            Text = "FrmMain2";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSearching;
        private Button BtnIndex;
    }
}
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
            Btninterrogation = new Button();
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
            // Btninterrogation
            // 
            Btninterrogation.Location = new Point(229, 146);
            Btninterrogation.Name = "Btninterrogation";
            Btninterrogation.Size = new Size(100, 40);
            Btninterrogation.TabIndex = 1;
            Btninterrogation.Text = "심문";
            Btninterrogation.UseVisualStyleBackColor = true;
            Btninterrogation.Click += Btninterrogation_Click;
            // 
            // FrmMain2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(Btninterrogation);
            Controls.Add(BtnSearching);
            Name = "FrmMain2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain2";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSearching;
        private Button Btninterrogation;
    }
}
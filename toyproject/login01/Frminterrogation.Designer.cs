namespace login01
{
    partial class Frminterrogation
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
            RtbNote = new RichTextBox();
            BtnLoad = new Button();
            BtnSave = new Button();
            BtnBold = new Button();
            BtnHighlight = new Button();
            DlgOpen = new OpenFileDialog();
            DlgSave = new SaveFileDialog();
            DlgColor = new ColorDialog();
            SuspendLayout();
            // 
            // RtbNote
            // 
            RtbNote.Location = new Point(12, 12);
            RtbNote.Name = "RtbNote";
            RtbNote.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            RtbNote.Size = new Size(560, 246);
            RtbNote.TabIndex = 0;
            RtbNote.Text = "";
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(472, 269);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(100, 30);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "읽기";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(366, 269);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 30);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnBold
            // 
            BtnBold.BackColor = SystemColors.ActiveCaption;
            BtnBold.Location = new Point(285, 273);
            BtnBold.Name = "BtnBold";
            BtnBold.Size = new Size(75, 23);
            BtnBold.TabIndex = 3;
            BtnBold.Text = "Bold";
            BtnBold.UseVisualStyleBackColor = false;
            BtnBold.Click += BtnBold_Click;
            // 
            // BtnHighlight
            // 
            BtnHighlight.BackColor = SystemColors.ActiveBorder;
            BtnHighlight.Location = new Point(204, 273);
            BtnHighlight.Name = "BtnHighlight";
            BtnHighlight.Size = new Size(75, 23);
            BtnHighlight.TabIndex = 4;
            BtnHighlight.Text = "Highlight";
            BtnHighlight.UseVisualStyleBackColor = false;
            BtnHighlight.Click += BtnHighlight_Click;
            // 
            // DlgOpen
            // 
            DlgOpen.FileName = "openFileDialog1";
            // 
            // Frminterrogation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnHighlight);
            Controls.Add(BtnBold);
            Controls.Add(BtnSave);
            Controls.Add(BtnLoad);
            Controls.Add(RtbNote);
            Name = "Frminterrogation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frminterrogation";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox RtbNote;
        private Button BtnLoad;
        private Button BtnSave;
        private Button BtnBold;
        private Button BtnHighlight;
        private OpenFileDialog DlgOpen;
        private SaveFileDialog DlgSave;
        private ColorDialog DlgColor;
    }
}
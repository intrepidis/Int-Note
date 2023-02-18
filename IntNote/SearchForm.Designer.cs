namespace IntNote
{
    partial class SearchForm
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            this.groupBoxReplace = new System.Windows.Forms.GroupBox();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.groupBoxFind.SuspendLayout();
            this.groupBoxReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(409, 55);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 34);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Find Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Continue;
            this.btnClose.Location = new System.Drawing.Point(409, 186);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Location = new System.Drawing.Point(6, 25);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(378, 26);
            this.txtFind.TabIndex = 0;
            this.txtFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFind_KeyPress);
            // 
            // txtReplace
            // 
            this.txtReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplace.Location = new System.Drawing.Point(6, 25);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(378, 26);
            this.txtReplace.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.Location = new System.Drawing.Point(409, 13);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(100, 34);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace.Location = new System.Drawing.Point(409, 97);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(4);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(100, 34);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFind.Controls.Add(this.txtFind);
            this.groupBoxFind.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxFind.Location = new System.Drawing.Point(12, 11);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Size = new System.Drawing.Size(390, 68);
            this.groupBoxFind.TabIndex = 0;
            this.groupBoxFind.TabStop = false;
            this.groupBoxFind.Text = "Find";
            // 
            // groupBoxReplace
            // 
            this.groupBoxReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReplace.Controls.Add(this.txtReplace);
            this.groupBoxReplace.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxReplace.Location = new System.Drawing.Point(12, 85);
            this.groupBoxReplace.Name = "groupBoxReplace";
            this.groupBoxReplace.Size = new System.Drawing.Size(390, 68);
            this.groupBoxReplace.TabIndex = 1;
            this.groupBoxReplace.TabStop = false;
            this.groupBoxReplace.Text = "Replace";
            // 
            // chkCase
            // 
            this.chkCase.AutoSize = true;
            this.chkCase.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chkCase.Location = new System.Drawing.Point(18, 164);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(121, 24);
            this.chkCase.TabIndex = 6;
            this.chkCase.Text = "Case Sensitive";
            this.chkCase.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(115F, 115F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(522, 233);
            this.Controls.Add(this.chkCase);
            this.Controls.Add(this.groupBoxReplace);
            this.Controls.Add(this.groupBoxFind);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(438, 272);
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            this.groupBoxReplace.ResumeLayout(false);
            this.groupBoxReplace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private Button btnPrev;
        private Button btnReplace;
        private GroupBox groupBoxFind;
        private GroupBox groupBoxReplace;
        internal TextBox txtFind;
        internal TextBox txtReplace;
        private CheckBox chkCase;
    }
}
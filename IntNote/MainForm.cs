using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IntNote
{
    public partial class MainForm : Form
    {
        private int cnt;
        private int cnt1;
        private int cnt2;
        private int cnt3;
        private Color Amoled = new();
        private Color defaultDark = new();
        private Color deepSlate = new();
        private Color trueDark = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void SaveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, mainTextBox.Text);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Do you want to save your changes?", "Create New File", MessageBoxButtons.YesNoCancel);
            mainTextBox.Text = "";
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                mainTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Undo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Paste();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectAll();
        }

        private void FontFaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                mainTextBox.Font = fontDialog1.Font;
        }

        private void FontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                mainTextBox.ForeColor = colorDialog1.Color;
        }

        private void AboutNotepadCloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Int-Note - Text editor in dark mode" + Environment.NewLine + "https://github.com/intrepidis/Int-Note", "About Int-Note", MessageBoxButtons.OK);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visit https://github.com/intrepidis/Int-Note for details about this app.", "About", MessageBoxButtons.OK);
        }

        private void PageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                mainTextBox.BackColor = colorDialog1.Color;
        }

        private void TrueDarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trueDark = ColorTranslator.FromHtml("#9A9A9A");
            switch (cnt)
            {
                case 1:
                {
                    mainTextBox.BackColor = trueDark;
                    cnt = 0;
                    break;
                }
                case 0:
                {
                    mainTextBox.BackColor = trueDark;
                    cnt = 1;
                    break;
                }
            }

        }

        private void DeepSlateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deepSlate = ColorTranslator.FromHtml("#3D3B3B");
            switch (cnt1)
            {
                case 1:
                {
                    mainTextBox.BackColor = deepSlate;
                    cnt1 = 0;
                    break;
                }
                case 0:
                {
                    mainTextBox.BackColor = deepSlate;
                    cnt1 = 1;
                    break;
                }
            }
        }

        private void DefaultDarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultDark = ColorTranslator.FromHtml("#404040");
            switch (cnt2)
            {
                case 1:
                {
                    mainTextBox.BackColor = defaultDark;
                    cnt2 = 0;
                    break;
                }
                case 0:
                {
                    mainTextBox.BackColor = defaultDark;
                    cnt2 = 1;
                    break;
                }
            }
        }

        private void JazzyAmoledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Amoled = ColorTranslator.FromHtml("#000000");
            switch (cnt3)
            {
                case 1:
                {
                    mainTextBox.BackColor = Amoled;
                    cnt3 = 0;
                    break;
                }
                case 0:
                {
                    mainTextBox.BackColor = Amoled;
                    cnt3 = 1;
                    break;
                }
            }
        }

        private void ChangelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Int-Note" + Environment.NewLine + "- Forked from Deybedanta WinNote 1.1.", "What's New?", MessageBoxButtons.OK);
        }
    }
}
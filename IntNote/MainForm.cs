using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IntNote
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private bool dirty = false;
        private static readonly string nl = Environment.NewLine;

        private void MainTextBox_TextChanged(object sender, EventArgs e) => dirty = true;

        private void NewFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DirtyCheckPass("Create New File"))
                return;

            mainTextBox.Text = "";
            dirty = false;
        }

        private void OpenFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DirtyCheckPass("Open File"))
                return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mainTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
                dirty = false;
            }
        }

        private void SaveFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, mainTextBox.Text);
                dirty = false;
            }
        }

        private void ExitProgram_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DirtyCheckPass("Exit App"))
                return;

            Close();
        }

        private void PrintFile_ToolStripMenuItem_Click(object sender, EventArgs e)
            => printDialog1.ShowDialog();

        private void Undo_ToolStripMenuItem_Click(object sender, EventArgs e)
            => mainTextBox.Undo();

        private void Cut_ToolStripMenuItem_Click(object sender, EventArgs e)
            => mainTextBox.Cut();

        private void Copy_ToolStripMenuItem_Click(object sender, EventArgs e)
            => mainTextBox.Copy();

        private void Paste_ToolStripMenuItem_Click(object sender, EventArgs e)
            => mainTextBox.Paste();

        private void SelectAll_ToolStripMenuItem_Click(object sender, EventArgs e)
            => mainTextBox.SelectAll();

        private void AboutAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MessageForm
            {
                Message = $"Int-Note - Text editor in dark mode{nl}https://github.com/intrepidis/Int-Note",
                Title = "About Int-Note",
            }.ShowDialog(this);
        }

        private void FontFaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                mainTextBox.Font = fontDialog1.Font;
        }

        private void FontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                SetStyle(fg: colorDialog1.Color);
        }

        private void PageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                SetStyle(bg: colorDialog1.Color);
        }

        private void TrueDarkToolStripMenuItem_Click(object sender, EventArgs e) => SetTheme("#9A9A9A");

        private void DeepSlateToolStripMenuItem_Click(object sender, EventArgs e) => SetTheme("#3D3B3B");

        private void DefaultDarkToolStripMenuItem_Click(object sender, EventArgs e) => SetTheme("#404040");

        private void JazzyAmoledToolStripMenuItem_Click(object sender, EventArgs e) => SetTheme("#000000");

        private void SetTheme(string bg) => SetStyle(fg: Color.White, bg: ColorTranslator.FromHtml(bg));

        private void SetStyle(Color? fg = null, Color? bg = null)
        {
            if (fg != null)
                mainTextBox.ForeColor = (Color)fg;

            if (bg != null)
                mainTextBox.BackColor = (Color)bg;
        }

        private bool DirtyCheckPass(string operation)
        {
            if (dirty)
            {
                DialogResult result = new MessageForm
                {
                    Message = "Is it ok to lose the unsaved changes?",
                    Title = operation,
                    CancelText = "Cancel",
                    SwitchButtonLocations = true,
                }.ShowDialog(this);

                if (result != DialogResult.OK)
                    return false;
            }
            return true;
        }
    }
}
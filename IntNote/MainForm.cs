using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IntNote
{
    public partial class MainForm : Form
    {
        public MainForm(string filePath)
        {
            InitializeComponent();

            theme = new(() => mainTextBox);
            file = new(ClearFile, SetFile, AnnounceFile);

            if (!string.IsNullOrEmpty(filePath))
                file.OpenFile(filePath);
        }

        private static readonly string nl = Environment.NewLine;
        private readonly ThemeManager theme;
        private readonly FileHandler file;

        private void MainTextBox_TextChanged(object sender, EventArgs e) => file.Dirty = true;

        private void NewFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DirtyCheckPass("Create New File"))
                return;

            file.NewFile();
        }

        private void OpenFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DirtyCheckPass("Open File"))
                return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                file.OpenFile(openFileDialog1.FileName);
        }

        private void SaveFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(file.CurrentFile))
            {
                SaveAsFile_ToolStripMenuItem_Click(sender, e);
                return;
            }

            file.SaveFile(mainTextBox.Text);
        }

        private void SaveAsFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                file.SaveAsFile(saveFileDialog1.FileName, mainTextBox.Text);
        }

        private void ExitProgram_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DirtyCheckPass("Exit App"))
                return;

            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !DirtyCheckPass("Exit App");
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
                Message = $"{nl}{nl}{nl}Int-Note - Text editor in dark mode{nl}{nl}{nl}{nl}https://github.com/intrepidis/Int-Note{nl}",
                Title = "About Int-Note",
            }.ShowDialog(this);
        }

        private void WordWrap_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectionStart = mainTextBox.SelectionStart;
            int selectionLength = mainTextBox.SelectionLength;

            if (mainTextBox.WordWrap)
            {
                mainTextBox.WordWrap = false;
                mainTextBox.ScrollBars = ScrollBars.Both;
            }
            else
            {
                mainTextBox.WordWrap = true;
                mainTextBox.ScrollBars = ScrollBars.Vertical;
            }

            mainTextBox.SelectionStart = mainTextBox.Text.Length;
            mainTextBox.SelectionLength = 0;
            mainTextBox.ScrollToCaret();

            mainTextBox.SelectionStart = selectionStart;
            mainTextBox.SelectionLength = selectionLength;
            mainTextBox.ScrollToCaret();
        }

        private void FontFaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                theme.SetFont(fontDialog1.Font);
        }

        private void FontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                theme.SetStyle(fg: colorDialog1.Color);
        }

        private void PageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                theme.SetStyle(bg: colorDialog1.Color);
        }

        private void TrueDarkToolStripMenuItem_Click(object sender, EventArgs e) => SetTheme("#9A9A9A");

        private void DeepSlateToolStripMenuItem_Click(object sender, EventArgs e) => SetTheme("#3D3B3B");

        private void DefaultDarkToolStripMenuItem_Click(object sender, EventArgs e) => SetTheme("#404040");

        private void JazzyAmoledToolStripMenuItem_Click(object sender, EventArgs e) => SetTheme("#000000");

        private void SetTheme(string bg) => theme.SetStyle(fg: Color.White, bg: ColorTranslator.FromHtml(bg));

        public void ClearFile()
        {
            mainTextBox.ClearUndo();
            mainTextBox.Clear();
        }

        public void SetFile(string fileData)
        {
            mainTextBox.ClearUndo();
            mainTextBox.Text = fileData;
            mainTextBox.SelectionStart = 0;
            mainTextBox.SelectionLength = 0;
        }

        public void AnnounceFile(string filePath)
        {
            openFileDialog1.FileName = filePath;
            saveFileDialog1.FileName = filePath;
        }

        private bool DirtyCheckPass(string operation)
        {
            if (file.Dirty)
            {
                DialogResult result = new MessageForm
                {
                    Message = $"{nl}Is it ok to lose the unsaved changes?{nl}{nl}{nl}",
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
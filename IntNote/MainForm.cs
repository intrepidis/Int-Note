using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IntNote
{
    public partial class MainForm : Form
    {
        public MainForm(string name, string version, string filePath)
        {
            InitializeComponent();

            Text = appName = name;

            double fractionOfMaxLengthToOpen = 0.8;
            maximumLengthAllowed = (int)(mainTextBox.MaxLength * fractionOfMaxLengthToOpen);

            searchForm = new SearchForm(Activate, FindNextText, FindPreviousText, ReplaceSelectedText);
            theme = new ThemeManager(() => mainTextBox);
            file = new FileHandler(ClearFile, SetFile, AnnounceFile);

            FileDialogSettings(openFileDialog1);
            FileDialogSettings(saveFileDialog1);

            appVersion = version;
            commandLineFile = filePath;

            void FileDialogSettings(FileDialog d)
                => d.Filter = "Text Files|*.txt|All Files|*.*";
        }

        private static readonly string nl = Environment.NewLine;
        private readonly SearchForm searchForm;
        private readonly ThemeManager theme;
        private readonly FileHandler file;
        private readonly int maximumLengthAllowed;
        private string appName;
        private string appVersion;
        private string commandLineFile;
        private bool titleBarSaysModified;

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (commandLineFile.Length > 0)
            {
                TryOpenFile(commandLineFile);
                commandLineFile = "";
            }

            void TryOpenFile(string filePath)
            {
                if (!string.IsNullOrEmpty(filePath))
                    try
                    {
                        filePath = Environment.ExpandEnvironmentVariables(filePath);
                        filePath = Path.GetFullPath(filePath);
                        if (File.Exists(filePath))
                        {
                            if (OpenFileWithLengthCheck(filePath))
                                return;

                            string? folder = Path.GetDirectoryName(filePath);
                            if (folder != null)
                            {
                                AnnounceFile(folder);
                                return;
                            }
                        }
                    }
                    catch (Exception) { }

                AnnounceFile(Environment.CurrentDirectory);
            }
        }

        private void NewFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ModifiedCheckInteraction("Create New File"))
                return;

            file.NewFile();
        }

        private void OpenFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ModifiedCheckInteraction("Open File"))
                return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                OpenFileWithLengthCheck(openFileDialog1.FileName);
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
            if (!ModifiedCheckInteraction("Exit"))
                return;

            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
            => e.Cancel = !ModifiedCheckInteraction("Exit");

        private void MainTextBox_TextChanged(object sender, EventArgs e)
            => CheckIfModified();

        private async void CheckIfModified()
        {
            string text = mainTextBox.Text;
            bool isModified = await Task.Run(() => !file.DoesHashMatch(text));
            if (isModified != titleBarSaysModified)
            {
                SetTitleBar(openFileDialog1.FileName, isModified);
                Invoke(CheckIfModified);
            }
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
            => ShowAboutBox();

        private void Find_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchForm.txtReplace.Text = "";
            searchForm.txtFind.Text = mainTextBox.SelectedText;

            if (!searchForm.Visible)
                searchForm.Show(this);
            else
                searchForm.Activate();

            searchForm.Invoke(Act);

            void Act()
            {
                searchForm.txtFind.SelectAll();
                searchForm.txtFind.Focus();
            }
        }

        private void Replace_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchForm.txtFind.Text = mainTextBox.SelectedText;
            searchForm.txtReplace.Text = "";

            if (!searchForm.Visible)
                searchForm.Show(this);
            else
                searchForm.Activate();

            searchForm.Invoke(Act);

            void Act()
            {
                searchForm.txtReplace.Focus();
            }
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

            SelectAndScrollTo(selectionStart, selectionLength);
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

        public void FindNextText(string find, bool caseSensitive)
        {
            int start = mainTextBox.SelectionStart + mainTextBox.SelectionLength;
            StringComparison compareType = CompareType(caseSensitive);

            int matchPos = mainTextBox.Text.IndexOf(find, start, compareType);
            if (matchPos == -1 && start > 0)
                matchPos = mainTextBox.Text.IndexOf(find, 0, start, compareType);
            if (matchPos == -1)
            {
                ShowSearchNotFound();
                return;
            }

            SelectAndScrollTo(matchPos, find.Length);
        }

        public void FindPreviousText(string find, bool caseSensitive)
        {
            int start = mainTextBox.SelectionStart;
            int end = mainTextBox.Text.Length;
            int count = end - (mainTextBox.SelectionStart + mainTextBox.SelectionLength);
            StringComparison compareType = CompareType(caseSensitive);

            int matchPos = mainTextBox.Text.LastIndexOf(find, start - 1, compareType);
            if (matchPos == -1 && start > 0)
                matchPos = mainTextBox.Text.LastIndexOf(find, end - 1, count, compareType);
            if (matchPos == -1)
            {
                ShowSearchNotFound();
                return;
            }

            SelectAndScrollTo(matchPos, find.Length);
        }

        public void ReplaceSelectedText(string expectedText, string newText, bool caseSensitive)
        {
            StringComparison compareType = CompareType(caseSensitive);
            if (!string.Equals(mainTextBox.SelectedText, expectedText, compareType))
                return;

            int selectionStart = mainTextBox.SelectionStart;
            mainTextBox.SelectedText = newText;
            mainTextBox.SelectionStart = selectionStart;
            mainTextBox.SelectionLength = newText.Length;
        }

        private StringComparison CompareType(bool caseSensitive)
            => caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

        private void SelectAndScrollTo(int selectionStart, int selectionLength)
        {
            mainTextBox.Select(mainTextBox.Text.Length, 0);
            mainTextBox.ScrollToCaret();

            mainTextBox.Select(BackSome(), 0);
            mainTextBox.ScrollToCaret();

            mainTextBox.Select(selectionStart, selectionLength);

            int BackSome()
            {
                int back = selectionStart;
                for (int i = 0; i < 8; i++)
                {
                    back = mainTextBox.Text.LastIndexOf(nl, back);
                    back -= nl.Length;
                    if (back < 0)
                        return 0;
                }
                return back;
            }
        }

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
            if (new DirectoryInfo(filePath).Exists)
            {
                openFileDialog1.InitialDirectory = filePath;
                saveFileDialog1.InitialDirectory = filePath;
                filePath = "";
            }
            else
            {
                string? folder = Path.GetDirectoryName(filePath);
                if (!string.IsNullOrEmpty(folder))
                {
                    openFileDialog1.InitialDirectory = folder;
                    saveFileDialog1.InitialDirectory = folder;
                }
            }

            SetTitleBar(filePath, isModified: false);

            openFileDialog1.FileName = filePath;
            saveFileDialog1.FileName = filePath;
        }

        private void SetTitleBar(string filePath, bool isModified)
        {
            titleBarSaysModified = isModified;
            string modifiedPrefix = isModified ? "* " : "";
            if (filePath.Length == 0)
            {
                Text = $"{modifiedPrefix}{appName}";
            }
            else
            {
                string fileName = Path.GetFileName(filePath) ?? "";
                string folderPath = Path.GetDirectoryName(filePath) ?? "";
                Text = $"{modifiedPrefix}{fileName} : ({folderPath}) : {appName}";
            }
        }

        private void ShowAboutBox()
            => new MessageForm
            {
                Message = $"{nl}{nl}{nl}{appName}{nl}- Text editor in dark mode -{nl}{nl}v{appVersion}{nl}{nl}{nl}https://github.com/intrepidis/Int-Note{nl}",
                Title = "About",
            }.ShowDialog(this);

        private void ShowSearchNotFound()
            => new MessageForm
            {
                Message = $"{nl}The specified text was not found.{nl}",
                Title = "Find",
            }.ShowDialog(this);

        private bool OpenFileWithLengthCheck(string filePath)
        {
            if (file.ValidateLength(filePath, maximumLengthAllowed))
            {
                file.OpenFile(filePath);
                return true;
            }

            new MessageForm
            {
                Message = $"{nl}File is too large. Maximum file size is {maximumLengthAllowed:###,###,###,##0} bytes.{nl}",
                Title = "Open File",
            }.ShowDialog(this);

            return false;
        }

        private bool ModifiedCheckInteraction(string operation)
        {
            if (!file.DoesHashMatch(mainTextBox.Text))
            {
                DialogResult result = new MessageForm
                {
                    Message = $"{nl}Is it ok to lose the unsaved changes?{nl}",
                    Title = operation,
                    OkayText = "LOSE CHANGES",
                    CancelText = "Stay Open",
                    SwitchButtonLocations = true,
                }.ShowDialog(this);

                if (result != DialogResult.OK)
                    return false;
            }
            return true;
        }
    }
}
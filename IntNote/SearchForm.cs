using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntNote
{
    /// <summary>
    /// The search form.
    /// </summary>
    public partial class SearchForm : Form
    {
        public SearchForm(Action<string, bool> findNextText, Action<string, bool> findPreviousText, Action<string, string, bool> replaceSelectedText)
        {
            InitializeComponent();

            findNext = findNextText;
            findPrevious = findPreviousText;
            replaceSelection = replaceSelectedText;
        }

        private readonly Action<string, bool> findNext;
        private readonly Action<string, bool> findPrevious;
        private readonly Action<string, string, bool> replaceSelection;

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TxtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                findNext(txtFind.Text, chkCase.Checked);
                e.Handled = true;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            findNext(txtFind.Text, chkCase.Checked);
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            findPrevious(txtFind.Text, chkCase.Checked);
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            replaceSelection(txtFind.Text, txtReplace.Text, chkCase.Checked);
        }
    }
}

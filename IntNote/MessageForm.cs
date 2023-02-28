using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntNote
{
    /// <summary>
    /// A custom message box.
    /// </summary>
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
            CancelText = "";
            InhibitEscapeKeyClosing();
        }

        private const int mainFormSurroundHeight = 60;
        private const int mainFormSurroundSide = 12;
        private const int groupBoxSurroundHeight = 26;
        private const int textBoxMinimumWidth = 424;
        private const int textBoxPaddingWidth = 42;
        private const int buttonSurroundWidth = 28;
        private const int buttonMinimumWidth = 66;

        public string Message
        {
            get => txtMessage.Text;
            set => txtMessage.Text = value;
        }

        public string Title
        {
            get => Text;
            set => Text = value;
        }

        public string OkayText
        {
            get => btnOK.Text;
            set => btnOK.Text = value;
        }

        public string CancelText
        {
            get => btnCancel.Text;
            set => btnCancel.Text = value;
        }

        public bool SwitchButtonLocations { get; set; }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            groupBoxMain.SuspendLayout();
            SuspendLayout();

            Graphics g = CreateGraphics();

            Point formMiddle = new Point(
                Location.X + (Size.Width / 2),
                Location.Y + (Size.Height / 2));

            // Adjust the window to accommodate the size of the text.
            SizeF size = g.MeasureString(
                txtMessage.Text + ".", // The dot ensures trailing whitespace is considered.
                txtMessage.Font,
                txtMessage.Width);

            int mainFormSurroundWidth = ClientSize.Width - groupBoxMain.Width;
            int groupBoxSurroundWidth = groupBoxMain.ClientSize.Width - txtMessage.Width;

            int textBoxWidth = (int)size.Width + textBoxPaddingWidth;
            textBoxWidth = textBoxWidth > textBoxMinimumWidth ? textBoxWidth : textBoxMinimumWidth;

            txtMessage.ClientSize = new Size(textBoxWidth, (int)size.Height);

            groupBoxMain.ClientSize = new Size(
                txtMessage.Width + groupBoxSurroundWidth,
                txtMessage.ClientSize.Height + groupBoxSurroundHeight);

            ClientSize = new Size(
                groupBoxMain.Width + mainFormSurroundWidth,
                groupBoxMain.ClientSize.Height + mainFormSurroundHeight);

            // Hide the cancel button if it doesn't have text.
            if (string.IsNullOrEmpty(CancelText))
                btnCancel.Visible = false;

            // Set the location and size of the buttons.
            int buttonBankHeight = ClientSize.Height - groupBoxMain.Height;
            int buttonY = groupBoxMain.Bounds.Bottom + (buttonBankHeight / 2) - (btnOK.Height / 2);

            Button leftButton, rightButton;
            (leftButton, rightButton) = SwitchButtonLocations ? (btnOK, btnCancel) : (btnCancel, btnOK);

            SetButtonSize(rightButton);
            SetButtonSize(leftButton);

            int buttonX = ClientSize.Width - rightButton.Size.Width - mainFormSurroundSide;
            rightButton.Location = new Point(buttonX, buttonY);

            buttonX = rightButton.Bounds.Left - leftButton.Size.Width - mainFormSurroundSide;
            leftButton.Location = new Point(buttonX, buttonY);

            Location = new Point(
                formMiddle.X - (Size.Width / 2),
                formMiddle.Y - (Size.Height / 2));

            groupBoxMain.ResumeLayout(false);
            groupBoxMain.PerformLayout();
            ResumeLayout(false);

            void SetButtonSize(Button button)
            {
                SizeF buttonSize = g.MeasureString(button.Text, button.Font);
                int buttonWidth = (int)buttonSize.Width + buttonSurroundWidth;
                buttonWidth = buttonWidth > buttonMinimumWidth ? buttonWidth : buttonMinimumWidth;
                button.ClientSize = new Size(buttonWidth, button.ClientSize.Height);
            }
        }

        private void InhibitEscapeKeyClosing()
        {
            var button = new Button();
            button.Click += (s, a) => { };
            CancelButton = button;
        }
    }
}

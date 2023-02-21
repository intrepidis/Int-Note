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
            InhibitEscapeKeyClosing();
            CancelText = "";
        }

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
            if (string.IsNullOrEmpty(CancelText))
            {
                // Hide the cancel button.
                btnCancel.Visible = false;
            }

            if (SwitchButtonLocations)
            {
                // Switch the button locations.
                (btnCancel.Location, btnOK.Location) =
                    (btnOK.Location, btnCancel.Location);
            }

            // Adjust the window height to accommodate the size of the text.
            SizeF size = CreateGraphics().MeasureString(
                txtMessage.Text + ".",
                txtMessage.Font,
                txtMessage.Width);

            Height += (int)size.Height - txtMessage.Height + txtMessage.Font.Height;

            // A hack because I can't get DPI awareness working right.
            if (btnOK.Bottom > ClientRectangle.Bottom)
            {
                int x = btnOK.Location.X;
                int y = btnOK.Location.Y + (ClientRectangle.Bottom - btnOK.Bottom);
                btnOK.Location = new Point(x, y);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntNote
{
    internal class ThemeManager
    {
        public ThemeManager(Func<TextBox> getTextBox) => tb = getTextBox;

        private readonly Func<TextBox> tb;

        public void SetStyle(Color? fg = null, Color? bg = null)
        {
            if (fg != null)
                tb().ForeColor = (Color)fg;

            if (bg != null)
                tb().BackColor = (Color)bg;
        }

        public void SetFont(Font font)
        {
            tb().Font = font;
        }
    }
}

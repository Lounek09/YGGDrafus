using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGGDrafus
{
    class ExtendedKeyEventArgs : KeyEventArgs
    {
        public ExtendedKeyEventArgs(Keys keyData) : base(keyData)
        {
        }

        public override string ToString()
        {
            string input = "";

            if (Control)
                input += "Ctrl+";
            if (Shift)
                input += "Shift+";
            if (!String.Equals(KeyCode.ToString(), "ShiftKey", StringComparison.Ordinal) &&
               !String.Equals(KeyCode.ToString(), "Capital", StringComparison.Ordinal) &&
               !String.Equals(KeyCode.ToString(), "ControlKey", StringComparison.Ordinal) &&
               !String.Equals(KeyCode.ToString(), "Menu", StringComparison.Ordinal) &&
               !String.Equals(KeyCode.ToString(), "Apps", StringComparison.Ordinal) &&
               !String.Equals(KeyCode.ToString(), "Return", StringComparison.Ordinal) &&
               !String.Equals(KeyCode.ToString(), "LWin", StringComparison.Ordinal))
                input += KeyCode.ToString();

            if (input.Length > 0 && !String.Equals(input.Substring(input.Length - 1), "+", StringComparison.Ordinal))
                return input;
            else
                return "";
        }
    }
}

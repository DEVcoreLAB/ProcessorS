using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Globals.DbOperations.Validation.ForWindowDirectly
{
    public class RestrictedChars
    {
        public static void Check(object textBoxControl)
        {
            if (textBoxControl is TextBox)
            {
                TextBox sender = textBoxControl as TextBox;
                int caretPosition = sender.CaretIndex;

                if (!char.IsLetter(sender.Text[0]))
                {
                    sender.Text = sender.Text.Remove(0, 1);
                }

                var sb = new StringBuilder();
                foreach (char item in sender.Text)
                {
                    if (char.IsLetterOrDigit(item) || char.IsWhiteSpace(item))
                    {
                        sb.Append(item);
                    }
                }
                sender.Text = sb.ToString();

                sender.CaretIndex = sender.Text.Length;
            }
        }
    }
}

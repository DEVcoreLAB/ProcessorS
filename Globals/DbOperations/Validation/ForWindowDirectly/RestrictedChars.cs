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
                else if (sender.Text.Contains('_'))
                {
                    sender.Text = sender.Text.Replace("_", "");
                }
                sender.CaretIndex = sender.Text.Length;
            }
        }
    }
}

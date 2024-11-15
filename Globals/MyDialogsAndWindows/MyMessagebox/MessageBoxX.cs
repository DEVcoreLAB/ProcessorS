using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.MyDialogsAndWindows.MyMessagebox
{
    public static class MessageBoxX
    {
        public static void Show(string message)
        {
            MyMessageboxX messageBoxBasic = new(message);
            messageBoxBasic.Topmost = true;
            //messageBoxBasic.Owner = window;
            messageBoxBasic.Show();
        }
    }
}

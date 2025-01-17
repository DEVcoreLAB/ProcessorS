using Globals.MyDialogsAndWindows.MyDialogBox.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.MyDialogsAndWindows.MyDialogBox
{
    public static class DialogBoxX
    {
        public static void Show(string message,Action action)
        {
            MyDialogBoxX myDialogBoxX = new MyDialogBoxX(message,action);
            myDialogBoxX.ShowDialog();
        }
    }
}

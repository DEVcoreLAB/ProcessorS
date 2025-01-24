using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowMainWindowContextMenu.ViewModel.Command.ShowHomeControlCommands
{
    public class ClickEvent
    {
        public static event EventHandler Click;

        protected virtual void Run()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}

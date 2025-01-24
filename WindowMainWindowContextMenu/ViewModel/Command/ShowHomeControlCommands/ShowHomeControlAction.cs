using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowMainWindowContextMenu.View;

namespace WindowMainWindowContextMenu.ViewModel.Command.ShowHomeControlCommands
{
    internal class ShowHomeControlAction : ClickEvent
    {
        ClickEvent ClickEventClass;

        public ShowHomeControlAction()
        {
            ClickEventClass = new ClickEvent();
        }

        public void Execute(object? parameter)
        {
            var windwow = parameter as ContextMenuWindow;
            windwow.Hide();
            Run();
        }
    }
}

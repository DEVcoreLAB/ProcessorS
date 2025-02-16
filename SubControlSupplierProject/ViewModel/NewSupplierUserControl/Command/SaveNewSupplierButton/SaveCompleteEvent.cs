using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubControlSupplierProject.ViewModel.NewSupplierUserControl.Command.SaveNewSupplierButton
{
    public class SaveCompleteEvent
    {
        public static event EventHandler<EventArgs> SaveNewSupplierCompleteEvent;

        public void EvetRun()
        {
            SaveNewSupplierCompleteEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}

using Globals.MyControlsSchemas.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.MyControlsSchemas
{
    public class SetCustmControl
    {
        public ISetControl setControl;

        public SetCustmControl(ISetControl setControl)
        {
            this.setControl = setControl;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Model.Observer.Components
{
    public class Connector
    {
        public IBehaviour Behaviour { get; private set; }

        public Connector(IBehaviour behaviour)
        {
            Behaviour = behaviour;
        }
    }
}

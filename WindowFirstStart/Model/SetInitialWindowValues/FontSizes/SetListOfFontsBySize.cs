using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFirstStart.Model.SetInitialWindowValues.FontSizes
{
    internal class SetListOfFontsBySize
    {
        public double[] Set(double bottomLimit)
        {
            return new double[] { bottomLimit, bottomLimit +2, bottomLimit +4, bottomLimit +6};
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Globals.DbOperations.Validation.TextValidation
{
    public class DictionaryKeyValidation
    {
        public (bool,SolidColorBrush) Validate(Dictionary<string,string> dictionary, string text)
        {
            bool isValid = false;
            SolidColorBrush color = new SolidColorBrush(Colors.Red);



            return (isValid, color);
        }
    }
}

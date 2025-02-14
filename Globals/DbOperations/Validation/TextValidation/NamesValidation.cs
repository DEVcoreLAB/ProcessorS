using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Globals.DbOperations.Validation.TextValidation
{
    public class NamesValidation
    {
        bool isNameUnique = true;
        SolidColorBrush color = new SolidColorBrush(Colors.Black);

        public (bool _isNameInique, SolidColorBrush _textColor) Validate(IEnumerable<string> listOfNames, string currentName)
        {
         
            if (!string.IsNullOrEmpty(currentName))
            {
                var restrictedWords = Enum
               .GetValues(typeof(Globals.DbOperations.Validation.ReserverWords.ReservedDbWords))
               .Cast<Globals.DbOperations.Validation.ReserverWords.ReservedDbWords>()
               .Select(x => x.ToString())
               .ToList();

                foreach (var word in restrictedWords)
                {
                    if (word.ToLower().Equals(currentName.ToLower()))
                    {
                        color = new SolidColorBrush(Colors.Red);
                        isNameUnique = false;

                        break;
                    }
                    else
                    {
                        color = new SolidColorBrush(Colors.Black);
                        isNameUnique = true;
                    }
                }

                if (isNameUnique == false)
                {
                    return (isNameUnique, color);
                }

                foreach (var item in listOfNames)
                {

                    if (item.ToLower().Equals(currentName.ToLower()))
                    {
                        color = new SolidColorBrush(Colors.Red);
                        isNameUnique = false;
                        break;
                    }
                    else
                    {
                        color = new SolidColorBrush(Colors.Black);
                        isNameUnique = true;
                    }
                }

            }

                return (isNameUnique, color);
        }
    }
}

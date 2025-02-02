
using Globals.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WindowFirstStart.Model.SetInitialWindowValues.Languages
{
    internal class SetLangsCollection
    {
        public List<ComboboxItemBaseClass> Set()
        {
            return new List<ComboboxItemBaseClass>()
            {
                new ComboboxItemBaseClass { CountryName = "Polska", CountryFlague = BmpInitializer(Uris.PoiishFlague), CultureCode = "pl-PL"} ,
                new ComboboxItemBaseClass { CountryName = "England", CountryFlague = BmpInitializer(Uris.BritainFlague), CultureCode = "en-US"}
            };
        }

        private BitmapImage BmpInitializer(Uri uri)
        {
            BitmapImage tempImage = new BitmapImage();
            tempImage.BeginInit();
            tempImage.UriSource = uri;
            tempImage.EndInit();
            return tempImage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Globals.Graphics
{
    public class SetProperButtonBackground
    {
        public static BitmapImage Set(bool isEnabled, Uri enabled, Uri disabled)
        {
            BitmapImage? tempImage = null;

            if (isEnabled)
            {
                tempImage = new BitmapImage();
                tempImage.BeginInit();
                tempImage.UriSource = enabled;
                tempImage.EndInit();
            }
            else
            {
                tempImage = new BitmapImage();
                tempImage.BeginInit();
                tempImage.UriSource = disabled;
                tempImage.EndInit();
            }
            return tempImage;
        }

        public static BitmapImage SetSimple(Uri uri)
        {
            BitmapImage? tempImage = null;

            tempImage = new BitmapImage();
            tempImage.BeginInit();
            tempImage.UriSource = uri;
            tempImage.EndInit();

            return tempImage;
        }
    }
}

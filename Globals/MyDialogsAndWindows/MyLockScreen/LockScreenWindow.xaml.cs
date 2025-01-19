using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Globals.MyDialogsAndWindows.MyLockScreen
{
    /// <summary>
    /// Interaction logic for LockScreenWindow.xaml
    /// </summary>
    public partial class LockScreenWindow : Window
    {
        public LockScreenWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private SecureString myPass;
        public SecureString MyPass
        {
            get { return myPass; }
            set { myPass = value; }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
           
        }
    }
}

using Globals.Security.PasswordBoxControlHelper;
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
using System.Windows.Media.Effects;
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
            this.Owner = Application.Current.MainWindow;
            Application.Current.MainWindow.IsEnabled = false;
            MyPasswordBox.Focus();

            MyPass = ConvertToSecureString.Convert(ReadFromFileSecuredStringToString.UnprotectString(
                Globals.SettingFiles.PassKey.Default.MyPassKey));

        }

        private SecureString myPass;
        public SecureString MyPass
        {
            get { return myPass; }
            set { myPass = value; }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            string origin = ReadFromFileSecuredStringToString.UnprotectString(
               Globals.SettingFiles.PassKey.Default.MyPassKey);
            string current = MyPasswordBox.Password;

            if (current.SequenceEqual(origin))
            {
                Application.Current.MainWindow.IsEnabled = true;
                this.Hide();
            }
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!this.IsVisible)
            { 
                Application.Current.MainWindow.Effect = new BlurEffect() { Radius = 0 };
            }
        }
    }
}

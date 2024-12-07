
using System;
using System.Collections.Generic;
using System.Linq;
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
using WindowFirstStart.ViewModel;

namespace WindowFirstStart.View
{
    /// <summary>
    /// Interaction logic for FirsStartWindow.xaml
    /// </summary>
    public partial class FirsStartWindow : Window
    {
        MainViewModel mainViewModel; 

        public FirsStartWindow(WindowRegularStart.View.MainWindow.MainWindow mainWindow)
        {
            InitializeComponent();
            mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($@"pass1: {Globals.Security.PasswordBoxControlHelper.ConvertToUnsecureString.Convert(mainViewModel.PasswordBase)}");
                sb.Append("\n");
                sb.Append($@"pass2: {Globals.Security.PasswordBoxControlHelper.ConvertToUnsecureString.Convert(mainViewModel.PasswordConfirm)}");
                sb.Append("\n");

                MessageBox.Show(sb.ToString());
            }
        }
    }
}

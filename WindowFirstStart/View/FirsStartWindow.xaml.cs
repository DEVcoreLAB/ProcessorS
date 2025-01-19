
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

        public FirsStartWindow()
        {
            InitializeComponent();
            mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {

            }
        }

        private void PasswordBaseLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            label.ToolTip = Globals.Security.PasswordBoxControlHelper.ConvertToUnsecureString.Convert(mainViewModel.PasswordBase);
        }

        private void PasswordBaseLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            label.ToolTip = null;
        }

        private void PasswordConfirmLABEL_MouseEnter(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            label.ToolTip = Globals.Security.PasswordBoxControlHelper.ConvertToUnsecureString.Convert(mainViewModel.PasswordConfirm);
        }

        private void PasswordConfirmLABEL_MouseLeave(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            label.ToolTip = null;
        }

        ////////////////////////////////////////////////////////////////////////


        private void connStringTEXTBOX_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            mainViewModel.ControlName = textBox.Name;
        }

        private void connectionStringButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            mainViewModel.ControlName = button.Name;
        }

        private void languageCOMBOBOX_MouseEnter(object sender, MouseEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            mainViewModel.ControlName = comboBox.Name;
        }

        private void passwordBoxBase_MouseEnter(object sender, MouseEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            mainViewModel.ControlName = passwordBox.Name;
        }
    }
}

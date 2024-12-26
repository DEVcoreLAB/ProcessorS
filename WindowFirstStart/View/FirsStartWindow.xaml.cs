
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
                //StringBuilder sb = new StringBuilder();
                //sb.Append($@"pass1: {Globals.Security.PasswordBoxControlHelper.ConvertToUnsecureString.Convert(mainViewModel.PasswordBase)}");
                //sb.Append("\n");
                //sb.Append($@"pass2: {Globals.Security.PasswordBoxControlHelper.ConvertToUnsecureString.Convert(mainViewModel.PasswordConfirm)}");
                //sb.Append("\n");

                //MessageBox.Show(sb.ToString());


                //MessageBox.Show(Globals.Security.PasswordBoxControlHelper.SaveToFileStringToSecuredString.Convert(mainViewModel.PasswordConfirm));

                ////// manual test for encodimg...
                //string unsecureString = ConvertToUnsecureString.Convert(mainViewModel.PasswordConfirm);
                //string coded = SaveToFileStringToSecuredString.ConvertString(unsecureString);
                //string uncodedString = ReadFromFileSecuredStringToString.UnprotectString(coded);
                //SecureString secureString = new SecureString();
                //foreach (var item in uncodedString)
                //{
                //    secureString.AppendChar(item);
                //}
                //string seconduncodedString = ConvertToUnsecureString.Convert(secureString);
                //StringBuilder sb = new StringBuilder();
                //MessageBox.Show(coded);

                MessageBox.Show(mainViewModel.HelpDocument.ToString());
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
    }
}

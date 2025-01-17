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

namespace Globals.MyDialogsAndWindows.MyDialogBox.Basic
{
    /// <summary>
    /// Interaction logic for MyDialogBoxX.xaml
    /// </summary>
    public partial class MyDialogBoxX : Window
    {
        string message;
        Action action;

        public MyDialogBoxX(string message,Action action)
        {
            InitializeComponent();
            this.message = message;
            this.action = action;
            MessageTEXTBOX.Text = message;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void YesBUTTON_Click(object sender, RoutedEventArgs e)
        {
            action.Invoke();
        }

        private void NoBUTTON_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

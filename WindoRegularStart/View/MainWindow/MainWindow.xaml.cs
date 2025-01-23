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
using WindowRegularStart.ViewModel.MainWindowViewModel;

using Globals.SettingFiles;

namespace WindowRegularStart.View.MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainViewModel;
        WindowMainWindowContextMenu.View.ContextMenuWindow contextMenuWindow;

        public MainWindow()
        {
            InitializeComponent();
            mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
            contextMenuWindow = new WindowMainWindowContextMenu.View.ContextMenuWindow(this);


           
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                //Globals.MyDialogsAndWindows.MyMessagebox.MessageBoxX.Show("this is a test message");
            }
            if (e.Key == Key.Escape)
            {
                contextMenuWindow.ShowDialog();
            }          
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Globals.MyDialogsAndWindows.MyLockScreen.LockScreenWindow lockScreenWindow =
               new Globals.MyDialogsAndWindows.MyLockScreen.LockScreenWindow();
            lockScreenWindow.Show();
        }

        private void WizardButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.MainUserControl = new ControlMainWizard.View.WizardMainControl();
        }
    }
}

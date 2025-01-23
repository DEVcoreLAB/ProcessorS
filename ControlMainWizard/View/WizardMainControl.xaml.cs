using ControlMainWizard.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlMainWizard.View
{
    /// <summary>
    /// Interaction logic for WizardMainControl.xaml
    /// </summary>
    public partial class WizardMainControl : UserControl
    {
        MainViewModel mainViewModel;

        public WizardMainControl()
        {
            InitializeComponent();
            mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }
    }
}

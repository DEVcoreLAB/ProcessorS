using SubControlSupplierProject.ViewModel;
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

namespace SubControlSupplierProject.View
{
    /// <summary>
    /// Interaction logic for SupplierControl.xaml
    /// </summary>
    public partial class SupplierControl : UserControl
    {
        MainViewModel mainViewModel;

        public SupplierControl()
        {
            InitializeComponent();
            mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in mainViewModel.ListOfSuppliers)
                {
                    sb.AppendLine(item);
                }
                MessageBox.Show(sb.ToString());
            }

        }
    }
}

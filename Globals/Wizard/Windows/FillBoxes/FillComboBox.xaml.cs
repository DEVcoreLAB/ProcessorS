using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

namespace Globals.Wizard.Windows.FillBoxes
{
    /// <summary>
    /// Interaction logic for FillComboBox.xaml
    /// </summary>
    public partial class FillComboBox : Window
    {
        ObservableCollection<string> refData;

        public FillComboBox(ObservableCollection<string> refData)
        {
            InitializeComponent();
            this.DataContext = this;
            this.refData = refData;
            LocalData = new ObservableCollection<DataGridRow>();
            this.Owner = Application.Current.MainWindow;

            SaveButtonForeground = Globals.Graphics.SetProperButtonBackground.Set
               (
                   true,
                   Globals.Graphics.Uris.SaveSettingsEnabled,
                   Globals.Graphics.Uris.SaveSettingsDisabled
               );
        }

        private BitmapImage saveButtonForegroundar;
        public BitmapImage SaveButtonForeground
        {
            get { return saveButtonForegroundar; }
            set { saveButtonForegroundar = value; }
        }


        private ObservableCollection<DataGridRow> localData;
        public ObservableCollection<DataGridRow> LocalData
        {
            get { return localData; }
            set { localData = value; }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (DataGridRow row in LocalData)
            {
                if (!string.IsNullOrEmpty(row.value))
                {
                    refData.Add(row.value);
                }
            }
            this.Close();
        }
    }

    public class DataGridRow
    {
        public string value { get; set; }
    }
}

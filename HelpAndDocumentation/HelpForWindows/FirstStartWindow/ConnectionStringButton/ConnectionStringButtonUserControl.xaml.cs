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

namespace HelpAndDocumentation.HelpForWindows.FirstStartWindow.ConnectionStringButton
{
    /// <summary>
    /// Interaction logic for ConnectionStringButtonUserControl.xaml
    /// </summary>
    public partial class ConnectionStringButtonUserControl : UserControl
    {
        public ConnectionStringButtonUserControl(double fontSzie)
        {
            InitializeComponent();
            this.DataContext = this;
            ThisFontSize = fontSzie;
            MainDescription = Langs.LangConnectionButton.mainDescription;
        }

        private string mainDescription;
        public string MainDescription
        {
            get { return mainDescription; }
            set { mainDescription = value; }
        }

        private double thisFontSize;
        public double ThisFontSize
        {
            get { return thisFontSize; }
            set { thisFontSize = value; }
        }


    }
}

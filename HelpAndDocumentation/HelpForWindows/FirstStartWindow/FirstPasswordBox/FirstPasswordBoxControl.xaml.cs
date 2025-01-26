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

namespace HelpAndDocumentation.HelpForWindows.FirstStartWindow.FirstPasswordBox
{
    /// <summary>
    /// Interaction logic for FirstPasswordBoxControl.xaml
    /// </summary>
    public partial class FirstPasswordBoxControl : UserControl
    {
        public FirstPasswordBoxControl(double fontSize)
        {
            InitializeComponent();
            this.DataContext = this;
            ThisFontSize = fontSize;
            MainDescription = Langs.LangFirstPasswordBox.mainDescription;
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

using HelpAndDocumentation.ProgramInfo.BasicInfo.Langs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace HelpAndDocumentation.ProgramInfo.BasicInfo
{
    /// <summary>
    /// Interaction logic for BasicInformationAbouProgram.xaml
    /// </summary>
    public partial class BasicInformationAbouProgram : UserControl
    {
        public BasicInformationAbouProgram()
        {
            InitializeComponent();
            this.DataContext = this;


            MainDescription = Lang.mainDescriptioText;
        }
    

        private double fontSize;
        public double FontSize
        {
            get { return fontSize; }
            set 
            { 
                fontSize = value;
            }
        }

        private string mainDescription;
        public string MainDescription
        {
            get { return mainDescription; }
            set { mainDescription = value; }
        }

    }
}

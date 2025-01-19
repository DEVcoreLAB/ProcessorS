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

namespace ControlProgramStart
{
    /// <summary>
    /// Interaction logic for ControlStart.xaml
    /// </summary>
    public partial class ControlStart : UserControl
    {
        public ControlStart()
        {
            InitializeComponent();
            this.DataContext = this;
            SetText();
        }

        private string myTextblockText;
        public string MyTextblockText
        {
            get { return myTextblockText; }
            set { myTextblockText = value; }
        }

        private void SetText()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("xxxxxxx");

            MyTextblockText = sb.ToString();
        }
    }
}

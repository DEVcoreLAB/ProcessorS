﻿using HelpAndDocumentation.ProgramInfo.BasicInfo.Langs;
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
        public BasicInformationAbouProgram(double fontSize)
        {
            InitializeComponent();
            this.DataContext = this;
            ThisFontSize = fontSize;
            MainDescription = Lang.mainDescriptioText;
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

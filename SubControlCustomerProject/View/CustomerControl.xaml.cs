﻿using SubControlCustomerProject.ViewModel;
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

namespace SubControlCustomerProject.View
{
    /// <summary>
    /// Interaction logic for CustomerControl.xaml
    /// </summary>
    public partial class CustomerControl : UserControl
    {
        public CustomerControl()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }
    }
}

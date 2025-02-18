﻿using System;
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

namespace Globals.MyDialogsAndWindows.MyMessagebox
{
    /// <summary>
    /// Interaction logic for MyMessageboxX.xaml
    /// </summary>
    public partial class MyMessageboxX : Window
    {
        public MyMessageboxX(string message)
        {
            InitializeComponent();
            MessageTEXTBOX.Text = message;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void OkBUTTON_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

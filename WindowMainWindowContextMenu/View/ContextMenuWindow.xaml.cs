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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WindowMainWindowContextMenu.ViewModel;

namespace WindowMainWindowContextMenu.View
{
    /// <summary>
    /// Interaction logic for ContextMenuWindow.xaml
    /// </summary>
    public partial class ContextMenuWindow : Window
    {
        Window window;
        MainViewModel MainViewModel { get; }

        public ContextMenuWindow(Window window)
        {
            InitializeComponent();
            this.window = window;

            MainViewModel = new MainViewModel();
            this.DataContext = MainViewModel;
        }


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}

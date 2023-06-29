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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowStoreClone.Pages;

namespace WindowStoreClone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Main MainWindowContentPage;
        public MainWindow()
        {
            InitializeComponent();
            MainWindowContentPage = new Main();
        }

        private void MainFrameWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrameWindow.Content = MainWindowContentPage;
        }
    }
}
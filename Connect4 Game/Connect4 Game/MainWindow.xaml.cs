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

namespace Connect4_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, RoutedEventArgs e)
        {
           var msgbox = MessageBox.Show("Are you sure you want to exit?",
               "Are you sure?" ,MessageBoxButton.YesNoCancel, MessageBoxImage.Error);

            if(msgbox == MessageBoxResult.Yes)
            {
                Application.exit
            }
        }
    }
}

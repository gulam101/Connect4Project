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
using mainGame;
using newGrid;


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
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit?",
               "Are you sure?", MessageBoxButton.YesNoCancel, MessageBoxImage.Error);
            
            if(result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown(); //Shuts down the application
            }
        }

        private void Play_btn_Click(object sender, RoutedEventArgs e)
        {
            // mainGame.MainWindow newForm = new mainGame.MainWindow();
            newGrid.MainWindow newGame = new newGrid.MainWindow();
            newGame.Show();
            this.Close();
        }

        private void Btn_Highscore_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry this feature is not yet avaliable!");
        }
    }
}

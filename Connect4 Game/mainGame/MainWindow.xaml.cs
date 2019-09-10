using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace mainGame
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

        //When false is playerone, when true playertwo

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Player turn
            if (!playerTurn)  //Yellow
            {
                //Player one
                playerTurn = true;
                Counter.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)); //Changes to red when pressed
            }
            else //Red
            {
                //Player two
                playerTurn = false;
                Counter.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 0)); //Changes to yellow when pressed
            }
            
        }

        bool playerTurn = false;
        bool counter = true;

        private void Button_Click_1(object sender, RoutedEventArgs e)
       {
           
        }
    }
}

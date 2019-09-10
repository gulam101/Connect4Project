using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
//using System.Windows.Forms;
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
            Button button = sender as Button; //It takes the sender objected and parsed it into sender object which casts it into a sender object
            //Player turn
            if (!playerTurn)  //Yellow
            {
                //Player one
                button.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)); //Changes to red when pressed
                playerTurn = true;
            }
            else //Red
            {
                //Player two
                button.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 0)); //Changes to yellow when pressed
                playerTurn = false;
            }
            button.Click -= Button_Click; //Removes the event so that it doesn't call this method again
        }

        bool playerTurn = false;
        bool counter = true;

        private void Button_Click_1(object sender, RoutedEventArgs e)
       {
           
        }
    }
}

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

namespace newGrid
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
        bool playerTurn = false;

        public void Button6_Click(object sender, RoutedEventArgs e)
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
            button.Click -= Button6_Click; //Removes the event so that it doesn't call this method again
            {
                //Checks the row
                bool checkBox = false;

                for (int i = 0; i <= 5; i++)
                {

                }

            }
        }
    }
}


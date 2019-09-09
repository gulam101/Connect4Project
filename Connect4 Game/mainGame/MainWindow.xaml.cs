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

        bool playerTurn = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Player turn

            if(!playerTurn)
            {
                //Player one
                
            } else
            {
                //Player two
            }
        }

      private void Button_Click_1(object sender, RoutedEventArgs e)
       {
       }
    }
}

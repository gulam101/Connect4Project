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

namespace GameWIndow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            void Initialize()
            {

                for (int i = 0; i < 9; i++)
                {
                    var b = new Button();
                    int buttonNumber = i + 1;
                    b.Name = "Button" + buttonNumber;
                    b.Content = buttonNumber;
                    b.Click += new RoutedEventHandler(button_click);
                    buttons.Add(b);


                    Grid.SetColumn(b, i % 3);
                    Grid.SetRow(b, i / 3);

                    Grid01.Children.Add(b);
                }


            }
        }
    }
}

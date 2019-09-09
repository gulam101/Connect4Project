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
        private System.Drawing.Rectangle[] boardColumns; //Initalizes a new instance of the rectangle class with the specified location and size
        public MainWindow()
        {
            InitializeComponent();
            this.boardColumns = new System.Drawing.Rectangle[7];
        }

        //Draws the objects onto the screen
        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(System.Drawing.Brushes.Blue, new RectangleF(24, 24, 340, 300));
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0)
                    {
                        this.boardColumns[j] = new System.Drawing.Rectangle(32 + 48 * j, 24, 32, 300);
                    }
                    e.Graphics.FillEllipse(System.Drawing.Brushes.White, 32 + 48 * j, 32 + 48 * i, 32, 32);
                }
            }
        }
    }
}

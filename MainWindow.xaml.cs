/*
 * Ian McTavish
 * March 19, 2018
 * demonstrates how to use method and draw shapes
 */
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

namespace u2Graphics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //Draw the first square
            drawSquare(10,65, 10, 65);
            //draw the second
            drawSquare(65, 65 + 50, 10, 65);
            drawSquare(65, 65 + 50 + 50, 10, 65);
            drawSquare(65, 65 + 50 + 50 + 50, 10, 65);
        }

        //These variable names are confusing - I need to fix this
        private void drawSquare(double leftCorner, double rightCorner, double topCorner, double bottomCorner)
        {
            //draw left line
            myGrid.Children.Add(createLine(leftCorner, leftCorner, topCorner, bottomCorner));//in MainWindow.xaml set x:Name 
            //draw top line
            myGrid.Children.Add(createLine(leftCorner, rightCorner, topCorner, topCorner));
            //draw right line
            myGrid.Children.Add(createLine(rightCorner, rightCorner, topCorner, bottomCorner));
            //draw bottom line
            myGrid.Children.Add(createLine(leftCorner, rightCorner, bottomCorner, bottomCorner));
        }

        //createLine method
        private static Line createLine(double x1, double x2, double y1, double y2)
        {
            Line myLine = new Line();

            myLine.Stroke = System.Windows.Media.Brushes.Black;
            //note I use the parameters to set the x and y values
            myLine.X1 = x1;
            myLine.X2 = x2;
            myLine.Y1 = y1;
            myLine.Y2 = y2;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 4;
            return myLine;//returns a line
        }
    }
}

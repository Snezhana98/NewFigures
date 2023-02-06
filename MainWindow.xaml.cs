using NewFigures.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewFigures
{
    public partial class MainWindow : Window
    {
        MainClassFigures main;

        public MainWindow()
        {
            InitializeComponent();
            main = new MainClassFigures(canvas);
            double a = double.Parse(TextWidth.Text);
            double b = double.Parse(TextHeigth.Text);
        }

        private void OnClickCircle(object sender, RoutedEventArgs e)
        {
            Elements element = new Circle(double.Parse(coordX.Text), double.Parse(coordY.Text));
            main.AddElementInList(element);
        }


        private void OnClickBox(object sender, RoutedEventArgs e)
        {
            Elements element = new Box(double.Parse(coordX.Text), double.Parse(coordY.Text));
            main.AddElementInList(element);
        }



        private void OnClickCoord(object sender, RoutedEventArgs e)
        {
            main.SelectedElement.SetXY(double.Parse(coordX.Text), double.Parse(coordY.Text));
        }



        private void OnClickStar(object sender, RoutedEventArgs e)
        {
            Elements element = new Star(double.Parse(coordX.Text), double.Parse(coordY.Text));
            main.AddElementInList(element);
        }

        private void OnClickPicture(object sender, RoutedEventArgs e)
        {
        }

        private void OnClickLeft(object sender, RoutedEventArgs e)
        {
            main.SelectedElement.MoveFigure(Elements.Move.left, double.Parse(coordX.Text), double.Parse(coordY.Text));
        }

        private void OnClickRight(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickUp(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickDown(object sender, RoutedEventArgs e)
        {

        }


        private void OnClickBefore(object sender, RoutedEventArgs e)
        {
            main.SelectElement(Direct.Prev);
        }

        private void OnClickNext(object sender, RoutedEventArgs e)
        {
            main.SelectElement(Direct.Next);
            
        }

        private void OnClickSizes(object sender, RoutedEventArgs e)
        {
            
            main.SelectedElement.SetSizes(double.Parse(TextWidth.Text), double.Parse(TextHeigth.Text));
        }
    }
}

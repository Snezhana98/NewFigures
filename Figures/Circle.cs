using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Shapes;

namespace NewFigures.Figures
{
    class Circle : Elements
    {
        public Circle(double x, double y)
        {
            SelsectElement = new Ellipse();
        }
    }
}

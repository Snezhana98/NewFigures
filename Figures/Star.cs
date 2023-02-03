using System;
using System.Collections.Generic;
using System.Windows;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;


namespace NewFigures.Figures
{
    class Star : Elements
    {
        public Star(double x, double y) : base(x, y)
        {
            Polygon elem = new Polygon();

            //Point Point1 = new Point(3, 50);
            //Point Point2 = new Point(54, 50);
            //Point Point3 = new Point(70, 2);
            //Point Point4 = new Point(86, 50);
            //Point Point5 = new Point(137, 50);
            //Point Point6 = new Point(96, 79);
            //Point Point7 = new Point(110, 122);
            //Point Point8 = new Point(70, 96);
            //Point Point9 = new Point(30, 122);
            //Point Point10 = new Point(44, 79);
            //Point Point11 = new Point(44, 79);            
            Point Point1 = new Point(1, 16.7);
            Point Point2 = new Point(18, 16.7);
            Point Point3 = new Point(23.3, 0.7);
            Point Point4 = new Point(28.7, 16.7);
            Point Point5 = new Point(45.7, 16.7);
            Point Point6 = new Point(32, 26.3);
            Point Point7 = new Point(36.7, 40.7);
            Point Point8 = new Point(23.3, 32);
            Point Point9 = new Point(10, 40.7);
            Point Point10 = new Point(14.7, 26.3);
            Point Point11 = new Point(14.7, 26.3);

            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);
            myPointCollection.Add(Point5);
            myPointCollection.Add(Point6);
            myPointCollection.Add(Point7);
            myPointCollection.Add(Point8);
            myPointCollection.Add(Point9);
            myPointCollection.Add(Point10);
            myPointCollection.Add(Point11);

            elem.Points = myPointCollection;

            elem.Height = 47;
            elem.Width = 47;
            elem.Fill = Brushes.Blue;
            elem.Stroke = Brushes.Red;
            _element = elem;

        }

        public override void onPaint()
        {
            SetXY(_x, _y);
        }

        public override void SetSelect(Choosen choosen)
        {
            (_element as Polygon).StrokeThickness = choosen == Choosen.Select ? 3 : 0;
        }

        public override void SetSizes(double X, double Y)
        {
            _element.Width = X;
            _element.Height = Y;
        }
    }
}


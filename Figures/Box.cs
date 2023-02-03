using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace NewFigures.Figures
{
    class Box : Elements
    {
        public Box(double x, double y) : base(x, y)
        {
            Rectangle elem = new Rectangle();
            elem.Height = 40;
            elem.Width = 40;
            elem.Fill = Brushes.Yellow;
            elem.Stroke = Brushes.Red;
            _element = elem;

        }

        public override void onPaint()
        {
            SetXY(_x, _y);
        }

        public override void SetSelect(Choosen choosen)
        {
            (_element as Rectangle).StrokeThickness = choosen == Choosen.Select ? 3 : 0;
        }

        public override void SetSizes(double X, double Y)
        {
            _element.Width = X;
            _element.Height = Y;
        }
    }
}

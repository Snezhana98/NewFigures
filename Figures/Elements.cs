using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace NewFigures.Figures
{
    public abstract class Elements
    {
        protected double _x;
        protected double _y;
        protected Move move;
        protected double x, y;
        public enum Move { up, down, right, left };

        protected FrameworkElement _element;
        public Elements(double X, double Y)
        {
            _x = X;
            _y = Y;
        }
        public abstract void SetSelect(Choosen choosen);
        public abstract void onPaint();
        public void SetXY(double X, double Y)
        {
            double x = X - _element.Width / 2;
            double y = Y - _element.Height / 2;
            Canvas.SetLeft(_element, x);
            Canvas.SetTop(_element, y);
        }
        public abstract void SetSizes(double X, double Y);

        public void MoveFigure(Move move, double x, double y)
        {

            switch (move)
            {
                case Move.up:
                    Canvas.SetLeft(_element, y + 30);
                    break;
                case Move.down:
                    Canvas.SetLeft(_element, y - 30);
                    break;
                case Move.left:
                    Canvas.SetLeft(_element, x - 30);
                    break;
                case Move.right:
                    Canvas.SetLeft(_element, x + 30);
                    break;

            }
        }

        public FrameworkElement GetElement()
        {
            return _element;
        }

    }   
    
}

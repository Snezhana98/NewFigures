using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace NewFigures.Figures
{
    class Elements(Canvas canvas):MainClassFigures(canvas)
    {
       ChoosenElement = new Elements();
       public abstract void SetSelect();

       public abstract void inPaint();

       
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace NewFigures.Figures
{
   public enum Direct { Next,Prev};
    public enum Choosen { Select, UnSelect};
    
    public class MainClassFigures
    {
        List<Elements> listElements;
        public Elements SelectedElement;
        Canvas canvas;
        public MainClassFigures(Canvas canvas)
        {
            listElements = new List<Elements>();
            this.canvas = canvas;
        }
        public void AddElementInList(Elements element)
        {
            
            canvas.Children.Add(element.GetElement());
            listElements.Add(element);
            SelectedElement = element;
            element.SetSelect(Choosen.Select);
            element.onPaint();
            int index = listElements.IndexOf(SelectedElement);
            for (int i=0; i < index; i++)
            {
                listElements[i].SetSelect(Choosen.UnSelect);
            }
        }
        public void SelectElement(Direct direct)
        {
            int index =listElements.IndexOf(SelectedElement);
            listElements[index].SetSelect(Choosen.UnSelect);
            if (direct == Direct.Next)
            {
                index++;
                if (index >= listElements.Count)
                {
                    index = 0;
                }
            }
            else
            {
                index--;
                if (index < 0)
                {
                    index = listElements.Count - 1;
                }

            }
            SelectedElement = listElements[index];
            SelectedElement.SetSelect(Choosen.Select);
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Example
{
    internal class Figur
    {
        float width;
        float height;
        float posx;
        float posy;

        public Ellipse Ellipse { get; set; }

        public float Width { get => width; set => width = value; }
        public float Height { get => height; set => height = value; }
        public float Posx { get => posx; set => posx = value; }
        public float Posy { get => posy; set => posy = value; }

        public Figur(int x, int y, int w, int h)
        {
            posx = x;
            posy = y;
            Ellipse = new Ellipse();
            Ellipse.Width = w;
            Ellipse.Height = h;
            Ellipse.Fill = System.Windows.Media.Brushes.Red;
            Canvas.SetTop(Ellipse, y);
            Canvas.SetLeft(Ellipse, x);
        }

        public void Move(int x, int y)
        {
            posx += x;
            posy += y;
            Canvas.SetTop(Ellipse, posy);
            Canvas.SetLeft(Ellipse, posx);
        }
    }
}

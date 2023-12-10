using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace geometric_figures.Figures
{
    class Circle(double radius, Brush fill) : Shape(radius * 2, radius * 2, fill)
    {
        public override void Draw(Canvas canvas)
        {
            System.Windows.Shapes.Ellipse ellipse = new()
            {
                Width = Width,
                Height = Height,
                Fill = Fill
            };
            canvas.Children.Add(ellipse);
        }
    }
}

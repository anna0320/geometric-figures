using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace geometric_figures.Figures
{
    class Rectangle(double width, double height, Brush fill) : Shape(width, height, fill)
    {
        public override void Draw(Canvas canvas)
        {
            System.Windows.Shapes.Rectangle rectangle = new()
            {
                Width = Width,
                Height = Height,
                Fill = Fill
            };
            canvas.Children.Add(rectangle);
        }
    }
}

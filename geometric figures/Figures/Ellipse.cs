using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace geometric_figures.Figures
{
    class Ellipse : Shape
    {
        public Ellipse(double semiMajorAxis, double semiMinorAxis, Brush fill)
            : base(semiMajorAxis * 2, semiMinorAxis * 2, fill)
        {
        }

        public override void Draw(Canvas canvas)
        {
            System.Windows.Shapes.Ellipse ellipse = new System.Windows.Shapes.Ellipse
            {
                Width = Width,
                Height = Height,
                Fill = Fill
            };
            canvas.Children.Add(ellipse);
        }
    }

}

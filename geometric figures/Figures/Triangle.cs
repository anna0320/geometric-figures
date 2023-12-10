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
    class Triangle : Shape
    {
        public Triangle(double side1, double side2, double side3, Brush fill)
            : base(side1 + side2 + side3, CalculateHeight(side1, side2, side3), fill)
        {
        }

        public override void Draw(Canvas canvas)
        {
            Polygon triangle = new()
            {
                Fill = Fill,
                Points = new PointCollection
                {
                    new System.Windows.Point(0, 0),
                    new System.Windows.Point(Width, 0),
                    new System.Windows.Point(Width / 2, Height)
                }
            };
            canvas.Children.Add(triangle);
        }

        private static double CalculateHeight(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return 2 * Math.Sqrt(s * (s - a) * (s - b) * (s - c)) / a;
        }
    }
}

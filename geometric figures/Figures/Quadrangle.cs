using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace geometric_figures.Figures
{
    class Quadrangle : Shape
    {
        private double side1, side2, side3;

        public Quadrangle(double side1, double side2, double side3, Brush fill)
            : base(side1 + side2 + side3, CalculateHeight(side1, side2, side3), fill)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override void Draw(Canvas canvas)
        {
            Polygon quadrangle = new Polygon
            {
                Fill = Fill
            };

            quadrangle.Points.Add(new System.Windows.Point(0, 0));
            quadrangle.Points.Add(new System.Windows.Point(side1, 0));
            quadrangle.Points.Add(new System.Windows.Point(side1, -side3));
            quadrangle.Points.Add(new System.Windows.Point(side1 - side2, -side3));

            canvas.Children.Add(quadrangle);
        }

        private static double CalculateHeight(double a, double b, double c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
    }

}

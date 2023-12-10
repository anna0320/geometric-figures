using geometric_figures.Figures;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace geometric_figures
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly List<string> comboBoxItems = ["Круг", "Эллипс", "Треугольник", "Квадрат", "Четырёхугольник"];
        readonly Circle circle = new(80, Brushes.Blue);
        readonly Rectangle square = new(100, 100, Brushes.Green);
        readonly Triangle triangle = new(70, 80, 60, Brushes.Red);
        readonly Quadrangle quadrangle = new(35 , 60, 70, Brushes.Purple);
        readonly Ellipse ellipse = new(80, 40, Brushes.Orange);
        public MainWindow()
        {
            InitializeComponent();
            comboBox.ItemsSource = comboBoxItems;
        }
        private void DrawShapes()
        {
            switch(comboBox.SelectedItem)
            {
                case "Круг":
                    circle.Draw(canvas);
                    TextSize.Text = $"{circle.Height}";
                    break;
                case "Эллипс":
                    ellipse.Draw(canvas);
                    TextSize.Text = $"{ellipse.Height}, {ellipse.Width}";
                    break;
                case "Треугольник":
                    triangle.Draw(canvas);
                    TextSize.Text = $"{triangle.Height}, {triangle.Width}";
                    break;
                case "Квадрат":
                    square.Draw(canvas);
                    TextSize.Text = $"{square.Height}";
                    break;
                case "Четырёхугольник":
                    quadrangle.Draw(canvas);
                    TextSize.Text = $"{quadrangle.Height}, {quadrangle.Width}";
                    break;
            }    
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            canvas.Children.Clear();
            DrawShapes();
        }
    }

    abstract class Shape
    {
        protected Shape(double width, double height, Brush fill)
        {
            Width = width;
            Height = height;
            Fill = fill;
        }

        public double Width { get; }
        public double Height { get; }
        public Brush Fill { get; }

        public abstract void Draw(Canvas canvas);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba1Fig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            wcanvas = (int) Polotno.Width;
            hcanvas = (int) Polotno.Height;

        }
        Random rand = new Random();
        int wcanvas, hcanvas;

        private void Tri_Click(object sender, RoutedEventArgs e)
        {
            Points p1 = new Points(rand.Next(wcanvas), rand.Next(hcanvas));
            Points p2 = new Points(rand.Next(wcanvas), rand.Next(hcanvas));
            Points p3 = new Points(rand.Next(wcanvas), rand.Next(hcanvas));

            Triangle tree = new Triangle(p1, p2, p3);

            DrawFig(tree.getPoints());
        }

        private void DrawLine(Points a, Points b) 
        {
            Line line = new Line
            {
                StrokeThickness = 2,
                Stroke = Brushes.Blue,
                X1 = a.getX(),
                Y1 = a.getY(),
                X2 = b.getX(),
                Y2 = b.getY()
            };
            Polotno.Children.Add(line);
        }

        private void Chetyre_Click(object sender, RoutedEventArgs e)
        {
            Points p1= new Points(rand.Next(wcanvas-20), rand.Next(hcanvas-20));
            Points p2=new Points(rand.Next(p1.getX(), wcanvas), rand.Next(p1.getY(), hcanvas));

            Rectangle Upryam = new Rectangle( p1, p2 );
            DrawFig(Upryam.getPoints());
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
            Points p1 = new Points(rand.Next(wcanvas - 20), rand.Next(hcanvas - 20));
            int side = rand.Next(wcanvas - p1.getX());
            Square Kvadrat;
            if (side < wcanvas - p1.getX() & side < hcanvas - p1.getY())
            { Kvadrat = new Square(p1, side); }
            else {
                side = rand.Next(hcanvas - p1.getY());
                Kvadrat = new Square(p1, side);
            }
            DrawFig(Kvadrat.getPoints());
            
        }

        private void DrawFig(List<Points> pointz)
        {
            for (int i = 0; i < pointz.Count - 1; i++)
                DrawLine(pointz[i], pointz[i + 1]);
            DrawLine(pointz[pointz.Count - 1], pointz[0]);
        }
    }
}

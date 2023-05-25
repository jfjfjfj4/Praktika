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

namespace план
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GeometryGroup group = new GeometryGroup(); EllipseGeometry ellipse = new EllipseGeometry(); EllipseGeometry ellipse1 = new EllipseGeometry();
        public MainWindow()
        {
            InitializeComponent();

            Path path = new Path();
            path.Stroke = Brushes.White;
            path.StrokeThickness = 2;

            SolidColorBrush solidColor = new SolidColorBrush();
            solidColor.Color = Color.FromArgb(255, 204, 204, 255);
            path.Fill = solidColor;


            ellipse.Center = new Point(100, 20);
            ellipse.RadiusX = 10;
            ellipse.RadiusY = 10;

            


            group.Children.Add(ellipse); 
            path.Data = group;
            qq.Children.Add(path);

        }
        int vl = 0; int a = 100; int v = 20;
        private void Vverx_Click(object sender, RoutedEventArgs e)
        {
          
            v -= 20;

            ellipse.Center = new Point(a, v);
            
        }

        private void Vlevo_Click(object sender, RoutedEventArgs e)
        {
            
a -= 20;
            ellipse.Center = new Point(a, v);
           


          
          
           
        }

        private void Vpravo_Click(object sender, RoutedEventArgs e)
        {
            a += 20;
            ellipse.Center = new Point(a, v);
           
        }

        private void Vniz_Click(object sender, RoutedEventArgs e)
        {
            v += 20;
            
            ellipse.Center = new Point(a, v);
            
        }
    }
}

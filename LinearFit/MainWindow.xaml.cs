using Microsoft.Research.DynamicDataDisplay.DataSources;
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

namespace LinearFit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            const int N = 100;
            Random rand = new Random(23123);
            Point[] points = new Point[N];
            double[] x = new double[N];
            double[] y = new double[N];
            for (int j = 0; j < N; j++)
            {
                x[j] = j * 1E-10;
                y[j] = 1E-10 *(2* j + rand.Next(-20, 20));
                points[j] = new Point(x[j], y[j]);
            }
             //   y[j] = new Point(j, 2*j+rand.Next(-20,20));
            var datasource = new RawDataSource(points);
            v1.Value = points[0].X;
            v2.Value = points[points.Length - 1].X;

            //ObservableDataSource<Point> s = new ObservableDataSource<Point>();
            

            var fit  = MathNet.Numerics.Fit.Line(x,y);
            var intercept = fit.Item1;
            var slope = fit.Item2;
            
            var point1=new Point(v1.Value,GetY(intercept,slope,v1.Value));
            var point2 = new Point(v2.Value,GetY(intercept,slope,v2.Value));
            var fitsource = new RawDataSource(new Point[2] { point1, point2 });
            linearFit.DataSource = fitsource;
            //var fitsource = new RawDataSource();
            // Plot line connecting points. Note that we use only Y coordinate. 
            // X is computed automatically as zero-based index of Y array element
            line.DataSource = datasource;
            //linearFit.DataChanged =  
            // Plot points
            markers.DataSource = datasource;
           
            // Compute errors as random numbers


        }
        private double GetY(double interc,double slope,double x)
        {
            return interc+slope*x;
        }
        

    }



}

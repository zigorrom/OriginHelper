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
using FileObjectProject;
using Parameters;
using Parameters.NamedParameters;
using System.Collections.ObjectModel;

namespace OriginHelperUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var dynList = new ObservableCollection<DynamicDictionary>();
            for (int i = 0; i < 100; i++)
            {
                dynamic file = new DynamicDictionary();
                file.Petro = i.ToString();
                file.Vasya = "ada"+i.ToString();
                dynList.Add(file);
            }
            ParameterDataGrid.DataContext = dynList;
            //ParameterDataGrid.DataContext = file;
            //var dict = new Dictionary<IParameterHeader, int>();
            //dict.Add(new ParameterHeader<Voltage>("V1", "Comment1", null), 0);
            //dict.Add(new ParameterHeader<Current>("C1", "Comment2", null), 1);
            //file = new FileObject(
            //    @"D:\Master\Optimization SiNW FETs\I.Zadorozhniy\Progen\MeasurDataExtended.dat",
            //    new FileReaderConfig(0, 0, 0, 2, 0, ""),
            //     dict
            //    );
            //Binding bind = new Binding();
            //bind.Source = file;
            //bind.Path = new PropertyPath("ParameterColumns");
            //bind.Mode = BindingMode.TwoWay;
            //ParameterDataGrid.SetBinding()
        }
        
    }
}

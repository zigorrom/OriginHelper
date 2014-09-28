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

namespace DataGridTest
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitItems();
            GenerateColumns();
        }

        private void GenerateColumns()
        {
            
            //ParamDataGrid.DataContext = items;
            for (int i = 0; i < items.Count; i++)
            {
                var col = new DataGridTextColumn();
                var bind = new Binding();
                bind.Mode = BindingMode.OneWay;
                bind.Source = items[i];
                col.Binding = bind;
                ParamDataGrid.Columns.Add(col);
            }
                
        }
        private List<List<string>> items;
        private void InitItems()
        {
            items = new List<List<string>>();
            var datForm = "{{col{0};row{1}}}";
                
            for (int i = 0; i < 10; i++)
            {
                var list = new List<string>();
                for (int j = 0; j < 100; j++)
                {
                    list.Add(String.Format(datForm, i, j));
                }
                items.Add(list);
            }
        }
    }
}

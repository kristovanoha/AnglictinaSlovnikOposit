using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace DictionaryOposites
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }


        private DatabasesMainEntities _context = new DatabasesMainEntities();
      
        private void MainForm_Loaded(object sender, RoutedEventArgs e)
        {

            //neco
            _context.TestTable.Load();

            List<TestTable> dd = _context.TestTable.ToList();
            GridTest.ItemsSource = dd;
    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //_context.TestTable.Load();
            TestTable tt = new TestTable();
        //    tt = _context.TestTable.First(i => i.Cislo == 1);
            tt.Popis = tt.Name + tt.Cislo;
            tt.Cislo = 8;
            tt.Name = "pridavek";
            tt.Popis = "jedu";
            _context.TestTable.Add(tt);
          //  _context.TestTable
       //     _context.
        //    _context.SaveChangesAsync();
            _context.SaveChanges();


        }
    }
}

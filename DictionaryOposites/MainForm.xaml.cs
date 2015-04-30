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


        private DictionareOpositesEntities _context = new DictionareOpositesEntities();
      
        private void MainForm_Loaded(object sender, RoutedEventArgs e)
        {

            //neco
            _context.TestTable.Load();

            List<TestTable> dd = _context.TestTable.ToList();
            GridTest.ItemsSource = dd;
    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // pridavek
            var dfo = _context.TestTable.ToList();
            _context.SaveChangesAsync();
            TestTable tt = new TestTable();
            tt.Name = "Jmeno " + _context.TestTable.Count() + 1;
            tt.Popis = "Novy pridavek  " + _context.TestTable.Count() + 1;
            tt.Id = _context.TestTable.Count() + 1;
            tt.Cislo = _context.TestTable.Count() + 1;
            tt = _context.TestTable.Add(tt);


           _context.SaveChanges();

           List<TestTable> dd = _context.TestTable.ToList();
           GridTest.ItemsSource = dd;
        }

        private void MainForm_Closed(object sender, EventArgs e)
        {
            _context.Dispose();
        }
    }
}

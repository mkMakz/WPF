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
using WpfEauipments.DAL.Model;

namespace WpfEquipment.View
{
    /// <summary>
    /// Interaction logic for PageManufacturers.xaml
    /// </summary>
    public partial class PageManufacturers : Page
    {
        private mcs db = new mcs();
        public PageManufacturers()
        {
            InitializeComponent();
            lvManufacturers.ItemsSource = db.TablesManufacturer.
                OrderByDescending(o=>o.intManufacturerID).ToList();
            
        }
    }
}

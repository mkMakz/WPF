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

namespace WpfEquipment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame mf;
        private mcs db = new mcs();
        public MainWindow()
        {
            InitializeComponent();
            mf = MainFrame;
        }

        private void miManufactures_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/PageManufacturers.xaml", UriKind.RelativeOrAbsolute);
        }

        private void miAddManufacture_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/AddManufacture.xaml", UriKind.RelativeOrAbsolute);
        }


        private void miModels(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/PageModels.xaml", UriKind.RelativeOrAbsolute);
        }
    }
    }


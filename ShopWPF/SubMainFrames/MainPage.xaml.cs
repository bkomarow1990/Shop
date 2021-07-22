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

namespace ShopWPF.SubMainFrames
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        ViewModel vm = null;
        public MainPage(ViewModel vm)
        {
            InitializeComponent();
            this.vm = vm;
            //this.ShopsListBox.ItemsSource = (from e in vm.Shops select new { Name = e.Name, e.ParkingArea, e.Adress ,CityName = e.City.Name, CountryName = e.City.Country.Name});
            this.ShopsListBox.ItemsSource = vm.Shops;
            //this.ShopsDataGrid.ItemsSource = (from e in vm.Shops select (e.Name, e.ParkingArea, e.Adress ,e.City.Name, e.City.Country.Name)).ToList();
        }
    }
}

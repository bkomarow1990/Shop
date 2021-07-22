using DAL.Entities;
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
    /// Interaction logic for ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        ViewModel vm;
        public ProductsPage(ViewModel vm, Shop shop)
        {
            InitializeComponent();
            this.vm = vm;
            //var products = (from e in vm.Context.Products where e.Shops.Any(el => el.Id == shop.Id) select new { e.Id, CategoryName = e.Category.Name, e.Name, e.Price, e.Quantity }).ToList();
            var products = (
                    from e in vm.Context.Products where e.Shops.Contains(shop) select e
               ).ToList();
            if (products.Count == 0)
            {
                MessageBox.Show("Null");
                return;
            }
            this.ProductsDataGrid.ItemsSource = products;
        }
    }
}

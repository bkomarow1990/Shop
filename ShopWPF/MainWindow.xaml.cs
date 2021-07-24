using DAL.Entities;
using ShopWPF.SubMainFrames;
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

namespace ShopWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vm = new ViewModel();
        MainPage mainPage;
        public MainWindow()
        {
            InitializeComponent();
            mainPage = new MainPage(vm);
            MainFrame.Content = mainPage;
            this.DataContext = vm;
        }


        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = mainPage;
        }

        private void showProductsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ProductsPage(vm, mainPage.ShopsListBox.SelectedItem as Shop);
        }

        private void showWorkersBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new WorkersPage(vm, mainPage.ShopsListBox.SelectedItem as Shop);
        }
    }
}

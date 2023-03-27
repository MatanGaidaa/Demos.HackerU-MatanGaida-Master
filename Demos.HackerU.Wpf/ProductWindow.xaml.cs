using Demos.HackerU.HomeWork;
using Demos.HackerU.HomeWork.Store;
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
using System.Windows.Shapes;

namespace Demos.HackerU.Wpf
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public int _categoryId = -1;
        public string name;
        public decimal price;
        public bool isInstock;
        public int categoryId;
        bool[] bools = new bool[2] { true, false };
        private IProductsService servProducts;


        public ProductWindow(int categoryId)
        {
            InitializeComponent();
            _categoryId = categoryId;
            servProducts = ProductsService.GetInstance();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            comboInStock.Items.Insert(0, "Select True/False");
            comboInStock.SelectedIndex = 0;
            comboInStock.Items.Insert(1, bools[0]);
            comboInStock.Items.Insert(2, bools[1]);
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            name = txtName.Text;
        }

        private void txtPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pricetxt = txtPrice.Text;

            bool isOk = decimal.TryParse(pricetxt, out decimal priceDecimal);
            if (isOk)
            {
                price = priceDecimal;
            }
            else
            {
                price = 0;
            }

        }

        private void comboInStock_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboInStock.SelectedIndex == 1)
            {
                isInstock = bools[0];
            }
            else if (comboInStock.SelectedIndex == 2)
            {
                isInstock = bools[1];
            }

        }

        private void createProduct_Click(object sender, RoutedEventArgs e)
        {
            servProducts.AddNewProduct(name, price, isInstock, _categoryId);
            Close();


        }


    }
}

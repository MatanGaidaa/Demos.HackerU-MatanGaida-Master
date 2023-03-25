using Demos.HackerU.HomeWork.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for StoreWindow.xaml
    /// </summary>
    public partial class StoreWindow : Window
    {
        private IProductsService servProducts;

        public StoreWindow()
        {
            InitializeComponent();
            servProducts = ProductsService.GetInstance();
        }

        /// <summary>
        /// Once When Window is First loaded with all 
        /// Inner Components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Initialization Of GUI WITH DATA
            InitData();
            InitView();

        }

        private void InitView()
        {
            //Update CONTROLS With DATA

            //Init  ComboBox Categories
            comboCategories.Items.Clear();
            var categories = servProducts.GetSubCategories(4);
            for (int i = 0; i < categories.Count; i++)
            {
                comboCategories.Items.Add(categories[i].Name);
            }
            comboCategories.Items.Insert(0, "--Please Choose Categories--");
            comboCategories.SelectedIndex = 0;
        }

        private void InitData()
        {

            //create top level and sub Categories
            StoreCategory c1 = new StoreCategory("Electronics", 0); //id=1
            StoreCategory c2 = new StoreCategory("Laptops", c1.Id); //id=2
            StoreCategory c3 = new StoreCategory("Gadgets", c1.Id);//id=3

            StoreCategory c4 = new StoreCategory("Toys", 0);//id=4
            StoreCategory c5 = new StoreCategory("Games Nintendo", c4.Id);//id=5
            StoreCategory c6 = new StoreCategory("Cards", c4.Id);//id=6

            this.servProducts.AddNewCategories(new StoreCategory[] { c1, c2, c3, c4, c5, c6 });

            StoreProduct p1 = new StoreProduct(c5.Id, "SUPER MARIO", 200, true);
            StoreProduct p2 = new StoreProduct(c5.Id, "FIFA 2023", 300, false);
            StoreProduct p3 = new StoreProduct(c5.Id, "NBA", 100, true);
            StoreProduct p4 = new StoreProduct(c5.Id, "Mine Sweeper", 100, true);

            StoreProduct p5 = new StoreProduct(c6.Id, "Pockimon Cards X10", 200, true);
            StoreProduct p6 = new StoreProduct(c6.Id, "FIFA Cards", 300, false);

            this.servProducts.AddNewProducts(new StoreProduct[] { p1, p2, p3, p4, p5, p6 });

        }

        private void comboCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (comboCategories.SelectedIndex == 0)
            {
                this.ListBoxProducts.Items.Clear();
                return;
            }

            string categorySelected = comboCategories.SelectedItem.ToString();
            var categories = servProducts.GetSubCategories(4);
            StoreCategory found = categories.Find(c => c.Name == categorySelected);
            if (found != null)
            {
                int idSelected = found.Id;
                List<StoreProduct> listProducts = servProducts.GetProductsCategory(idSelected);
                this.ListBoxProducts.ItemsSource = listProducts;
            }

        }
    }
}

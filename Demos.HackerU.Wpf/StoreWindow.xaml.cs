using Demos.HackerU.HomeWork;
using Demos.HackerU.HomeWork.Inhheritance;
using Demos.HackerU.HomeWork.Store;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
            var categories = servProducts.GetAllTopLevelCategories();
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

            // Laptops
            StoreProduct p1 = new StoreProduct(c2.Id, "MAC BOOK", 4000, true);
            StoreProduct p2 = new StoreProduct(c2.Id, "ASUS ZENBOOK", 5000, false);
            StoreProduct p3 = new StoreProduct(c2.Id, "HP ENVY", 11000, true);
            StoreProduct p4 = new StoreProduct(c2.Id, "Dell Vostro", 3100, true);

            //Gadgets
            StoreProduct p5 = new StoreProduct(c3.Id, "Automatic Bottle Opener", 60, true);
            StoreProduct p6 = new StoreProduct(c3.Id, "Mobile Fan", 450, true);


            // Games Nintendo
            StoreProduct p7 = new StoreProduct(c5.Id, "SUPER MARIO", 200, true);
            StoreProduct p8 = new StoreProduct(c5.Id, "FIFA 2023", 300, false);
            StoreProduct p9 = new StoreProduct(c5.Id, "NBA", 100, true);
            StoreProduct p10 = new StoreProduct(c5.Id, "Mine Sweeper", 100, true);

            //Cards
            StoreProduct p11 = new StoreProduct(c6.Id, "Pockimon Cards X10", 200, true);
            StoreProduct p12 = new StoreProduct(c6.Id, "FIFA Cards", 300, false);



            this.servProducts.AddNewProducts(new StoreProduct[] { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12 });

        }

        private void comboCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int PerentIds = 0;
            List<StoreCategory> categoriesSub;
            switch (comboCategories.SelectedIndex)
            {
                case 0:
                    ListBoxProducts.ItemsSource = null;
                    break;
                case 1:
                    PerentIds = 1;
                    comboCategoriesSub.Items.Clear();
                    categoriesSub = servProducts.GetSubCategories(PerentIds);
                    for (int i = 0; i < categoriesSub.Count; i++)
                    {
                        comboCategoriesSub.Items.Add(categoriesSub[i].Name);
                    }
                    comboCategoriesSub.Items.Insert(0, "--Please Choose Sub Category--");
                    comboCategoriesSub.SelectedIndex = 0;
                    break;

                case 2:
                    PerentIds = 4;
                    comboCategoriesSub.Items.Clear();
                    categoriesSub = servProducts.GetSubCategories(PerentIds);
                    for (int i = 0; i < categoriesSub.Count; i++)
                    {
                        comboCategoriesSub.Items.Add(categoriesSub[i].Name);
                    }
                    comboCategoriesSub.Items.Insert(0, "--Please Choose Sub Category--");
                    comboCategoriesSub.SelectedIndex = 0;
                    break;
            }





        }

        private void comboCategoriesSub_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboCategories.SelectedIndex == 1)
            {
                switch (comboCategoriesSub.SelectedIndex)
                {
                    case 0:
                        ListBoxProducts.ItemsSource = null;
                        break;

                    case 1:
                        ListBoxProducts.ItemsSource = servProducts.GetProductsCategory(2);
                        break;

                    case 2:
                        ListBoxProducts.ItemsSource = servProducts.GetProductsCategory(3);
                        break;

                }
            }
            else if (comboCategories.SelectedIndex == 2)
            {
                switch (comboCategoriesSub.SelectedIndex)
                {
                    case 0:
                        ListBoxProducts.ItemsSource = null;
                        break;

                    case 1:
                        ListBoxProducts.ItemsSource = servProducts.GetProductsCategory(5);
                        break;

                    case 2:
                        ListBoxProducts.ItemsSource = servProducts.GetProductsCategory(6);
                        break;

                }
            }





        }

        private void ListBoxProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object product = ListBoxProducts.SelectedItem;
            var obj = (StoreProduct)product;
            if (ListBoxProducts.SelectedIndex >= 0)
            {
                servProducts.RemoveProduct(obj.Id);
                ListBoxProducts.ItemsSource = servProducts.GetProductsCategory(obj.CategoryId);
            }
            else
            {
                MessageBox.Show("You Must Selecte A Product to Delete");
            }


        }

    }
}

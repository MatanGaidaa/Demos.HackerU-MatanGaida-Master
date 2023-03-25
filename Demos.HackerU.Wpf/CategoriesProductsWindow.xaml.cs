using Demos.HackerU.HomeWork;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
namespace Demos.HackerU.Wpf
{
    /// <summary>
    /// Interaction logic for CategoriesProductsWindow.xaml
    /// </summary>
    public partial class CategoriesProductsWindow : Window
    {


        private List<Category> categoriesList = new List<Category>();
        public List<Category> CategoriesList { get => categoriesList; set => categoriesList = value; }


        public CategoriesProductsWindow(List<Category> categoriesList)
        {
            InitializeComponent();
            this.categoriesList = categoriesList;
        }

        public CategoriesProductsWindow() : this(new List<Category>())
        {
            InitializeComponent();

        }





        private void CategoriesListBox(object sender, SelectionChangedEventArgs e)
        {
            var index = catList.SelectedIndex;
            Category selectedCat = this.categoriesList[index];


            proList.Items.Clear();

            for (int i = 0; i < selectedCat.Products.Count; i++)
            {
                proList.Items.Add(selectedCat.Products[i].GetAsText());
            }


        }

        private void ProductListBox(object sender, SelectionChangedEventArgs e)
        {

        }

        public void FillCategoriesListBox()
        {

            catList.ItemsSource = categoriesList;

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillCategoriesListBox();
        }

        private void SaveToFile_Click(object sender, RoutedEventArgs e)
        {
            string contentToFile = "";
            foreach (Category s in categoriesList)
            {
                contentToFile += s.GetAsText() + Environment.NewLine;
            }

            System.IO.File.WriteAllText("Categories.txt", contentToFile);
        }
    }
}
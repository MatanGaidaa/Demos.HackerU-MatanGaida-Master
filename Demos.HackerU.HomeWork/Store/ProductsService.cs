using Demos.HackerU.HomeWork.Inhheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Store
{
    public class ProductsService : IProductsService
    {
        private readonly List<StoreCategory> _categories;
        private readonly List<StoreProduct> _products;

        private static ProductsService instanceObj = null;

        /// <summary>
        /// private constractor
        /// Can be access only from inside the class 
        /// not allowed from main: MyManager m = new MyManager();
        /// </summary>
        private ProductsService()
        {
            _categories = new List<StoreCategory>();
            _products = new List<StoreProduct>();
        }
        public static IProductsService GetInstance()
        {
            if (instanceObj == null)
            {
                instanceObj = new ProductsService();
            }
            return instanceObj;
        }

        public void AddNewCategory(string categoryName, int categoryParentId)
        {
            StoreCategory storeCategory = new StoreCategory(categoryName, categoryParentId);
            _categories.Add(storeCategory);
        }

        public void AddNewProduct(string name, decimal price, bool isinstock, int categoryId)
        {
            StoreProduct storeProduct = new StoreProduct(categoryId, name, price, isinstock);
            _products.Add(storeProduct);
        }

        public void AddNewProducts(StoreProduct[] products)
        {
            _products.AddRange(products);

        }

        public void AddNewCategories(StoreCategory[] categories)
        {
            _categories.AddRange(categories);
        }

        public StoreProduct FindProductByName(string productname)
        {
            StoreProduct storeProduct = _products.Find(p => p.Name == productname);

            return storeProduct;

        }

        public StoreProduct FindProductById(int productId)
        {
            StoreProduct Product = _products.Find(p => p.Id == productId);


            return Product;
        }

        public List<StoreProduct> GetAllProducts()
        {
            return _products;
        }

        public List<StoreProduct> GetAllProductsByPrice(int lowPrice, int highPrice)
        {
            List<StoreProduct> newProducts = new List<StoreProduct>();

            foreach (StoreProduct storeProduct in _products)
            {
                if (storeProduct.Price >= lowPrice && storeProduct.Price <= highPrice)
                {
                    newProducts.Add(storeProduct);
                }
            }
            return newProducts.OrderBy(product => product.Price).ToList();
        }

        public List<StoreProduct> GetAllProductsByPrice(int inCategoryId, int lowPrice, int highPrice)
        {
            List<StoreProduct> newProducts = new List<StoreProduct>();

            foreach (StoreProduct storeProduct in _products)
            {

                if (storeProduct.Price >= lowPrice && storeProduct.Price <= highPrice && storeProduct.CategoryId == inCategoryId)
                {
                    newProducts.Add(storeProduct);
                }
            }
            return newProducts.OrderBy(product => product.Price).ToList();
        }

        public List<StoreCategory> GetAllTopLevelCategories()
        {


            List<StoreCategory> newCategories = _categories.FindAll(c => c.ParentCatogoryId == 0);


            return newCategories;
        }

        public List<StoreProduct> GetProductsCategory(int categoryId)
        {

            List<StoreProduct> newProducts = _products.FindAll(p => p.CategoryId == categoryId);


            return newProducts;
        }

        public List<StoreCategory> GetSubCategories(int parentCategoryID)
        {
            List<StoreCategory> newCategories = _categories.FindAll(c => c.ParentCatogoryId == parentCategoryID);

            return newCategories;
        }

        public void RemoveAllProductsOfCategory(int categoryId)
        {
            for (int i = _products.Count - 1; i >= 0; i--)
            {
                if (_products[i].CategoryId == categoryId)
                {
                    _products.RemoveAt(i);
                }
            }
        }

        public void RemoveProduct(int productId)
        {
            StoreProduct Product = FindProductById(productId);
            _products.Remove(Product);

        }

        public void SaveAllProductsByCategory(int categoryId)
        {
            StoreCategory s1 = _categories.Find(c => c.Id == categoryId);
            string categoryName = s1.Name;

            List<StoreProduct> newProducts = GetProductsCategory(categoryId);


            string contentToFile = "";
            foreach (StoreProduct p in newProducts)
            {
                contentToFile += p.ToString() + Environment.NewLine;
            }

            System.IO.File.WriteAllText(categoryName + ".txt", contentToFile);
        }

        public void UpdateProduct(int productId, StoreProduct newProductInfo)
        {
            StoreProduct Product = FindProductById(productId);

            int index = _products.IndexOf(Product);

            newProductInfo.Id = productId;

            _products[index] = newProductInfo;
        }


    }
}

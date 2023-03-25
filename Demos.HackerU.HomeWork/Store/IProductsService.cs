using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Store
{
    public interface IProductsService
    {
        void AddNewCategory(string categoryName, int categoryParentId);
        void AddNewProduct(string name, decimal price, bool isinstock, int categoryId);
        void AddNewProducts(StoreProduct[] products);
        void AddNewCategories(StoreCategory[] categories);
        void RemoveProduct(int productId);
        void UpdateProduct(int productId, StoreProduct newProductInfo);
        StoreProduct FindProductById(int productId);
        List<StoreCategory> GetAllTopLevelCategories();
        List<StoreCategory> GetSubCategories(int parentCategoryID);
        List<StoreProduct> GetProductsCategory(int categoryId);
        List<StoreProduct> GetAllProductsByPrice(int lowPrice, int highPrice);
        List<StoreProduct> GetAllProductsByPrice(int inCategoryId, int lowPrice, int highPrice);
        List<StoreProduct> GetAllProducts();
        StoreProduct FindProductByName(string productname);
        void RemoveAllProductsOfCategory(int categoryId);
        void SaveAllProductsByCategory(int categoryId); //file name will be the according to the value of of the Category Name property 	

    }
}

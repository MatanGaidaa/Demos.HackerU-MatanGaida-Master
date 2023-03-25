using Demos.HackerU.HomeWork.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork
{
    public class StoreOOP
    {
        public static void Run()
        {

            //create top level and sub Categories
            StoreCategory s1 = new StoreCategory("Electronics", 0);
            StoreCategory s2 = new StoreCategory("Games", 0);
            StoreCategory s3 = new StoreCategory("Clothes");// the constructor put 0 for parentCategoryId
            StoreCategory s4 = new StoreCategory("SmartPhones", 1);
            StoreCategory s5 = new StoreCategory("Lamps", 1);
            StoreCategory s6 = new StoreCategory("xBox Games", 2);
            StoreCategory s7 = new StoreCategory("PlaySation Games", 2);
            StoreCategory s8 = new StoreCategory("shirt", 3);
            StoreCategory s9 = new StoreCategory("pants", 3);

            //create Producs 
            StoreProduct p1 = new StoreProduct(4, "iPhone 14 pro Max", 5500, true);
            StoreProduct p2 = new StoreProduct(4, "iPhone 13 pro Max", 3500, true);
            StoreProduct p3 = new StoreProduct(4, "iPhone 14 pro", 4000, true);

            StoreProduct p4 = new StoreProduct(5, "Kitchen Lamp", 200, true);
            StoreProduct p5 = new StoreProduct(5, "toylet Lamp", 300, false);
            StoreProduct p6 = new StoreProduct(5, "room Lamp", 100, true);

            var obj = ProductsService.GetInstance();
            obj.AddNewCategory("Cameras", 1);
            obj.AddNewProduct("canon 200s", 4300, true, 10);

            StoreProduct[] products = { p1, p2, p3, p4, p5, p6 };
            obj.AddNewProducts(products);
            StoreCategory[] storeCategories = { s1, s2, s3, s4, s5, s6, s7, s8, s9 };
            obj.AddNewCategories(storeCategories);

            Console.WriteLine("find Product by Name");
            var name = obj.FindProductByName("iPhone 14 pro Max");
            Console.WriteLine(name + "\n");

            Console.WriteLine("get all products");
            var producs1 = obj.GetAllProducts();
            producs1.ForEach(producs => Console.WriteLine(producs));

            Console.WriteLine("");
            Console.WriteLine("sorted products by price");
            var producs2 = obj.GetAllProductsByPrice(100, 300);
            producs2.ForEach(producs => Console.WriteLine(producs));

            Console.WriteLine("");
            Console.WriteLine("sorted products by price depended id");
            var producs3 = obj.GetAllProductsByPrice(4, 100, 6000);
            producs3.ForEach(producs => Console.WriteLine(producs));

            Console.WriteLine("");
            Console.WriteLine("Top level categories");
            var producs4 = obj.GetAllTopLevelCategories();
            producs4.ForEach(producs => Console.WriteLine(producs));

            Console.WriteLine("");
            Console.WriteLine("Product by category");
            var producs5 = obj.GetProductsCategory(4);
            producs5.ForEach(producs => Console.WriteLine(producs));

            Console.WriteLine("");
            Console.WriteLine("sub categories by Parent Catogory Id");
            var producs6 = obj.GetSubCategories(0);
            producs6.ForEach(producs => Console.WriteLine(producs));

            Console.WriteLine("");
            Console.WriteLine("Remove all products by Catogory Id");
            obj.RemoveAllProductsOfCategory(4);
            producs1.ForEach(producs => Console.WriteLine(producs));

            Console.WriteLine("");
            Console.WriteLine("Remove product by Id");
            obj.RemoveProduct(5);
            producs1.ForEach(producs => Console.WriteLine(producs));

            Console.WriteLine("");
            //save to file;
            obj.SaveAllProductsByCategory(5);

            Console.WriteLine("");
            Console.WriteLine("Update Product and id same");
            obj.UpdateProduct(6, p1);
            producs1.ForEach(producs => Console.WriteLine(producs));
        }
    }
}

using Demos.HackerU.HomeWork.HW19_Q2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW19__Q3_Q4
{
    public class HW19_Q3_4
    {
        public static void Run()
        {

            try
            {
                CPDataB db = new CPDataB();

                CategoryHW19 categoryHW19 = new CategoryHW19() { CategoryName = "Electronic", CategoryDescription = "EEEEE" };
                categoryHW19.ProductsList = new List<ProductHW19>()
                {
                    new ProductHW19{ProductName="Laps",ProductDescription="LLLLL"},
                    new ProductHW19{ProductName="Tv",ProductDescription="TTTTT"},
                    new ProductHW19{ProductName="Phones",ProductDescription="PPPPP"}
                };

                ProductHW19 productHW19 = new ProductHW19() { ProductName = "TShirts", ProductDescription = "Go TShirts" };
                productHW19.CategoriesList = new List<CategoryHW19>()
                {
                    new CategoryHW19{CategoryName="Sports" ,CategoryDescription="SSSSSSS"},
                    new CategoryHW19{CategoryName="Fashion" ,CategoryDescription="FFFFFF"},
                    new CategoryHW19{CategoryName="Stores" ,CategoryDescription="SSSSSSS"},

                };

                db.categoryHW19s.Add(categoryHW19);
                db.productHW19s.Add(productHW19);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex);
            }
        }
    }
}

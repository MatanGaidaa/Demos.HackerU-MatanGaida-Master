using Microsoft.VisualBasic;
using Nest;

namespace Demos.HackerU.HomeWork
{
    public class Category
    {

        private int id;
        private string title;
        private List<Product> products = new List<Product>();

        public Category(int id, string title)
        {
            this.id = id;
            Title = title;
        }

        public Category()
        {
            id = 0;
            title = string.Empty;
        }

        public List<Product> Products { get => products; set => products = value; }
        public string Title { get => title; set => title = value; }
        public int Id { get => id; }

        public string GetAsText()
        {

            string innerData = $"id:{id} ,title:{title}\n";

            foreach (Product product in products)
            {
                innerData += product.GetAsText() + "\n";
            }

            return innerData;
        }

        public string GetAsTextShort()
        {

            string innerData = $"id:{id}\ntitle:{title}\n";


            return innerData;
        }

        public void AddProduct(Product newProductToAdd)
        {
            products.Add(newProductToAdd);
        }

        public void AddProducts(Product[] productsToAdd)
        {
            foreach (Product product in productsToAdd)
            {
                products.Add(product);
            }
        }
        public Product GetProductById(int id)
        {
            Product value = products.Find(x => x.Id == id);

            return value;
        }

        public Product GetProductByTitle(string title)
        {
            Product value = products.Find(x => x.Title == title);

            return value;
        }

        public List<Product> FindAllProductsByKeyWord(string keyword)
        {
            List<Product> result = new List<Product>();

            foreach (Product product in products)
            {
                if (product.Keywords.Contains(keyword))
                {
                    result.Add(product);
                }
            }

            return result;
        }

        public void RemoveProductById(int id)
        {
            Product value = products.Find(x => x.Id == id);
            products.Remove(value);
        }

        public void RemoveProductByTitle(string productName)
        {
            Product value = products.Find(x => x.Title == productName);
            products.Remove(value);
        }


        public void DiscountAllProducts(int percent)
        {
            foreach (Product product in products)
            {
                product.Price = product.Discount(percent);
            }
        }

        public void UpdateProductPrice(int productId, double newPrice)
        {
            Product value = products.Find(x => x.Id == productId);

            value.Price = newPrice;
        }

        public override string ToString()
        {
            return $"Id : {Id}  , Title : {Title} ";
        }
    }
}
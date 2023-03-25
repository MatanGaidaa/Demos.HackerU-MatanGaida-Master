namespace Demos.HackerU.HomeWork
{
    public class CategoryOOP
    {

        public static void Run()
        {


            Product p1 = new Product(1, "Gameing things", "all gameing things", 99.9, new List<string>
            {
               "gaming",
               "3d games",
               "microsoft",
               "PlaySation",
               "xBox",
               "Nintendo"
            });
            Product p2 = new Product(2, "Space Collection", "space things", 99.9, new List<string>
            {
                "Saturn V rocket",
                "Hubble Space Telescope",
                "International Space Station",
                "Mars Rover",
                "SpaceX Falcon 9 rocket"
            });

            Product p3 = new Product(3, "sea things", "all sea", 99.9, new List<string>
            {
               "Sharks",
               "Whales",
               "Octopuses",
               "Dolphins",
               "Jellyfish"});
            Product p4 = new Product(4, "Cars Collection", "popular cars", 299.99, new List<string>
            {
                "Ferrari 488 GTB",
                "Lamborghini Aventador",
                "McLaren 720S",
                "Porsche 911 GT3 RS",
                "Bugatti Chiron"
            });

            Product p5 = new Product(5, "Aircraft Collection", "popular aircraft", 499.99, new List<string>
            {
                "Boeing 747",
                "Airbus A380",
                "Cessna 172",
                "F-16 Fighting Falcon",
                "Bell 206 JetRanger"
            });

            Product p6 = new Product(6, "Famous People Collection", "a collection of famous people", 299.99, new List<string>
            {
                "Albert Einstein",
                "Leonardo da Vinci",
                "William Shakespeare",
                "Nelson Mandela",
                "Martin Luther King Jr."
            });

            Product[] p7 = { p2, p3, p4, p5, p6 };





            //Console.WriteLine(p1.GetAsText());
            // Console.WriteLine(p1.GetAsTextShort());

            //char seperate = char.Parse("|");
            //Console.WriteLine(p1.GetAllKeywordsAsTextSeperated(seperate));


            //string[] keywordstoAdd = new string[] { "roei", "matan", "oren" };

            // p1.AddKeywords(keywordstoAdd);


            //int DiscountInPre = 50;
            //double afterDiscount = p1.Discount(DiscountInPre);
            //Console.WriteLine($"the new price after the {DiscountInPre}% Discount : {afterDiscount} ");



            Category c1 = new Category(1, "Main Category");

            c1.AddProduct(p1);

            c1.AddProducts(p7);

            Category c2 = new Category(2, "new Category");

            c2.AddProduct(p1);

            c2.AddProducts(p7);

            List<Category> listof = new List<Category> { c1, c2 };



            //Console.WriteLine(c1.GetAsText());
            // Console.WriteLine(c1.GetAsTextShort());


            // Product p8 = c1.GetProductById(1);// get product by id 
            //Console.WriteLine(p8.GetAsText()); // print


            //Product p9 = c1.GetProductByTitle("Space Collection"); //get product by title
            // Console.WriteLine(p9.GetAsText()); // print it


            // List<Product> list = c1.FindAllProductsByKeyWord("McLaren 720S"); // get the list that returned from findall by keywords
            // print the list
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i].GetAsText());
            //}

            //remove product by id
            //c1.RemoveProductById(1);
            //print all again to show that was removed
            // Console.WriteLine(c1.GetAsText());

            //c1.RemoveProductByTitle("Aircraft Collection");//remove product by title
            //Console.WriteLine(c1.GetAsText());

            // c1.DiscountAllProducts(30);// send 30% dicount for all products
            // Console.WriteLine(c1.GetAsText());

            //c1.UpdateProductPrice(2, 700); // change price for product
            //Console.WriteLine(c1.GetAsText());
        }
    }
}

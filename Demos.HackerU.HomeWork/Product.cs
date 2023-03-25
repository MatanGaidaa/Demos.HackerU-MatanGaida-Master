namespace Demos.HackerU.HomeWork
{
    public class Product
    {
        private int id;
        private string title;
        private string description;
        private double price;
        private List<string> keywords;

        public int Id { get => id; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public List<string> Keywords { get => keywords; set => keywords = value; }

        public Product(int id, string title, string description, double price, List<string> keywords)
        {
            this.id = id;
            Title = title;
            Description = description;
            Price = price;
            Keywords = keywords;

        }

        public Product()
        {
            id = 0;
            title = string.Empty;
            description = string.Empty;
            price = 0;
            keywords = new List<string>();
        }

        /// <summary>
        /// print full ada include keywords
        /// </summary>
        /// <returns></returns>
        public string GetAsText()
        {


            string innerData = $"id:{id}\ntitle:{title}\ndesc:{description}\nPrice:{Price}\n";
            innerData += "Keywords: ";

            foreach (string words in Keywords)
            {

                innerData += words + "\n";
            }
            return innerData;
        }
        /// <summary>
        /// print all text without keywords
        /// </summary>
        /// <returns></returns>
        public string GetAsTextShort()
        {
            Console.WriteLine("\nShort inner Data:");

            string innerData = $"id:{id}\ntitle:{title}\ndesc:{description}\nPrice:{Price}\n";


            return innerData;
        }
        /// <summary>
        /// add for keyword list seperated "|" from user
        /// </summary>
        /// <param name="seperatedChar"></param>
        /// <returns></returns>
        public string GetAllKeywordsAsTextSeperated(char seperatedChar)
        {


            string innerData = "";
            innerData += "Keywords: \n";

            for (int i = 0; i < Keywords.Count; i++)
            {

                if (i == keywords.Count - 1)
                {
                    innerData += keywords[i];
                }
                else
                {
                    innerData += keywords[i] + seperatedChar;
                }

            }
            return innerData;
        }

        /// <summary>
        /// add array string from user to keywords list
        /// </summary>
        /// <param name="keywordstoAdd"></param>
        public void AddKeywords(string[] keywordstoAdd)
        {

            foreach (string keyword in keywordstoAdd)
            {
                if (keyword != null)
                {
                    keywords.Add(keyword);
                }

            }
            Console.WriteLine("_____________________________");
            Keywords.ForEach(Console.WriteLine);

        }
        /// <summary>
        /// calculate the discount for user and return it in %
        /// </summary>
        /// <param name="percentDiscount"></param>
        /// <returns></returns>
        public double Discount(int percentDiscount)
        {
            float x = (float)percentDiscount;
            double convertedPresent = x / 100;
            double discount = Price - (Price * convertedPresent);
            return Math.Round(discount);
        }


    }
}


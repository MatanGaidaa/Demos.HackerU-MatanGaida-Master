namespace Demos.HackerU.HomeWork
{
    public class Hw3
    {
        public static void Run()
        {
            //DrawRectangleBorder();
            //CreateList();
            CountriesNamesManager();
        }
        /// <summary>
        /// 
        /// </summary>
        private static void DrawRectangleBorder()
        {
            Console.WriteLine("Rectangle drawing app\n");
            Console.WriteLine("Height and width must be greater than or equal to 2.\n");
            Console.WriteLine("enter height:");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter width:");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter one sign to draw, for example *");

            if (h < 2 || w < 2)
            {
                DrawRectangleBorder();
            }

            char tav = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Write true or false \n true = solid rectangle \n false = empty rectangle");
            bool isFull = Convert.ToBoolean(Console.ReadLine());

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (i == 0 || i == h - 1 || j == 0 || j == w - 1)
                    {
                        Console.Write(tav);
                    }

                    else if (isFull)
                    {
                        Console.Write(tav);
                    }

                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine($"height: {h} X width: {w}");
            if (isFull)
                Console.WriteLine($"Area =  {h * w}");
            else
                Console.WriteLine($"size = {h * 2 + w * 2}");
        }

        /// <summary>
        /// 
        /// </summary>
        private static void CreateList()
        {

            //List<object> studentsGrades = new List<object>();

            var studentsGrades = new List<object>();
            int grade;
            string names;

            Console.WriteLine("Enter names and grades of students. Enter 'exit' to exit.");
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Enter Name:");
                names = Console.ReadLine();

                if (!string.IsNullOrEmpty(names))
                {
                    if (names.ToLower() != "exit")
                    {
                        Console.WriteLine("Enter Grade:");
                        string number = Console.ReadLine();

                        bool isConvertedOk = int.TryParse(number, out grade);
                        if (isConvertedOk)
                        {
                            if (grade >= 0 && grade <= 100)
                            {
                                studentsGrades.Add(names);
                                studentsGrades.Add(grade);
                            }
                            else
                            {
                                Console.WriteLine("grade must be between 0-100\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine(number + " is not number format");
                        }

                    }
                    else
                    {
                        exit = false;
                        List<int> grads = new List<int>();
                        int bestGrade = 0;
                        string nameOfstudent = "";
                        for (int i = 0; i < studentsGrades.Count - 1; i += 2)
                        {
                            string name = (string)studentsGrades[i];
                            int gar = (int)studentsGrades[i + 1];
                            grads.Add(gar);

                            if (gar > bestGrade)
                            {
                                bestGrade = gar;
                                nameOfstudent = name;
                            }


                            Console.WriteLine($"{name} ----> {gar}");
                        }
                        Console.WriteLine("__________________________________");
                        int avg = grads.Sum() / grads.Count;
                        Console.WriteLine($"the average is : {avg}");
                        Console.WriteLine($"student with best grade : {nameOfstudent} {bestGrade}");


                    }
                }

                else
                {
                    Console.WriteLine("enter Valid name\n");
                }



            }
        }

        private static void CountriesNamesManager()
        {
            List<string> CountriesList = new List<string>() { "israel", "usa", "iiii", "island", "isotopia" };
            bool isContinue = true;
            while (isContinue)
            {
                isContinue = MainMenu(CountriesList);
            }
        }


        public static bool MainMenu(List<string> CountriesList)
        {
            Console.WriteLine("The countries List");
            Console.WriteLine("_________________________");
            foreach (string country in CountriesList)
            {
                Console.WriteLine($"{CountriesList.IndexOf(country)} {country}");
            }

            Console.WriteLine("_________________________");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add new Country ");
            Console.WriteLine("2) Remove country from list");
            Console.WriteLine("3) Find coutry by prefix text");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Operattion1(CountriesList);
                    return true;
                case "2":
                    Operattion2(CountriesList);
                    return true;
                case "3":
                    Operattion3(CountriesList);
                    return false;
                default:
                    return true;
            }
        }

        private static void Operattion1(List<string> CountriesList)
        {
            Console.WriteLine("Enter new Country Name : ");
            string country = Console.ReadLine().ToLower();
            if (CountriesList.Contains(country))
            {
                Console.WriteLine("the country allready exsist");
            }
            else
            {
                CountriesList.Add(country);
            }

        }

        private static void Operattion2(List<string> CountriesList)
        {
            Console.WriteLine("Enter Country to Remove : ");
            string country = Console.ReadLine().ToLower();
            if (CountriesList.Contains(country))
            {
                CountriesList.Remove(country);

            }
            else
            {
                Console.WriteLine("the country Not exsist");
            }

        }

        private static void Operattion3(List<string> CountriesList)
        {
            Console.WriteLine("Enter prefix to find : ");
            string prefix = Console.ReadLine();
            var Countriesfind = CountriesList.Where(x => x.StartsWith(prefix));
            Console.WriteLine($"\nThe countries that start with the letter {prefix} are:");
            Console.WriteLine("_________________________");

            foreach (var country in Countriesfind)
            {
                Console.WriteLine(country);
            }

        }


    }
}




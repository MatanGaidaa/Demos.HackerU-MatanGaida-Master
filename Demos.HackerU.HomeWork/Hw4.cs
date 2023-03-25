namespace Demos.HackerU.HomeWorks
{
    public class Hw4
    {
        public static void Run()
        {
            //#region Q1
            //Console.WriteLine("Enter customer type Start with UpperCase : ");
            //string customertype = Console.ReadLine();

            //Console.WriteLine("Enter product Type : ");
            //double price = double.Parse(Console.ReadLine());

            //object customertypeObj;

            //bool isConvertedOk = Enum.TryParse(
            //    typeof(CustomerType), // type to do convert
            //    customertype,  // string value
            //    out customertypeObj); // Out Object to Assign
            //if (isConvertedOk)
            //{
            //    double newproductPrice = DiscountCalc((CustomerType)customertypeObj, price);
            //    Console.WriteLine($"Old Price: {price}");
            //    Console.WriteLine($"the Price after the Discount : {newproductPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("wrong customer type");
            //}
            //#endregion

            StudentGradesManager();



        }
        #region Q1
        /// <summary>
        /// discount calculation for user
        /// </summary>
        /// <param name="customerType">string from user </param>
        /// <param name="productPrice">variable that sent to func </param>
        /// <returns></returns>
        private static double DiscountCalc(CustomerType customerType, double productPrice)
        {
            double discount = 0;
            switch (customerType)
            {
                case CustomerType.Regular:
                    discount = productPrice - (productPrice * 0.1);
                    return discount;

                case CustomerType.Subscriber:
                    discount = productPrice - (productPrice * 0.25);
                    return discount;

                case CustomerType.Gold:
                    discount = productPrice - (productPrice * 0.35);
                    return discount;

                default:
                    return discount;

            }

        }
        public enum CustomerType
        {
            Regular = 0,
            Subscriber = 1,
            Gold = 2
        }
        #endregion

        #region Q3
        public static void StudentGradesManager()
        {
            List<string> IdsList = new List<string>() { "1234567", "4345345", "2343434" };
            List<string> NamesList = new List<string>() { "Dani Shovevani", "Gabi Gabot", "Uri Buri" };
            List<int> GradesList = new List<int>() { 95, 100, 88 };
            List<StudentType> TypeList = new List<StudentType>() { StudentType.Inner, StudentType.External, StudentType.Inner };

            Console.WriteLine($"IdList\t\tNamesList\t\tGradesList\tTypeList");
            for (int i = 0; i < IdsList.Count; i++)
            {
                Console.WriteLine($"{IdsList[i]}\t\t{NamesList[i]}\t\t{GradesList[i]}\t\t{TypeList[i]}");
            }

            bool isContinue = true;
            while (isContinue)
            {
                isContinue = MainMenu(IdsList, NamesList, GradesList, TypeList);
            }

        }

        public static bool MainMenu(List<string> IdsList, List<string> NamesList, List<int> GradesList, List<StudentType> TypeList)
        {


            Console.WriteLine("_________________________");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add New Student to lists ");
            Console.WriteLine("2) Update Grade for user");
            Console.WriteLine("3) Show All Grades");
            Console.WriteLine("4) Remove Student");
            Console.WriteLine("5) Print User Grade by Name");
            Console.WriteLine("6) Print All Users By student Type");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Operattion1(IdsList, NamesList, GradesList, TypeList);
                    return true;
                case "2":
                    Operattion2(IdsList, NamesList, GradesList, TypeList);
                    return true;
                case "3":
                    Operattion3(IdsList, NamesList, GradesList, TypeList);
                    return false;
                case "4":
                    Operattion4(IdsList, NamesList, GradesList, TypeList);
                    return false;
                case "5":
                    Operattion5(IdsList, NamesList, GradesList, TypeList);
                    return false;
                case "6":
                    Operattion6(IdsList, NamesList, GradesList, TypeList);
                    return false;
                default:
                    return true;
            }
        }



        private static void Operattion1(List<string> IdsList, List<string> NamesList, List<int> GradesList, List<StudentType> TypeList)
        {
            Console.WriteLine("Enter student id : ");
            string id = Console.ReadLine();
            IdsList.Add(id);
            Console.WriteLine("Enter student name : ");
            string name = Console.ReadLine();
            NamesList.Add(name);
            Console.WriteLine("Enter student type : Inner or External ");
            string type = Console.ReadLine().ToLower();
            switch (type)
            {
                case "external":
                    TypeList.Add(StudentType.External);
                    break;
                case "inner":
                    TypeList.Add(StudentType.Inner);
                    break;
                default:
                    Console.WriteLine("Enter student type : Inner or External");
                    break;
            }
            Console.WriteLine("Enter student grade : ");
            int grade = int.Parse(Console.ReadLine());
            GradesList.Add(grade);
            Console.WriteLine($"IdList\t\tNamesList\t\tGradesList\tTypeList");
            for (int i = 0; i < IdsList.Count; i++)
            {
                Console.WriteLine($"{IdsList[i]}\t\t{NamesList[i]}\t\t{GradesList[i]}\t\t{TypeList[i]}");
            }

        }

        private static void Operattion2(List<string> IdsList, List<string> NamesList, List<int> GradesList, List<StudentType> TypeList)
        {
            Console.WriteLine("Enter student id : to update ");
            string id = Console.ReadLine();


            while (!IdsList.Contains(id))
            {
                Console.WriteLine("student id Does not exist! :Enter student id ");
                id = Console.ReadLine();
            }

            Console.WriteLine("Enter grade to update : grade must be between 0-100 ");
            int grade = int.Parse(Console.ReadLine());


            while (grade < 0 || grade > 100)
            {
                Console.WriteLine("grade must be between 0-100 ");
                grade = int.Parse(Console.ReadLine());
            }

            //find the index about id and replace the grade
            int index = IdsList.IndexOf(id);
            GradesList[index] = grade;

            Console.WriteLine($"IdList\t\tNamesList\t\tGradesList\tTypeList");
            for (int i = 0; i < IdsList.Count; i++)
            {
                Console.WriteLine($"{IdsList[i]}\t\t{NamesList[i]}\t\t{GradesList[i]}\t\t{TypeList[i]}");
            }

        }

        private static void Operattion3(List<string> IdsList, List<string> NamesList, List<int> GradesList, List<StudentType> TypeList)
        {
            Console.WriteLine($"IdList\t\tNamesList\t\tGradesList\tTypeList");
            for (int i = 0; i < IdsList.Count; i++)
            {
                Console.WriteLine($"{IdsList[i]}\t\t{NamesList[i]}\t\t{GradesList[i]}\t\t{TypeList[i]}");
            }

        }

        private static void Operattion4(List<string> IdsList, List<string> NamesList, List<int> GradesList, List<StudentType> TypeList)
        {
            Console.WriteLine("Enter student id : to remove ");
            string id = Console.ReadLine();


            while (!IdsList.Contains(id))
            {
                Console.WriteLine("student id Does not exist! :Enter student id ");
                id = Console.ReadLine();
            }

            int index = IdsList.IndexOf(id);
            IdsList.RemoveAt(index);
            NamesList.RemoveAt(index);
            GradesList.RemoveAt(index);
            TypeList.RemoveAt(index);

            Console.WriteLine($"IdList\t\tNamesList\t\tGradesList\tTypeList");
            for (int i = 0; i < IdsList.Count; i++)
            {
                Console.WriteLine($"{IdsList[i]}\t\t{NamesList[i]}\t\t{GradesList[i]}\t\t{TypeList[i]}");
            }
        }

        private static void Operattion5(List<string> IdsList, List<string> NamesList, List<int> GradesList, List<StudentType> TypeList)
        {
            Console.WriteLine("Enter student name : ");
            string name = Console.ReadLine();


            while (!NamesList.Contains(name))
            {
                Console.WriteLine("student name Does not exist! :Enter student name ");
                name = Console.ReadLine();
            }

            int index = NamesList.IndexOf(name);

            Console.WriteLine($"IdList\t\tNamesList\t\tGradesList");
            Console.WriteLine($"{IdsList[index]}\t\t{NamesList[index]}\t\t{GradesList[index]}");

        }

        private static void Operattion6(List<string> IdsList, List<string> NamesList, List<int> GradesList, List<StudentType> TypeList)
        {
            Console.WriteLine("Enter student type : Inner or External ");
            string type = Console.ReadLine().ToLower();
            switch (type)
            {
                case "external":
                    Console.WriteLine($"IdList\t\tNamesList\t\tGradesList\tTypeList");
                    for (int i = 0; i < TypeList.Count; i++)
                    {
                        if (TypeList[i] == StudentType.External)
                        {
                            Console.WriteLine($"{IdsList[i]}\t\t{NamesList[i]}\t\t{GradesList[i]}\t\t{TypeList[i]}");
                        }
                    }
                    break;


                case "inner":
                    Console.WriteLine($"IdList\t\tNamesList\t\tGradesList\tTypeList");
                    for (int i = 0; i < TypeList.Count; i++)
                    {
                        if (TypeList[i] == StudentType.Inner)
                        {
                            Console.WriteLine($"{IdsList[i]}\t\t{NamesList[i]}\t\t{GradesList[i]}\t\t{TypeList[i]}");
                        }
                    }
                    break;

                default:
                    Console.WriteLine($"ther is no type of {type} : Inner or External");
                    break;
            }
        }
        public enum StudentType
        {
            External = 0,
            Inner = 1
        }
        #endregion
    }
}
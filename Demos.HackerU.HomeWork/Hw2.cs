namespace Demos.HackerU.HomeWork
{
    public class Hw2
    {
        public static void Run()
        {

            //Targil 1
            string[] arr = { "Hello", "World", "Roei", "atar", "Hackeru", "HackerUcollge" };
            string longest = Targil1(arr);
            Console.WriteLine("Longest string: " + longest);


            //Targil 2
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //string res = Targil2(numbers);
            //Console.WriteLine(res);

            //Targil 3
            //Calculate();


            // Targil 4

            //int[] numbers2 = { 10, 2, 38, 22, 38, 23, 21 };
            //int distanceAvg = 2;
            //List<int> result = DitanceFromAvg(numbers2, distanceAvg);
            //Console.WriteLine("the result is : " + string.Join(", ", result));

            //Targil 5

            //ListFromUser();

            //Targil 6 

            //List<int> numbersList = new List<int>() { 1, 2, 4, 3, 6, 5, 7, 9, 8 };
            //SortedList(numbersList);

            //Targil 7 
            //ReadIntFromUser();


            //Targil 8 

            //List<string> Allstrings = new List<string>() { "banana", "roei", "atar", "first", "last" };
            //Console.WriteLine("Choose which word to remove from the list :");
            //Allstrings.ForEach(Console.WriteLine);
            //Console.WriteLine("______________________________");
            //string strToRemove = (Console.ReadLine()).ToLower();
            //List<string> rtnStrings = RemoveFromList(Allstrings, strToRemove);
            //Console.WriteLine("______________________________");
            //rtnStrings.ForEach(Console.WriteLine);

            //Targil 9

            //List<decimal> AllNumbers = new List<decimal>() { 10, 23, 40, 31, 62, 45, 57, 49, 58 };
            //List<decimal> rtnlist = DecimalList(AllNumbers);
            //Console.WriteLine("the new list without removed numbers");
            //rtnlist.ForEach(Console.WriteLine);


            //Targil gadShor

            // List<int> lNumbers = GetListFromRowText("1_2_3_XXX_100_34535");
        }

        /// <summary>
        /// Targil1
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static string Targil1(string[] arr)

        {
            string longest = "";

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i].Length > longest.Length)
                {
                    longest = arr[i];
                }

            }

            return longest;

        }

        /// <summary>
        /// Targil2
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static string Targil2(int[] arr)
        {
            string answer = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    answer += arr[i];
                    break;
                }
                answer += $"{arr[i]}_";

            }

            return answer;
        }

        /// <summary>
        /// Targil3
        /// </summary>
        private static void Calculate()
        {
            Console.WriteLine("Enter 2 numbers :");
            Console.WriteLine("Enter the first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select Operator from  ( + | - | * | / )");
            var oper = Console.ReadLine();

            switch (oper)
            {
                case "+":
                    Console.WriteLine($"the result of {num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"the result of {num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"the result of {num1} * {num2} = {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"the result of {num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("select a valid operator!");
                    break;
            }


        }

        /// <summary>
        /// Targil4
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="distanceAvg"></param>
        /// <returns></returns>
        private static List<int> DitanceFromAvg(int[] numbers, int distanceAvg)
        {
            List<int> arrNumbers = new List<int>();
            int avg = numbers.Sum() / numbers.Length;

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i];
                //remove the sign from the number
                if (Math.Abs(numbers[i] - avg) <= distanceAvg)
                {
                    arrNumbers.Add(num);
                }
            }

            arrNumbers.Sort();

            return arrNumbers;
        }

        /// <summary>
        /// Targil5
        /// </summary>
        private static void ListFromUser()
        {
            Console.WriteLine("enter words, to exit type exit");
            Console.WriteLine("______________________________");
            List<string> arrwords = new List<string>();
            string wordInput = "";
            while (wordInput != "exit")
            {
                wordInput = (Console.ReadLine()).ToLower();
                if (wordInput != "exit")
                {
                    if (string.IsNullOrEmpty(wordInput))
                    {
                        Console.WriteLine("you must enter word");
                        Console.WriteLine("______________________________");
                    }
                    else
                    {
                        string word = wordInput.Trim();
                        arrwords.Add(word);
                        Console.WriteLine("______________________________");
                    }

                }
            }
            Console.WriteLine("______________________________");
            for (int i = arrwords.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(arrwords[i].ToUpper());
            }
            Console.WriteLine($"strings in the list : {arrwords.Count}");
        }

        /// <summary>
        /// Targil6
        /// </summary>
        /// <param name="numbers"></param>
        private static void SortedList(List<int> numbers)
        {
            numbers.Sort();
            Console.WriteLine("the sorted list is :");
            numbers.ForEach(Console.WriteLine);
        }

        /// <summary>
        /// Targil7
        /// </summary>
        private static void ReadIntFromUser()
        {
            Console.WriteLine("Enter numbers between 0 and 100, to exit type exit");
            Console.WriteLine("______________________________");
            List<int> arrNumbers = new List<int>();
            string wordInput = "";
            while (wordInput != "exit")
            {
                wordInput = (Console.ReadLine()).ToLower();
                if (wordInput != "exit")
                {
                    if (!string.IsNullOrEmpty(wordInput))
                    {
                        int numChange = int.Parse(wordInput);
                        if (numChange > 0 && numChange < 100)
                        {
                            int num = numChange;
                            arrNumbers.Add(num);
                            Console.WriteLine("______________________________");
                        }
                        else
                        {
                            Console.WriteLine("you must enter number between 0 and 100");
                            Console.WriteLine("______________________________");
                        }
                    }
                    else
                    {
                        Console.WriteLine("you must enter number between 0 and 100");
                        Console.WriteLine("______________________________");
                    }
                }
            }
            Console.WriteLine("______________________________");
            for (int i = 0; i < arrNumbers.Count; i++)
            {
                Console.WriteLine(arrNumbers[i]);
            }
            Console.WriteLine($"numbers in the list : {arrNumbers.Count}");

        }

        /// <summary>
        /// Targil8
        /// </summary>
        /// <param name="Allstrings"></param>
        /// <param name="strToRemove"></param>
        /// <returns></returns>
        private static List<string> RemoveFromList(List<string> Allstrings, string strToRemove)
        {
            Allstrings.Remove(strToRemove);
            return Allstrings;
        }

        /// <summary>
        /// Targil9
        /// </summary>
        /// <param name="AllNumbers"></param>
        /// <returns></returns>
        static List<decimal> DecimalList(List<decimal> AllNumbers)
        {
            decimal avg = AllNumbers.Sum() / AllNumbers.Count;
            List<decimal> result = new List<decimal>();
            for (int i = AllNumbers.Count - 1; i >= 0; i--)
            {
                if (AllNumbers[i] > avg)
                {
                    result.Add(AllNumbers[i]);
                    AllNumbers.RemoveAt(i);
                }
            }
            Console.WriteLine("the list of removed indexs");
            result.ForEach(Console.WriteLine);
            return AllNumbers;
        }


        /// <summary>
        /// 1_xxxx_100
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static List<int> GetListFromRowText(string row)
        {
            List<int> returnNumbers = new List<int>();
            string[] numbers = row.Split("_");//1_2_3
            foreach (string numberText in numbers)
            {
                //int number = int.Parse(numberText);
                int number;
                bool isConvertedOk = int.TryParse(numberText, out number);
                if (isConvertedOk)
                {
                    returnNumbers.Add(number);
                }
            }

            return returnNumbers;

        }

    }
}

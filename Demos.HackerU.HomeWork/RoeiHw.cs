namespace Demos.HackerU.HomeWork
{
    internal class RoeiHw
    {
        public static void Run()
        {
            MethodA();
            string res = MethodB("hello", "world");
            string res2 = MethodC("HELLO", "WORLD");
            Console.WriteLine(res);

            //Console.WriteLine(res2);

            //Hw2.MethodD("Roei", "1234");


            int[] arr = { 80, 60, 50 };
            int avg = MethodE(arr);
            Console.WriteLine($"The average is :{avg}");

            MethodF();
        }

        public static void MethodA()
        {
            string name = "Roei";
            string lastname = "Atar";

            Console.WriteLine($"My First Name is : {name} and my LastName :{lastname}");

        }

        public static string MethodB(string txt1, string txt2)
        {
            string combine = (txt1 + txt2).ToUpper();
            return combine;
        }

        public static string MethodC(string txt1, string txt2)
        {
            string combine = (txt1 + txt2).ToLower();
            return combine;
        }

        public static void MethodD(string userName, string passWord)
        {

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                Console.WriteLine("user name or password empty");
            }
            if (userName == "Roei" && passWord == "1234")
            {
                Console.WriteLine("login sucssefully");
                Console.WriteLine($"Welcome {userName}");
            }
            else
            {
                Console.WriteLine("login faild");
            }

        }

        public static int MethodE(int[] arr)

        {
            int avg = arr.Sum() / arr.Length;

            return avg;
        }
        /// <summary>
        /// Getting a number for the amount of points from the user
        /// Receiving grades themselves and the user
        /// average calculation and printing
        /// </summary>
        public static void MethodF()

        {
            Console.WriteLine("Enter how many grades there are?");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int avg = arr.Sum() / arr.Length;
            Console.WriteLine($"The average is :{avg}");
        }
    }
}

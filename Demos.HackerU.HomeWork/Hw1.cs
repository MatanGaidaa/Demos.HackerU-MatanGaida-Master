namespace Demos.HackerU.HomeWork
{
    public class Hw1
    {
        public static void Run()
        {
            bool res1 = CheckLowerUpperEquals("AabB", "aAbb");
            Console.WriteLine($"Is Equals : {res1}");

            bool res2 = CheckLowerUpperEquals("AabBX", "aAbb");
            Console.WriteLine($"Is Equals : {res2}");


            string email = ToEmail("gshor", "gmail");
            //string email = ToEmail("gshor", "outlook");
            //string email = ToEmail("g_shor", "gmail");
            //string email = ToEmail("g_shor", "");

            if (email.Contains("@"))
            {
                Console.WriteLine($"valid: {email}");
            }
            else
            {
                Console.WriteLine($"not valid: {email}");
            }
        }

        public static bool CheckLowerUpperEquals(string txt1, string txt2)
        {
            bool isValid = false;

            if (txt1.ToLower() == txt2.ToLower())
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }

        public static string ToEmail(string username, string emailtype)
        {
            string message = "";
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(emailtype))
            {
                message += "* One of parameters are empty";
            }

            if (username.Length > 10)
            {
                message += "* username too long";
            }

            if (username.Contains(".") || username.Contains("_"))
            {
                message += "* . or _ are not allowed for username";
            }

            if (message == "")
            {
                message += $"{username}@{emailtype}.com";
            }
            return message;

        }
    }
}
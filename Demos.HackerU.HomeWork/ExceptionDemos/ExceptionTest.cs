using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.ExceptionDemos
{
    public static class ExceptionTest
    {

        public static void WordCount(this string str)
        {

            char[] operators = new char[] { '+', '-', '*', '/' };

            string[] numbers = str.Split(operators, StringSplitOptions.RemoveEmptyEntries);

            if (numbers.Length != 2)
            {
                throw new ArgumentNullException("Invalid expression");

            }

            int num1 = int.Parse(numbers[0].Trim());
            int num2 = int.Parse(numbers[1].Trim());

            char oper = str.FirstOrDefault(c => operators.Contains(c));
            int result;
            switch (oper)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    throw new ArgumentException("Invalid operator");
            }

            Console.WriteLine(result);

        }

        public static void ReadFromFile()
        {
            //Console.WriteLine("Please Enter a file Path:");
            //string fileName = Console.ReadLine();
            var path = "c:/test.txt";
            StreamReader sr = null;
            try
            {
                using (sr = File.OpenText(path))
                {
                    string s = String.Empty;//"";
                    int i = 1;
                    while ((s = sr.ReadLine()) != null)
                    {
                        WordCount(s);

                        i++;
                    }
                }//Dispose The File handle (close and  dispose sr)

            }
            catch (FileNotFoundException ex)
            {
                throw ex;
                //Catch Exception and rethrow new Exception object to caller
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sr != null)
                    sr.Dispose();
            }

        }
    }
}

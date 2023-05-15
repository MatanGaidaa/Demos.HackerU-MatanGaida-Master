using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW_17
{
    public class Threading
    {

        public static string downloadAndSave(string url, string name)
        {
            Console.WriteLine($"Starting Connection....{name}");
            string contents;
            using (var wc = new System.Net.WebClient())
                contents = wc.DownloadString(url);
            Console.WriteLine($"{name} :is runing");
            for (int i = 0; i < 4; i++)
            {
                Task.Delay(700).Wait();
                Console.Write(".");
            }
            Console.WriteLine();
            Console.WriteLine($"Finish Connection..{name}");
            File.WriteAllText(name + ".txt", contents);
            return contents;

        }


        public static void Run()
        {
            Task<string> t1 = Task.Factory.StartNew<string>(() => downloadAndSave("http://www.walla.co.il", "T1"));
            Task<string> t2 = Task.Factory.StartNew<string>(() => downloadAndSave("http://www.google.co.il", "T2"));
            Task<string> t3 = Task.Factory.StartNew<string>(() => downloadAndSave("http://www.youtube.com", "T3"));
            Task<string> t4 = Task.Factory.StartNew<string>(() => downloadAndSave("https://translate.google.com", "T4"));
            Task<string> t5 = Task.Factory.StartNew<string>(() => downloadAndSave("https://www.hackampus.com", "T5"));
            Console.WriteLine($"Finish read:\n{t1.Result.Length}\n{t2.Result.Length}\n{t3.Result.Length}\n{t4.Result.Length}\n{t5.Result.Length}");

        }

        #region MY ASYNC AWAIT
        //public static void Run()
        //{
        //    var task1 = Task.Factory.StartNew(() => downloadAndSave("http://www.microsoft.com", "Task1"));
        //    var task2 = Task.Factory.StartNew(() => downloadAndSave("http://www.microsoft.com", "Task2"));
        //    var task3 = Task.Factory.StartNew(() => downloadAndSave("http://www.microsoft.com", "Task3"));
        //    var task4 = Task.Factory.StartNew(() => downloadAndSave("http://www.microsoft.com", "Task4"));



        //}

        //public static async Task downloadAndSave(string url, string fileName)
        //{

        //    var client = new HttpClient(); // Create a new instance of the HttpClient class
        //    using HttpResponseMessage response = client.GetAsync(url).Result;// Send an HTTP GET request to the specified URL
        //    using HttpContent content = response.Content; // Get the content of the HTTP response
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.Write(fileName + " | ");
        //        Thread.Sleep(1000);
        //    }
        //    var r = await content.ReadAsStringAsync();// Read the content as a string
        //    File.WriteAllTextAsync(fileName + ".txt", r);


        //}
        #endregion
    }
}

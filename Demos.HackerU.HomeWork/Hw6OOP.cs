namespace Demos.HackerU.HomeWork
{
    public class Hw6OOP
    {


        public static void Run()
        {
            //List<string> list = new List<string>() { "hghghg", "hghghh" };

            Course s1 = new Course("Math", "Hadva a", 1, new List<string> { "Roei", "Oren", "Matan", "Itay", "Oz", "Gad" }, CategoryType.Webmaster);

            Console.WriteLine(s1.DisplayCourseInfo());

            Console.WriteLine(s1.DisplayShortCourseInfo());

            Course s2 = new Course();
            s2.Title = "Music";
            s2.Description = "Music is the life";
            s2.Students = new List<string> { "Roei", "Oren", "Matan", "Itay", "Oz", "Gad", "lior" };
            s2.categoryType = CategoryType.Graphics;



            Console.WriteLine(s2.DisplayCourseInfo());

            Console.WriteLine(s2.DisplayShortCourseInfo());
        }







    }


}

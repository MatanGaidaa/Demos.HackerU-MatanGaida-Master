namespace Demos.HackerU.HomeWork
{
    public class RectangleOOP
    {


        public static void Run()
        {


            Rectangle r1 = new Rectangle();
            r1.width = 10;
            r1.height = 10;
            r1.tav = char.Parse("x");
            r1.DisplayInfo();
            r1.Draw(true);
            int Area = r1.GetArea(r1.width, r1.height);
            int Perimeter = r1.GetPerimeter(r1.width, r1.height);
            Console.WriteLine($"\nthe Area is : {Area}");
            Console.WriteLine($"the Perimeter is : {Perimeter}\n");

            Rectangle r2 = new Rectangle() { width = 20, height = 20, tav = char.Parse("*") };
            r2.DisplayInfo();
            r2.Draw(false);
            r2.PrintAll(r2.width, r2.height);

            Rectangle r3 = new Rectangle() { width = 30, height = 10, tav = char.Parse("+") };
            r3.DisplayInfo();
            r3.Draw(false);
            r3.PrintAll(r3.width, r3.height);

            Rectangle r4 = new Rectangle() { width = 30, height = 10, tav = char.Parse("-") };
            r4.DisplayInfo();
            r4.Draw(true);
            r4.PrintAll(r4.width, r4.height);


            Rectangle r5 = new Rectangle();

            Console.WriteLine("Rectangle drawing app\n");
            Console.WriteLine("enter width:");
            int? num1 = r5.ValidateNumber(Console.ReadLine());//create new variable of null or int and sent to ValidateNumber
            Console.WriteLine("enter height:");
            int? num2 = r5.ValidateNumber(Console.ReadLine());

            if (num1.HasValue && num2.HasValue) //chack if it's have value float for num1 and num2
            {
                r5.width = num1.Value;// to get the value of float? need to put num1.Value
                r5.height = num2.Value;
            }
            else

            {
                Console.WriteLine("ERROR NUMBER FORMAT");
            }

            Console.WriteLine("enter one sign to draw, for example *");
            r5.tav = char.Parse(Console.ReadLine());
            Console.WriteLine("Write true or false \n true = solid rectangle \n false = empty rectangle");
            bool isFull = bool.Parse(Console.ReadLine());
            r5.Draw(true);
            r5.PrintAll(r5.width, r5.height);

            Rectangle[] r6 = { r1, r2, new Rectangle { width = 3, height = 3, tav = char.Parse("$") }, r4, r5 };
            foreach (Rectangle r in r6)
            {
                Console.WriteLine(r);
                r.Draw(true);
                r.PrintAll(r.width, r.height);
            }
        }
    }
}

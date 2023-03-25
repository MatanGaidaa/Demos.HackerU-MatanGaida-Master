namespace Demos.HackerU.HomeWork
{
    public class Rectangle

    {
        public int width { get; set; }
        public int height { get; set; }
        public char tav { get; set; }

        public void PrintAll(int width, int height)
        {
            int Area = GetArea(width, height);
            int Perimeter = GetPerimeter(width, height);
            Console.WriteLine($"\nthe Area is : {Area}");
            Console.WriteLine($"the Perimeter is : {Perimeter}\n");
        }

        public int? ValidateNumber(string textNumber)
        {
            int? parse = null;

            bool isValid = int.TryParse(textNumber, out int numberValue);
            if (isValid)
            {
                parse = numberValue;
            }
            return parse;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"this is a Rectangle:\nwidth:{width},\nheight:{height} \ntav:{tav}\n");
        }

        public int GetArea(int height, int width)
        {
            int Area = height * width;

            return Area;
        }

        public int GetPerimeter(int height, int width)
        {
            int Perimeter = (height + width) * 2;

            return Perimeter;
        }

        public void Draw(bool isFull)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
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


        }
    }
}
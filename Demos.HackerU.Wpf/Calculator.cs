using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.Wpf
{
    public class Calculator
    {
       //Part 1 - Data 
        public float num1;
        public float num2;

        //Part 2 - Method 
        public float  Calculate(Operation operation)
        {
            float result = 0;
            switch (operation)
            {
                case Operation.Plus:
                    {
                        result = num1 + num2;
                        break;
                    }
                case Operation.Minus:
                    {
                        result = num1 - num2;
                        break;
                    }
                case Operation.Multiply:
                    {
                        result = num1 * num2;
                        break;

                    }
                case Operation.Divide:
                    {
                        result = num1 / num2;
                        break;
                    }

            }
            return result;
        }


    }
}

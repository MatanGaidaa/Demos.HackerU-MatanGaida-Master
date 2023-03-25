using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Inhheritance
{
    public class Customer : Person
    {
        public string ShippingAddress;

        public Customer() : base()
        {
            ShippingAddress = "No Shipping Address";
        }

        public Customer(string shippingAddress, string address, int age, string city, string name) : base(address, name, age, city)
        {
            ShippingAddress = shippingAddress;
        }

        public new void DisplayInfoToConsole()
        {
            base.DisplayInfoToConsole();
            Console.WriteLine($"Customer:\nShippingAddress :{ShippingAddress}\n");

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW19_Q2
{
    public class CategoryEmployee
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public int ManagerId { get; set; }
        public ManagerEmployee Manager { get; set; }
    }
}

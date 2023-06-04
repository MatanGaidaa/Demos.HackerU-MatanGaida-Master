using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW19__Q3_Q4
{
    public class CategoryHW19
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public int Id { get; set; }

        public List<ProductHW19> ProductsList { get; set; }
    }
}

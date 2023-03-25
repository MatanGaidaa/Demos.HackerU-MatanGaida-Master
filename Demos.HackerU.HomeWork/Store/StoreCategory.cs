using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Store
{
    public class StoreCategory
    {
        private static int idCounter = 0;
        public int Id { get; }
        public string Name { get; set; }
        public int ParentCatogoryId { get; set; }

        public StoreCategory(string name, int parentcategoryId)
        {

            Name = name;
            ParentCatogoryId = parentcategoryId;
            idCounter++;
            Id = idCounter;

        }

        public StoreCategory(string name) : this(name, 0) { } // set parentcategoryId = 0 

        public StoreCategory() : this("No Name", 0) { } // set parentcategoryId = 0 

        public override string ToString()
        {
            return $"StoreCategory ID: {Id}, Name: {Name}, Parent Category ID: {ParentCatogoryId}";
        }
    }
}


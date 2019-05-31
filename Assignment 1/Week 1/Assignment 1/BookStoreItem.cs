using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    abstract class BookStoreItem
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public int NumberOfItems { get; set; }

        public BookStoreItem(string Title,float Price , int NumberOfitems)
        {
            this.Title = Title;
            this.Price = Price;
            this.NumberOfItems = NumberOfItems;
        }

        public virtual void Print()
        {
            Console.WriteLine("Nothing to print");
        }
    }
}

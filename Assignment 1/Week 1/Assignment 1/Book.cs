using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Book : BookStoreItem
    {
        private string Author;

        public Book(string Title, float Price, int NumberOfItems,string Author) : base(Title,Price,NumberOfItems)
        {
            this.Author = Author;
        }

        public override void Print()
        {
            Console.WriteLine("[Book] {0} - {1}, {2:0.00} {3}x",Author,Title,Price,NumberOfItems);
        }
    }

    
}

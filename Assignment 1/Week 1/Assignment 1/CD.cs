using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class CD : BookStoreItem
    {
        private string Artist;


        public CD(string Title, float Price, int NumberOfItems, string Artist) : base(Title, Price, NumberOfItems)
        {
            this.Artist = Artist;
        }
        public override void Print()
        {
            Console.WriteLine("[CD] {0} - {1}, {2:0.00} {3}x", Title, Artist, Price, NumberOfItems);
        }
    }
}

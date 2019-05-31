using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Magazine : BookStoreItem
    {
        private DayOfWeek day;


        public Magazine(string Title, float Price, int NumberOfItems, DayOfWeek day) : base(Title, Price, NumberOfItems)
        {
            this.day = day;
        }

        public override void Print()
        {
            Console.WriteLine("[Magazine] {0} - {1}, {2:0.00} {3}x", Title, day,Price, NumberOfItems);
        }
    }
}

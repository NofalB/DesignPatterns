﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            BookStore bs = new BookStore();
            Book b1 = new Book("Dracula", 15.00f, 5, "Bram Stoker");
            Book b2 = new Book("Joe speedboat", 12.50f, 3, "Tommy Wieringa");
            Magazine m1 = new Magazine("Time",3.90f,10,DayOfWeek.Friday);
            Magazine m2 = new Magazine("Donald Duck", 2.50f, 15, DayOfWeek.Thursday);
            CD c1 = new CD("The Cure",3.90f,5,"Seventeen Seconds");
            bs.Add(b1);
            bs.Add(b2);
            bs.Add(m1);
            bs.Add(m2);
            bs.Add(c1);
            bs.PrintAllItems();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BookStore
    {
        private List<BookStoreItem> bookstoreitemlist;
        BookStoreItem b;
        

        public BookStore()
        {
            bookstoreitemlist = new List<BookStoreItem>();
        }

        public void Add(BookStoreItem b)
        {
            bookstoreitemlist.Add(b);
        }

        public void PrintAllItems()
        {
            foreach(BookStoreItem b in bookstoreitemlist)
            {
                b.Print();
            }
        }
    }
}

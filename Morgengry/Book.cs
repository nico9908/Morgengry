using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class Book
    {
        string itemid;
        string title;
        double price;
        public Book(string itemid)
        {
            this.itemid = itemid;
        }
        public Book(string itemid, string title)
        {
            this.itemid = itemid;
            this.title = title;
        }
        public Book(string itemid, string title, double price)
        {
            this.itemid = itemid;
            this.title = title;
            this.price = price;
            ToString();
        }
    }
}


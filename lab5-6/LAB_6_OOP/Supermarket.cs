using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6_OOP
{
    abstract class Supermarket
    {
        public string title;
        public string address;
        public Manager manager = new Manager();
        public Сasher casher = new Сasher();
        public SortedDictionary<string, Product_info> items = new SortedDictionary<string, Product_info>();
        public Supermarket(string title, string address)
        {
            this.title = title;
            this.address = address;
        }
    }
}

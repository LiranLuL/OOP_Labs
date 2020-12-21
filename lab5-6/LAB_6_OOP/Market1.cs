using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6_OOP
{
    class Market1 : Supermarket
    {
        public Market1():base("Магнит", "ул.Пушкина")
        {}
        public Market1(string title, string address) : base(title, address)
        { }
    }
}

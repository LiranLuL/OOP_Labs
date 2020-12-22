using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6_OOP
{
    struct Product_info
    {
        public int price;
        public int how;
        public int how_remain;
        public Product_info(int price, int how, int how_remain)
        {
            this.price = price;
            this.how = how;
            this.how_remain = how_remain;
        }
    }
}

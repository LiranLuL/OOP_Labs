using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6_OOP
{
    class Manager
    {
        public void Fill_in_products(Supermarket market)
        {
            List<string> keys=new List<string>();
            foreach (string keyValue in market.items.Keys)
            {
                keys.Add(keyValue);
            }
            for(int i=0;i< market.items.Count();i++)
            {
                Product_info temp = new Product_info(market.items[keys[i]].price, market.items[keys[i]].how, market.items[keys[i]].how);
                market.items[keys[i]] = temp;
            }
        }
    }
}

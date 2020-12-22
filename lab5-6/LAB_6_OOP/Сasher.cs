using System.Collections.Generic;
using System.Windows.Forms;

namespace LAB_6_OOP
{
    partial class Сasher
    {
        public void Buy_item(Supermarket market, string product_title, string buy_count)
        {
            int count = market.items[product_title].how_remain;
            if (count < int.Parse(buy_count))
            {
                MessageBox.Show("В магазине недостаточно товара, попробуйте ещё раз");
            }
            else
            {
                var prod = Create_product(market.items, product_title, buy_count, count - int.Parse(buy_count));
                market.items[key: product_title] = prod;
            }
        }

        private Product_info Create_product(SortedDictionary<string, Product_info> items, string product_title, string buy_count, int how_remain)
        {
            var product = new Product_info(
                       items[product_title].price,
                       items[product_title].how,
                       how_remain
                       );
            return product;
        }
    }
}
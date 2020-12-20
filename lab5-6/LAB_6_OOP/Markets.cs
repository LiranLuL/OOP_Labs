using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

namespace LAB_6_OOP
{
    public partial class Markets : Form
    {
        bool flag = false;
        private Start_form form1;
        string path1;
        string path2;
        public Markets(string ft, string fa, string st, string sa ,string path1,string path2,Start_form form)
        {
            form1 = form;
            market1 = new Market1(ft, fa);
            market2 = new Market2(st, sa);
            InitializeComponent();
            street_label1.Text = ft;
            street_label_1.Text = fa;
            second_title.Text = st;
            street_label2.Text = sa;
            this.path1 = path1;
            this.path2 = path2;
        }

        private void Update_list(ListBox list,Supermarket market)
        {
            list.Items.Clear();
            foreach (KeyValuePair<string, Product_info> keyValue in market.items)
            {
                list.Items.Add(keyValue.Key + "   " + keyValue.Value.how);
            }
        }
        

private void end_prog_button_MouseEnter(object sender, EventArgs e)
        {
            end_prog_button.BackColor = Color.Red;
            end_prog_button.ForeColor = Color.Black;
        }

        private void end_prog_button_MouseLeave(object sender, EventArgs e)
        {
            end_prog_button.BackColor = SystemColors.ButtonFace;
            end_prog_button.ForeColor = Color.Red;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (flag)
            {
                if (int.Parse(shop_revenue_1.Text) >= int.Parse(shop_revenue_2.Text))
                {
                    MessageBox.Show("На этот раз первый магазин заработал больше!");
                }
                else
                {
                    MessageBox.Show("На этот раз второй магазин заработал больше!");
                }
            }
            form1.Close();
            this.Close();
        }

        private void Buy_item(Supermarket market,TextBox product_title,TextBox buy_count, ListBox product_list,Label shop_revenue)
        {
            if (flag)
            {
                int count = market.items[product_title.Text].how_remain;
                if (count < int.Parse(buy_count.Text))
                {
                    MessageBox.Show("В магазине недостаточно товара, попробуйте ещё раз");
                }
                else
                {
                    Update_revenue(product_title, shop_revenue, market, buy_count);

                    var prod = Create_product(market, product_title, buy_count, count - int.Parse(buy_count.Text));

                    market.items[key: product_title.Text] = prod;
                    Replace_by_index(product_title.Text, prod, product_list, product_title);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                product_title_1.Text = product_title_1.Text.ToLower();
                if (market1.items.ContainsKey(product_title_1.Text.ToLower()))
                {
                    int count = market1.items[product_title_1.Text.ToLower()].how_remain;
                    if (count < int.Parse(buy_count_1.Text))
                    {
                        MessageBox.Show("В магазине недостаточно товара, попробуйте ещё раз");
                    }
                    else
                    {
                        Buy_item(market1, product_title_1, buy_count_1, product_list_1, shop_revenue_1);
                    }
                }
                else
                {
                    MessageBox.Show("Данный магазин не имеет такого товара, попробуйте заново");
                }
            }
            else
            {
                MessageBox.Show("Вы не считали товары из файла, нажмите на кнопку");
            }
        }

        private void buy_button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                product_title_2.Text = product_title_2.Text.ToLower();
                if (market2.items.ContainsKey(product_title_2.Text))
                {
                    int count = market2.items[product_title_2.Text].how_remain;
                    if (count < int.Parse(buy_count_2.Text))
                    {
                        MessageBox.Show("В магазине недостаточно товара, попробуйте ещё раз");
                    }
                    else
                    {
                        Buy_item(market2, product_title_2, buy_count_2, product_list_2, shop_revenue_2);
                    }
                }
                else
                {
                    MessageBox.Show("Данный магазин не имеет такого товара, попробуйте заново");
                }
            }
            else
            {
                MessageBox.Show("Вы не считали товары из файла, нажмите на кнопку");
            }
        }

        private Product_info Create_product(Supermarket market, TextBox product_title, TextBox buy_count, int how_remain)
        {
            var product = new Product_info(
                       market.items[product_title.Text].price,
                       market.items[product_title.Text].how,
                       how_remain
                       );
            return product;
        }

        private void Update_revenue(TextBox product_title,Label label,Supermarket market,TextBox buy_count)
        {
            int temp = int.Parse(label.Text);
            temp += int.Parse(buy_count.Text) * market.items[product_title.Text].price;
            label.Text = temp.ToString();
        }

        private void Replace_by_index(string index, Product_info prod,ListBox product_list,TextBox product_title)
        {
            int i = product_list.FindString(index);
            product_list.Items.RemoveAt(i);
            product_list.Items.Insert(i, product_title.Text + "   " + prod.how_remain);
        }

        private void Read_file_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                try
                {
                    Parser parser = new Parser();
                    parser.Parse_file(market1, path1);
                    parser.Parse_file(market2, path2);
                    flag = true;
                    Update_list(product_list_1, market1);
                    Update_list(product_list_2, market2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                    MessageBox.Show("В дириктории отсутсвует файл");
                    this.Close();
                    form1.Close();
                }
            }
        }


        private void call_manager1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                market1.manager.Fill_in_products(market1);
                Update_list(product_list_1, market1);
            }
            else
            {
                MessageBox.Show("Вы не считали товары из файла, нажмите на кнопку");
            }
        }

        private void call_manager2_buton_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                market2.manager.Fill_in_products(market2);
                Update_list(product_list_2, market2);
            }
            else
            {
                MessageBox.Show("Вы не считали товары из файла, нажмите на кнопку");
            }
        }
        private void Markets_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Markets_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void first_title_Click(object sender, EventArgs e)
        {

        }

        private void second_title_Click(object sender, EventArgs e)
        {

        }
    }
}

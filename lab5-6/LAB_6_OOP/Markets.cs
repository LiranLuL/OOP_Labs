using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LAB_6_OOP
{
    public partial class Markets : Form
    {
        bool flag = false;
        private Start_form form1;
        string path1;
        string path2;
        public Markets(string ft, string fa, string st, string sa, string path1, string path2, Start_form form)
        {
            try
            {
                market1 = Markets_factory.Create_market(ft, fa, 1);
                market2 = Markets_factory.Create_market(st, sa, 2);
                form1 = form;
                InitializeComponent();
                first_title.Text = market1.title;
                first_street_label.Text = market1.address;
                second_title.Text = market2.title;
                second_street_label.Text = market2.address;
                this.path1 = path1;
                this.path2 = path2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }


        private void Update_list(ListBox list, Supermarket market)
        {
            list.Items.Clear();
            foreach (KeyValuePair<string, Product_info> keyValue in market.items)
            {
                list.Items.Add(keyValue.Key + "   " + keyValue.Value.how_remain);
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

        private void Replace_by_index(string index, int how_remain, ListBox product_list, string product_title)
        {
            int i = product_list.FindString(index);
            product_list.Items.RemoveAt(i);
            product_list.Items.Insert(i, product_title + "   " + how_remain);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                product_title_1.Text = product_title_1.Text.ToLower();
                if (market1.items.ContainsKey(product_title_1.Text))
                {
                    int count = market1.items[product_title_1.Text].how_remain;
                    if (count < int.Parse(buy_count_1.Text))
                    {
                        MessageBox.Show("В магазине недостаточно товара, попробуйте ещё раз");
                    }
                    else
                    {
                        market1.casher.Buy_item(market1, product_title_1.Text, buy_count_1.Text);
                        Replace_by_index(product_title_1.Text, market1.items[product_title_1.Text].how_remain, product_list_1, product_title_1.Text);
                        Update_revenue(shop_revenue_1, int.Parse(buy_count_1.Text), market1.items[product_title_1.Text].price);
                        Update_list(product_list_1, market1);
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
                        market2.casher.Buy_item(market2, product_title_2.Text, buy_count_2.Text);
                        Replace_by_index(product_title_2.Text, market2.items[product_title_2.Text].how_remain, product_list_2, product_title_2.Text);
                        Update_revenue(shop_revenue_2, int.Parse(buy_count_2.Text), market2.items[product_title_2.Text].price);
                        Update_list(product_list_2, market2);
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



        private void Update_revenue(Label label, int buy_count, int price)
        {
            int temp = int.Parse(label.Text);
            temp += buy_count * price;
            label.Text = temp.ToString();
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
                    Application.Exit();
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

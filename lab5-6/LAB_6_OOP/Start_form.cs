using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_6_OOP
{
    public partial class Start_form : Form
    {
        public Start_form()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Markets newForm = new Markets(first_title.Text, first_address.Text, 
                second_title.Text, second_address.Text, 
                path1.Text,
                path2.Text,
                this);
            newForm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void second_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

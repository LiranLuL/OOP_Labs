using System.Windows.Forms;

namespace LAB_6_OOP
{
    partial class Markets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            Application.Exit();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Markets));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.shop_revenue_1 = new System.Windows.Forms.Label();
            this.buy_button1 = new System.Windows.Forms.Button();
            this.shop_revenue_2 = new System.Windows.Forms.Label();
            this.product_list_1 = new System.Windows.Forms.ListBox();
            this.product_list_2 = new System.Windows.Forms.ListBox();
            this.read_file_button = new System.Windows.Forms.Button();
            this.product_title_1 = new System.Windows.Forms.TextBox();
            this.product_title_2 = new System.Windows.Forms.TextBox();
            this.buy_count_1 = new System.Windows.Forms.TextBox();
            this.buy_count_2 = new System.Windows.Forms.TextBox();
            this.buy_button2 = new System.Windows.Forms.Button();
            this.call_manager1_button = new System.Windows.Forms.Button();
            this.call_manager2_buton = new System.Windows.Forms.Button();
            this.first_label = new System.Windows.Forms.Label();
            this.second_label = new System.Windows.Forms.Label();
            this.end_prog_button = new System.Windows.Forms.Button();
            this.street_label1 = new System.Windows.Forms.Label();
            this.second_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.street_label_1 = new System.Windows.Forms.Label();
            this.street_label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LAB_6_OOP.Properties.Resources.Store;
            this.pictureBox2.InitialImage = global::LAB_6_OOP.Properties.Resources.Store;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LAB_6_OOP.Properties.Resources.Store;
            this.pictureBox3.InitialImage = global::LAB_6_OOP.Properties.Resources.Store;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // shop_revenue_1
            // 
            resources.ApplyResources(this.shop_revenue_1, "shop_revenue_1");
            this.shop_revenue_1.Name = "shop_revenue_1";
            this.shop_revenue_1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buy_button1
            // 
            resources.ApplyResources(this.buy_button1, "buy_button1");
            this.buy_button1.Name = "buy_button1";
            this.buy_button1.Tag = "buy_button1";
            this.buy_button1.UseVisualStyleBackColor = true;
            this.buy_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shop_revenue_2
            // 
            resources.ApplyResources(this.shop_revenue_2, "shop_revenue_2");
            this.shop_revenue_2.Name = "shop_revenue_2";
            this.shop_revenue_2.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // product_list_1
            // 
            this.product_list_1.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.product_list_1, "product_list_1");
            this.product_list_1.FormattingEnabled = true;
            this.product_list_1.Name = "product_list_1";
            this.product_list_1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // product_list_2
            // 
            this.product_list_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.product_list_2, "product_list_2");
            this.product_list_2.FormattingEnabled = true;
            this.product_list_2.Name = "product_list_2";
            // 
            // read_file_button
            // 
            resources.ApplyResources(this.read_file_button, "read_file_button");
            this.read_file_button.ForeColor = System.Drawing.Color.Green;
            this.read_file_button.Name = "read_file_button";
            this.read_file_button.Tag = "";
            this.read_file_button.UseVisualStyleBackColor = true;
            this.read_file_button.Click += new System.EventHandler(this.Read_file_Click);
            // 
            // product_title_1
            // 
            resources.ApplyResources(this.product_title_1, "product_title_1");
            this.product_title_1.Name = "product_title_1";
            this.product_title_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // product_title_2
            // 
            resources.ApplyResources(this.product_title_2, "product_title_2");
            this.product_title_2.Name = "product_title_2";
            // 
            // buy_count_1
            // 
            resources.ApplyResources(this.buy_count_1, "buy_count_1");
            this.buy_count_1.Name = "buy_count_1";
            // 
            // buy_count_2
            // 
            resources.ApplyResources(this.buy_count_2, "buy_count_2");
            this.buy_count_2.Name = "buy_count_2";
            // 
            // buy_button2
            // 
            resources.ApplyResources(this.buy_button2, "buy_button2");
            this.buy_button2.Name = "buy_button2";
            this.buy_button2.UseVisualStyleBackColor = true;
            this.buy_button2.Click += new System.EventHandler(this.buy_button2_Click);
            // 
            // call_manager1_button
            // 
            resources.ApplyResources(this.call_manager1_button, "call_manager1_button");
            this.call_manager1_button.Name = "call_manager1_button";
            this.call_manager1_button.UseVisualStyleBackColor = true;
            this.call_manager1_button.Click += new System.EventHandler(this.call_manager1_Click);
            // 
            // call_manager2_buton
            // 
            resources.ApplyResources(this.call_manager2_buton, "call_manager2_buton");
            this.call_manager2_buton.Name = "call_manager2_buton";
            this.call_manager2_buton.UseVisualStyleBackColor = true;
            this.call_manager2_buton.Click += new System.EventHandler(this.call_manager2_buton_Click);
            // 
            // first_label
            // 
            resources.ApplyResources(this.first_label, "first_label");
            this.first_label.Name = "first_label";
            this.first_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // second_label
            // 
            resources.ApplyResources(this.second_label, "second_label");
            this.second_label.Name = "second_label";
            // 
            // end_prog_button
            // 
            resources.ApplyResources(this.end_prog_button, "end_prog_button");
            this.end_prog_button.ForeColor = System.Drawing.Color.Red;
            this.end_prog_button.Name = "end_prog_button";
            this.end_prog_button.Tag = "end_prog_button";
            this.end_prog_button.UseVisualStyleBackColor = true;
            this.end_prog_button.Click += new System.EventHandler(this.button3_Click_1);
            this.end_prog_button.MouseLeave += new System.EventHandler(this.end_prog_button_MouseLeave);
            this.end_prog_button.MouseHover += new System.EventHandler(this.end_prog_button_MouseEnter);
            // 
            // street_label1
            // 
            this.street_label1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.street_label1, "street_label1");
            this.street_label1.Name = "street_label1";
            this.street_label1.Click += new System.EventHandler(this.first_title_Click);
            // 
            // second_title
            // 
            this.second_title.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.second_title, "second_title");
            this.second_title.Name = "second_title";
            this.second_title.Click += new System.EventHandler(this.second_title_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // street_label_1
            // 
            this.street_label_1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.street_label_1, "street_label_1");
            this.street_label_1.Name = "street_label_1";
            // 
            // street_label2
            // 
            this.street_label2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.street_label2, "street_label2");
            this.street_label2.Name = "street_label2";
            // 
            // Markets
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.street_label2);
            this.Controls.Add(this.street_label_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.second_title);
            this.Controls.Add(this.street_label1);
            this.Controls.Add(this.end_prog_button);
            this.Controls.Add(this.second_label);
            this.Controls.Add(this.first_label);
            this.Controls.Add(this.call_manager2_buton);
            this.Controls.Add(this.call_manager1_button);
            this.Controls.Add(this.buy_button2);
            this.Controls.Add(this.buy_count_2);
            this.Controls.Add(this.buy_count_1);
            this.Controls.Add(this.product_title_2);
            this.Controls.Add(this.product_title_1);
            this.Controls.Add(this.read_file_button);
            this.Controls.Add(this.product_list_2);
            this.Controls.Add(this.product_list_1);
            this.Controls.Add(this.shop_revenue_2);
            this.Controls.Add(this.buy_button1);
            this.Controls.Add(this.shop_revenue_1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Markets";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.label1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label shop_revenue_1;
        private System.Windows.Forms.Button buy_button1;
        private System.Windows.Forms.Label shop_revenue_2;
        private System.Windows.Forms.ListBox product_list_1;
        private Market1 market1;
        private Market2 market2;
        private System.Windows.Forms.ListBox product_list_2;
        private System.Windows.Forms.Button read_file_button;
        private System.Windows.Forms.TextBox product_title_1;
        private System.Windows.Forms.TextBox product_title_2;
        private System.Windows.Forms.TextBox buy_count_1;
        private System.Windows.Forms.TextBox buy_count_2;
        private System.Windows.Forms.Button buy_button2;
        private System.Windows.Forms.Button call_manager1_button;
        private System.Windows.Forms.Button call_manager2_buton;
        private System.Windows.Forms.Label first_label;
        private System.Windows.Forms.Label second_label;
        private System.Windows.Forms.Button end_prog_button;
        private System.Windows.Forms.Label street_label1;
        private System.Windows.Forms.Label second_title;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label street_label_1;
        private Label street_label2;
    }
}


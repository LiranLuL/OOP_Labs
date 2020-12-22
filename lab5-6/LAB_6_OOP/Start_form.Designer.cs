namespace LAB_6_OOP
{
    partial class Start_form
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inform = new System.Windows.Forms.Label();
            this.first_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.second_label = new System.Windows.Forms.Label();
            this.second_title = new System.Windows.Forms.TextBox();
            this.first_title = new System.Windows.Forms.TextBox();
            this.second_address = new System.Windows.Forms.TextBox();
            this.continue_button = new System.Windows.Forms.Button();
            this.first_address = new System.Windows.Forms.TextBox();
            this.path1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.path2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inform
            // 
            this.inform.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inform.AutoSize = true;
            this.inform.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inform.Location = new System.Drawing.Point(418, 49);
            this.inform.Name = "inform";
            this.inform.Size = new System.Drawing.Size(433, 45);
            this.inform.TabIndex = 0;
            this.inform.Text = "Введите названия и адреса";
            this.inform.Click += new System.EventHandler(this.label1_Click);
            // 
            // first_label
            // 
            this.first_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.first_label.AutoSize = true;
            this.first_label.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_label.Location = new System.Drawing.Point(192, 209);
            this.first_label.Name = "first_label";
            this.first_label.Size = new System.Drawing.Size(203, 32);
            this.first_label.TabIndex = 3;
            this.first_label.Text = "Первый магазин";
            this.first_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(121, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Адрес:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(812, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Адрес:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(791, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Название:";
            // 
            // second_label
            // 
            this.second_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.second_label.AutoSize = true;
            this.second_label.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second_label.Location = new System.Drawing.Point(899, 209);
            this.second_label.Name = "second_label";
            this.second_label.Size = new System.Drawing.Size(194, 32);
            this.second_label.TabIndex = 8;
            this.second_label.Text = "Второй магазин";
            // 
            // second_title
            // 
            this.second_title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second_title.Location = new System.Drawing.Point(938, 299);
            this.second_title.MinimumSize = new System.Drawing.Size(4, 30);
            this.second_title.Multiline = true;
            this.second_title.Name = "second_title";
            this.second_title.Size = new System.Drawing.Size(218, 42);
            this.second_title.TabIndex = 7;
            // 
            // first_title
            // 
            this.first_title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_title.Location = new System.Drawing.Point(237, 299);
            this.first_title.MinimumSize = new System.Drawing.Size(4, 30);
            this.first_title.Multiline = true;
            this.first_title.Name = "first_title";
            this.first_title.Size = new System.Drawing.Size(218, 39);
            this.first_title.TabIndex = 6;
            this.first_title.TextChanged += new System.EventHandler(this.second_title_TextChanged);
            // 
            // second_address
            // 
            this.second_address.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second_address.Location = new System.Drawing.Point(938, 391);
            this.second_address.MinimumSize = new System.Drawing.Size(4, 30);
            this.second_address.Multiline = true;
            this.second_address.Name = "second_address";
            this.second_address.Size = new System.Drawing.Size(218, 42);
            this.second_address.TabIndex = 11;
            this.second_address.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // continue_button
            // 
            this.continue_button.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continue_button.Location = new System.Drawing.Point(-8, 611);
            this.continue_button.Name = "continue_button";
            this.continue_button.Size = new System.Drawing.Size(1270, 157);
            this.continue_button.TabIndex = 12;
            this.continue_button.Text = "Далее";
            this.continue_button.UseVisualStyleBackColor = true;
            this.continue_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // first_address
            // 
            this.first_address.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_address.Location = new System.Drawing.Point(237, 394);
            this.first_address.Multiline = true;
            this.first_address.Name = "first_address";
            this.first_address.Size = new System.Drawing.Size(218, 39);
            this.first_address.TabIndex = 13;
            this.first_address.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // path1
            // 
            this.path1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.path1.Location = new System.Drawing.Point(237, 494);
            this.path1.Multiline = true;
            this.path1.Name = "path1";
            this.path1.Size = new System.Drawing.Size(218, 39);
            this.path1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Путь к файлу:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(302, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "items1.txt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1003, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "items2.txt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(761, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Путь к файлу:";
            // 
            // path2
            // 
            this.path2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.path2.Location = new System.Drawing.Point(938, 494);
            this.path2.Multiline = true;
            this.path2.Name = "path2";
            this.path2.Size = new System.Drawing.Size(218, 39);
            this.path2.TabIndex = 17;
            // 
            // Start_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.path2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path1);
            this.Controls.Add(this.first_address);
            this.Controls.Add(this.continue_button);
            this.Controls.Add(this.second_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.second_label);
            this.Controls.Add(this.second_title);
            this.Controls.Add(this.first_title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.first_label);
            this.Controls.Add(this.inform);
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "Start_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inform;
        private System.Windows.Forms.Label first_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label second_label;
        private System.Windows.Forms.TextBox second_title;
        private System.Windows.Forms.TextBox first_title;
        private System.Windows.Forms.TextBox second_address;
        private System.Windows.Forms.Button continue_button;
        private System.Windows.Forms.TextBox first_address;
        private System.Windows.Forms.TextBox path1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox path2;
    }
}
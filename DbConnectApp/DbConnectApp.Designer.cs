namespace DbConnectApp
{
    partial class DbConnectApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            comboBox1 = new ComboBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            button1 = new Button();
            label7 = new Label();
            textBox12 = new TextBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            textBox11 = new TextBox();
            button2 = new Button();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 357);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 1;
            label1.Text = "Строка подключения";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(23, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "Server";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(23, 73);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "Initial Catalog";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(23, 182);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 23);
            textBox4.TabIndex = 5;
            textBox4.Text = "User ID";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(23, 130);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(143, 23);
            textBox5.TabIndex = 4;
            textBox5.Text = "Integrated Security";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(23, 226);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(143, 23);
            textBox6.TabIndex = 6;
            textBox6.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 47);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 7;
            label2.Text = "Источик данных";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 99);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 8;
            label3.Text = "Имя базы данных";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 156);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 9;
            label4.Text = "Система авторизации";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 208);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 10;
            label5.Text = "Имя / логин";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 252);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 11;
            label6.Text = "Пароль";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(22, 328);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(766, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(185, 21);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(143, 23);
            textBox7.TabIndex = 12;
            textBox7.TextChanged += connection_string;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(185, 73);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(143, 23);
            textBox8.TabIndex = 13;
            textBox8.TextChanged += connection_string;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "false", "true" });
            comboBox1.Location = new Point(186, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += connection_string;
            comboBox1.TextChanged += connection_string;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(185, 182);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(143, 23);
            textBox9.TabIndex = 15;
            textBox9.TextChanged += connection_string;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(186, 226);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(143, 23);
            textBox10.TabIndex = 16;
            textBox10.TextChanged += connection_string;
            // 
            // button1
            // 
            button1.Location = new Point(23, 403);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 307);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 19;
            label7.Text = "Пароль";
            // 
            // textBox12
            // 
            textBox12.Enabled = false;
            textBox12.Location = new Point(23, 281);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(143, 23);
            textBox12.TabIndex = 18;
            textBox12.Text = "TrustServerCertificate";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "true", "false" });
            comboBox2.Location = new Point(187, 281);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(142, 23);
            comboBox2.TabIndex = 20;
            comboBox2.SelectedValueChanged += connection_string;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(289, 400);
            label8.Name = "label8";
            label8.Size = new Size(125, 15);
            label8.TabIndex = 22;
            label8.Text = "Строка подключения";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(22, 374);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(423, 23);
            textBox11.TabIndex = 21;
            // 
            // button2
            // 
            button2.Location = new Point(713, 403);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(465, 374);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(153, 23);
            textBox13.TabIndex = 24;
            textBox13.TextChanged += changeInsert;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(635, 374);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(153, 23);
            textBox14.TabIndex = 25;
            textBox14.TextChanged += changeInsert;
            // 
            // button3
            // 
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 26;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(8, 8);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 27;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(414, 417);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 28;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // DbConnectApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox14);
            Controls.Add(textBox13);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(textBox11);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(textBox12);
            Controls.Add(button1);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(comboBox1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "DbConnectApp";
            Text = "Form1";
            Load += connection_string;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox7;
        private TextBox textBox8;
        private ComboBox comboBox1;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button button1;
        private Label label7;
        private TextBox textBox12;
        private ComboBox comboBox2;
        private Label label8;
        private TextBox textBox11;
        private Button button2;
        private TextBox textBox13;
        private TextBox textBox14;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}

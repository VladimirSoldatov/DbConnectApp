using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace DbConnectApp
{
    public partial class DbConnectApp : Form
    {
        public DbConnectApp()
        {
            InitializeComponent();
        }
        DataGridView dataGridView1;
        DataTable dataTable = new DataTable(); // Создаем объект для хранения данных из БД
        DataSet ds = new DataSet();
        private void connection_string(object sender, EventArgs e)
        {
            // Собираем строку подключения
            textBox1.Text = String.Empty;
            if (!string.IsNullOrEmpty(textBox7.Text))
                textBox1.Text += $"{textBox2.Text}={textBox7.Text};";
            if (!string.IsNullOrEmpty(textBox8.Text))
                textBox1.Text += $"{textBox3.Text}={textBox8.Text};";
            if (!string.IsNullOrEmpty($"{comboBox1.SelectedItem}"))
                textBox1.Text += $"{textBox5.Text}={comboBox1.SelectedItem};";
            if ($"{comboBox1.SelectedItem}" == "false" && !string.IsNullOrEmpty($"{textBox9.Text}") && !string.IsNullOrEmpty($"{textBox10.Text}"))
                textBox1.Text += $"{textBox4.Text}={textBox9.Text};{textBox6.Text}={textBox10.Text};";
            if (!string.IsNullOrEmpty($"{comboBox2.SelectedItem}"))
                textBox1.Text += $"{textBox12.Text}={comboBox2.SelectedItem};";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1 = Controls.Find("dataGridView1", true).FirstOrDefault() as DataGridView ?? new DataGridView();
            if (this.Controls.Find("dataGridView1", true).Length == 0)
            {
                dataGridView1.Name = "dataGridView1";
                dataGridView1.Location = new Point(textBox7.Location.X + textBox7.Width + 50, textBox7.Location.Y);
                dataGridView1.Size = new Size(this.Width - dataGridView1.Width - 250, this.Height - dataGridView1.Height - 50);
                dataGridView1.AllowUserToAddRows = false;
                this.Controls.Add(dataGridView1);
                dataGridView1.DataSourceChanged += (sender, e) =>
                {
                    this.Size = new Size(dataGridView1.Width + textBox7.Width + textBox7.Location.X + textBox2.Width, this.Size.Height);
                };
            }
            get_data2();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSize = true;
            //this.Size = new Size(dataGridView1.Width + textBox7.Width + textBox7.Location.X + textBox2.Width + textBox2.Location.X, this.Size.Height)  ;
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = ds.Tables[0];
        }
        void get_data()
        {
            var strings = textBox1.Text.Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            if (strings.Length < 10)
                return;
            dataTable.Rows.Clear();
            dataTable.Columns.Clear();
            dataTable.Clear();

            string selectCommand = "SELECT * FROM dbo.Authors;";
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(textBox1.Text))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = selectCommand;
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            int index = 0;
                            while (sqlDataReader.Read())
                            {
                                if (sqlDataReader.HasRows)
                                {
                                    if (index == 0)
                                    {
                                        for (int i = 0; i < sqlDataReader.FieldCount; i++)
                                        {
                                            dataTable.Columns.Add(new DataColumn(sqlDataReader.GetName(i)));
                                        }
                                        index++;
                                    }
                                    object[] objects = new object[sqlDataReader.FieldCount];
                                    sqlDataReader.GetValues(objects);
                                    dataTable.Rows.Add(objects);


                                }
                            }
                        }

                    }
                }

                MessageBox.Show("Соединение установлено");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Help!: {ex.Message}");
            }
        }
        void get_data2()
        {
            var strings = textBox1.Text.Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            if (strings.Length < 10)
                return;
            dataTable.Rows.Clear();
            dataTable.Columns.Clear();
            dataTable.Clear();
            ds = new DataSet();
         
            string selectCommand = "SELECT * FROM dbo.Authors; SELECT * from dbo.books;";
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(textBox1.Text))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = selectCommand;
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand, sqlConnection);
                        sqlDataAdapter.TableMappings.Add("Table", "Authors");
                        sqlDataAdapter.TableMappings.Add("Table1", "Books");
                        sqlDataAdapter.Fill(ds);
                    }
                }
                MessageBox.Show("Соединение установлено");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Help!: {ex.Message}");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox11.Text.Length > 0)
                non_query(textBox11.Text);
            get_data();

        }
        void non_query(string selectCommand)
        {
            var strings = textBox1.Text.Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            if (strings.Length < 10)
                return;
            DataTable dataTable = new DataTable();


            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(textBox1.Text))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = selectCommand;
                        int result = sqlCommand.ExecuteNonQuery();

                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Help!: {ex.Message}");
            }
        }
        void changeInsert(object sender, EventArgs e)
        {
            textBox11.Text = $"INSERT INTO Authors (FirstName, LastName) VALUES ('{textBox13.Text}','{textBox14.Text}');";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (ds.Tables.Count > 1)
            {

                if (dataGridView1.DataSource == ds.Tables["Authors"])
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ds.Tables["Books"];
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ds.Tables["Authors"];
                }
            }
        }
    }

}

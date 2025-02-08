using Microsoft.Data.SqlClient;
using System.Data;

namespace DbConnectApp
{
    public partial class DbConnectApp : Form
    {
        public DbConnectApp()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        private void connection_string(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox2.Text}={textBox7.Text};{textBox3.Text}={textBox8.Text};" +
                $"{textBox4.Text}={textBox9.Text};{textBox5.Text}={comboBox1.SelectedItem};{textBox6.Text}={textBox10.Text};{textBox12.Text}={comboBox2.SelectedItem};";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView1 = Controls.Find("dataGridView1", true).FirstOrDefault() as DataGridView??new DataGridView();
            if (this.Controls.Find("dataGridView1", true).Length == 0)
            {
                dataGridView1.Name = "dataGridView1";
                dataGridView1.Location = new Point(textBox7.Location.X + textBox7.Width + 50, textBox7.Location.Y);
                dataGridView1.Size = new Size(this.Width - dataGridView1.Width - 200, this.Height - dataGridView1.Height - 50);
                dataGridView1.AllowUserToAddRows = false;
                this.Controls.Add(dataGridView1);
            }
            get_data();
    
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataTable;
        }
        void get_data()
        {
            var strings = textBox1.Text.Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            if (strings.Length < 10)
                return;
            dataTable.Rows.Clear();
            dataTable.Columns.Clear();
            dataTable.Clear();

            string selectCommand = "SELECT * FROM dbo.Authors";
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

          

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Help!: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox11.Text.Length>0)
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
    }

}

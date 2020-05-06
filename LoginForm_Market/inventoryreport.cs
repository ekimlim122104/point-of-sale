using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginForm_Market
{
    public partial class inventoryreport : Form
    {
      
        public inventoryreport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform mf = new Mainform();
            mf.Show();
        }




        void load_table()
        {
            String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
            string query = "SELECT * FROM producttb;";

            MySqlConnection sqlConnection = new MySqlConnection(path);
            MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = sqlCommand;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                sda.Update(dt);


            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message);

            }

        }
        public void viewData()
        {
            try
            {

                MySqlConnection mcon = new MySqlConnection("datasource = localhost; port = 3306;username = root; password = ");
                MySqlDataAdapter mda = new MySqlDataAdapter("select * from inventory.producttb", mcon);
                mcon.Open();
                DataSet ds = new DataSet();
                mda.Fill(ds, "inventory");
                dataGridView1.DataSource = ds.Tables["inventory"];
                mcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            processCompelete();
            String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
            string query = "SELECT id as 'Product ID',name as 'Product Name',price as 'Product Price',stock as 'NO of Stock' from producttb;";

            MySqlConnection sqlConnection = new MySqlConnection(path);
            MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = sqlCommand;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                sda.Update(dt);


            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message);

            }

        }
        public void processCompelete()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Beep();
                
                }
            
            
            }
          

        private void inventoryreport_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals(""))
            {
                viewData();

            }

            else
            {
                //searching in textbar
                try
                {

                    MySqlConnection mcon = new MySqlConnection("datasource = localhost; port = 3306;username = root; password = ");
                    MySqlDataAdapter mda = new MySqlDataAdapter("select * from inventory.producttb where id = '" +textBox1.Text+ "'", mcon);
                    mcon.Open();
                    DataSet ds = new DataSet();
                    mda.Fill(ds, "inventory");
                    dataGridView1.DataSource = ds.Tables["inventory"];
                    mcon.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            processCompelete();
            try
            {
                String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
                MySqlConnection sqlConnection = new MySqlConnection(path);
                MySqlCommand sqlCommand = new MySqlCommand();
                string query = "Delete from  producttb where id = '" +textBox1.Text+ "' ;";
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = query;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Deleted!");
                viewData();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            
            {
                processCompelete();
                String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
                MySqlConnection sqlConnection = new MySqlConnection(path);
                MySqlCommand sqlCommand = new MySqlCommand();
                string query = "Update producttb SET name = '" + textBox2.Text + "', price = '" + textBox3.Text + "',stock = '" + textBox4.Text + "' WHERE id = '" + textBox1.Text + "'";
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = query;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                viewData();
                MessageBox.Show("Updated!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals(""))
            {
                MessageBox.Show("Fill missing fields");
            }
            else
            {
                try
                {
                    String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
                    MySqlConnection sqlConnection = new MySqlConnection(path);
                    MySqlCommand sqlCommand = new MySqlCommand();
                    string query = "Insert into producttb (name,price,stock) Values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = query;
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    processCompelete();
                    viewData();
                    MessageBox.Show("Saved!!");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    
                 
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Number Value", "ERROR");
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Number Value", "ERROR");
            }
        }
    }
}

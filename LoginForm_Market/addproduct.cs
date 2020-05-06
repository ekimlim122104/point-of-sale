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
    public partial class addproduct : Form
    {
      
      
        public addproduct()
        {
            InitializeComponent();
            Fillcombo();
        }
        public void viewData()
        {
            try
            {

                MySqlConnection mcon = new MySqlConnection("datasource = localhost; port = 3306;username = root; password = ");
                MySqlDataAdapter mda = new MySqlDataAdapter("select * from inventory.productTB", mcon);
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
        void Fillcombo()
        {
            try
            {
                String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
                string query = "SELECT * FROM productTB;";

                MySqlConnection sqlConnection = new MySqlConnection(path);
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                MySqlDataReader myReader;
                myReader = sqlCommand.ExecuteReader();



                while (myReader.Read())
                {

                    comboBox1.Items.Add(myReader.GetString("name"));
                }
                sqlConnection.Close();


                // sqlCommand.CommandType = CommandType.Text;
                // sqlCommand.CommandText = query;
                //  sqlCommand.Connection = sqlConnection;
                // sqlCommand.ExecuteNonQuery();


            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
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
                    string query = "Insert into productTB (name,price,stock) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = query;
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    viewData();
                    MessageBox.Show("Saved!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform mf = new Mainform();
            mf.Show();
        }

        private void addproduct_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
             String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
            string query = "SELECT * from productTB;";

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        }
    }


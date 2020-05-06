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
    public partial class addS : Form
    {
        
        public addS()
        {
            InitializeComponent();
            Fillcombo();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            //add variable and initiate all data that we need to total the products
        {
            int total_stock;
            int qtystock = Convert.ToInt32(_qtytxt.Text);
            int remainstock = Convert.ToInt32(_remainstock.Text);

      

            total_stock = (qtystock + remainstock);

            _totalstocktxt.Text = ("" + total_stock);
            
            try
            {
            String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
            MySqlConnection sqlConnection = new MySqlConnection(path);
            MySqlCommand sqlCommand = new MySqlCommand();
            string query = "Update productTB SET stock = '" + _totalstocktxt.Text + "' WHERE id= '" + idtxt.Text + "';";
            sqlConnection.Open();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Add Stock Saved!!");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String path = "Data Source = LOCALHOST; Initial Catalog = inventory; username='root';password=''";
                string query = "SELECT * FROM productTB where name = '" + comboBox1.Text + "';";

                MySqlConnection sqlConnection = new MySqlConnection(path);
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                MySqlDataReader myReader;
                myReader = sqlCommand.ExecuteReader();



                while (myReader.Read())
                {

                    comboBox1.Items.Add(myReader.GetString("name"));
                    string sID = myReader.GetInt32("id").ToString();
                    string sStock = myReader.GetInt32("stock").ToString();


                    idtxt.Text = sID;
                    _remainstock.Text = sStock;
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

        private void addS_Load(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform mf = new Mainform();
            mf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtxt.Text = "";
            comboBox1.Text = "";
            _remainstock.Text = "";
            _qtytxt.Text = "";
            _totalstocktxt.Text = "";
        
        }
    }
}

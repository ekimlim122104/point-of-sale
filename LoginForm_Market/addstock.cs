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
    public partial class taeee : Form
    {
        public taeee()
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform mf = new Mainform();
            mf.Show();
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
                    _qtystock.Text = sStock;
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

        private void addstock_Load(object sender, EventArgs e)
        {
            viewData();

        }
        private void button1_Click(object sender, EventArgs e)

            //add stock okay
        {
            int total_stock;

            int qtystock = Convert.ToInt32(_qtystock.Text);
            int addstock = Convert.ToInt32(addtxt.Text);

            total_stock = qtystock + addstock;

            _total.Text = ("" + total_stock);
           
            


            String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
            MySqlConnection sqlConnection = new MySqlConnection(path);
            MySqlCommand sqlCommand = new MySqlCommand();
            string query = "Update productTB SET stock = '" +_total.Text + "' WHERE id= '" + idtxt.Text + "';";
            sqlConnection.Open();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            viewData();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void _qtystock_TextChanged(object sender, EventArgs e)
        {

        }

        private void addtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void _total_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

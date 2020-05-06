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
    public partial class Deliver : Form
    {
        public Deliver()
        {
            InitializeComponent();
            fill_listbox();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerfield mf = new customerfield();
            mf.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deliver_Load(object sender, EventArgs e)
        {

        }

        void fill_listbox()
        {
            // this method will connect the listbox into the database in table of producttb
            try
            {
                String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
                string query = "SELECT * FROM producttb;";

                MySqlConnection sqlConnection = new MySqlConnection(path);
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                MySqlDataReader myReader;
                myReader = sqlCommand.ExecuteReader();



                while (myReader.Read())
                {


                    string sName = myReader.GetString("name");
                    listBox1.Items.Add(sName);
                }
                sqlConnection.Close();

            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /*connecting the listbox into the database in the table of producttb and when you select the certain product in
                 * textfield and print the several or certain info about what you select on listbox
                 * */
                String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
                string query = "SELECT * FROM producttb where name = '" + listBox1.Text + "';";

                MySqlConnection sqlConnection = new MySqlConnection(path);
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                MySqlDataReader myReader;
                myReader = sqlCommand.ExecuteReader();



                while (myReader.Read())
                {

                    //comboBox1.Items.Add(myReader.GetString("fname"));


                    string sPrice = myReader.GetInt32("price").ToString();
                    string sStock = myReader.GetInt32("stock").ToString();
                    string sName = myReader.GetString("name");
                   
                    textBox4.Text = sPrice;
                    textBox7.Text = sStock;
                    textBox10.Text = sName;
                    

                }
                sqlConnection.Close();

            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }
        public void Process()
        {

            //giving an reference number for deliver transaction.
            double price, qty, total,stock,lstock;
            double vat = 0.12;
            double totalvat;
            double vatvat;
            Random rnd = new Random();
            textBox3.Text = rnd.Next(1, 1000).ToString();

            price = Convert.ToInt32(textBox4.Text);
            qty = Convert.ToInt32(textBox6.Text);
            stock = Convert.ToInt32(textBox7.Text);


            //setting up the formula that we use to compute the transaction needs.

            total = price * qty;
            vatvat = total * vat;
            lstock = stock - qty;
            totalvat = total + vatvat;
            textBox8.Text = ("" + totalvat);
            textBox9.Text = ("" + vatvat);
            textBox7.Text = ("" + lstock);


        }
        public void processCompelete()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Beep();

            }


        }
          
        private void button2_Click(object sender, EventArgs e)
        {
            //calling the method process
            Process();

            try
            {
                //insert the data into the database in table of delivertb
                String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
                MySqlConnection sqlConnection = new MySqlConnection(path);
                MySqlCommand sqlCommand = new MySqlCommand();
                string query = "Insert into delivertb (product,cnum,refno,address,qty,stockno,total,vat,customername,price) Values('" + textBox10.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox1.Text + "','"+textBox4.Text+"')";
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = query;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                processCompelete();
                
                MessageBox.Show("Saved!!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //data validation for number only
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Number Value", "ERROR");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            // data validation for number only
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Number Value", "ERROR");
            }
        }
    }
}
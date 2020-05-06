using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace LoginForm_Market
{
    public partial class purchase : Form
    {
       
        public purchase()
        {
            
            InitializeComponent();
            timer1.Start();
            fill_listbox();
       
            //load_table();
            // para hnde automatic show
      
          
        }
        double totalfinal;
        int Pprice;
        int Mmoney;
        double result;
        int qty;
        int stockNo;
        int totalstock;
        double vat;
        double totalvat;
        double change;
       

        
        private void button3_Click(object sender, EventArgs e)
        {
          
          this.Hide();
          customerfield mf = new customerfield();
           mf.Show();
            
                
        }
        void fill_listbox()
        {

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

        private void purchase_Load(object sender, EventArgs e)
        {
            

        }

        public void stockMonitoring()
        {
            qty = Convert.ToInt32(_tqty.Text);
            stockNo = Convert.ToInt32(_stock.Text);
            totalstock = stockNo - qty;

            _totalStock.Text = (""+ totalstock);



            String path = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
            MySqlConnection sqlConnection = new MySqlConnection(path);
            MySqlCommand sqlCommand = new MySqlCommand();
            string query = "Update productTB SET stock = '" + _totalStock.Text + "' WHERE id = '" + _ID.Text + "'";
            sqlConnection.Open();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            //vat + tootal
            double finalnato;
         
              //  change = Convert.ToInt32(_change.Text);
                Pprice = Convert.ToInt32(_tprice.Text);
                Mmoney = Convert.ToInt32(_tmoney.Text);
                // vat - change
            if(_tmoney.Text == ""||_tqty.Text == "" || _tname.Text == "")
            {
                MessageBox.Show("Please Complete the Fields");
            }
               

                if (Mmoney < Pprice)
                {

                    MessageBox.Show("Please enter enough money!!", "ERROR");

                }
                else
                {
                    result = Mmoney - Pprice;
                    change = Mmoney - result;
                    vat = 0.12 * result;
                    finalnato = change - vat;

                    totalvat = result * 0.12;
                    totalfinal = totalvat + change;
                    vattxt.Text = ("" + totalvat);
                    t_total.Text = (" " + totalfinal);
                    _change.Text = ("" + finalnato);
                    stockMonitoring();
                    processCompelete();
                
                }
      

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
            _ID.Text = "";
            _tname.Text = "";
            _tmoney.Text = "";
            listBox1.Text = "";
            _tprice.Text = "";
            _tqty.Text = "";
            _stock.Text = "";
            _totalStock.Text = "";
            t_total.Text = "";
            _change.Text = "";
            vattxt.Text = "";
            richTextBox1.Text = "";
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.timelbl.Text = dt.ToString();
        }

        private void _tmoney_TextChanged(object sender, EventArgs e)
        {

        }

        public void disp()
        {
            richTextBox1.Text = ("Lim,Mena,Batrina SuperMarket"+"\n"+"================RECEIPT================ \n" + timelbl.Text + "\n" + "Product ID: " + _ID.Text + "\n" +
                "Product Name: " + listBox1.Text + "\n" + "Product Price: " + _tprice.Text + "Qty: " + _tqty.Text + "\n" + "Customer Name: " + _tname.Text + "\n" + "Money: " + _tmoney.Text + "\n" + "Total  :" + t_total.Text + "\n"
            + "Change: " + _change.Text + "\n" + "Vat Value: " + vattxt.Text + "\n"+ "======= THANK YOU COME AGAIN =======");
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            disp();
        }

        private void _tmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Number Value", "ERROR");
            }
        }

        private void _tqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void _tqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Number Value", "ERROR");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
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


                    string sPrice = myReader.GetString("price").ToString();
                    string sStock = myReader.GetString("stock").ToString();
                    string sID = myReader.GetString("id").ToString();
                    
                    _tprice.Text = sPrice;
                    _stock.Text = sStock;
                    _ID.Text = sID;

                }
                sqlConnection.Close();

            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void timelbl_Click(object sender, EventArgs e)
        {

        }

       
    }
}

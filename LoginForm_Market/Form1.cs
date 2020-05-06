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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mainform x = new Mainform();
            //x.Show();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Must Complete All Fields!");
            }
            else
            {
                checkAccount();

            }
        }


        public void checkAccount()
        {




            string conString = "Data Source = LOCALHOST; Initial Catalog =inventory; username='root';password=''";
            MySqlConnection con = new MySqlConnection(conString);
            string selectSql = "select * from useraccounts";
            MySqlCommand cmd = new MySqlCommand(selectSql, con);
            bool found = true;
            try
            {
                con.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String username = reader["Username"].ToString();
                        String password = reader["Password"].ToString();
                        String UserType = reader["userlvl"].ToString();

                        
                         if (textBox1.Text == username && textBox2.Text == password && UserType == comboBox1.SelectedItem.ToString() && found)
                         {
                             
                                if (UserType == "Admin")
                                {
                                    this.Hide();
                                    switchuser pur = new switchuser();
                                    pur.Show();
                                    MessageBox.Show("LogIn Successfully!");
                                    found = false;
                                }
                                else
                                {
                                    Mainform zxc = new Mainform();
                                    zxc.Show();
                                    this.Hide();
                                    found = false;

                                }
                            
                                            
                        }
                    }
                }
            }
            finally
            {
                con.Close();
            }
            if (found)
            {
                MessageBox.Show("Invalid UserName / Password / UserType /Fill up the Missing fields / You Dont have account so you can Create one..");
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.timelbl.Text = dt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            registration rg = new registration();
            rg.Show();

        }

        private void timelbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Focus();
                epUser.SetError(textBox1, "Username Error!");

            }
            else {

                epUser.Icon = Properties.Resources.Tatice_Cristal_Intense_Ok;
                epUser.SetError(textBox1,"Ok");
            }
     
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.Focus();
                epUser.SetError(textBox2, "Username Error!");

            }
            else
            {

                epUser.Icon = Properties.Resources.Tatice_Cristal_Intense_Ok;
                epUser.SetError(textBox2, "Ok");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
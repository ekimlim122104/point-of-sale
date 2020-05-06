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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
                    String path = "Data Source = LOCALHOST; Initial Catalog = inventory; username='root';password=''";
                    MySqlConnection sqlConnection = new MySqlConnection(path);
                    MySqlCommand sqlCommand = new MySqlCommand();
                    string query = "Insert into useraccounts (username,password,userlvl) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text+ "')";
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = query;
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    if (textBox2.Text == textBox3.Text)
                    {
                        MessageBox.Show("Saved!!");

                    }
                    else
                    {
                        MessageBox.Show("Password not Confirm, Please Try again.", "ERROR");
                    
                    }
                

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 x = new Form1();
            x.Show();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}

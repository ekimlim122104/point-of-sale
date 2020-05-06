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
    public partial class employee_account : Form
    {
       

        public employee_account()
        {
            InitializeComponent();
        }
        string gender;
   


        public void asd()
        {
            try
            {

                MySqlConnection mcon = new MySqlConnection("datasource = localhost; port = 3306;username = root; password = ");
                MySqlDataAdapter mda = new MySqlDataAdapter("select * from marketdb.employeetb", mcon);
                mcon.Open();
                DataSet ds = new DataSet();
                mda.Fill(ds, "marketdb");
                dataGridView1.DataSource = ds.Tables["marketdb"];
                mcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void employee_account_Load(object sender, EventArgs e)
        {
            asd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals(""))
            {
                MessageBox.Show("Fill missing fields");
            }
            else
            {
                try
                {
                    String path = "Data Source = LOCALHOST; Initial Catalog = invetory; username='root';password=''";
                    MySqlConnection sqlConnection = new MySqlConnection(path);
                    MySqlCommand sqlCommand = new MySqlCommand();
                    string query = "Insert into employeetb (name,gender,bday,age,position) Values('" + textBox2.Text + "','"+gender+"','"+dateTimePicker1.Text+"','" + textBox3.Text + "','"+textBox4.Text+"')";
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = query;
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    asd();  

                    MessageBox.Show("Saved!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void button4_Click(object sender, EventArgs e)
        {


            Mainform mf = new Mainform();
         
            mf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Number Value", "ERROR");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

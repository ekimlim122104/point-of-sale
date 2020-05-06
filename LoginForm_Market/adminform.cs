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
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                        string selectSql = "select * from adminacc";
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



                                    if (textBox1.Text == username && textBox2.Text == password && found)
                                    {


                                        this.Hide();
                                        Mainform pur = new Mainform();
                                        pur.Show();


                                    }
                                }
                            }
                        }
                        finally
                        {
                            con.Close();
                        }

                    }
                }
            }

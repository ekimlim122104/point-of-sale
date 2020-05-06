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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
       


        }

        public void connection()
        {
            
            
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                employee_account ea = new employee_account();
            
                ea.Show();
                this.Hide();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchase pur = new purchase();
            pur.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {


                addS ads = new addS(); 
                ads.Show();
                this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

           

                addproduct ap = new addproduct();
                ap.Show();
                this.Hide();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {



            inventoryreport ir = new inventoryreport();

            ir.Show();
            this.Hide();

        }
         

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }
        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you reall want to close the program?",
              "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deliver del = new Deliver();
            del.Show();
        }



    }
    }


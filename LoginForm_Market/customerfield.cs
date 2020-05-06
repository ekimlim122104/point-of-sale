using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginForm_Market
{
    public partial class customerfield : Form
    {
        public customerfield()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            purchase ads = new purchase();
            ads.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deliver ads = new Deliver();
            ads.Show();
            this.Hide();
        }
    }
}

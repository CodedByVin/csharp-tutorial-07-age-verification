using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_prac7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtAge.Text == "")
            {
                MessageBox.Show("Please enter your age!","Input Error");
                return;
            }

            int age = Convert.ToInt32(txtAge.Text);

            if(age >= 18)
            {
                MessageBox.Show("Welcome to the club!", "Welcome");
            }
            else
            {
                MessageBox.Show("You are too young, try again in a few years!", "Under-Age");
            }
        }
    }
}

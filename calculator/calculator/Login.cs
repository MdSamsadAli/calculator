using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text==""&&textBox2.Text=="")
            {
                MessageBox.Show("please Enter username and password");
            }
           else if(textBox1.Text=="Groot"&&textBox2.Text=="Root")
            {
                MessageBox.Show("login successful");
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
           else
            {
                MessageBox.Show("login is not successful");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

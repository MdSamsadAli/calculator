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
    public partial class Form1 : Form
    {
        double firstnumber;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            firstnumber = Convert.ToDouble(display.Text);
            display.Text = "0";
            Operation = "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for display seven(7)
            display.Text = display.Text + "7";  

        }

        private void button13_Click(object sender, EventArgs e)
        {

            firstnumber = Convert.ToDouble(display.Text);
            display.Text = "0";
            Operation = "-";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // display dot(.) on textbox when press dot button
            if (display.Text.Contains("."))
            { }
            else
            {
                display.Text = display.Text + ".";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // for zero
            display.Text = display.Text + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            // for display one (1)
            display.Text = display.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            //for two display
            display.Text = display.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            //for display three(3)
            display.Text = display.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
            {
                //for display four(4)
                display.Text = display.Text + "4";
            }

        private void five_Click(object sender, EventArgs e)
        {
            {
                //for display five(5)
                display.Text = display.Text + "5";
            }

        }

        private void six_Click(object sender, EventArgs e)
        { 
                //for display six(6)
                display.Text = display.Text + "6";

        }

        private void eight_Click(object sender, EventArgs e)
        {
            //for display eight(8)
            display.Text = display.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            //for display nine(9)
            display.Text = display.Text + "9";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double secondnumber;
            double res;
            secondnumber = Convert.ToDouble(display.Text);
            if(Operation=="+")
            {
                res = (firstnumber + secondnumber);
                display.Text = Convert.ToString(res);
                firstnumber = res;
            }
            if (Operation == "-")
            {
                res = (firstnumber - secondnumber);
                display.Text = Convert.ToString(res);
                firstnumber = res;
            }
            if (Operation == "*")
            {
                res = (firstnumber * secondnumber);
                display.Text = Convert.ToString(res);
                firstnumber = res;
            }
            if (Operation == "/")
            {
                if (secondnumber == 0)
                {
                    display.Text = "Cannot divide by 0";
                }
                else
                {
                    res = (firstnumber / secondnumber);
                    display.Text = Convert.ToString(res);
                    firstnumber = res;
                }
            }
            if(Operation=="%")
            {
                res = (firstnumber % secondnumber);
                display.Text = Convert.ToString(res);
                firstnumber = res;
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {

            firstnumber = Convert.ToDouble(display.Text);
            display.Text = "0";
            Operation = "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {

            firstnumber = Convert.ToDouble(display.Text);
            display.Text = "0";
            Operation = "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(display.Text);
            display.Text = "0";
            Operation = "%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text.Remove(display.Text.Length - 1, 1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int count;
            display.Clear();
            count = 0;
        }
    }
}

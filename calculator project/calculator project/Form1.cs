using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_project
{
    public partial class Form1 : Form
    {
        double num1, num2, result;
        char c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void mins_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            c = '-';
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
           

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void blus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            c = '+';
            textBox1.Clear();
        }

        private void drb_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            c = '*';
            textBox1.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            c = '/';
            textBox1.Clear();
        }

        private void euqal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            
            switch (c)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            textBox1.Text = Convert.ToString(result);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text  += "7";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resul = MessageBox.Show("Do you want yo exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resul == DialogResult.No)
            {
e.Cancel=true;
            }
            
            
            }
        }
    }


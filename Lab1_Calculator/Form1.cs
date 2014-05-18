using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week10
{
    public partial class Form1 : Form
    {
        private LinkedList<int> num1 = new LinkedList<int>();
        private int num2 = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private string Presentate(LinkedList<int> num1)
        {
            string presentNum = "";
            foreach (int value in num1)
            {
                presentNum = presentNum + value.ToString();
            }
            return presentNum;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            num1.AddLast(1);
            textBox1.Text = Presentate(num1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1.AddLast(2);
            textBox1.Text = Presentate(num1);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            num1.AddLast(3);
            textBox1.Text = Presentate(num1);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            num1.AddLast(4);
            textBox1.Text = Presentate(num1);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            num1.AddLast(5);
            textBox1.Text = Presentate(num1);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            num1.AddLast(6);
            textBox1.Text = Presentate(num1);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            num1.AddLast(7);
            textBox1.Text = Presentate(num1);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            num1.AddLast(8);
            textBox1.Text = Presentate(num1);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            num1.AddLast(9);
            textBox1.Text = Presentate(num1);
        }

        private void button0_Click_1(object sender, EventArgs e)
        {
            num1.AddLast(0);
            textBox1.Text = Presentate(num1);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            num1.Clear();
            num2 = 0;
            textBox1.Text = "0";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (num2 == 0)
            {
                num2 = int.Parse(Presentate(num1));
                num1.Clear();
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            int N1 = int.Parse(Presentate(num1));
            int N2 = num2;
            string result = (N1 + N2).ToString();
            textBox1.Text = result;

            num1.Clear();
            num2 = N1 + N2;
        }
    }
}


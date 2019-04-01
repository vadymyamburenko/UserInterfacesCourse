using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double a, b;
        int count;
        bool znak = true;
        bool operation = false;

        private void button17_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
        #region numbers
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        #endregion
        private void button11_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.IndexOf(",") == -1) && (textBox1.Text.IndexOf("∞") == -1))
                textBox1.Text += ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                calculate();
            }
            if (textBox1.Text == "") { a = 0; }
            else a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            operation = true;
            label1.Text = a.ToString() + "+";
            znak = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            if (operation)
            {
                calculate();
            }
            if (textBox1.Text == "") { a = 0; }
            else a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            operation = true;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                calculate();
            }
            if (textBox1.Text == "") { a = 0; }
            else a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            operation = true;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                calculate();
            }
            if (textBox1.Text == "") { a = 0; }
            else a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            operation = true;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {

            calculate();
            label1.Text = "";
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    if (textBox1.Text == "") { b = a; }
                    else b = a + double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    operation = false;
                    break;
                case 2:
                    if (textBox1.Text == "") { b = a; }
                    else b = a - double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    operation = false;
                    break;
                case 3:
                    if (textBox1.Text == "") { b = a; }
                    else b = a * double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    operation = false;
                    break;
                case 4:
                    if (textBox1.Text == "") { b = a; }
                    else b = a / double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    operation = false;
                    break;
                case 5:
                    if (textBox1.Text == "") { b = a; }
                    else b = Math.Pow(a,double.Parse(textBox1.Text));
                    textBox1.Text = b.ToString();
                    operation = false;
                    break;
                case 6:
                    b = Math.Sqrt(a);
                    textBox1.Text = b.ToString();
                    operation = false;
                    break;
                case 7:
                    b = Math.Round(Math.Sin(a*Math.PI/180),15);
                    textBox1.Text = b.ToString();
                    operation = false;
                    break;
                case 8:
                    b = Math.Round(Math.Cos(a * Math.PI / 180),15);
                    textBox1.Text = b.ToString();
                    operation = false;
                    break;
                case 9:
                    b = Math.Round(Math.Tan(a * Math.PI / 180),15);
                    textBox1.Text = b.ToString();
                    operation = false;
                    break;
                default:
                    break;
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                calculate();
            }
            if (textBox1.Text == "") { a = 0; }
            else a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            operation = true;
            label1.Text = a.ToString() + "^";
            znak = true;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                calculate();
            }
            if (textBox1.Text == "") { a = 0; }
            else a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 6;
            operation = true;
            label1.Text = "√" + a.ToString();
            znak = true;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                calculate();
            }
            if (textBox1.Text == "") { a = 0; }
            else a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 7;
            operation = true;
            label1.Text = "sin(" + a.ToString() + ")";
            znak = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                calculate();
            }
            if (textBox1.Text == "") { a = 0; }
            else a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 8;
            operation = true;
            label1.Text = "cos(" + a.ToString() + ")";
            znak = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (operation)
            {
                calculate();
            }
            if (textBox1.Text == "") { a = 0; }
            else a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 9;
            operation = true;
            label1.Text = "tan(" + a.ToString() + ")";
            znak = true;
        }

    }
}

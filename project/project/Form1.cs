using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox5.Text = "whole number 1";
            textBox2.Text = "+, -, *, or /";
            textBox7.Text = "whole number 2";
            label2.Text = "Input:";
            label3.Text = "Your output would appear here";
            button1.Text = "Run Code!";
            textBox4.Text = "x";
            textBox6.Text = "y";
            textBox1.Text = "x";
            textBox3.Text = "y";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num1 = textBox5.Text;
            string math = textBox2.Text;
            string num2 = textBox7.Text;
            string var1 = textBox4.Text;
            string var2 = textBox6.Text;
            string varname1 = textBox1.Text;
            string varname2 = textBox3.Text;
            int int1 = 0;
            int int2 = 0;
            int no1;
            int no2;
            bool input1int;
            bool input3int;
            bool varmatch1 = true;
            bool varmatch2 = true;
            input1int = int.TryParse(num1, out no1);
            input3int = int.TryParse(num2, out no2);
            if (varname1 == var1)
            {
                int1 = no1;
                varmatch1 = true;
            }
            else if (varname1 == var2)
            {
                int1 = no2;
                varmatch1 = true;
            }
            else
            {
                varmatch1 = false;
            }
            if (varname2 == var1)
            {
                int2 = no1;
                varmatch2 = true;
            }
            else if (varname2 == var2)
            {
                int2 = no2;
                varmatch2 = true;
            }
            else
            {
                varmatch2 = false;
            }
            if (varmatch1 == true)
            {
                if (varmatch2 == true)
                {
                    if (input1int == true)
                    {
                        if (input3int == true)
                        {
                            if (math == "+")
                            {
                                int sum = int1 + int2;
                                label3.Text = sum.ToString();
                            }
                            else if (math == "-")
                            {
                                int dif = int1 - int2;
                                label3.Text = dif.ToString();
                            }
                            else if (math == "*")
                            {
                                int pro = int1 * int2;
                                label3.Text = pro.ToString();
                            }
                            else if (math == "/")
                            {
                                if (int1 % int2 > 0)
                                {
                                    label3.Text = "Those don't divide into a whole number";
                                }
                                else
                                {
                                    int quo = int1 / int2;
                                    label3.Text = quo.ToString();
                                }
                            }
                            else
                            {
                                label3.Text = "The second box isn't +, -, *, or /";
                            }
                        }
                        else
                        {
                            label3.Text = "The second variable isn't equal to a whole number or is more than 9 digits";
                        }
                    }
                    else
                    {
                        label3.Text = "The first variable isn't equal to a whole number or is more than 9 digits";
                    }
                }
                else
                {
                    label3.Text = "The second variable you reference doesn't match a preset variable.";
                }
            }
            else
            {
                label3.Text = "The first variable you reference doesn't match a preset variable.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3.complete4 = "complete";
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.StartPosition = FormStartPosition.Manual;
            f3.Location = this.Location;
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3.complete4 = "complete";
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.StartPosition = FormStartPosition.Manual;
            f5.Location = this.Location;
            f5.Show();
            this.Hide();
        }
    }
}

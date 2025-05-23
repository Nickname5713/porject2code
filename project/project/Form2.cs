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
    public partial class Form2 : Form
    {
        public bool capscheck = true;
        public Form2()
        {
            InitializeComponent();
            label1.Text = "this will tell you whether it matches or not";
            textBox1.Text = "type your sentence here";
            textBox2.Text = "type the word you want to check matches for here";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3.complete3 = "complete";
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.StartPosition = FormStartPosition.Manual;
            f4.Location = this.Location;
            f4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] words = textBox1.Text.Split(' ');
            bool match = false;
            if (capscheck == true)
            {
                foreach (var w in words)
                {
                    if (w == textBox2.Text)
                    {
                        match = true;
                    }
                }
            }
            else
            {
                foreach (var w in words)
                {
                    if (w.ToLower() == textBox2.Text.ToLower())
                    {
                        match = true;
                    }
                }
            }
            if (match == true)
            {
                label1.Text = "match";
            }
            else
            {
                label1.Text = "no match";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (capscheck == true)
            {
                capscheck = false;
                label2.Text = "Caps Sensitivity: OFF";
            }
            else
            {
                capscheck = true;
                label2.Text = "Caps Sensitivity: ON";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3.complete3 = "complete";
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.StartPosition = FormStartPosition.Manual;
            f3.Location = this.Location;
            f3.Show();
            this.Hide();
        }
    }
}

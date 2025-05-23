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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label1.Text = "You can use integer variables for many things, such as crucial parts of your program, dictating whether or not they run or how much they run, for maths,\n or you can call them to display or as a way to set other variables. On the following page, you will do maths functions by setting and then calling\n variables in order to do maths with them.";
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3.complete2 = "complete";
            Form1 f1 = new Form1();
            f1.Owner = this;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = this.Location;
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3.complete2 = "complete";
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.StartPosition = FormStartPosition.Manual;
            f3.Location = this.Location;
            f3.Show();
            this.Hide();
        }

    }
    }

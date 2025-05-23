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
    public partial class Form3 : Form
    {
        public static string complete1 = "incomplete";
        public static string complete2 = "incomplete";
        public static string complete3 = "incomplete";
        public static string complete4 = "incomplete";
        public static string complete5 = "incomplete";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.StartPosition = FormStartPosition.Manual;
            f4.Location = this.Location;
            f4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.StartPosition = FormStartPosition.Manual;
            f5.Location = this.Location;
            f5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = this.Location;
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Owner = this;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = this.Location;
            f1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this;
            f6.StartPosition = FormStartPosition.Manual;
            f6.Location = this.Location;
            f6.Show();
            this.Hide();
        }

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            label4.Text = complete1;
            label3.Text = complete2;
            label2.Text = complete3;
            label1.Text = complete4;
            label5.Text = complete5;
        }
    }
}

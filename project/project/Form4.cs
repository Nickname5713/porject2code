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

    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label1.Text = "There are many things you can do with variables, such as having strings of variables. You can call the strings later and have \n them written in full or you can check strings for various words. One of the best things about strings is that you can easily \nconvert a user's input into a string and then check it. The next page will allow you to check if a string input of yours contains\n a particular word, much like you can do for other users.";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3.complete1 = "complete";
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = this.Location;
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3.complete1 = "complete";
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.StartPosition = FormStartPosition.Manual;
            f3.Location = this.Location;
            f3.Show();
            this.Hide();
        }
    }
}

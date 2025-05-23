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
    public partial class Form6 : Form
    {
        public string int1text = "int1";
        public string int2text = "int2";
        public int var1;
        public int var2;
        public int int1 = 0;
        public int int2 = 0;
        public string num1 = "";
        public string num2 = "";
        public int no1;
        public int no2;
        public bool input1int;
        public bool input2int;
        public int count = 0;
        public string stringtext = "string";
        public bool var1int1 = false;
        public bool var1int2 = false;
        public bool var1int1plusint1 = false;
        public bool var1int1plusint2 = false;
        public bool var1int1timesint1 = false;
        public bool var1int1timesint2 = false;
        public bool var1int2plusint2 = false;
        public bool var1int2timesint2 = false;
        public bool var1int1divint2 = false;
        public bool var1int2divint1 = false;
        public bool var1int1minint2 = false;
        public bool var1int2minint1 = false;
        public bool var2int1 = false;
        public bool var2int2 = false;
        public bool var2int1plusint1 = false;
        public bool var2int1plusint2 = false;
        public bool var2int1timesint1 = false;
        public bool var2int1timesint2 = false;
        public bool var2int2plusint2 = false;
        public bool var2int2timesint2 = false;
        public bool var2int1divint2 = false;
        public bool var2int2divint1 = false;
        public bool var2int1minint2 = false;
        public bool var2int2minint1 = false;
        public bool valueint1 = false;
        public bool valueint2 = false;
        public bool changeintplus1 = false;
        public bool changeintmin1 = false;
        public bool comparitoreq = false;
        public bool comparitornoteq = false;
        public bool comparitorless = false;
        public bool comparitorlesseq = false;
        public bool comparitorgreat = false;
        public bool comparitorgreateq = false;
        public void var1allfalse()
        {
            var1int1 = false;
            var1int2 = false;
            var1int1plusint1 = false;
            var1int1plusint2 = false;
            var1int1timesint1 = false;
            var1int1timesint2 = false;
            var1int2plusint2 = false;
            var1int2timesint2 = false;
            var1int1divint2 = false;
            var1int2divint1 = false;
            var1int1minint2 = false;
            var1int2minint1 = false;
        }
        public void var2allfalse()
        {
            var2int1 = false;
            var2int2 = false;
            var2int1plusint1 = false;
            var2int1plusint2 = false;
            var2int1timesint1 = false;
            var2int1timesint2 = false;
            var2int2plusint2 = false;
            var2int2timesint2 = false;
            var2int1divint2 = false;
            var2int2divint1 = false;
            var2int1minint2 = false;
            var2int2minint1 = false;
        }
        public void valueallfalse()
        {
            valueint1 = false;
            valueint2 = false;
        }
        public void changeallfalse()
        {
            changeintplus1 = false;
            changeintmin1 = false;
        }
        public void comparitorallfalse()
        {
            comparitoreq = false;
            comparitornoteq = false;
            comparitorless = false;
            comparitorlesseq = false;
            comparitorgreat = false;
            comparitorgreateq = false;
        }
        public void change()
        {
            if (valueint1 == true)
            {
                if (changeintplus1 == true)
                {
                    int1 += 1;
                }
                else if (changeintmin1 == true)
                {
                    int1 -= 1;
                }
            }
            else if (valueint2 == true)
            {
                if (changeintplus1 == true)
                {
                    int2 += 1;
                }
                else if (changeintmin1 == true)
                {
                    int2 -= 1;
                }
            }
        }
        public void varset()
        {
            input1int = int.TryParse(num1, out no1);
            input2int = int.TryParse(num2, out no2);
            if (var1int1plusint1 == true || var1int1timesint1 == true || var1int1 == true)
            {
                int1 = no1;
                int2 = no1;
            }
            else if (var1int1plusint2 == true || var1int1timesint2 == true || var1int1minint2 == true || var1int2minint1 == true || var1int1divint2 == true || var1int2divint1 == true)
            {
                int1 = no1;
                int2 = no2;
            }
            else if (var1int2plusint2 == true || var1int2timesint2 == true || var1int2 == true)
            {
                int1 = no2;
                int2 = no2;
            }

            if (input1int == true)
            {
                if (input2int == true)
                {
                    if (var1int2 == true)
                    {
                        var1 = int2;
                    }
                    else if (var1int2plusint2 == true)
                    {
                        var1 = int2 + int2;
                    }
                    else if (var1int2timesint2 == true)
                    {
                        var1 = int2 * int2;
                    }
                    else if (var1int1timesint2 == true)
                    {
                        var1 = int1 * int2;
                    }
                    else if (var1int1plusint2 == true)
                    {
                        var1 = int1 + int2;
                    }
                    else if (var1int1minint2 == true)
                    {
                        var1 = int1 - int2;
                    }
                    else if (var1int2minint1 == true)
                    {
                        var1 = int2 - int1;
                    }
                    else if (var1int1divint2 == true)
                    {
                        var1 = int1 / int2;
                    }
                    else if (var1int2divint1 == true)
                    {
                        var1 = int2 / int1;
                    }
                    else if (var1int1plusint1 == true)
                    {
                        var1 = int1 + int1;
                    }
                    else if (var1int1timesint1 == true)
                    {
                        var1 = int1 * int1;
                    }
                    else if (var1int1 == true)
                    {
                        var1 = int1;
                    }
                    else
                    {
                        label4.Text = "no bool true 1";
                    }
                }
                else
                {
                    label4.Text = "The second variable isn't equal to a whole number or is more than 9 digits";
                }
            }
            else
            {
                label4.Text = "The first variable isn't equal to a whole number or is more than 9 digits";
            }
            if (var2int1plusint1 == true || var2int1timesint1 == true || var2int1 == true)
            {
                int1 = no1;
                int2 = no1;
            }
            else if (var2int1plusint2 == true || var2int1timesint2 == true || var2int1minint2 == true || var2int2minint1 == true || var2int1divint2 == true || var2int2divint1 == true)
            {
                int1 = no1;
                int2 = no2;
            }
            else if (var2int2plusint2 == true || var2int2timesint2 == true || var2int2 == true)
            {
                int1 = no2;
                int2 = no2;
            }

            if (input1int == true)
            {
                if (input2int == true)
                {
                    if (var2int2 == true)
                    {
                        var2 = int2;
                    }
                    else if (var2int2plusint2 == true)
                    {
                        var2 = int2 + int2;
                    }
                    else if (var2int2timesint2 == true)
                    {
                        var2 = int2 * int2;
                    }
                    else if (var2int1timesint2 == true)
                    {
                        var2 = int1 * int2;
                    }
                    else if (var2int1plusint2 == true)
                    {
                        var2 = int1 + int2;
                    }
                    else if (var2int1minint2 == true)
                    {
                        var2 = int1 - int2;
                    }
                    else if (var2int2minint1 == true)
                    {
                        var2 = int2 - int1;
                    }
                    else if (var2int1divint2 == true)
                    {
                        var2 = int1 / int2;
                    }
                    else if (var2int2divint1 == true)
                    {
                        var2 = int2 / int1;
                    }
                    else if (var2int1plusint1 == true)
                    {
                        var2 = int1 + int1;
                    }
                    else if (var2int1timesint1 == true)
                    {
                        var2 = int1 * int1;
                    }
                    else if (var2int1 == true)
                    {
                        var2 = int1;
                    }
                    else
                    {
                        label4.Text = "no bool true 2";
                    }
                }
                else
                {
                    label4.Text = "The first variable isn't equal to a whole number or is more than 9 digits";
                }
            }
            else
            {
                label4.Text = "The first variable isn't equal to a whole number or is more than 9 digits";
            }
        }
public Form6()
        {
            InitializeComponent();
            var1allfalse();
            var2allfalse();
            comparitorallfalse();
            valueallfalse();
            changeallfalse();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int1text = textBox2.Text;
            toolStripMenuItem14.Text = int1text;
            toolStripMenuItem18.Text = int1text + "+" + int1text;
            toolStripMenuItem19.Text = int1text + "+" + int2text;
            toolStripMenuItem21.Text = int1text + "-" + int2text;
            toolStripMenuItem22.Text = int2text + "-" + int1text;
            toolStripMenuItem23.Text = int1text + "/" + int2text;
            toolStripMenuItem24.Text = int2text + "/" + int1text;
            toolStripMenuItem25.Text = int1text + "*" + int1text;
            toolStripMenuItem26.Text = int1text + "*" + int2text;
            int1ToolStripMenuItem1.Text = int1text;
            int1int1ToolStripMenuItem2.Text = int1text + "+" + int1text;
            int1int1ToolStripMenuItem3.Text = int1text + "*" + int1text;
            int1int2ToolStripMenuItem4.Text = int1text + "*" + int2text;
            int1int2ToolStripMenuItem5.Text = int1text + "+" + int2text;
            int1int2ToolStripMenuItem6.Text = int1text + "-" + int2text;
            int2int1ToolStripMenuItem2.Text = int2text + "-" + int1text;
            int1int2ToolStripMenuItem7.Text = int1text + "/" + int2text;
            int2int1ToolStripMenuItem3.Text = int2text + "/" + int1text;
            int1ToolStripMenuItem7.Text = int1text + "=";
            int1ToolStripMenuItem2.Text = int1text + "+1";
            int2ToolStripMenuItem1.Text = int1text + "-1";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int2text = textBox3.Text;
            toolStripMenuItem15.Text = int2text;
            toolStripMenuItem20.Text = int2text + "+" + int2text;
            toolStripMenuItem19.Text = int1text + "+" + int2text;
            toolStripMenuItem21.Text = int1text + "-" + int2text;
            toolStripMenuItem22.Text = int2text + "-" + int1text;
            toolStripMenuItem23.Text = int1text + "/" + int2text;
            toolStripMenuItem24.Text = int2text + "/" + int1text;
            toolStripMenuItem26.Text = int1text + "*" + int2text;
            toolStripMenuItem27.Text = int2text + "*" + int2text;
            int2ToolStripMenuItem.Text = int2text;
            int1int2ToolStripMenuItem4.Text = int1text + "*" + int2text;
            int2int2ToolStripMenuItem2.Text = int2text + "+" + int2text;
            int2int2ToolStripMenuItem3.Text = int2text + "*" + int2text;
            int1int2ToolStripMenuItem4.Text = int1text + "*" + int2text;
            int1int2ToolStripMenuItem5.Text = int1text + "+" + int2text;
            int1int2ToolStripMenuItem6.Text = int1text + "-" + int2text;
            int2int1ToolStripMenuItem2.Text = int2text + "-" + int1text;
            int1int2ToolStripMenuItem7.Text = int1text + "/" + int2text;
            int2int1ToolStripMenuItem3.Text = int2text + "/" + int1text;
            int2ToolStripMenuItem3.Text = int2text + "=";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            stringtext = textBox4.Text;
            actionToolStripMenuItem.Text = "and write " + stringtext;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            //var1int1
            var1allfalse();
            var1int1 = true;
            toolStripMenuItem13.Text = toolStripMenuItem14.Text;
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            //var1int2
            var1allfalse();
            var1int2 = true;
            toolStripMenuItem13.Text = toolStripMenuItem15.Text;
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            //var1int1+int1
            var1allfalse();
            var1int1plusint1 = true;
            toolStripMenuItem13.Text = toolStripMenuItem18.Text;
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            //var1int1 + int2
            var1allfalse();
            var1int1plusint2 = true;
            toolStripMenuItem13.Text = toolStripMenuItem19.Text;
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            //var1int2 + int2
            var1allfalse();
            var1int2plusint2 = true;
            toolStripMenuItem13.Text = toolStripMenuItem20.Text;
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            //var1int1 - int2
            var1allfalse();
            var1int1minint2 = true;
            toolStripMenuItem13.Text = toolStripMenuItem21.Text;
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            //var1int2 - int1
            var1allfalse();
            var1int2minint1 = true;
            toolStripMenuItem13.Text = toolStripMenuItem22.Text;
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            //var1int1 / int2
            var1allfalse();
            var1int1divint2 = true;
            toolStripMenuItem13.Text = toolStripMenuItem23.Text;
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            //var1int2 / int1
            var1allfalse();
            var1int2divint1 = true;
            toolStripMenuItem13.Text = toolStripMenuItem24.Text;
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            //var1int1 * int1
            var1allfalse();
            var1int1timesint1 = true;
            toolStripMenuItem13.Text = toolStripMenuItem25.Text;
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            //var1int1 * int2
            var1allfalse();
            var1int1timesint2 = true;
            toolStripMenuItem13.Text = toolStripMenuItem26.Text;
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            //var1int2* int2
            var1allfalse();
            var1int2timesint2 = true;
            toolStripMenuItem13.Text = toolStripMenuItem27.Text;
        }
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            //comparitor=
           comparitorallfalse();
            comparitoreq = true;
            toolStripMenuItem1.Text = toolStripMenuItem12.Text;
        }
        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            //comparitor !=
            comparitorallfalse();
            comparitornoteq = true;
            toolStripMenuItem1.Text = toolStripMenuItem29.Text;
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            //comparitor <
            comparitorallfalse();
            comparitorless = true;
            toolStripMenuItem1.Text = toolStripMenuItem30.Text;
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            //comparitor<=
            comparitorallfalse();
            comparitorlesseq = true;
            toolStripMenuItem1.Text = toolStripMenuItem31.Text;
        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            //comparitor>
            comparitorallfalse();
            comparitorgreat = true;
            toolStripMenuItem1.Text = toolStripMenuItem32.Text;
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            //comparitor>=
            comparitorallfalse();
            comparitorgreateq = true;
            toolStripMenuItem1.Text = toolStripMenuItem33.Text;
        }

        private void int1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //var2int1
            var2allfalse();
            var2int1 = true;
            int1ToolStripMenuItem.Text = int1ToolStripMenuItem1.Text;
        }

        private void int2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var2int2
            var2allfalse();
            var2int2 = true;
            int1ToolStripMenuItem.Text = int2ToolStripMenuItem.Text;
        }

        private void int1int1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //var2int1+int1
            var2allfalse();
            var2int1plusint1 = true;
            int1ToolStripMenuItem.Text = int1int1ToolStripMenuItem2.Text;
        }

        private void int1int1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //var2int1*int1
            var2allfalse();
            var2int1timesint1 = true;
            int1ToolStripMenuItem.Text = int1int1ToolStripMenuItem3.Text;
        }

        private void int1int2ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //var2int1*int2
            var2allfalse();
            var2int1timesint2 = true;
            int1ToolStripMenuItem.Text = int1int2ToolStripMenuItem4.Text;
        }

        private void int1int2ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //var2int1+int2
            var2allfalse();
            var2int1plusint2 = true;
            int1ToolStripMenuItem.Text = int1int2ToolStripMenuItem5.Text;
        }

        private void int2int2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //var2int2+int2
            var2allfalse();
            var2int2plusint2 = true;
            int1ToolStripMenuItem.Text = int2int2ToolStripMenuItem2.Text;
        }

        private void int2int2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //var2int2*int2
            var2allfalse();
            var2int2timesint2 = true;
            int1ToolStripMenuItem.Text = int2int2ToolStripMenuItem3.Text;
        }

        private void int1int2ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //var2int1-int2
            var2allfalse();
            var2int1minint2 = true;
            int1ToolStripMenuItem.Text = int1int2ToolStripMenuItem6.Text;
        }

        private void int2int1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //var2int2-int1
            var2allfalse();
            var2int2minint1 = true;
            int1ToolStripMenuItem.Text = int2int1ToolStripMenuItem2.Text;
        }

        private void int1int2ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //var2int1/int2
            var2allfalse();
            var2int1divint2 = true;
            int1ToolStripMenuItem.Text = int1int2ToolStripMenuItem7.Text;
        }

        private void int2int1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //var2int2/int1
            var2allfalse();
            var2int2divint1 = true;
            int1ToolStripMenuItem.Text = int2int1ToolStripMenuItem3.Text;
        }

        private void int1ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //valueint1=
            valueallfalse();
            valueint1 = true;
            comparitorToolStripMenuItem.Text = int1ToolStripMenuItem7.Text;
            int1ToolStripMenuItem2.Text = int1text + "+1";
            int2ToolStripMenuItem1.Text = int1text + "-1";
        }

        private void int2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //valueint2=
            valueallfalse();
            valueint2 = true;
            comparitorToolStripMenuItem.Text = int2ToolStripMenuItem3.Text;
            int1ToolStripMenuItem2.Text = int2text + "+1";
            int2ToolStripMenuItem1.Text = int2text + "-1";
        }

        private void int1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //changeint+1
            changeallfalse();
            changeintplus1 = true;
            var2ToolStripMenuItem.Text = int1ToolStripMenuItem2.Text;
        }

        private void int2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //changeint-1
            changeallfalse();
            changeintmin1 = true;
            var2ToolStripMenuItem.Text = int2ToolStripMenuItem1.Text;
        }

private void button1_Click(object sender, EventArgs e)
        {
            num1 = textBox6.Text;
            num2 = textBox7.Text;
            if (comparitoreq == true)
            {
                while (var1 == var2)
                {
                    count += 1;
                    varset();
                    label4.Text = textBox8.Text + " x" + count;
                    change();
                }
            }
            else if (comparitornoteq == true)
            {
                while (var1 != var2)
                {
                    count += 1;
                    varset();
                    label4.Text = textBox8.Text + " x" + count;
                    change();
                }
            }
            else if (comparitorless == true)
            {
                while (var1 < var2)
                {
                    count += 1;
                    varset();
                    label4.Text = textBox8.Text + " x" + count;
                    change();
                }
            }
            else if (comparitorlesseq == true)
            {
                while (var1 <= var2)
                {
                    count += 1;
                    varset();
                    label4.Text = textBox8.Text + " x" + count;
                    change();
                }
            }
            else if (comparitorgreat == true)
            {
                while (var1 > var2)
                {
                    count += 1;
                    varset();
                    label4.Text = textBox8.Text + " x" + count;
                    change();
                }
            }
            else if (comparitorgreateq == true)
            {
                while (var1 >= var2)
                {
                    count += 1;
                    varset();
                    label4.Text = textBox8.Text + " x" + count;
                    change();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3.complete5 = "complete";
            this.Owner.Show();
            this.Close();
        }
    }
}

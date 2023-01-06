using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Jerry Gama
namespace Calculator
{
    public partial class Form1 : Form
    {
        double Num1 = 0;
        double Num2 = 0;
        int operators;

    public Form1()
        {
            InitializeComponent();
            btnClear.Select();
            txtBox.Text += "0";

        }



    private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtBox.Clear();
            txtBox.Text = txtBox.Text + "0";
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBox.Text +=  "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBox.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBox.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBox.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBox.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBox.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBox.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBox.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBox.Text += "9";
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            txtBox.Text += ".";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case 1:
                    {
                        Num2 = Num1 + Double.Parse(txtBox.Text);
                        break;
                    }
                case 2:
                    {
                        Num2 = Num1 - Double.Parse(txtBox.Text);
                        break;
                    }
                case 3:
                    {
                        Num2 = Num1 * Double.Parse(txtBox.Text);
                        break;
                    }
                case 4:
                    {
                        Num2 = Num1 / Double.Parse(txtBox.Text);
                        break;
                    }
            }

            txtBox.Text = Num2.ToString();
            btnClear.Focus();
            Num1 = 0;
            Num2 = 0;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Num1 += Double.Parse(txtBox.Text);
            txtBox.Clear();
            operators = 1;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Num1 += Double.Parse(txtBox.Text);
            txtBox.Clear();
            operators = 2;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Num1 += Double.Parse(txtBox.Text);
            txtBox.Clear();
            operators = 3;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Num1 += Double.Parse(txtBox.Text);
            txtBox.Clear();
            operators = 4;

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

            /*

                if (txtBox.Text.StartsWith("0") && (txtBox.Text.Length > 1) && !(txtBox.Text.StartsWith("0.0")))
                {
                    txtBox.Text.Remove(0, 1);
                    txtBox.Text.Substring(1);
                }
            }
            */
                /*  while(txtBox.Text.StartsWith("0"))
                {
                if (txtBox.Text.Length > 0)
                {
                    txtBox.Text.TrimStart('0');
                    continue;
                }
            }
            */


        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            txtBox.Text += "0";

        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Num1 += Double.Parse(txtBox.Text);
            txtBox.Clear();
            operators = 1;
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Num1 += Double.Parse(txtBox.Text);
            txtBox.Clear();
            operators = 2;
        }

        private void multiplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Num1 += Double.Parse(txtBox.Text);
            txtBox.Clear();
            operators = 3;
        }

        private void divideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Num1 += Double.Parse(txtBox.Text);
            txtBox.Clear();
            operators = 4;
        }
    }
}

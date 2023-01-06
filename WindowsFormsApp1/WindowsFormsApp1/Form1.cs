using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTwoNumbers();
        }

        private void AddTwoNumbers()
        {
            Class1.AddTwoNumbers();
            Class1.AddTwoNumbers(3, 4);
            int FirstNum = 7;
            int SecNum = 12;
            Class1.AddTwoNumbers(FirstNum, SecNum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int RetVal;
            RetVal = Class1.AddTwoNumbersRet(3, 1);
            //now you can do whatever..show in messagebox or textbox
            //first method then return value then assign value
            RetVal = 0;
            RetVal = Class1.AddTwoNumbersRet(3, 1) +  Class1.AddTwoNumbersRet(3, 1);
            //f10(step over method) is what key (what does it do)
            //f11(step into method) is the how key (how does it work)
            RetVal = Class1.AddTwoNumbersRet(3,Class1.AddTwoNumbersRet(7, 2));
            //nested, the method inside gets done first because you need it to get (3, #)
            RetVal = Class1.AddTwoNumbersRet(3, Class1.AddTwoNumbersRet(7, 2)) * 2;

        }

        private void MnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //Menustrip
            //single click close in menu to rename it MnuClose
            // in menustrip - gives you seperator 
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            int RetVal = 0;
            int FirstNum = 100;
            int SecondNum = 200;
            RetVal = Class1.AddTwoNumbersVal(FirstNum, SecondNum);
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            int RetVal = 0;
            int FirstNum = 100;
            int SecondNum = 200;
            RetVal = Class1.AddTwoNumbersRef(ref FirstNum,ref SecondNum);
  //        RetVal = Class1.AddTwoNumbersOut(out int Num1, out int Num2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1.setBackColor(textBox1, Color.Aqua);
            Class1.setBackColor(button1, Color.Bisque);
            Class1.setBackColor(button3, Color.Coral);
        }
    }
}

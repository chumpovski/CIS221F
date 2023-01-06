using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Class1
    {

        public static void AddTwoNumbers()
            //static means dont need to make instance for this class?
        {
            int Num1 = 2;
            int Num2 = 3;
            int Answer = Num1 + Num2;
            MessageBox.Show(Answer.ToString());
        }

        public static void AddTwoNumbers(int Num1, int Num2)
        {
            int Answer = Num1 + Num2;
            MessageBox.Show(Answer.ToString());
        }

        public static int AddTwoNumbersRet(int Num1, int Num2)
        //void means return a value
        //Ret means return
        {

            //int Answer = Num1 + Num2;
            // return Answer;
            return Num1 + Num2;


            //datatype of expression has to match return type
        }

        public static int AddTwoNumbersVal(int Num1, int Num2)
        {
            int Answer = Num1 + Num2;
            Num1 = 500;
            return Answer;
        }

        public static int AddTwoNumbersRef(ref int Num1,ref int Num2)
        {
            int Answer = Num1 + Num2;
            Num1 = 500;
            return Answer;
        }

  //    public static int AddTwoNumbersOut(out int Num1, out int Num2)
 //     {
  //        Num1 = 5;
   //       Num2 = 10;
  //    }

        public static void setBackColor(Control myControl, Color myColor)
        {
            myControl.BackColor = myColor;
        }

    }
}

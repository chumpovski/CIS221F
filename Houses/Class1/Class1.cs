using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1
{
    public class Class1
    {
        private static int[] aBaths = new int[10];
        private static int[] aPersons = new int[10];
        private static double[] aIncome = new double[10];
        static int x = new int();

        public static void ProcessHouse(int HouseNum, int NumBaths, int Persons, double Income, ListBox lstHouses, TextBox txtAvgBaths, TextBox txtAvgPersons, TextBox txtAvgIncome)
        {
            ++x;
            if(x >= 10)
            {
                x = 10;
            }
            aBaths[HouseNum - 1] = NumBaths;
            aPersons[HouseNum - 1] = Persons;
            aIncome[HouseNum - 1] = Income;

            lstHouses.Items.Add(Convert.ToString(HouseNum) + "      " + "Baths: " + Convert.ToString(NumBaths) + "  " + "Persons: " + Convert.ToString(Persons) + "     " + "Income: " + Income.ToString("c2")); 

            new Class1().AverageBaths(txtAvgBaths);
            new Class1().AveragePersons(txtAvgPersons);
            new Class1().AverageIncome(txtAvgIncome);
            
        }
        private void AverageBaths(TextBox txtAvgBaths)
        {
            int avgbath = 0;
            int sumbath = 0;
            for(int i = 0; i < 10; i++)
            {
                sumbath += aBaths[i];
            }
            avgbath = sumbath / x;

            txtAvgBaths.Text = Convert.ToString(avgbath);
        }
        private void AveragePersons(TextBox txtAvgPersons)
        {
            int avgpersons = 0;
            int sumpersons = 0;
            for (int i = 0; i < 10; i++)
            {
                sumpersons += aPersons[i];
            }
            avgpersons = sumpersons / x;
            txtAvgPersons.Text = Convert.ToString(avgpersons);
        }
        private void AverageIncome(TextBox txtAvgIncome)
        {
            double avgincome = 0.00;
            double sumincome = 0.00;
            for (int i = 0; i < 10; i++)
            {
                sumincome += aIncome[i];
            }
            avgincome = sumincome / x;
            txtAvgIncome.Text = avgincome.ToString("c2");
        }
        public static void ClearForm(TextBox NumBaths, TextBox Persons, TextBox Income, ListBox lstHouses, TextBox txtAvgBaths, TextBox txtAvgPersons, TextBox txtAvgIncome)
        {
            x = 0;

            for(int i = 0; i < 10; i++)
            {
                aBaths[i] = 0;
                aPersons[i] = 0;
                aIncome[i] = 0;
            }

            NumBaths.Clear();
            //NumBaths.Text = 0.ToString();
            Persons.Clear();
            //Persons.Text = 0.ToString();
            Income.Clear();
            //Income.Text = 0.ToString();
            lstHouses.Items.Clear();


            txtAvgBaths.Clear();
            //txtAvgBaths.Text = Convert.ToString(0);
            txtAvgPersons.Clear();
            //txtAvgPersons.Text = Convert.ToString(0);
            txtAvgIncome.Clear();
            //txtAvgIncome.Text = 0.ToString("c2");

            NumBaths.Focus();
            

        }
    }
}

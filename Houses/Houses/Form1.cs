using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class1;

namespace Houses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Class1.Class1.ClearForm(txtBaths, txtPersons, txtIncome, lstHouses, txtAvgBaths, txtAvgPersons, txtAvgIncome);
        }

        private void btnHouse1_Click(object sender, EventArgs e)
        {
            Class1.Class1.ProcessHouse(1, Convert.ToInt32(txtBaths.Text), Convert.ToInt32(txtPersons.Text), Convert.ToDouble(txtIncome.Text), lstHouses, txtAvgBaths, txtAvgPersons, txtAvgIncome);
        }

        private void btnHouse2_Click(object sender, EventArgs e)
        {
            Class1.Class1.ProcessHouse(2, Convert.ToInt32(txtBaths.Text), Convert.ToInt32(txtPersons.Text), Convert.ToDouble(txtIncome.Text), lstHouses, txtAvgBaths, txtAvgPersons, txtAvgIncome);
        }

        private void btnHouse3_Click(object sender, EventArgs e)
        {
            Class1.Class1.ProcessHouse(3, Convert.ToInt32(txtBaths.Text), Convert.ToInt32(txtPersons.Text), Convert.ToDouble(txtIncome.Text), lstHouses, txtAvgBaths, txtAvgPersons, txtAvgIncome);
        }

        private void btnHouse4_Click(object sender, EventArgs e)
        {
            Class1.Class1.ProcessHouse(4, Convert.ToInt32(txtBaths.Text), Convert.ToInt32(txtPersons.Text), Convert.ToDouble(txtIncome.Text), lstHouses, txtAvgBaths, txtAvgPersons, txtAvgIncome);
        }

        private void btnHouse5_Click(object sender, EventArgs e)
        {
            Class1.Class1.ProcessHouse(5, Convert.ToInt32(txtBaths.Text), Convert.ToInt32(txtPersons.Text), Convert.ToDouble(txtIncome.Text), lstHouses, txtAvgBaths, txtAvgPersons, txtAvgIncome);
        }

        private void btnHouse6_Click(object sender, EventArgs e)
        {
           Class1.Class1.ProcessHouse(6, Convert.ToInt32(txtBaths.Text), Convert.ToInt32(txtPersons.Text), Convert.ToDouble(txtIncome.Text), lstHouses, txtAvgBaths, txtAvgPersons, txtAvgIncome);
        }

        private void btnHouse7_Click(object sender, EventArgs e)
        {
            Class1.Class1.ProcessHouse(7, Convert.ToInt32(txtBaths.Text), Convert.ToInt32(txtPersons.Text), Convert.ToDouble(txtIncome.Text), lstHouses, txtAvgBaths, txtAvgPersons, txtAvgIncome);
        }

        private void btnHouse8_Click(object sender, EventArgs e)
        {
            Class1.Class1.ProcessHouse(8, Convert.ToInt32(txtBaths.Text), Convert.ToInt32(txtPersons.Text), Convert.ToDouble(txtIncome.Text), lstHouses, txtAvgBaths, txtAvgPersons, txtAvgIncome);
        }

        private void btnHouse9_Click(object sender, EventArgs e)
        {
           Class1.Class1.ProcessHouse(9, Convert.ToInt32(txtBaths.Text), Convert.ToInt32(txtPersons.Text), Convert.ToDouble(txtIncome.Text), lstHouses, txtAvgBaths, txtAvgPersons, txtAvgIncome);
        }

        private void btnHouse10_Click(object sender, EventArgs e)
        {
            Class1.Class1.ProcessHouse(10, Convert.ToInt32(txtBaths.Text), Convert.ToInt32(txtPersons.Text), Convert.ToDouble(txtIncome.Text), lstHouses, txtAvgBaths, txtAvgPersons, txtAvgIncome);
        }

        private void txtBaths_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersons_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIncome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

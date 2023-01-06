using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ice_cream
{
    public partial class Form1 : Form
    {
        float Total = 0.00f;

        public Form1()
        {
            InitializeComponent();
            lBoxFlavors.SelectedIndex = 0;
            rdo1scoop.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        { 
            lBoxFlavors.ClearSelected();
            lBoxFlavors.SelectedIndex = 0;
            chBoxSprinkles.Checked = false;
            chBoxOreos.Checked = false;
            chBoxChocChips.Checked = false;
            ChBoxCherSyrp.Checked = false;
            ChBoxGumWrm.Checked = false;
            rdo1scoop.Select();
            rdo1scoop.Checked = true;

            
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text =  Total.ToString("c2");
     
        }

        private void rdo1scoop_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo1scoop.Checked == true)
            {
                Total += 1.00f;
            }
            else
            {
                Total -= 1.00f;
            }
            
        }

        private void rdo2scoop_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo2scoop.Checked == true)
            {
                Total += 2.00f;
            }
            else
            {
                Total -= 2.00f;
            }
        }

        private void rdo3scoop_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo3scoop.Checked == true)
            {
                Total += 3.00f;
            }
            else
            {
                Total -= 3.00f;
            }
        }

        private void chBoxSprinkles_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxSprinkles.Checked == true)
            {
                Total += .50f;
            }
            else if (chBoxSprinkles.Checked == false)
            {
                Total -= .50f;
            }
        }

        private void chBoxOreos_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxOreos.Checked == true)
            {
                Total += .50f;
            }
            else if (chBoxOreos.Checked == false)
            {
                Total -= .50f;
            }
        }

        private void chBoxChocChips_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxChocChips.Checked == true)
            {
                Total += .50f;
            }
            else if (chBoxChocChips.Checked == false)
            {
                Total -= .50f;
            }
        }

        private void ChBoxCherSyrp_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBoxCherSyrp.Checked == true)
            {
                Total += .50f;
            }
            else if (ChBoxCherSyrp.Checked == false)
            {
                Total -= .50f;
            }
        }

        private void ChBoxGumWrm_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBoxGumWrm.Checked == true)
            {
                Total += .50f;

            }
            else if (ChBoxGumWrm.Checked == false)
            {
                Total -= .50f;
            }
        }

        private void lBoxFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}

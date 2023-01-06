using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataSet myDS = new DataSet(); 
        private int nRow = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbCommand myComm = new OleDbCommand();
            OleDbConnection myConn = new OleDbConnection();
            OleDbDataAdapter myDA = new OleDbDataAdapter();

            myConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"H:\\Project 5.accdb\""; 
            myComm.CommandText = "SELECT Employees.ID, Employees.LastName, Employees.FirstName, Employees.Address1, Employees.Address2, Employees.City, Employees.State, Employees.Zip, Employees.PhoneNumber, Employees.DateBirth, Employees.DateHire, Employees.ActiveInd, DeptLookUp.Description AS DeptDesc, JobLookUp.Description AS JobDesc FROM ((Employees INNER JOIN DeptLookUp ON Employees.DeptCode = DeptLookUp.Code) INNER JOIN JobLookUp ON Employees.JobCode = JobLookUp.Code)";
            myComm.Connection = myConn;
            myDA.SelectCommand = myComm;
            myDA.Fill(myDS);

            nRow = 0;
            LoadFormControls();
        }
        
        private void LoadFormControls()
        {
            txtEmpID.Text = myDS.Tables[0].Rows[nRow]["ID"].ToString();  //ID is the field tabls is always [0]
            txtFirstName.Text = myDS.Tables[0].Rows[nRow]["FirstName"].ToString();
            txtLastName.Text = myDS.Tables[0].Rows[nRow]["LastName"].ToString();
            txtAddress.Text = myDS.Tables[0].Rows[nRow]["Address1"].ToString();
            txtAddress2.Text = myDS.Tables[0].Rows[nRow]["Address2"].ToString();
            txtCity.Text = myDS.Tables[0].Rows[nRow]["City"].ToString();
            txtState.Text = myDS.Tables[0].Rows[nRow]["State"].ToString();
            txtZip.Text = myDS.Tables[0].Rows[nRow]["Zip"].ToString();
            txtPhone.Text = myDS.Tables[0].Rows[nRow]["PhoneNumber"].ToString();
            txtDoB.Text = myDS.Tables[0].Rows[nRow]["DateBirth"].ToString();
            txtDoH.Text = myDS.Tables[0].Rows[nRow]["DateHire"].ToString();
            txtDept.Text = myDS.Tables[0].Rows[nRow]["DeptDesc"].ToString();
            txtJob.Text = myDS.Tables[0].Rows[nRow]["JobDesc"].ToString();
            chBoxActiveInd.Checked = Convert.ToBoolean(myDS.Tables[0].Rows[nRow]["ActiveInd"]);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            nRow = 0;
            LoadFormControls();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            nRow = myDS.Tables[0].Rows.Count - 1; 
            LoadFormControls();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nRow++;
            if (nRow >= myDS.Tables[0].Rows.Count)
            {
                nRow = myDS.Tables[0].Rows.Count - 1;
            }
            LoadFormControls();
        }

        private void btnPrior_Click(object sender, EventArgs e)
        {
            nRow--;
            if (nRow < 0)
                nRow = 0;
            LoadFormControls();
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click_1(object sender, EventArgs e)
        {
            nRow = 0;
            LoadFormControls();
        }

        private void btnPrior_Click_1(object sender, EventArgs e)
        {
            nRow--;
            if (nRow < 0)
                nRow = 0;
            LoadFormControls();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            nRow++;
            if (nRow >= myDS.Tables[0].Rows.Count)
            {
                nRow = myDS.Tables[0].Rows.Count - 1;
            }
            LoadFormControls();
        }

        private void btnLast_Click_1(object sender, EventArgs e)
        {
            nRow = myDS.Tables[0].Rows.Count - 1;
            LoadFormControls();
        }



        /*
         *        
         *        if(chBoxActiveInd.Checked == true)
            {
                
            }
            else if (chBoxActiveInd.Checked == false)
            {

            }
            */
    }
}

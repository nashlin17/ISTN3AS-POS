using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ISTN3AS
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



          



            salesControl lgs = new salesControl();
            this.Hide();
            lgs.ShowDialog();
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            managerScreen mngSc = new managerScreen();
            this.Hide();
            mngSc.ShowDialog();
            this.Dispose();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group6DataSet.StaffTbl' table. You can move, or remove it, as needed.
            this.staffTblTableAdapter.Fill(this.group6DataSet.StaffTbl);
            Boolean bflag = false;
            string status = "";
            string username = "";

            btnStaff.Enabled = false;
            button2.Enabled = false;



            foreach (DataGridViewRow row2 in logGrid.Rows)
            {
                username = row2.Cells[2].Value.ToString();

                if (GlobalVariables.username == username)
                {
                    status = row2.Cells[4].Value.ToString();
                    break;
                }

            }


            if (status == "Employee" || status == "Inventory" || status == "Cashier" ) 
            {
                btnStaff.Enabled = true;
            }
            else if (status == "CEO" || status == "Manager" )
            {
                button2.Enabled = true;
                btnStaff.Enabled = true;
            }

        }
    }
}

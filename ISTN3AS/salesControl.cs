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
    public partial class salesControl : Form
    {
        cls_itemComp sc = new cls_itemComp();
      
        public salesControl()
        {
            InitializeComponent();
        
            sc.Intialise(this);
            sc.Hidebuttons(this);
            tabcontrol1.SelectedTab = purchase;
            tabcontrol1.Size = new Size(1382, 734);
            btnItems.Enabled = false;


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            sc.Showbuttons(this);
            tabcontrol1.SelectedTab = cat1;
            tabcontrol1.Size = new Size(307, 640);




        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            sc.Hidebuttons(this);
            tabcontrol1.SelectedTab = purchase;
            
          
        }

        private void btnCat1_Click(object sender, EventArgs e)
        {
            tabcontrol1.SelectedTab = cat1;
        }

        private void btnCat2_Click(object sender, EventArgs e)
        {
            tabcontrol1.SelectedTab = cat2;
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnCustAcc_Click(object sender, EventArgs e)
        {
            sc.Hidebuttons(this);
            tabcontrol1.SelectedTab = memberAcc;
         
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            sc.Hidebuttons(this);
            tabcontrol1.SelectedTab = orders;
            tabcontrol1.Size = new Size(1382, 734);

        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            sc.Hidebuttons(this);
            tabcontrol1.SelectedTab = returnItem;
            tabcontrol1.Size = new Size(1382, 734);

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            sc.Hidebuttons(this);
            tabcontrol1.SelectedTab = accCreate;
            tabcontrol1.Size = new Size(1382, 734);
          
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCat3_Click(object sender, EventArgs e)
        {
            tabcontrol1.SelectedTab = cat3;
          
        }

        private void btnCat4_Click(object sender, EventArgs e)
        {
            tabcontrol1.SelectedTab = cat4;
       
        }

        private void btnCat5_Click(object sender, EventArgs e)
        {
            tabcontrol1.SelectedTab = cat5;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form payment = new payment(this);
            payment.ShowDialog();

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

      

        private void rgbOrdMem_Click(object sender, EventArgs e)
        {
            if (rgbOrdMem.Checked == true)
            {

                rgbOrdCust.Checked = false;
            }
        }

        private void rgbOrdCust_Click(object sender, EventArgs e)
        {
            if (rgbOrdCust.Checked == true)
            {
                rgbOrdMem.Checked = false;
            }
        }

        private void rgbStCust_CheckedChanged(object sender, EventArgs e)
        {
            if (rgbStCust.Checked==true)
            {
                lblStMem.Enabled = false;
                tbxStMem.Enabled = false;
            }
        }

        private void rgbStMem_CheckedChanged(object sender, EventArgs e)
        {
            if (rgbStMem.Checked == true)
            {
                lblStMem.Enabled = true;
                tbxStMem.Enabled = true;
            }
        }

        private void rgbOrdCust_CheckedChanged(object sender, EventArgs e)
        {
            if (rgbOrdCust.Checked == true)
            {
                lblOrdMem.Enabled = false;
                tbxOrdMem.Enabled = false;

                lblOrdCell.Enabled = true;
                lblOrdName.Enabled = true;
                lblOrdNo.Enabled = true;
                tbxOrdName.Enabled = true;
                tbxOrdCell.Enabled = true;
                tbxOrdNo.Enabled = true;
            }
        }

        private void rgbOrdMem_CheckedChanged(object sender, EventArgs e)
        {
            if (rgbOrdMem.Checked == true)
            {
                lblOrdMem.Enabled = true;
                tbxOrdMem.Enabled = true;

                lblOrdCell.Enabled = false;
                lblOrdName.Enabled = false;
                lblOrdNo.Enabled = false;
                tbxOrdName.Enabled = false;
                tbxOrdCell.Enabled = false;
                tbxOrdNo.Enabled = false;
            }
        }

        private void btnMenuPurchase_Click(object sender, EventArgs e)
        {
            sc.Purchase(this);
            sc.Showbuttons(this);
            tabcontrol1.SelectedTab = cat1;
            tabcontrol1.Size = new Size(307, 640);
            btnCashOut.Enabled = false;
            btnItems.Enabled = true;
        }

        private void btnMenuOrder_Click(object sender, EventArgs e)
        {
            sc.Order(this);
            sc.Showbuttons(this);
            tabcontrol1.SelectedTab = cat1;
            tabcontrol1.Size = new Size(307, 640);
            btnCashOut.Enabled = false;
            btnItems.Enabled = true;
        }

        private void salesControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group6DataSet.ProductTbl' table. You can move, or remove it, as needed.
            this.productTblTableAdapter.Fill(this.group6DataSet.ProductTbl);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void cat2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

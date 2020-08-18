﻿using ISTN3AS.ProductDSTableAdapters;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISTN3AS
{
    public partial class salesControl : Form
    {
        cls_itemComp sc = new cls_itemComp();
        private bool filterOn = false;
        private bool filterCategory = false;
        String FilterParameters = "";

        public salesControl()
        {
            InitializeComponent();

            sc.Intialise(this);
            sc.Hidebuttons(this);
            tabcontrol1.SelectedTab = purchase;
            tabcontrol1.Size = new Size(1382, 734);
            btnItems.Enabled = false;


        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            sc.Showbuttons(this);
            //tabcontrol1.SelectedTab = cat1;
            tabcontrol1.Size = new Size(307, 640);
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            sc.Hidebuttons(this);
            //tabcontrol1.SelectedTab = purchase;


        }

        private void btnCat1_Click(object sender, EventArgs e)
        {
            //tabcontrol1.SelectedTab = cat1;
            categorySelceted("T-Shirt");
            lblCategory.Text = "T-Shirts";
        }

        private void btnCat2_Click(object sender, EventArgs e)
        {
            //tabcontrol1.SelectedTab = cat2;
            categorySelceted("Shoe");
            lblCategory.Text = "Shoe";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            sc.Hidebuttons(this);
            tabcontrol1.SelectedTab = accCreate;
            tabcontrol1.Size = new Size(1382, 734);

        }

        private void btnCat3_Click(object sender, EventArgs e)
        {
            //tabcontrol1.SelectedTab = cat3;
            categorySelceted("Cap");
            lblCategory.Text = "Caps";

        }

        private void btnCat4_Click(object sender, EventArgs e)
        {
            //tabcontrol1.SelectedTab = cat4;
            categorySelceted("Accessories");
            lblCategory.Text = "Accessories";
        }

        private void btnCat5_Click(object sender, EventArgs e)
        {
            //tabcontrol1.SelectedTab = cat5;
            categorySelceted("Equipment");
            lblCategory.Text = "Equipment";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.TransactionType.Equals("Store"))
            {
                Form payment = new payment(this);
                payment.ShowDialog();
            }
            else
            {
                //Add to Phone Order Table.
                phoneOrderTableAdapter.Insert(Decimal.Parse(GlobalVariables.cartTotal.ToString()),GlobalVariables.customerName_Order,GlobalVariables.customerCellNo_Order,GlobalVariables.StaffID, null);

                int maxID = int.Parse(phoneOrderTableAdapter.getMaxID().ToString());
                //MessageBox.Show(maxID.ToString()) ;
                for (int i = 0; i < GlobalVariables.productCart_ProductID.Count(); i++)
                {
                    phoneOrderLineTblTableAdapter.Insert(maxID, int.Parse(GlobalVariables.productCart_ProductID.ElementAt(i)), Decimal.Parse(GlobalVariables.productCart_UnitPrice.ElementAt(i).ToString()), GlobalVariables.productCart_Quantity.ElementAt(i));
                }

                this.phoneOrderLineTblTableAdapter.Fill(this.productDS.PhoneOrderLineTbl);
                this.phoneOrderTableAdapter.Fill(this.productDS.PhoneOrder);

                tabcontrol1.SelectedTab = orders;
                tabcontrol1.Size = new Size(1280, 566);
            }



        }

        private void rgbOrdMem_Click(object sender, EventArgs e)
        {
            //if (rgbOrdMem.Checked == true)
            //{

            //    rgbOrdCust.Checked = false;
            //}
        }

        private void rgbOrdCust_Click(object sender, EventArgs e)
        {
            //if (rgbOrdCust.Checked == true)
            //{
            //    //rgbOrdMem.Checked = false;
            //}
        }

        private void rgbStCust_CheckedChanged(object sender, EventArgs e)
        {
            //if (rgbStCust.Checked == true)
            //{
            //    lblStMem.Enabled = false;
            //    tbxStMem.Enabled = false;
            //}
        }

        private void rgbStMem_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxIsMemeber_Purchase.Checked)
            {
                lblStMem.Enabled = true;
                tbxStMem.Enabled = true;
            }
            else { tbxStMem.Enabled = false; }
        }

        private void rgbOrdCust_CheckedChanged(object sender, EventArgs e)
        {
            //if (rgbOrdCust.Checked == true)
            //{
            //   // lblOrdMem.Enabled = false;
            //   // tbxOrdMem.Enabled = false;

            //    lblOrdCell.Enabled = true;
            //    lblOrdName.Enabled = true;
            //    lblOrdNo.Enabled = true;
            //    tbxOrdName.Enabled = true;
            //    tbxOrdCell.Enabled = true;
            //    tbxOrdNo.Enabled = true;
            //}
        }

        private void rgbOrdMem_CheckedChanged(object sender, EventArgs e)
        {
            //if (rgbOrdMem.Checked == true)
            //{
            //   // lblOrdMem.Enabled = true;
            //    //tbxOrdMem.Enabled = true;

            //    lblOrdCell.Enabled = false;
            //    lblOrdName.Enabled = false;
            //    lblOrdNo.Enabled = false;
            //    tbxOrdName.Enabled = false;
            //    tbxOrdCell.Enabled = false;
            //    tbxOrdNo.Enabled = false;
            //}
        }

        private void btnMenuPurchase_Click(object sender, EventArgs e)
        {
            if (chbxStoreOrder_Purchase.Checked)
            {
                GlobalVariables.TransactionType = "Store";
            }
            else { GlobalVariables.TransactionType = "Phone"; }
            GlobalVariables.customerName_Order = tbxCustomerOrdName_BeginPurchase.Text;
            GlobalVariables.customerCellNo_Order = tbxCustomerOrdCell_BeginPurchase.Text;

            
            sc.Purchase(this);
            sc.Showbuttons(this);
            tabcontrol1.SelectedTab = cat4;
            this.categoryFIlterTA.AllProducts(this.productDS.CategoryFIlter);
            tabcontrol1.Size = new Size(242, 640);
            btnCashOut.Enabled = false;
            btnItems.Enabled = true;


            cbxCategory_Purchase.SelectedIndex = -1;

            filterCategory = true;

        }

        private void btnMenuOrder_Click(object sender, EventArgs e)
        {
        }

        private void salesControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDS.PhoneOrderLineTbl' table. You can move, or remove it, as needed.
            

            chbxStoreOrder_Purchase.CheckState = CheckState.Checked;
            pnlContactDetails_Purchase.Enabled = false;


            //MessageBox.Show(GlobalVariables.StaffID.ToString());
            // TODO: This line of code loads data into the 'group6DataSet.MemberTbl' table. You can move, or remove it, as needed.
            this.memberTblTableAdapter.Fill(this.group6DataSet.MemberTbl);
            this.categoryTblTableAdapter.populateCategory(this.productFilterDS.CategoryTbl);

            tbxAccountNo_AccCreation.ReadOnly = true;
            //lblProductID_Purchase.Visible = false;

            Quantity_Control.Value = 1;
            lblTotal.Text = "Total : ";


            lsvProductCart_Control.View = View.Details;

            lsvProductCart_Control.Columns.Add("Player Name");
            lsvProductCart_Control.Columns[0].Width = 203;
            lsvProductCart_Control.Columns.Add("Qty");
            lsvProductCart_Control.Columns[1].TextAlign = HorizontalAlignment.Center;
            lsvProductCart_Control.Columns.Add("Total");
            lsvProductCart_Control.Columns[2].TextAlign = HorizontalAlignment.Center;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tbxAddress_AccCreation.Clear();
            tbxCell_AccCreation.Clear();
            tbxCustAccPass.Clear();
            tbxEmail_AccCreation.Clear();
            tbxName_AccCreation.Clear();
            tbxSurname_AccCreation.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (tbxCell_AccCreation.TextLength == 10 & (tbxEmail_AccCreation.Text.Contains("@")))
            {
               string AccNumber = tbxID_AccCreation.Text.Substring(0, 6) + tbxName_AccCreation.Text.ElementAt(0) + tbxSurname_AccCreation.Text.ElementAt(0) + memberTblTableAdapter.maxID();
                tbxAccountNo_AccCreation.Text = AccNumber;
               memberTblTableAdapter.Insert(tbxName_AccCreation.Text, tbxSurname_AccCreation.Text, tbxCell_AccCreation.Text, tbxAddress_AccCreation.Text, tbxEmail_AccCreation.Text, tbxID_AccCreation.Text,AccNumber);
               this.memberTblTableAdapter.Fill(this.group6DataSet.MemberTbl);
                MessageBox.Show(AccNumber);
            }
            else { MessageBox.Show("Please Re-Enter PhoneNumber or Email"); }
            
        }


        private void categorySelceted(string category)
        {
            filterOn = false;
            try
            {
                this.categoryFIlterTA.FilterCategory(this.productDS.CategoryFIlter, category);
                cbxDefaultIndex();
                //FilterParameters = "";
                this.colourTblTableAdapter1.populateColour(this.productFilterDS.ColourTbl, category);
                this.brandTblTableAdapter1.populateBrand(this.productFilterDS.BrandTbl, category);
                this.sizeTblTableAdapter1.populateSize(this.productFilterDS.SizeTbl, category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            cbxDefaultIndex();  
            filterOn = true;
        }

        private void cbxDefaultIndex()
        {
            cbxColour_Accessories.SelectedIndex = -1;
            cbxBrand_Accessories.SelectedIndex = -1;
            cbxSize_Accessories.SelectedIndex = -1;
            categoryFIlterBS.RemoveFilter();
            //FilterParameters = "";
        }

        private void cbxSize_Accessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterOn)
            {
                FilterProducts();
            }
            
        }

        private void cbxBrand_Accessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterOn)
            {
               FilterProducts();
            }
        }

        private void cbxColour_Accessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterOn)
            {
                FilterProducts();
            }
            
        }

        private void FilterProducts()
        {
            FilterParameters = "";
            if (cbxColour_Accessories.SelectedIndex != -1)
            {
                if (FilterParameters.Length == 0)
                {
                    FilterParameters += "Colour = '" + cbxColour_Accessories.Text + "'";
                }
                else
                {
                    FilterParameters += "AND Colour = '" + cbxColour_Accessories.Text + "'";
                }
            }
            if (cbxBrand_Accessories.SelectedIndex != -1)
            {
                if (FilterParameters.Length == 0)
                {
                    FilterParameters += "BrandName = '" + cbxBrand_Accessories.Text + "'";
                }
                else
                {
                    FilterParameters += "AND BrandName = '" + cbxBrand_Accessories.Text + "'";
                }
            }
            if (cbxSize_Accessories.SelectedIndex != -1)
            {
                if (FilterParameters.Length == 0)
                {
                    
                    FilterParameters += "Size = '" + cbxSize_Accessories.Text + "'";
                }
                else
                {
                    FilterParameters += " AND Size = '" + cbxSize_Accessories.Text + "'";
                }
            }
            if (filterOn)
            {
                categoryFIlterBS.Filter = FilterParameters;
            }
               
        }

        private void cbxCategory_Purchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterCategory)
            {
                categorySelceted(cbxCategory_Purchase.Text);
                lblCategory.Text = cbxCategory_Purchase.Text;
            }
            

        }

        List<String> Cart = new List<string>();
        //double cartTotal = 0;
        private void btnShoePurchase_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.TransactionType.Equals("Store"))
            {
                try
                {
                    this.selectProductIDTableAdapter.selectID(this.productDS.selectProductID, categoryFIlterDataGridView.CurrentRow.Cells[3].Value.ToString(), categoryFIlterDataGridView.CurrentRow.Cells[4].Value.ToString(), categoryFIlterDataGridView.CurrentRow.Cells[0].Value.ToString());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                this.getProductDiscountTableAdapter.getDiscount(this.productDS.getProductDiscount, int.Parse(lblProductID_Purchase.Text));
                //int.Parse(lblProductID_Purchase.Text)
                double tprice = (Double.Parse(Quantity_Control.Value.ToString()) * Double.Parse(categoryFIlterDataGridView.CurrentRow.Cells[1].Value.ToString()) - Double.Parse(lblProductDiscount.Text));

                GlobalVariables.productCart_ProductID.Add(lblProductID_Purchase.Text);
                GlobalVariables.productCart_UnitPrice.Add(tprice);
                GlobalVariables.productCart_Quantity.Add(int.Parse(Quantity_Control.Value.ToString()));

                lsvProductCart_Control.Items.Add(new ListViewItem(new[] { categoryFIlterDataGridView.CurrentRow.Cells[0].Value.ToString(), Quantity_Control.Value.ToString(), (Double.Parse(Quantity_Control.Value.ToString()) * Double.Parse(categoryFIlterDataGridView.CurrentRow.Cells[1].Value.ToString()) - Double.Parse(lblProductDiscount.Text)).ToString() }));
                GlobalVariables.cartTotal += tprice;
                lblTotal.Text = "Total : " + GlobalVariables.cartTotal.ToString();
            }
            else
            {
                try
                {
                    this.selectProductIDTableAdapter.selectID(this.productDS.selectProductID, categoryFIlterDataGridView.CurrentRow.Cells[3].Value.ToString(), categoryFIlterDataGridView.CurrentRow.Cells[4].Value.ToString(), categoryFIlterDataGridView.CurrentRow.Cells[0].Value.ToString());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                this.getProductDiscountTableAdapter.getDiscount(this.productDS.getProductDiscount, int.Parse(lblProductID_Purchase.Text));
                //int.Parse(lblProductID_Purchase.Text)
                double tprice = (Double.Parse(Quantity_Control.Value.ToString()) * Double.Parse(categoryFIlterDataGridView.CurrentRow.Cells[1].Value.ToString()) - Double.Parse(lblProductDiscount.Text));

                GlobalVariables.productCart_ProductID.Add(lblProductID_Purchase.Text);
                GlobalVariables.productCart_UnitPrice.Add(tprice);
                GlobalVariables.productCart_Quantity.Add(int.Parse(Quantity_Control.Value.ToString()));

                lsvProductCart_Control.Items.Add(new ListViewItem(new[] { categoryFIlterDataGridView.CurrentRow.Cells[0].Value.ToString(), Quantity_Control.Value.ToString(), (Double.Parse(Quantity_Control.Value.ToString()) * Double.Parse(categoryFIlterDataGridView.CurrentRow.Cells[1].Value.ToString()) - Double.Parse(lblProductDiscount.Text)).ToString() }));
                GlobalVariables.cartTotal += tprice;
                lblTotal.Text = "Total : " + GlobalVariables.cartTotal.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lsvProductCart_Control.SelectedItems)
            {
                GlobalVariables.cartTotal -= Double.Parse(lsvProductCart_Control.SelectedItems[0].SubItems[2].Text);
                lblTotal.Text = "Total : " + GlobalVariables.cartTotal.ToString();
                lsvProductCart_Control.Items.Remove(eachItem);
            }
            try
            {
                GlobalVariables.productCart_ProductID.RemoveAt(lsvProductCart_Control.FocusedItem.Index);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Select a Product to Remove");
            }
            
            //MessageBox.Show(GlobalVariables.productCart.Count().ToString());
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(chbxPhoneOrder_Purchase.Checked)
            {
                chbxStoreOrder_Purchase.CheckState = CheckState.Unchecked;
                pnlContactDetails_Purchase.Enabled = true;
            }
            else { 
                pnlContactDetails_Purchase.Enabled = false;
                chbxStoreOrder_Purchase.CheckState = CheckState.Checked;
            }
        }

        private void chbxStoreOrder_Purchase_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxStoreOrder_Purchase.Checked)
            {
                chbxPhoneOrder_Purchase.CheckState = CheckState.Unchecked;
            }
            else { chbxPhoneOrder_Purchase.CheckState = CheckState.Checked; }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}

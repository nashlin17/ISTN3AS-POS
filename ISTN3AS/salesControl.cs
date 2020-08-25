using ISTN3AS.ProductDSTableAdapters;
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
using System.Windows.Forms.VisualStyles;

namespace ISTN3AS
{
    public partial  class salesControl : Form
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
            tabcontrol1.Size = new Size(1285, 582);


        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            sc.Showbuttons(this);
            //tabcontrol1.SelectedTab = cat1;
            tabcontrol1.Size = new Size(307, 640);
            grpBoxDBgrid.Size = new Size(692, 533);
            gbItemsScroll.Size = new Size(321, 533);
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            GlobalVariables.Clear();
            sc.Hidebuttons(this);
            tabcontrol1.SelectedTab = purchase;  
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
            //tabcontrol1.SelectedTab = memberAcc;

        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            sc.Hidebuttons(this);

            this.phoneOrderLineTblTableAdapter.Fill(this.productDS.PhoneOrderLineTbl);
            this.phoneOrderTableAdapter.Fill(this.productDS.PhoneOrder);

            tabcontrol1.SelectedTab = orders;
            //tabcontrol1.Size = new Size(1280, 566);

            tabcontrol1.Size = new Size(1267, 582);

        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            lsvReturnItems_Returns.Items.Clear();
            GlobalVariables.Clear();
            this.orderLineTblTableAdapter.Fill(this.productDS.OrderLineTbl);
            this.orderTblTableAdapter.Fill(this.productDS.OrderTbl);
            sc.Hidebuttons(this);
            tabcontrol1.SelectedTab = returnItem;
            tabcontrol1.Size = new Size(1267, 582);

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            sc.Hidebuttons(this);
            tabcontrol1.SelectedTab = accCreate;
            tabcontrol1.Size = new Size(1267, 582);

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
                if (GlobalVariables.isMemeber)
                {
                    phoneOrderTableAdapter.Insert(Decimal.Parse(GlobalVariables.cartTotal.ToString()), GlobalVariables.customerName_Order, GlobalVariables.customerCellNo_Order, GlobalVariables.StaffID, GlobalVariables.MemberID);
                }
                else
                {
                    phoneOrderTableAdapter.Insert(Decimal.Parse(GlobalVariables.cartTotal.ToString()), GlobalVariables.customerName_Order, GlobalVariables.customerCellNo_Order, GlobalVariables.StaffID, null);
                }

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

                GlobalVariables.Clear();
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
            bool checkError = true;
            GlobalVariables.Clear();
            if (chbxStoreOrder_Purchase.Checked)
            {
                GlobalVariables.TransactionType = "Store";
            }
            else { 
                GlobalVariables.TransactionType = "Phone";
                if (!tbxCustomerOrdName_BeginPurchase.Text.Equals("") && !tbxCustomerOrdCell_BeginPurchase.Text.Equals(""))
                {
                    GlobalVariables.customerName_Order = tbxCustomerOrdName_BeginPurchase.Text;
                    GlobalVariables.customerCellNo_Order = tbxCustomerOrdCell_BeginPurchase.Text;
                }
                else { 
                    MessageBox.Show("Please Enter Contact Details");
                    checkError = false;
                }
            }
            

            getAccountIDTableAdapter.Fill(group6DataSet.getAccountID,tbxStMem.Text);
            if (chbxIsMemeber_Purchase.Checked && bool.Parse(queries1.CheckAccNum(tbxStMem.Text).ToString()))
            {
                try
                {
                    if (getAccountIDDataGridView.Rows.Count > 0)
                    {
                        GlobalVariables.MemberID = int.Parse(getAccountIDDataGridView.Rows[0].Cells[0].Value.ToString());
                        GlobalVariables.isMemeber = true;
                        GlobalVariables.AccDiscount = 0.05;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Please Enter a Valid Account Number");
                }
                
            }
            if (checkError)
            {
                sc.Purchase(this);
                sc.Showbuttons(this);
                tabcontrol1.SelectedTab = cat4;
                this.categoryFIlterTA.AllProducts(this.productDS.CategoryFIlter);
                filterOn = true;
                tabcontrol1.Size = new Size(230, 559);
                btnCashOut.Enabled = false;

                cbxCategory_Purchase.SelectedIndex = -1;
                filterCategory = true;
            }
        }

        private void btnMenuOrder_Click(object sender, EventArgs e)
        {
        }

        private void salesControl_Load(object sender, EventArgs e)
        {
            //Load All Tables
            this.sizesTableAdapter.Fill(this.productFilterDS.Sizes);
            this.coloursTableAdapter.Fill(this.productFilterDS.Colours);
            this.brandsTableAdapter.Fill(this.productFilterDS.Brands);
            this.orderLineTblTableAdapter.Fill(this.productDS.OrderLineTbl);
            this.orderTblTableAdapter.Fill(this.productDS.OrderTbl);
            this.orderTblTableAdapter.Fill(this.productDS.OrderTbl);
     
            tbxStMem.Enabled = false;
            chbxStoreOrder_Purchase.CheckState = CheckState.Checked;
            pnlContactDetails_Purchase.Enabled = false;
            //
            //CBXAttributes
            //
            for (int i = 0; i < brandsDataGridView.Rows.Count - 1; i++)
            {
                cbxBrand_Accessories.Items.Add(brandsDataGridView.Rows[i].Cells[0].Value.ToString());
            }
            for (int i = 0; i < coloursDataGridView.Rows.Count - 1; i++)
            {
                cbxColour_Accessories.Items.Add(coloursDataGridView.Rows[i].Cells[1].Value.ToString());
            }
            for (int i = 0; i < sizesDataGridView.Rows.Count - 1; i++)
            {
                cbxSize_Accessories.Items.Add(sizesDataGridView.Rows[i].Cells[1].Value.ToString());
            }

            //MessageBox.Show(GlobalVariables.StaffID.ToString());
            // TODO: This line of code loads data into the 'group6DataSet.MemberTbl' table. You can move, or remove it, as needed.
            this.memberTblTableAdapter.Fill(this.group6DataSet.MemberTbl);
            this.categoryTblTableAdapter.populateCategory(this.productFilterDS.CategoryTbl);

            tbxAccountNo_AccCreation.ReadOnly = true;
            //lblProductID_Purchase.Visible = false;

            Quantity_Control.Value = 1;
            lblTotal.Text = "Total : ";

            //ListView Columns
            lsvProductCart_Control.View = View.Details;

            lsvProductCart_Control.Columns.Add("Player Name");
            lsvProductCart_Control.Columns[0].Width = 203;
            lsvProductCart_Control.Columns.Add("Qty");
            lsvProductCart_Control.Columns[1].TextAlign = HorizontalAlignment.Center;
            lsvProductCart_Control.Columns.Add("Total");
            lsvProductCart_Control.Columns[2].TextAlign = HorizontalAlignment.Center;

            lsvReturnItems_Returns.View = View.Details;

            lsvReturnItems_Returns.Columns.Add("Player Name");
            lsvReturnItems_Returns.Columns[0].Width = 203;
            lsvReturnItems_Returns.Columns.Add("Qty");
            lsvReturnItems_Returns.Columns[1].TextAlign = HorizontalAlignment.Center;
            lsvReturnItems_Returns.Columns.Add("Total");
            lsvReturnItems_Returns.Columns[2].TextAlign = HorizontalAlignment.Center;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tbxAddress_AccCreation.Clear();
            tbxCell_AccCreation.Clear();
            //tbxCustAccPass.Clear();
            tbxEmail_AccCreation.Clear();
            tbxName_AccCreation.Clear();
            tbxSurname_AccCreation.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //Acc Number  = BirthDay + FirstLetter ofName + FirstLetter of Surname + MemberID
            if (checkAllFieldsFilled())
            {
                if (tbxCell_AccCreation.TextLength == 10 & (tbxEmail_AccCreation.Text.Contains("@")))
                {
                    string AccNumber = tbxID_AccCreation.Text.Substring(0, 6) + tbxName_AccCreation.Text.ElementAt(0) + tbxSurname_AccCreation.Text.ElementAt(0) + memberTblTableAdapter.maxID();
                    tbxAccountNo_AccCreation.Text = AccNumber;
                    memberTblTableAdapter.Insert(tbxName_AccCreation.Text, tbxSurname_AccCreation.Text, tbxCell_AccCreation.Text, tbxAddress_AccCreation.Text, tbxEmail_AccCreation.Text, tbxID_AccCreation.Text, AccNumber);
                    this.memberTblTableAdapter.Fill(this.group6DataSet.MemberTbl);
                    MessageBox.Show("Please Store this Number\n" + AccNumber, tbxName_AccCreation.Text + "'s Account Number");
                    resetAccCreation();
                }
                else { MessageBox.Show("Please Re-Enter PhoneNumber or Email"); }
            }
            else { MessageBox.Show("Enter Values for All Fields"); }


        }
        private bool checkAllFieldsFilled()
        {
            if (tbxAddress_AccCreation.Text.Equals("") || tbxEmail_AccCreation.Equals("") || tbxName_AccCreation.Equals("") || tbxSurname_AccCreation.Equals("") || tbxID_AccCreation.Equals("") || tbxAddress_AccCreation.Equals(""))
            {
                return false;
            }
            else { return true; }
            
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
                if (cbxCategory_Purchase.SelectedIndex == -1)
                {
                    this.categoryFIlterTA.AllProducts(this.productDS.CategoryFIlter);
                }
                else
                {
                    loadCBX();
                    categorySelceted(cbxCategory_Purchase.Text);
                    lblCategory.Text = cbxCategory_Purchase.Text;
                }

            }
            

        }

        public void loadCBX()
        {
            brandTblTableAdapter1.populateBrand(productFilterDS.BrandTbl, cbxCategory_Purchase.Text);
            colourTblTableAdapter1.populateColour(productFilterDS.ColourTbl, cbxCategory_Purchase.Text);
            sizeTblTableAdapter1.populateSize(productFilterDS.SizeTbl, cbxCategory_Purchase.Text);

            cbxBrand_Accessories.Items.Clear();
            cbxColour_Accessories.Items.Clear();
            cbxSize_Accessories.Items.Clear();

            

            for (int i = 0; i < brandTblDataGridView.Rows.Count - 1; i++)
            {
                cbxBrand_Accessories.Items.Add(brandTblDataGridView.Rows[i].Cells[0].Value.ToString());
            }
            for (int i = 0; i < colourTblDataGridView.Rows.Count - 1; i++)
            {
                cbxColour_Accessories.Items.Add(colourTblDataGridView.Rows[i].Cells[0].Value.ToString());
            }
            for (int i = 0; i < sizeTblDataGridView.Rows.Count - 1; i++)
            {
                cbxSize_Accessories.Items.Add(sizeTblDataGridView.Rows[i].Cells[0].Value.ToString());
            }
            cbxBrand_Accessories.Items.Add("           ");
            cbxColour_Accessories.Items.Add("          ");
            cbxSize_Accessories.Items.Add("            ");
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
                MessageBox.Show(lsvProductCart_Control.FocusedItem.Index.ToString());
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
            GlobalVariables.cartTotal = Double.Parse(phoneOrderDataGridView.CurrentRow.Cells[1].Value.ToString());
            GlobalVariables.customerName_Order = phoneOrderDataGridView.CurrentRow.Cells[2].Value.ToString();
            GlobalVariables.customerCellNo_Order = phoneOrderDataGridView.CurrentRow.Cells[3].Value.ToString();
            GlobalVariables.StaffID = int.Parse(phoneOrderDataGridView.CurrentRow.Cells[4].Value.ToString());
            if (GlobalVariables.isMemeber)
            {
                GlobalVariables.MemberID = int.Parse(phoneOrderDataGridView.CurrentRow.Cells[5].Value.ToString());
            }
            //MessageBox.Show(GlobalVariables.productCart_ProductID.Count.ToString());
            for (int i = 0; i < getPhoneOrderProductsDataGridView.Rows.Count - 1; i++)
            {
                //MessageBox.Show(i.ToString());
                GlobalVariables.productCart_ProductID.Add(getPhoneOrderProductsDataGridView.Rows[i].Cells[1].Value.ToString());
                GlobalVariables.productCart_UnitPrice.Add(Double.Parse(getPhoneOrderProductsDataGridView.Rows[i].Cells[2].Value.ToString()));
                GlobalVariables.productCart_Quantity.Add(int.Parse(getPhoneOrderProductsDataGridView.Rows[i].Cells[3].Value.ToString()));
            }
            // MessageBox.Show(GlobalVariables.productCart_ProductID.Count.ToString());
            GlobalVariables.TransactionType = "Phone";
            Form payment = new payment(this);
            payment.ShowDialog();

            updateProduantity1.DeletePhoneOrder(int.Parse(phoneOrderDataGridView.CurrentRow.Cells[0].Value.ToString()));
            updateProduantity1.deletePhoneOrderLine(int.Parse(phoneOrderDataGridView.CurrentRow.Cells[0].Value.ToString()));
        }

        private void chbxMember_BeginOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxIsMemeber_Purchase.Checked)
            {
                lblStMem.Enabled = true;
                tbxStMem.Enabled = true;
            }
            else { tbxStMem.Enabled = false; }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            updateProduantity1.DeletePhoneOrder(int.Parse(phoneOrderDataGridView.CurrentRow.Cells[0].Value.ToString()));
            updateProduantity1.deletePhoneOrderLine(int.Parse(phoneOrderDataGridView.CurrentRow.Cells[0].Value.ToString()));
            
            this.phoneOrderTableAdapter.Fill(this.productDS.PhoneOrder);
            this.phoneOrderLineTblTableAdapter.Fill(this.productDS.PhoneOrderLineTbl);

        }

        private void getPhoneOrderProductsToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void phoneOrderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.getPhoneOrderProductsTableAdapter.getPhoneOrderProducts(this.productDS.getPhoneOrderProducts, int.Parse(phoneOrderDataGridView.CurrentRow.Cells[0].Value.ToString()));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            orderTblTableAdapter.FilterByOrderNum(productDS.OrderTbl, int.Parse(tbxOrderNum_Returns.Text));
            
        }

        private void orderTblDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                this.orderLineTblTableAdapter.FillBy(this.productDS.OrderLineTbl, int.Parse(orderTblDataGridView.CurrentRow.Cells[0].Value.ToString()));

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            GlobalVariables.Return_OrderNum.Add(int.Parse(orderTblDataGridView.CurrentRow.Cells[0].Value.ToString()));

            string name = productTblTableAdapter1.GetProdName(int.Parse(orderLineTblDataGridView.CurrentRow.Cells[1].Value.ToString()));
            lsvReturnItems_Returns.Items.Add(new ListViewItem(new[] { name, orderLineTblDataGridView.CurrentRow.Cells[3].Value.ToString(), orderLineTblDataGridView.CurrentRow.Cells[2].Value.ToString() }));
            GlobalVariables.productCart_ProductID.Add(orderLineTblDataGridView.CurrentRow.Cells[1].Value.ToString());
            GlobalVariables.productCart_Quantity.Add(int.Parse(orderLineTblDataGridView.CurrentRow.Cells[3].Value.ToString()));
            GlobalVariables.productCart_UnitPrice.Add(Double.Parse(orderLineTblDataGridView.CurrentRow.Cells[2].Value.ToString()));

            GlobalVariables.cartTotal += Double.Parse(orderLineTblDataGridView.CurrentRow.Cells[2].Value.ToString());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            GlobalVariables.TransactionType = "Return";
            
            if(lsvReturnItems_Returns.Items.Count > 0)
            {
                Form payment = new payment(this);
                payment.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Add Items the Items to be Returned");
            }




            
        }

        private void orderLineTblDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string name = productTblTableAdapter1.GetProdName(int.Parse(orderLineTblDataGridView.CurrentRow.Cells[1].Value.ToString()));
            //lsvReturnItems_Returns.Items.Add(new ListViewItem(new[] { name, orderLineTblDataGridView.CurrentRow.Cells[3].Value.ToString(), orderLineTblDataGridView.CurrentRow.Cells[2].Value.ToString() }));

            //GlobalVariables.productCart_ProductID.Add(orderLineTblDataGridView.CurrentRow.Cells[1].Value.ToString());
            //GlobalVariables.productCart_Quantity.Add(int.Parse(orderLineTblDataGridView.CurrentRow.Cells[3].Value.ToString()));
            //GlobalVariables.productCart_UnitPrice.Add(Double.Parse(orderLineTblDataGridView.CurrentRow.Cells[2].Value.ToString()));
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbxAccountNo_AccCreation_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cbxSize_Accessories.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cbxBrand_Accessories.SelectedIndex = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cbxColour_Accessories.SelectedIndex = -1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cbxCategory_Purchase.SelectedIndex = -1;
        }

        public void resetBeginPurchase()
        {
            tbxStMem.Enabled = false;
            chbxStoreOrder_Purchase.CheckState = CheckState.Checked;
            pnlContactDetails_Purchase.Enabled = false;
            chbxIsMemeber_Purchase.CheckState = CheckState.Unchecked;

            tbxStMem.Clear();
            tbxCustomerOrdCell_BeginPurchase.Clear();
            tbxCustomerOrdName_BeginPurchase.Clear();
        }

        public void resetReturnOrder()
        {

        }

        public void resetAccCreation()
        {
            tbxName_AccCreation.Clear();
            tbxCell_AccCreation.Clear();
            tbxAccountNo_AccCreation.Clear();
            tbxEmail_AccCreation.Clear();
            tbxID_AccCreation.Clear();
            tbxSurname_AccCreation.Clear();
            tbxAddress_AccCreation.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void tbxSearch_PhoneOrder_TextChanged(object sender, EventArgs e)
        {
            phoneOrderTableAdapter.SeachPhoneOrder(productDS.PhoneOrder, tbxSearch_PhoneOrder.Text);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}

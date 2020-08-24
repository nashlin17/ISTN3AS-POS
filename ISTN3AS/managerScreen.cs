using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace ISTN3AS
{
    public partial class managerScreen : Form
    {
        public managerScreen()
        {
            InitializeComponent();
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpReport;
        }

        private void btnMngItems_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpItems;
        }

        private void btnMngStaff_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpStaff;
        }

        private void btnClientProf_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpClient;
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu mm = new mainMenu();
            mm.ShowDialog();
            this.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chtReports_Manager.
        }

        private void productTblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productTblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDS);

        }


        private SortedDictionary<string, int> brands = new SortedDictionary<string, int>();
        private SortedDictionary<string, int> colours = new SortedDictionary<string, int>();
        private SortedDictionary<string, int> sizes = new SortedDictionary<string, int>();
        private void managerScreen_Load(object sender, EventArgs e)
        {
    


            initTables();
            productTblDataGridView.ReadOnly = true;
            
            for (int i = 0; i < brandsDataGridView.Rows.Count - 1; i++)
            {
                //MessageBox.Show(brandsDataGridView.Rows[i].Cells[0].Value.ToString() + " " + brandsDataGridView.Rows[i].Cells[1].Value);
                brands.Add(brandsDataGridView.Rows[i].Cells[0].Value.ToString(), int.Parse(brandsDataGridView.Rows[i].Cells[1].Value.ToString())) ;
            }
            for (int i = 0; i < coloursDataGridView.Rows.Count - 1; i++)
            {
                //MessageBox.Show( + " " + coloursDataGridView.Rows[i].Cells[0].Value);
                colours.Add(coloursDataGridView.Rows[i].Cells[1].Value.ToString(), int.Parse(coloursDataGridView.Rows[i].Cells[0].Value.ToString()));
            }
            for (int i = 0; i < sizesDataGridView.Rows.Count - 1; i++)
            {
                sizes.Add(sizesDataGridView.Rows[i].Cells[1].Value.ToString(), int.Parse(sizesDataGridView.Rows[i].Cells[0].Value.ToString()));
            }


            //Init ComboBoxes
            initCbx();
            
            chbxAddProduct_Management.CheckState = CheckState.Checked;
            chbxAddAccount_Management.CheckState = CheckState.Checked;

            lsvRecipients.View = View.Details;

            lsvRecipients.Columns.Add("Emails");
            lsvRecipients.Columns[0].Width = 203;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (chbxAddAccount_Management.Checked)
            {
                DialogResult res = MessageBox.Show("Are You Sure", "Create Staff Account", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        staffTblTableAdapter.Insert(tbxFullName_Management.Text, tbxUsername_Management.Text, tbxPassword_Management.Text, tbxStatus_Management.Text, tbxEmail_Management.Text);
                        this.staffTblTableAdapter.Fill(this.group6DataSet.StaffTbl);
                        MessageBox.Show("Staff Account Created");
                        resetStaffTBX();
                    }
                    catch (Exception c)
                    {
                        MessageBox.Show("Details Incomplete");
                    }

                }
            }
            else if (chbxUpdateAccount_Management.Checked)
            {
                DialogResult res = MessageBox.Show("Are You Sure", "Add Staff Account", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    staffTblTableAdapter.updateStaffAccount(tbxFullName_Management.Text,tbxUsername_Management.Text,tbxPassword_Management.Text,tbxStatus_Management.Text,tbxEmail_Management.Text,int.Parse(staffTblDataGridView.CurrentRow.Cells[0].Value.ToString()));
                    this.staffTblTableAdapter.Fill(this.group6DataSet.StaffTbl);
                    MessageBox.Show("Staff Account Updated");
                    resetStaffTBX();
                }
            }
            
        }

        public void resetStaffTBX()
        {
            tbxFullName_Management.Text = "";
            tbxUsername_Management.Text = "";
            tbxPassword_Management.Text = "";
            tbxEmail_Management.Text = "";
            tbxStatus_Management.Text = "";
        }


        int ProdID;
        private void btnInsertProduct_Managment_Click(object sender, EventArgs e)
        {
            if (chbxAddProduct_Management.Checked)
            {
                try
                {
                    productTblTableAdapter.Insert(tbxProductName_Management.Text, Decimal.Parse(mtbxCostPrice_Management.Text), int.Parse(nupQuantity_Management.Value.ToString()), Decimal.Parse(tbxDiscount_Mangement.Text), Decimal.Parse(mtbxSellingPrice_Management.Text), cbxReorder_Management.Text, brands[cbxBrandName_Management.Text], sizes[cbxSize_Management.Text], colours[cbxColour_Management.Text], cbxCategory_Management.Text, cbxGender_Management.Text);
                }
                catch (Exception c)
                {
                    MessageBox.Show("Invalid Entries");
                }
                
            }
            else if (chbxUpdateProduct_Management.Checked)
            {
                productTblDataGridView.CurrentRow.Cells[1].Value = tbxProductName_Management.Text;
                productTblDataGridView.CurrentRow.Cells[10].Value = cbxCategory_Management.Text;
                productTblDataGridView.CurrentRow.Cells[7].Value = cbxBrandName_Management.SelectedIndex + 1;
                productTblDataGridView.CurrentRow.Cells[9].Value = cbxColour_Management.SelectedIndex + 1;
                productTblDataGridView.CurrentRow.Cells[8].Value = cbxSize_Management.SelectedIndex + 1;
                productTblDataGridView.CurrentRow.Cells[11].Value = cbxGender_Management.Text;
                productTblDataGridView.CurrentRow.Cells[2].Value = mtbxCostPrice_Management.Value;
                productTblDataGridView.CurrentRow.Cells[5].Value = mtbxSellingPrice_Management.Value;
                productTblDataGridView.CurrentRow.Cells[6].Value = cbxReorder_Management.Text;
                productTblDataGridView.CurrentRow.Cells[3].Value = nupQuantity_Management.Value;
                productTblDataGridView.CurrentRow.Cells[4].Value = tbxDiscount_Mangement.Text;

                try
                {
                    productTblTableAdapter.UpdateQuery(productTblDataGridView.CurrentRow.Cells[1].Value.ToString(), Decimal.Parse(productTblDataGridView.CurrentRow.Cells[2].Value.ToString()), int.Parse(productTblDataGridView.CurrentRow.Cells[3].Value.ToString()), Decimal.Parse(productTblDataGridView.CurrentRow.Cells[4].Value.ToString()), Decimal.Parse(productTblDataGridView.CurrentRow.Cells[5].Value.ToString()), productTblDataGridView.CurrentRow.Cells[6].Value.ToString(), int.Parse(productTblDataGridView.CurrentRow.Cells[7].Value.ToString()), int.Parse(productTblDataGridView.CurrentRow.Cells[8].Value.ToString()), int.Parse(productTblDataGridView.CurrentRow.Cells[9].Value.ToString()), productTblDataGridView.CurrentRow.Cells[10].Value.ToString(), productTblDataGridView.CurrentRow.Cells[11].Value.ToString(), ProdID);
                }
                catch(Exception c)
                {
                    MessageBox.Show("Invalid Entries");
                }
              

            }
            this.productTblTableAdapter.Fill(this.productDS.ProductTbl);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (cbxAttribute_Management.Text.Equals("Brand"))
            {
                brandsTableAdapter.Insert(tbxAttribute_Management.Text);
            }
            else if (cbxAttribute_Management.Text.Equals("Size"))
            {
                sizesTableAdapter.Insert(tbxAttribute_Management.Text);
            }
            else if (cbxAttribute_Management.Text.Equals("Colour"))
            {
                coloursTableAdapter.Insert(tbxAttribute_Management.Text);
            }

            initTables();
            initCbx();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            sendEmail(richTextBox2.Text);
        }

        List<string> recipients = new List<string>();
        private void sendEmail(string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("puzzlersistn@gmail.com");
                message.To.Add(new MailAddress(recipients.ElementAt(0)));
                for(int i = 1; i < recipients.Count - 1; i++)
                {
                    message.CC.Add(new MailAddress(recipients.ElementAt(i)));
                }
                message.Subject = ("Total Sports");
                message.IsBodyHtml = true;
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("puzzlersistn@gmail.com", "[ashnashlerukim]");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                MessageBox.Show("Email Sent");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void initTables()
        {
            // TODO: This line of code loads data into the 'group6DataSet.MemberTbl' table. You can move, or remove it, as needed.
            this.memberTblTableAdapter.Fill(this.group6DataSet.MemberTbl);
            // TODO: This line of code loads data into the 'productFilterDS.CategoryTbl' table. You can move, or remove it, as needed.
            this.categoryTblTableAdapter.populateCategory(this.productFilterDS.CategoryTbl);
            // TODO: This line of code loads data into the 'productFilterDS.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.productFilterDS.Brands);
            // TODO: This line of code loads data into the 'productFilterDS.Colours' table. You can move, or remove it, as needed.
            this.coloursTableAdapter.Fill(this.productFilterDS.Colours);
            // TODO: This line of code loads data into the 'productFilterDS.Sizes' table. You can move, or remove it, as needed.
            this.sizesTableAdapter.Fill(this.productFilterDS.Sizes);
            // TODO: This line of code loads data into the 'productFilterDS.CategoryTbl' table. You can move, or remove it, as needed.
            this.categoryTblTableAdapter.populateCategory(this.productFilterDS.CategoryTbl);
            // TODO: This line of code loads data into the 'group6DataSet.StaffTbl' table. You can move, or remove it, as needed.
            this.staffTblTableAdapter.Fill(this.group6DataSet.StaffTbl);
            // TODO: This line of code loads data into the 'productDS.ProductTbl' table. You can move, or remove it, as needed.
            this.productTblTableAdapter.Fill(this.productDS.ProductTbl);
            // TODO: This line of code loads data into the 'supplierDS.SupplierTbl' table. You can move, or remove it, as needed.
            this.supplierTblTableAdapter.Fill(this.supplierDS.SupplierTbl);
            // TODO: This line of code loads data into the 'supplierDS.SupplierProductLine' table. You can move, or remove it, as needed.
            this.supplierProductLineTableAdapter.Fill(this.supplierDS.SupplierProductLine);
            // TODO: This line of code loads data into the 'supplierDS.SupplierOrderTbl' table. You can move, or remove it, as needed.
            this.supplierOrderTblTableAdapter.Fill(this.supplierDS.SupplierOrderTbl);

        }

        private void initCbx()
        {
            cbxBrandName_Management.Items.Clear();
            cbxCategory_Management.Items.Clear();
            cbxColour_Management.Items.Clear();
            cbxSize_Management.Items.Clear();


            for (int i = 0; i < brandsDataGridView.Rows.Count - 1; i++)
            {
                cbxBrandName_Management.Items.Add(brandsDataGridView.Rows[i].Cells[0].Value);
            }
            for (int i = 0; i < coloursDataGridView.Rows.Count - 1; i++)
            {
                cbxColour_Management.Items.Add(coloursDataGridView.Rows[i].Cells[1].Value);
            }
            for (int i = 0; i < sizesDataGridView.Rows.Count - 1; i++)
            {
                cbxSize_Management.Items.Add(sizesDataGridView.Rows[i].Cells[1].Value);
            }
            for (int i = 0; i < categoryTblDataGridView.Rows.Count - 1; i++)
            {
                cbxCategory_Management.Items.Add(categoryTblDataGridView.Rows[i].Cells[0].Value);
            }

        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void memberTblDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        string rtbxEmailText = "";
        private void button9_Click(object sender, EventArgs e)
        {
            recipients.Add(memberTblDataGridView.CurrentRow.Cells[5].Value.ToString());
            lsvRecipients.Items.Add(new ListViewItem(new[] { memberTblDataGridView.CurrentRow.Cells[5].Value.ToString() }));
            //(memberTblDataGridView.CurrentRow.Cells[5].Value.ToString());
        }

        private void cbxUpdateProduct_Management_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxUpdateProduct_Management.Checked)
            {
                chbxAddProduct_Management.CheckState = CheckState.Unchecked;

            }

        }

        private void productTblDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chbxUpdateProduct_Management.Checked)
            {
                ProdID = int.Parse(productTblDataGridView.CurrentRow.Cells[0].Value.ToString());
                tbxProductName_Management.Text = productTblDataGridView.CurrentRow.Cells[1].Value.ToString();
                cbxCategory_Management.Text = productTblDataGridView.CurrentRow.Cells[10].Value.ToString();
                cbxBrandName_Management.SelectedIndex = int.Parse(productTblDataGridView.CurrentRow.Cells[7].Value.ToString());
                    // = productTblDataGridView.CurrentRow.Cells[7].Value.ToString();
                cbxColour_Management.SelectedIndex = int.Parse(productTblDataGridView.CurrentRow.Cells[9].Value.ToString());
                cbxSize_Management.SelectedIndex = int.Parse(productTblDataGridView.CurrentRow.Cells[8].Value.ToString());
                cbxGender_Management.Text = productTblDataGridView.CurrentRow.Cells[11].Value.ToString();
                mtbxCostPrice_Management.Value = Decimal.Parse(productTblDataGridView.CurrentRow.Cells[2].Value.ToString());
                mtbxSellingPrice_Management.Value = Decimal.Parse(productTblDataGridView.CurrentRow.Cells[5].Value.ToString());
                cbxReorder_Management.Text = productTblDataGridView.CurrentRow.Cells[6].Value.ToString();
                nupQuantity_Management.Value = Decimal.Parse(productTblDataGridView.CurrentRow.Cells[3].Value.ToString());
                tbxDiscount_Mangement.Text = productTblDataGridView.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void chbxAddProduct_Management_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAddProduct_Management.Checked)
            {
                chbxUpdateProduct_Management.CheckState = CheckState.Unchecked;
                tbxProductName_Management.Text="";
               cbxCategory_Management.Text = "";
               cbxBrandName_Management.SelectedIndex = -1;
               cbxColour_Management.SelectedIndex = -1;
               cbxSize_Management.SelectedIndex = -1;
               cbxGender_Management.Text = "";
               mtbxCostPrice_Management.Value = 0;
                mtbxSellingPrice_Management.Value = 0 ;
               cbxReorder_Management.Text = "";
               nupQuantity_Management.Value = 0;
               tbxDiscount_Mangement.Text = "";

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(tbxSuppName.Text=="" || tbxSuppNo.Text==""  || tbxSuppMail.Text == "" ||tbxSuppAddress.Text == "")
            {
                MessageBox.Show("Details Incomplete ");
            }
            else
            {
               
                supplierTblTableAdapter.InsertSupplier(tbxSuppName.Text, tbxSuppNo.Text, tbxSuppMail.Text, tbxSuppAddress.Text, "Active");
                initTables();
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(cbxSupplierStatus.Text!="" && int.Parse(supplierGrid.CurrentRow.Cells[0].Value.ToString()) > 0)
            {
                int id = int.Parse(supplierGrid.CurrentRow.Cells[0].Value.ToString());
                supplierTblTableAdapter.UpdateAvailability(cbxSupplierStatus.Text, id);
                initTables();
            }
            else
            {
                MessageBox.Show("Select a Supplier And Status ");
            }
            
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpSupp;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpOrder;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;


            supplierOrderTblTableAdapter.InsertOrderInView(decimal.Parse(tbxTotal.Text), "Undelivered", dt.ToString(), null, int.Parse(tbxSuppID.Text));
            initTables();
            int SuppOrderID = int.Parse(suppOrderGrid.Rows[suppOrderGrid.Rows.Count - 2].Cells[0].Value.ToString());
            supplierProductLineTableAdapter.InsertProductOrder(int.Parse(tbxProdID.Text), SuppOrderID, decimal.Parse(tbxTotal.Text), int.Parse(tbxProdQuantity.Text));

            initTables();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            DateTime dt2 = DateTime.Now;
            Boolean bflag = false;
            int prodID, quantity, originalQT;
            originalQT = 0;
            quantity = 0;
            prodID = 0;

            try
            {
                if (suppOrderGrid.CurrentRow.Cells[2].Value.ToString() == "Undelivered")
                {
                    supplierProductLineTableAdapter.FillBy(supplierDS.SupplierProductLine, int.Parse(suppOrderGrid.CurrentRow.Cells[0].Value.ToString()));

                    foreach (DataGridViewRow row in fillbyGrid.Rows)
                    {
                        prodID = int.Parse(row.Cells[0].Value.ToString());

                        quantity = int.Parse(row.Cells[3].Value.ToString());

                        foreach (DataGridViewRow row2 in productTblDataGridView.Rows)
                        {
                            int compareID = int.Parse(row2.Cells[0].Value.ToString());

                            if (prodID == compareID)
                            {
                                originalQT = int.Parse(row2.Cells[3].Value.ToString());
                                bflag = true;
                                break;
                            }

                        }
                        if (bflag)
                        {
                            break;
                        }

                    }
                    quantity = quantity + originalQT;
                    productTblTableAdapter.UpdateNewStock(quantity, prodID);

                    MessageBox.Show("Update Complete");
                    supplierOrderTblTableAdapter.UpdateDelieveryStatus("Delivered", dt2.ToString(), int.Parse(suppOrderGrid.CurrentRow.Cells[0].Value.ToString()));
                    initTables();
                }
                else
                {
                    MessageBox.Show("Products Already Delivered");
                }
                
            }
            catch(Exception c)
            {
                MessageBox.Show("Update Not Successful");
            }

            
       
        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void tbxProductName_Management_Click(object sender, EventArgs e)
        {
            //
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            productTblBindingSource.MoveFirst();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            productTblBindingSource.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            productTblBindingSource.MoveNext();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            productTblBindingSource.MoveLast();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult res =  MessageBox.Show("Are You Sure", "Delete Product", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                productTblTableAdapter.DeleteProduct(int.Parse(productTblDataGridView.CurrentRow.Cells[0].Value.ToString()));
                this.productTblTableAdapter.Fill(this.productDS.ProductTbl);
                MessageBox.Show("Product Deleted");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            staffTblBindingSource.MoveFirst();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            staffTblBindingSource.MovePrevious();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            staffTblBindingSource.MoveNext();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            staffTblBindingSource.MoveLast();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("Are You Sure", "Delete Staff Account", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                staffTblTableAdapter.DeleteStaffMember(int.Parse(staffTblDataGridView.CurrentRow.Cells[0].Value.ToString()));
                this.staffTblTableAdapter.Fill(this.group6DataSet.StaffTbl);
                MessageBox.Show("Staff Account Removed");
            }
        }

        private void tpStaff_Click(object sender, EventArgs e)
        {

        }

        private void chbxAddAccount_Management_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAddAccount_Management.Checked)
            {
                chbxUpdateAccount_Management.CheckState = CheckState.Unchecked;
            }
            resetStaffTBX();
        }

        private void chbxUpdateAccount_Management_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxUpdateAccount_Management.Checked)
            {
                chbxAddAccount_Management.CheckState = CheckState.Unchecked;
            }
            resetStaffTBX();
        }

        private void staffTblDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chbxUpdateAccount_Management.Checked)
            {
                tbxFullName_Management.Text = staffTblDataGridView.CurrentRow.Cells[1].Value.ToString();
                tbxUsername_Management.Text = staffTblDataGridView.CurrentRow.Cells[2].Value.ToString();
                tbxPassword_Management.Text = staffTblDataGridView.CurrentRow.Cells[3].Value.ToString();
                tbxEmail_Management.Text = staffTblDataGridView.CurrentRow.Cells[5].Value.ToString();
                tbxStatus_Management.Text = staffTblDataGridView.CurrentRow.Cells[4].Value.ToString();
            }
            
        }
    }
}

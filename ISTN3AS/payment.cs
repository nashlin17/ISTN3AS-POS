using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ISTN3AS
{
    public partial class payment : Form
    {
        private salesControl sc;
        
        
        public payment()
        {
            
            InitializeComponent();
            
        }

        public payment(salesControl sc)
        {
            this.sc = sc;
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(Double.Parse(tbxAmtPaid_Payment.Text) >= Double.Parse(lblTotal_Payment.Text))
            {
                if (GlobalVariables.TransactionType.Equals("Store"))
                {
                    if (GlobalVariables.isMemeber)
                    {
                        orderTblTableAdapter.Insert(Decimal.Parse(GlobalVariables.cartTotal.ToString()), GlobalVariables.TransactionType, null, null, GlobalVariables.StaffID, GlobalVariables.MemberID);

                    }
                    else
                    {
                        orderTblTableAdapter.Insert(Decimal.Parse(GlobalVariables.cartTotal.ToString()), GlobalVariables.TransactionType, null, null, GlobalVariables.StaffID, null);
                    }
                    GlobalVariables.orderNo= int.Parse(globalOrdeNoGrid.Rows[globalOrdeNoGrid.Rows.Count-2].Cells[0].Value.ToString());
                }
                else
                {
                    if (GlobalVariables.isMemeber)
                    {
                        orderTblTableAdapter.Insert(Decimal.Parse(GlobalVariables.cartTotal.ToString()), "Phone", GlobalVariables.customerName_Order, GlobalVariables.customerCellNo_Order, GlobalVariables.StaffID, GlobalVariables.MemberID);
                    }
                    else
                    {
                        orderTblTableAdapter.Insert(Decimal.Parse(GlobalVariables.cartTotal.ToString()), "Phone", GlobalVariables.customerName_Order, GlobalVariables.customerCellNo_Order, GlobalVariables.StaffID, null);
                    }
                  
                }
                int maxOrderID = int.Parse(orderTblTableAdapter.getMaxID().ToString());
                MessageBox.Show(maxOrderID.ToString());
                for (int i = 0; i < GlobalVariables.productCart_ProductID.Count(); i++)
                {
                    orderLineTblTableAdapter.Insert(maxOrderID, int.Parse(GlobalVariables.productCart_ProductID.ElementAt(i)), Decimal.Parse(GlobalVariables.productCart_UnitPrice.ElementAt(i).ToString()), GlobalVariables.productCart_Quantity.ElementAt(i));
                    int productQuantity = int.Parse(updateProduantity1.getQuanity(int.Parse(GlobalVariables.productCart_ProductID.ElementAt(i))).ToString());
                    updateProduantity1.updateProductQuantity(productQuantity - GlobalVariables.productCart_Quantity.ElementAt(i), int.Parse(GlobalVariables.productCart_ProductID.ElementAt(i)));
                }


                this.orderLineTblTableAdapter.Fill(this.productDS.OrderLineTbl);
                this.orderTblTableAdapter.Fill(this.productDS.OrderTbl);
                //Non Member
                GlobalVariables.orderNo = int.Parse(globalOrdeNoGrid.Rows[globalOrdeNoGrid.Rows.Count - 2].Cells[0].Value.ToString());
                sc.tabcontrol1.SelectedIndex = 1;
                sc.tabcontrol1.Size = new Size(1267, 582);
                sc.resetBeginPurchase();
                printForm pf = new printForm();

                pf.Show();
                this.Dispose();
            }
            else { MessageBox.Show("Outstanding Amount" + (Double.Parse(lblTotal_Payment.Text) - Double.Parse(tbxAmtPaid_Payment.Text))); }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sc.btnCashOut.Enabled = true;
            sc.btnItems.Enabled = false;
        }

        private void payment_Load(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalVariables.TransactionType);
            // TODO: This line of code loads data into the 'productDS.ReturnTbl' table. You can move, or remove it, as needed.
            if (GlobalVariables.TransactionType.Equals("Return"))
            {
                tabControl1.SelectedTab = tpReturn;
                // TODO: This line of code loads data into the 'productDS.ReturnTbl' table. You can move, or remove it, as needed.
                this.returnTblTableAdapter.Fill(this.productDS.ReturnTbl);
                // TODO: This line of code loads data into the 'productDS.ReturnProductTbl' table. You can move, or remove it, as needed.
                this.returnProductTblTableAdapter.Fill(this.productDS.ReturnProductTbl);
            }

            
            MessageBox.Show(GlobalVariables.productCart_ProductID.Count.ToString());
            this.orderLineTblTableAdapter.Fill(this.productDS.OrderLineTbl);
            this.orderTblTableAdapter.Fill(this.productDS.OrderTbl);
            //Initialize Payment Details(Total, Discount and Sub-Total)
            lblSubTotal_Payment.Text = GlobalVariables.cartTotal.ToString();
            lblDiscount_Payment.Text = (GlobalVariables.cartTotal * GlobalVariables.AccDiscount).ToString();
            lblTotal_Payment.Text = (GlobalVariables.cartTotal - (GlobalVariables.cartTotal * GlobalVariables.AccDiscount)).ToString();
            GlobalVariables.cartTotal = Double.Parse(lblTotal_Payment.Text);

            lblTotal_Return.Text = GlobalVariables.cartTotal.ToString();
        }

        private void tbxAmtPaid_Payment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVariables.cartTotal < Double.Parse(tbxAmtPaid_Payment.Text))
                {
                    lblCustomerChange_Payment.Text = (Double.Parse(tbxAmtPaid_Payment.Text) - Double.Parse(lblTotal_Payment.Text)).ToString();
                }
                else
                {
                    lblCustomerChange_Payment.Text = "0";
                }
            }
            catch (Exception ex) { }         

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnProcess_Return_Click(object sender, EventArgs e)
        {
            if (!tbxReason_Return.Text.Equals("") && tbxCellNo_Return.Text.Length == 10 && !tbxCellNo_Return.Text.Equals("")) {
                DialogResult confirm = MessageBox.Show("Are You Sure", "Confirm Return", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    returnTblTableAdapter.Insert(tbxReason_Return.Text, tbxCellNo_Return.Text);

                    int maxID = int.Parse(returnTblTableAdapter.getMaxID().ToString());
                    for (int i = 0; i < GlobalVariables.Return_OrderNum.Count; i++)
                    {
                        returnProductTblTableAdapter.Insert(int.Parse(GlobalVariables.productCart_ProductID.ElementAt(i)), maxID, dtpReturnDate_Returns.Value, GlobalVariables.Return_OrderNum.ElementAt(i));
                    }

                    for (int i = 0; i < GlobalVariables.Return_OrderNum.Count; i++)
                    {
                        updateProduantity1.DeleteOrderProduct(int.Parse(GlobalVariables.Return_OrderNum.ElementAt(i).ToString()), int.Parse(GlobalVariables.productCart_ProductID.ElementAt(i).ToString()));
                        this.orderLineTblTableAdapter.Fill(this.productDS.OrderLineTbl);

                        if (!bool.Parse(updateProduantity1.CheckOrderNumExists(int.Parse(GlobalVariables.Return_OrderNum.ElementAt(i).ToString())).ToString()))
                        {
                            updateProduantity1.DeleteOrder(int.Parse(GlobalVariables.Return_OrderNum.ElementAt(i).ToString()));
                            this.orderTblTableAdapter.Fill(this.productDS.OrderTbl);
                        }
                    }
                    sc.tabcontrol1.SelectedIndex = 1;
                    sc.tabcontrol1.Size = new Size(1267, 582);
                    sc.resetBeginPurchase();
                    printForm pf = new printForm();

                    pf.Show();
                    this.Dispose();
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("Please Re-Enter Details for Return ");
            }
        }

        private void tpItemPayment_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            sc.tabcontrol1.SelectedIndex = 1;
            sc.tabcontrol1.Size = new Size(1267, 582);
            sc.resetBeginPurchase();
            printForm pf = new printForm();

            pf.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cardPay cp = new cardPay();
            cp.ShowDialog();
            sc.tabcontrol1.SelectedIndex = 1;
            sc.tabcontrol1.Size = new Size(1267, 582);
            sc.resetBeginPurchase();
            printForm pf = new printForm();

            pf.Show();
            this.Dispose();
        }
    }
}

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
                //int productQuantity = int.Parse(updateProduantity1.getQuanity(int.Parse(GlobalVariables.productCart_ProductID.ElementAt(i))).ToString());
                //updateProduantity1.updateProductQuantity(productQuantity - GlobalVariables.productCart_Quantity.ElementAt(i), int.Parse(GlobalVariables.productCart_ProductID.ElementAt(i)));
            }


            this.orderLineTblTableAdapter.Fill(this.productDS.OrderLineTbl);
            this.orderTblTableAdapter.Fill(this.productDS.OrderTbl);
            //Non Member


            //sc.btnCashOut.Enabled = true;
            //sc.btnItems.Enabled = false;
            //sc.btnMenuOrder.Enabled = true;
            //sc.btnMenuPurchase.Enabled = true;
            ////sc.tabcontrol1.SelectedIndex=4 ;
            //sc.gbItemsScroll.SendToBack();
            //sc.tabcontrol1.Width = 1382;
            //sc.tabcontrol1.Height = 734;
            ////this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sc.btnCashOut.Enabled = true;
            sc.btnItems.Enabled = false;
        }

        private void payment_Load(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalVariables.productCart_ProductID.Count.ToString());
            this.orderLineTblTableAdapter.Fill(this.productDS.OrderLineTbl);
            this.orderTblTableAdapter.Fill(this.productDS.OrderTbl);
            //Initialize Payment Details(Total, Discount and Sub-Total)
            lblSubTotal_Payment.Text = GlobalVariables.cartTotal.ToString();
            lblDiscount_Payment.Text = (GlobalVariables.cartTotal * GlobalVariables.AccDiscount).ToString();
            lblTotal_Payment.Text = (GlobalVariables.cartTotal - (GlobalVariables.cartTotal * GlobalVariables.AccDiscount)).ToString();
            GlobalVariables.cartTotal = Double.Parse(lblTotal_Payment.Text);
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
    }
}

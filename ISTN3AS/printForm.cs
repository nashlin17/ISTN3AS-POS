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
    public partial class printForm : Form
    {
        Bitmap bmp;
        public printForm()
        {
            InitializeComponent();
        }

        private void printForm_Load(object sender, EventArgs e)
        {
            printForm.ActiveForm.BringToFront();
            lsvReceipt.View = View.Details;

            lsvReceipt.Columns.Add("Player Name");
            lsvReceipt.Columns[0].Width = 203;
            lsvReceipt.Columns.Add("Qty");
            lsvReceipt.Columns[1].TextAlign = HorizontalAlignment.Center;
            lsvReceipt.Columns.Add("Total");
            lsvReceipt.Columns[2].TextAlign = HorizontalAlignment.Center;

            for(int i =0; i < GlobalVariables.productCart_ProductID.Count - 1; i++)
            {
                lsvReceipt.Items.Add(new ListViewItem(new[] { GlobalVariables.productCart_ProductID.ElementAt(i), GlobalVariables.productCart_Quantity.ElementAt(i).ToString(), GlobalVariables.productCart_UnitPrice.ElementAt(i).ToString() }));
            }

            lblDate.Text = DateTime.Now.ToString();
            tbxReceipt.Text = GlobalVariables.cartTotal.ToString();


           

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 130, 0);
        }

        private void printForm_Shown(object sender, EventArgs e)
        {
           
        }

        private void printForm_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();
            this.Dispose();
           
            
        }
    }
}

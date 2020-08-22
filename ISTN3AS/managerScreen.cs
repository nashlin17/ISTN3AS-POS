using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

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


            
            for(int i = 0; i < cbxBrandName_Management.Items.Count - 1; i++)
            {
                brands.Add(cbxBrandName_Management.Items[i].ToString(), i);
            }
            
            for (int i = 0; i < cbxColour_Management.Items.Count - 1; i++)
            {
                colours.Add(cbxColour_Management.Items[i].ToString(),i);   
            }

            for (int i = 0; i < cbxSize_Management.Items.Count - 1; i++)
            {
                colours.Add(cbxSize_Management.Items[i].ToString(), i);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            staffTblTableAdapter.Insert(tbxFullName_Management.Text, tbxUsername_Management.Text, tbxPassword_Management.Text, tbxStatus_Management.Text, tbxEmail_Management.Text);
        }

        private void btnInsertProduct_Managment_Click(object sender, EventArgs e)
        {
            productTblTableAdapter.Insert(tbxProductName_Management.Text, Decimal.Parse(mtbxCostPrice_Management.Text), int.Parse(nupQuantity_Management.Value.ToString()), Decimal.Parse(tbxDiscount_Mangement.Text), Decimal.Parse(mtbxSellingPrice_Management.Text), cbxReorder_Management.Text, brands[cbxBrandName_Management.Text], sizes[cbxSize_Management.Text], colours[cbxColour_Management.Text], cbxCategory_Management.Text, cbxGender_Management.Text );
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
        }
    }
}

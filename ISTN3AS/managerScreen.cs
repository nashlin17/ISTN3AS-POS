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
    }
}

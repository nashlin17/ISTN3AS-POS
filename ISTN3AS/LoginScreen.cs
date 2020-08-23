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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnExit2Home_Click(object sender, EventArgs e)
        {
            mainMenu mm = new mainMenu();
            mm.Show();
            this.Close();

        }

        private void btnStaffSign_Click(object sender, EventArgs e)
        {
            try
            {
               this.getLoginDetailsTableAdapter.CheckLoginDetails(this.getLoginDS.GetLoginDetails, tbxUsername_Login.Text, tbxPassword_Login.Text);
                if(getLoginDS.GetLoginDetails.Rows[0][0].ToString().ToUpper() == tbxUsername_Login.Text.ToUpper() && getLoginDS.GetLoginDetails.Rows[0][1].ToString() == tbxPassword_Login.Text)
                {
                    
                    GlobalVariables.StaffID = int.Parse(getLoginDS.GetLoginDetails.Rows[0][2].ToString());
                    salesControl sc = new salesControl();
                    this.Hide();
                    sc.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            //getLoginDetailsTableAdapter.CheckLoginDetails(this.getLoginDS.GetLoginDetails, "Netflix", "Chill");
            //this.getLoginDetailsTableAdapter.CheckLoginDetails(this.getLoginDS.GetLoginDetails, "Netflix", "Chill");
        }
    }
}

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
    public partial class cardPay : Form
    {
        public cardPay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 4)
            {
                try
                {
                    int pin = int.Parse(textBox1.Text);
                    MessageBox.Show("Pin Okay");
                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Pin Incorrect");
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Pin Incorrect");
            }
           
           
        }
    }
}

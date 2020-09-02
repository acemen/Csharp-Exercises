using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odd_or_Even_num
{
    public partial class Odd_or_Even : Form
    {
        public Odd_or_Even()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            int val;
            string output = "Number is even";

            // Convert from text to number
            flag = int.TryParse(txtnumber.Text, out val);
            if (flag == false)
            {
                MessageBox.Show("Not a number. Re-enter.");
                txtnumber.Clear();
                txtnumber.Focus();
                return;
            }

            // See if odd or even
            if (val % 2 == 1)
            {
                if (val % 2 == 1)
                {
                    output = "Number is odd";
                }
                else
                {
                    output = "Number is even";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
            int myDay;
            string msg = "Today is ";   
            flag = int.TryParse(txtDay.Text, out myDay);
            if (flag == false)
            {
                MessageBox.Show("Numeric only, 1 thru 7");
                txtDay.Focus();  
                return;
            }
            switch (myDay)
            {
                case 1:
                    lblResult.Text = msg + "Monday";
                    break;
                case 2:
                    lblResult.Text = msg + "Tuesday";
                    break;
                case 3:
                    lblResult.Text = msg + "Wednesday";
                    break;
                case 4:
                    lblResult.Text = msg + "Thursday";
                    break;
                case 5:
                    lblResult.Text = msg + "Friday";
                    break;
                case 6:
                    lblResult.Text = msg + "Saturday";
                    break;
                case 7:
                    lblResult.Text = msg + "Sunday";
                    break;
                default:
                    lblResult.Text = "You should never get here";
                    break;
            }
        }
    }
}

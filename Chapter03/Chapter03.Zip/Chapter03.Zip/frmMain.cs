using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter03.Zip
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            void frmMain()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag;
            int operand1;
            int operand2;
            int answer;

            // input step
            // Check first input
            flag = int.TryParse(txtOperand1.Text, out operand1);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole Number", "Input Error");
                txtOperand1.Focus();
                return;
            }

            // Check second input
            flag = int.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole Number", "input Error");
                txtOperand2.Focus();
                return;
            }

            // Process step
            answer = operand1 / operand2;

            // Display step
            txtResult.Text = operand2.ToString() + "divided by" +
                operand2.ToString() + "equals" + answer.ToString();
            txtResult.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

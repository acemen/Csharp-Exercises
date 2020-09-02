using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05StringMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            bool flag;
            int index;
            int start;
            int howMany;
            string temp;

            lblIndexOf.Text = "";
            // Find Length
            txtInput.Text = txtInput.Text.Length.ToString();
            // Change cases
            txtToUpper.Text = txtInput.Text.ToUpper();
            txtLower.Text = txtInput.Text.ToLower();

            // Index of
            index = txtInput.Text.IndexOf(txtsearchchar.Text, 0);
            lblIndexOf.Text = "txtInput.Text.indexof(\"" + txtsearchchar.Text + "\") = ";
            txtsearchindex.Text = index.ToString();

            // Last index of
            index = txtInput.Text.IndexOf(txtlastchar.Text);
            txtlastindexof.Text = "txtInput.Text.lastindexof(\"" + txtlastchar.Text + "\") = ";
            txtlastindexof.Text = index.ToString();

            // Substring
            flag = int.TryParse(txtstartindex.Text, out start);
            if (flag==false)
            {
                MessageBox.Show("improper numeric input. Re-enter.");
                txtstartindex.Focus();
                return;
            }
            flag = int.TryParse(txtendindex.Text, out howMany);
            if (flag==false)
            {
                MessageBox.Show("improper numeric input. Re-enter.");
                txtendindex.Focus();
                return;
            }
            lblsubstringindex.Text = "txtInput.Text.Substring(" + start.ToString() + ", " +
                "" + howMany.ToString() + ") = ";
            txtsubstringResult.Text = txtInput.Text.Substring(start, howMany);

            // Remove 
            temp = txtInput.Text;
            index = temp.IndexOf(txtremove.Text);
            if(index > 0)
            {
                txtremoveresult.Text = temp.Remove(index, txtremove.Text.Length);
            }
            // Replace
            temp = txtInput.Text;
            txtreplaceresult.Text = temp.Replace(txtreplacechar.Text, txtreplacewith.Text);
        }
    }
}

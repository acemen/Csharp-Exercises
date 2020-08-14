using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter02Program01.Zip
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDisplayOutput_Click(object sender, EventArgs e)
        {
            // implement code for formatting mail label
            string buffer;

            buffer = "Mailing Label:" + Environment.NewLine + Environment.NewLine;
            buffer = buffer + "Name:" + txtName.Text + Environment.NewLine;
            buffer = buffer + "Adress:" + txtAddress.Text + Environment.NewLine;
            buffer = buffer + "City:" + txtCity.Text
                + "State:" + txtState + "Zip" + txtZip.Text;
            txtDisplayOutput.Text = buffer;
        }
    }
}

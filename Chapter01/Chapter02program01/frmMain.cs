using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter02program01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.ResumeLayout(false);

        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

        }
    }
}

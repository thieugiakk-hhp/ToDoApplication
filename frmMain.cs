using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoAplication
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            frmCalculator frm = new frmCalculator();
            frm.ShowDialog();
        }

        private void btnUserInformation_Click(object sender, EventArgs e)
        {
            frmUserInformation frm = new frmUserInformation();
            frm.ShowDialog();
        }

        private void btnMyStatus_Click(object sender, EventArgs e)
        {
            frmUserStatus frm = new frmUserStatus();
            frm.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp frm = new frmHelp();
            frm.ShowDialog();
        }
    }
}

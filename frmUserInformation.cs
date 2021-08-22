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
    public partial class frmUserInformation : Form
    {
        public frmUserInformation()
        {
            InitializeComponent();
        }

        private void btnEditInformation_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}

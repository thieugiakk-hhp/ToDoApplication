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
    public partial class frmDetail : Form
    {
        public frmDetail()
        {
            InitializeComponent();
        }

        private void btnZoomForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMain frm = new frmMain();
            frm.Show();
        }
    }
}

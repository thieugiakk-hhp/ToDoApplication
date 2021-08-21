using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAplication.DataModels;

namespace ToDoAplication
{
    public partial class frmMain : Form
    {
        private DatabaseContext context;
        private List<TaskList> taskLists;
        private List<Tasks> tasks;

        public frmMain()
        {
            InitializeComponent();

            context = new DatabaseContext();

            taskLists = context.TaskLists.ToList();
            tasks = context.Tasks.ToList();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Đóng Ứng dụng
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            //Show form
            frmCalculator frm = new frmCalculator();
            frm.ShowDialog();
        }

        private void btnUserInformation_Click(object sender, EventArgs e)
        {
            //Show form
            frmUserInformation frm = new frmUserInformation();
            frm.ShowDialog();
        }

        private void btnMyStatus_Click(object sender, EventArgs e)
        {
            //Show form
            frmUserStatus frm = new frmUserStatus();
            frm.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Show form
            frmHelp frm = new frmHelp();
            frm.ShowDialog();
        }

        private void btnZoomForm_Click(object sender, EventArgs e)
        {
            this.Visible = false; //Tắt form này
            //Show form
            frmDetail frm = new frmDetail();
            frm.Show();
        }
    }
}

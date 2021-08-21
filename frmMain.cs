using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAplication.Functions;
using ToDoAplication.DataModels;

namespace ToDoAplication
{
    public partial class frmMain : Form
    {
        private DatabaseContext context;
        private List<tblTaskList> tblTaskLists;
        private List<tblTask> tblTasks;
        private string userID;

        public frmMain()
        {
            InitializeComponent();

            context = new DatabaseContext();

            //Thêm dữ liệu từ database vào danh sách
            tblTaskLists = context.tblTaskLists.ToList();
            tblTasks = context.tblTasks.ToList();

            userID = "admin         "; //Thay đổi userID cho đúng với account đăng nhập... Tạm thời để thế đã
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FillToListView fill = new FillToListView();
            fill.FillListViewTaskList(lvTaskList, tblTaskLists, userID);
            fill.FillListViewTasks(lvTasks, tblTasks, userID);
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

        private void btnMyDay_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Ngày của tôi";
        }

        private void btnMyMonth_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Tháng của tôi";
            pnlCalendar.Visible = true;
        }

        private void DrawCalendar()
        {
            this.btnMyStatus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMyStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyStatus.Image = global::ToDoAplication.Properties.Resources.mood;
            this.btnMyStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMyStatus.Location = new System.Drawing.Point(18, 56);
            this.btnMyStatus.Name = "btnMyStatus";
            this.btnMyStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMyStatus.Size = new System.Drawing.Size(190, 28);
            this.btnMyStatus.TabIndex = 4;
            this.btnMyStatus.Text = "  Trạng thái của bạn";
            this.btnMyStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyStatus.UseVisualStyleBackColor = true;
            this.btnMyStatus.Click += new System.EventHandler(this.btnMyStatus_Click);
        }

        private void btnImportant_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quan trọng";
        }

        private void btnSingleTask_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Tác vụ đơn";
        }
    }
}

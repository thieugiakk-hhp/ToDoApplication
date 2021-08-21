
namespace ToDoAplication
{
    partial class frmDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetail));
            this.pnlHeaderButton = new System.Windows.Forms.Panel();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExcelOutput = new System.Windows.Forms.Button();
            this.btnZoomForm = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.grbDescription = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtDayCreated = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbtDone = new System.Windows.Forms.RadioButton();
            this.grbInList = new System.Windows.Forms.GroupBox();
            this.txtInList = new System.Windows.Forms.TextBox();
            this.grbCategory = new System.Windows.Forms.GroupBox();
            this.cbbCategories = new System.Windows.Forms.ComboBox();
            this.grbEndDate = new System.Windows.Forms.GroupBox();
            this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
            this.grbStartDate = new System.Windows.Forms.GroupBox();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.grbTitle = new System.Windows.Forms.GroupBox();
            this.rbtImportant = new System.Windows.Forms.RadioButton();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.pnlHeaderButton.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.grbDescription.SuspendLayout();
            this.panel7.SuspendLayout();
            this.grbInList.SuspendLayout();
            this.grbCategory.SuspendLayout();
            this.grbEndDate.SuspendLayout();
            this.grbStartDate.SuspendLayout();
            this.grbTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderButton
            // 
            this.pnlHeaderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.pnlHeaderButton.Controls.Add(this.btnCalculator);
            this.pnlHeaderButton.Controls.Add(this.btnClose);
            this.pnlHeaderButton.Controls.Add(this.btnExcelOutput);
            this.pnlHeaderButton.Controls.Add(this.btnZoomForm);
            this.pnlHeaderButton.Controls.Add(this.btnHelp);
            this.pnlHeaderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderButton.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderButton.Name = "pnlHeaderButton";
            this.pnlHeaderButton.Size = new System.Drawing.Size(287, 50);
            this.pnlHeaderButton.TabIndex = 1;
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackgroundImage = global::ToDoAplication.Properties.Resources.rating;
            this.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculator.Location = new System.Drawing.Point(6, 0);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(50, 50);
            this.btnCalculator.TabIndex = 1;
            this.btnCalculator.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ToDoAplication.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(230, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnExcelOutput
            // 
            this.btnExcelOutput.BackgroundImage = global::ToDoAplication.Properties.Resources.excel;
            this.btnExcelOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcelOutput.FlatAppearance.BorderSize = 0;
            this.btnExcelOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcelOutput.Location = new System.Drawing.Point(62, 0);
            this.btnExcelOutput.Name = "btnExcelOutput";
            this.btnExcelOutput.Size = new System.Drawing.Size(50, 50);
            this.btnExcelOutput.TabIndex = 1;
            this.btnExcelOutput.UseVisualStyleBackColor = true;
            // 
            // btnZoomForm
            // 
            this.btnZoomForm.BackgroundImage = global::ToDoAplication.Properties.Resources.back;
            this.btnZoomForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZoomForm.FlatAppearance.BorderSize = 0;
            this.btnZoomForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZoomForm.Location = new System.Drawing.Point(174, 0);
            this.btnZoomForm.Name = "btnZoomForm";
            this.btnZoomForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnZoomForm.Size = new System.Drawing.Size(50, 50);
            this.btnZoomForm.TabIndex = 2;
            this.btnZoomForm.UseVisualStyleBackColor = true;
            this.btnZoomForm.Click += new System.EventHandler(this.btnZoomForm_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = global::ToDoAplication.Properties.Resources.help;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Location = new System.Drawing.Point(118, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(50, 50);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetail.Controls.Add(this.grbDescription);
            this.pnlDetail.Controls.Add(this.panel7);
            this.pnlDetail.Controls.Add(this.grbInList);
            this.pnlDetail.Controls.Add(this.grbCategory);
            this.pnlDetail.Controls.Add(this.grbEndDate);
            this.pnlDetail.Controls.Add(this.grbStartDate);
            this.pnlDetail.Controls.Add(this.grbTitle);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 50);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(287, 586);
            this.pnlDetail.TabIndex = 4;
            // 
            // grbDescription
            // 
            this.grbDescription.BackColor = System.Drawing.Color.Transparent;
            this.grbDescription.Controls.Add(this.txtDescription);
            this.grbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDescription.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDescription.Location = new System.Drawing.Point(0, 296);
            this.grbDescription.Name = "grbDescription";
            this.grbDescription.Size = new System.Drawing.Size(285, 261);
            this.grbDescription.TabIndex = 4;
            this.grbDescription.TabStop = false;
            this.grbDescription.Text = "Nội dung";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(3, 22);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(279, 236);
            this.txtDescription.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.txtDayCreated);
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Controls.Add(this.rbtDone);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 557);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(285, 27);
            this.panel7.TabIndex = 3;
            // 
            // txtDayCreated
            // 
            this.txtDayCreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtDayCreated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDayCreated.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayCreated.Location = new System.Drawing.Point(39, 6);
            this.txtDayCreated.Name = "txtDayCreated";
            this.txtDayCreated.Size = new System.Drawing.Size(197, 15);
            this.txtDayCreated.TabIndex = 2;
            this.txtDayCreated.Text = "Đã tạo ngày";
            this.txtDayCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::ToDoAplication.Properties.Resources.delete1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(252, -1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(27, 27);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // rbtDone
            // 
            this.rbtDone.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtDone.BackgroundImage = global::ToDoAplication.Properties.Resources.tick;
            this.rbtDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbtDone.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtDone.FlatAppearance.BorderSize = 0;
            this.rbtDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtDone.Location = new System.Drawing.Point(6, -1);
            this.rbtDone.Name = "rbtDone";
            this.rbtDone.Size = new System.Drawing.Size(27, 27);
            this.rbtDone.TabIndex = 0;
            this.rbtDone.TabStop = true;
            this.rbtDone.UseVisualStyleBackColor = true;
            // 
            // grbInList
            // 
            this.grbInList.BackColor = System.Drawing.Color.Transparent;
            this.grbInList.Controls.Add(this.txtInList);
            this.grbInList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInList.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInList.Location = new System.Drawing.Point(0, 236);
            this.grbInList.Name = "grbInList";
            this.grbInList.Size = new System.Drawing.Size(285, 60);
            this.grbInList.TabIndex = 1;
            this.grbInList.TabStop = false;
            this.grbInList.Text = "Danh sách";
            // 
            // txtInList
            // 
            this.txtInList.BackColor = System.Drawing.Color.White;
            this.txtInList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInList.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInList.Location = new System.Drawing.Point(6, 25);
            this.txtInList.Name = "txtInList";
            this.txtInList.Size = new System.Drawing.Size(273, 27);
            this.txtInList.TabIndex = 0;
            // 
            // grbCategory
            // 
            this.grbCategory.BackColor = System.Drawing.Color.Transparent;
            this.grbCategory.Controls.Add(this.cbbCategories);
            this.grbCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbCategory.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCategory.Location = new System.Drawing.Point(0, 176);
            this.grbCategory.Name = "grbCategory";
            this.grbCategory.Size = new System.Drawing.Size(285, 60);
            this.grbCategory.TabIndex = 0;
            this.grbCategory.TabStop = false;
            this.grbCategory.Text = "Danh mục";
            // 
            // cbbCategories
            // 
            this.cbbCategories.BackColor = System.Drawing.Color.White;
            this.cbbCategories.FormattingEnabled = true;
            this.cbbCategories.Location = new System.Drawing.Point(6, 25);
            this.cbbCategories.Name = "cbbCategories";
            this.cbbCategories.Size = new System.Drawing.Size(273, 27);
            this.cbbCategories.TabIndex = 0;
            // 
            // grbEndDate
            // 
            this.grbEndDate.BackColor = System.Drawing.Color.Transparent;
            this.grbEndDate.Controls.Add(this.dtpEndDay);
            this.grbEndDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbEndDate.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEndDate.Location = new System.Drawing.Point(0, 116);
            this.grbEndDate.Name = "grbEndDate";
            this.grbEndDate.Size = new System.Drawing.Size(285, 60);
            this.grbEndDate.TabIndex = 0;
            this.grbEndDate.TabStop = false;
            this.grbEndDate.Text = "Đến ngày";
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpEndDay.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpEndDay.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDay.Location = new System.Drawing.Point(6, 25);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(273, 27);
            this.dtpEndDay.TabIndex = 0;
            // 
            // grbStartDate
            // 
            this.grbStartDate.BackColor = System.Drawing.Color.Transparent;
            this.grbStartDate.Controls.Add(this.dtpStartDay);
            this.grbStartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbStartDate.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStartDate.Location = new System.Drawing.Point(0, 60);
            this.grbStartDate.Name = "grbStartDate";
            this.grbStartDate.Size = new System.Drawing.Size(285, 56);
            this.grbStartDate.TabIndex = 0;
            this.grbStartDate.TabStop = false;
            this.grbStartDate.Text = "Từ ngày";
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpStartDay.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpStartDay.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDay.Location = new System.Drawing.Point(6, 25);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(273, 27);
            this.dtpStartDay.TabIndex = 0;
            // 
            // grbTitle
            // 
            this.grbTitle.BackColor = System.Drawing.Color.Transparent;
            this.grbTitle.Controls.Add(this.rbtImportant);
            this.grbTitle.Controls.Add(this.txtTitle);
            this.grbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbTitle.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTitle.Location = new System.Drawing.Point(0, 0);
            this.grbTitle.Name = "grbTitle";
            this.grbTitle.Size = new System.Drawing.Size(285, 60);
            this.grbTitle.TabIndex = 0;
            this.grbTitle.TabStop = false;
            this.grbTitle.Text = "Tiêu đề";
            // 
            // rbtImportant
            // 
            this.rbtImportant.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtImportant.BackgroundImage = global::ToDoAplication.Properties.Resources.star_bw;
            this.rbtImportant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbtImportant.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtImportant.FlatAppearance.BorderSize = 0;
            this.rbtImportant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtImportant.Location = new System.Drawing.Point(252, 24);
            this.rbtImportant.Name = "rbtImportant";
            this.rbtImportant.Size = new System.Drawing.Size(27, 27);
            this.rbtImportant.TabIndex = 0;
            this.rbtImportant.TabStop = true;
            this.rbtImportant.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(6, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(240, 27);
            this.txtTitle.TabIndex = 0;
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 636);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlHeaderButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(897, 50);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-do Application";
            this.pnlHeaderButton.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.grbDescription.ResumeLayout(false);
            this.grbDescription.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.grbInList.ResumeLayout(false);
            this.grbInList.PerformLayout();
            this.grbCategory.ResumeLayout(false);
            this.grbEndDate.ResumeLayout(false);
            this.grbStartDate.ResumeLayout(false);
            this.grbTitle.ResumeLayout(false);
            this.grbTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderButton;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExcelOutput;
        private System.Windows.Forms.Button btnZoomForm;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.GroupBox grbDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtDayCreated;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rbtDone;
        private System.Windows.Forms.GroupBox grbInList;
        private System.Windows.Forms.TextBox txtInList;
        private System.Windows.Forms.GroupBox grbCategory;
        private System.Windows.Forms.ComboBox cbbCategories;
        private System.Windows.Forms.GroupBox grbEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.GroupBox grbStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.GroupBox grbTitle;
        private System.Windows.Forms.RadioButton rbtImportant;
        private System.Windows.Forms.TextBox txtTitle;
    }
}
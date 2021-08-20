
namespace ToDoAplication
{
    partial class frmCalculator
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
            this.tctCalculator = new System.Windows.Forms.TabControl();
            this.tpgCalBMI = new System.Windows.Forms.TabPage();
            this.lblCalBMI = new System.Windows.Forms.Label();
            this.txtCommentBMI = new System.Windows.Forms.TextBox();
            this.txtResultBMI = new System.Windows.Forms.TextBox();
            this.lblCommentBMI = new System.Windows.Forms.Label();
            this.lblResultBMI = new System.Windows.Forms.Label();
            this.btnCalBMI = new System.Windows.Forms.Button();
            this.lblCm = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbHeight = new System.Windows.Forms.PictureBox();
            this.ptbWeight = new System.Windows.Forms.PictureBox();
            this.tpgCalSleep = new System.Windows.Forms.TabPage();
            this.btnZZZ = new System.Windows.Forms.Button();
            this.btnCalTime = new System.Windows.Forms.Button();
            this.cbbAMorPM = new System.Windows.Forms.ComboBox();
            this.cbbMinute = new System.Windows.Forms.ComboBox();
            this.cbbHour = new System.Windows.Forms.ComboBox();
            this.lblIfISleep = new System.Windows.Forms.Label();
            this.lblINeedWakeUp = new System.Windows.Forms.Label();
            this.tpgCalWater = new System.Windows.Forms.TabPage();
            this.btnSubWater = new System.Windows.Forms.Button();
            this.btnAddWater = new System.Windows.Forms.Button();
            this.ptbWaterCup = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tctCalculator.SuspendLayout();
            this.tpgCalBMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWeight)).BeginInit();
            this.tpgCalSleep.SuspendLayout();
            this.tpgCalWater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWaterCup)).BeginInit();
            this.SuspendLayout();
            // 
            // tctCalculator
            // 
            this.tctCalculator.Controls.Add(this.tpgCalBMI);
            this.tctCalculator.Controls.Add(this.tpgCalSleep);
            this.tctCalculator.Controls.Add(this.tpgCalWater);
            this.tctCalculator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctCalculator.ItemSize = new System.Drawing.Size(260, 30);
            this.tctCalculator.Location = new System.Drawing.Point(0, 0);
            this.tctCalculator.Name = "tctCalculator";
            this.tctCalculator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tctCalculator.SelectedIndex = 0;
            this.tctCalculator.Size = new System.Drawing.Size(784, 411);
            this.tctCalculator.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tctCalculator.TabIndex = 0;
            // 
            // tpgCalBMI
            // 
            this.tpgCalBMI.BackColor = System.Drawing.Color.White;
            this.tpgCalBMI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpgCalBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpgCalBMI.Controls.Add(this.lblCalBMI);
            this.tpgCalBMI.Controls.Add(this.txtCommentBMI);
            this.tpgCalBMI.Controls.Add(this.txtResultBMI);
            this.tpgCalBMI.Controls.Add(this.lblCommentBMI);
            this.tpgCalBMI.Controls.Add(this.lblResultBMI);
            this.tpgCalBMI.Controls.Add(this.btnCalBMI);
            this.tpgCalBMI.Controls.Add(this.lblCm);
            this.tpgCalBMI.Controls.Add(this.lblKg);
            this.tpgCalBMI.Controls.Add(this.nudHeight);
            this.tpgCalBMI.Controls.Add(this.label3);
            this.tpgCalBMI.Controls.Add(this.nudWeight);
            this.tpgCalBMI.Controls.Add(this.label1);
            this.tpgCalBMI.Controls.Add(this.ptbHeight);
            this.tpgCalBMI.Controls.Add(this.ptbWeight);
            this.tpgCalBMI.Location = new System.Drawing.Point(4, 34);
            this.tpgCalBMI.Name = "tpgCalBMI";
            this.tpgCalBMI.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCalBMI.Size = new System.Drawing.Size(776, 373);
            this.tpgCalBMI.TabIndex = 0;
            this.tpgCalBMI.Text = "Tính BMI";
            // 
            // lblCalBMI
            // 
            this.lblCalBMI.AutoSize = true;
            this.lblCalBMI.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalBMI.Location = new System.Drawing.Point(265, 211);
            this.lblCalBMI.Name = "lblCalBMI";
            this.lblCalBMI.Size = new System.Drawing.Size(73, 20);
            this.lblCalBMI.TabIndex = 9;
            this.lblCalBMI.Text = "Tính BMI";
            // 
            // txtCommentBMI
            // 
            this.txtCommentBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommentBMI.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentBMI.Location = new System.Drawing.Point(416, 212);
            this.txtCommentBMI.Name = "txtCommentBMI";
            this.txtCommentBMI.Size = new System.Drawing.Size(300, 30);
            this.txtCommentBMI.TabIndex = 8;
            // 
            // txtResultBMI
            // 
            this.txtResultBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultBMI.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultBMI.Location = new System.Drawing.Point(416, 141);
            this.txtResultBMI.Name = "txtResultBMI";
            this.txtResultBMI.Size = new System.Drawing.Size(300, 30);
            this.txtResultBMI.TabIndex = 8;
            // 
            // lblCommentBMI
            // 
            this.lblCommentBMI.AutoSize = true;
            this.lblCommentBMI.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentBMI.Location = new System.Drawing.Point(412, 184);
            this.lblCommentBMI.Name = "lblCommentBMI";
            this.lblCommentBMI.Size = new System.Drawing.Size(164, 20);
            this.lblCommentBMI.TabIndex = 7;
            this.lblCommentBMI.Text = "Nhận xét kết quả BMI:";
            // 
            // lblResultBMI
            // 
            this.lblResultBMI.AutoSize = true;
            this.lblResultBMI.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultBMI.Location = new System.Drawing.Point(412, 113);
            this.lblResultBMI.Name = "lblResultBMI";
            this.lblResultBMI.Size = new System.Drawing.Size(160, 20);
            this.lblResultBMI.TabIndex = 7;
            this.lblResultBMI.Text = "Kết quả BMI của bạn:";
            // 
            // btnCalBMI
            // 
            this.btnCalBMI.BackColor = System.Drawing.Color.Transparent;
            this.btnCalBMI.BackgroundImage = global::ToDoAplication.Properties.Resources.bmi1;
            this.btnCalBMI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalBMI.FlatAppearance.BorderSize = 0;
            this.btnCalBMI.Location = new System.Drawing.Point(263, 133);
            this.btnCalBMI.Name = "btnCalBMI";
            this.btnCalBMI.Size = new System.Drawing.Size(75, 75);
            this.btnCalBMI.TabIndex = 5;
            this.btnCalBMI.UseVisualStyleBackColor = false;
            // 
            // lblCm
            // 
            this.lblCm.AutoSize = true;
            this.lblCm.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCm.Location = new System.Drawing.Point(138, 330);
            this.lblCm.Name = "lblCm";
            this.lblCm.Size = new System.Drawing.Size(31, 20);
            this.lblCm.TabIndex = 4;
            this.lblCm.Text = "cm";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(138, 150);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(26, 20);
            this.lblKg.TabIndex = 4;
            this.lblKg.Text = "kg";
            // 
            // nudHeight
            // 
            this.nudHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudHeight.Location = new System.Drawing.Point(72, 329);
            this.nudHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(60, 26);
            this.nudHeight.TabIndex = 3;
            this.nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "_____";
            // 
            // nudWeight
            // 
            this.nudWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudWeight.Location = new System.Drawing.Point(72, 149);
            this.nudWeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudWeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(60, 26);
            this.nudWeight.TabIndex = 3;
            this.nudWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "_____";
            // 
            // ptbHeight
            // 
            this.ptbHeight.BackColor = System.Drawing.Color.Transparent;
            this.ptbHeight.BackgroundImage = global::ToDoAplication.Properties.Resources.height;
            this.ptbHeight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbHeight.Location = new System.Drawing.Point(53, 198);
            this.ptbHeight.Name = "ptbHeight";
            this.ptbHeight.Size = new System.Drawing.Size(125, 125);
            this.ptbHeight.TabIndex = 0;
            this.ptbHeight.TabStop = false;
            // 
            // ptbWeight
            // 
            this.ptbWeight.BackColor = System.Drawing.Color.Transparent;
            this.ptbWeight.BackgroundImage = global::ToDoAplication.Properties.Resources.weighing_machine;
            this.ptbWeight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbWeight.Location = new System.Drawing.Point(53, 18);
            this.ptbWeight.Name = "ptbWeight";
            this.ptbWeight.Size = new System.Drawing.Size(125, 125);
            this.ptbWeight.TabIndex = 0;
            this.ptbWeight.TabStop = false;
            // 
            // tpgCalSleep
            // 
            this.tpgCalSleep.BackColor = System.Drawing.Color.White;
            this.tpgCalSleep.BackgroundImage = global::ToDoAplication.Properties.Resources._7506562;
            this.tpgCalSleep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpgCalSleep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpgCalSleep.Controls.Add(this.btnZZZ);
            this.tpgCalSleep.Controls.Add(this.btnCalTime);
            this.tpgCalSleep.Controls.Add(this.cbbAMorPM);
            this.tpgCalSleep.Controls.Add(this.cbbMinute);
            this.tpgCalSleep.Controls.Add(this.cbbHour);
            this.tpgCalSleep.Controls.Add(this.lblIfISleep);
            this.tpgCalSleep.Controls.Add(this.lblINeedWakeUp);
            this.tpgCalSleep.Location = new System.Drawing.Point(4, 34);
            this.tpgCalSleep.Name = "tpgCalSleep";
            this.tpgCalSleep.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCalSleep.Size = new System.Drawing.Size(776, 373);
            this.tpgCalSleep.TabIndex = 1;
            this.tpgCalSleep.Text = "Tính Giờ Ngủ";
            // 
            // btnZZZ
            // 
            this.btnZZZ.Location = new System.Drawing.Point(330, 290);
            this.btnZZZ.Name = "btnZZZ";
            this.btnZZZ.Size = new System.Drawing.Size(100, 30);
            this.btnZZZ.TabIndex = 2;
            this.btnZZZ.Text = "zzz";
            this.btnZZZ.UseVisualStyleBackColor = true;
            // 
            // btnCalTime
            // 
            this.btnCalTime.Location = new System.Drawing.Point(330, 160);
            this.btnCalTime.Name = "btnCalTime";
            this.btnCalTime.Size = new System.Drawing.Size(100, 30);
            this.btnCalTime.TabIndex = 2;
            this.btnCalTime.Text = "Tính toán";
            this.btnCalTime.UseVisualStyleBackColor = true;
            // 
            // cbbAMorPM
            // 
            this.cbbAMorPM.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAMorPM.FormattingEnabled = true;
            this.cbbAMorPM.Location = new System.Drawing.Point(447, 100);
            this.cbbAMorPM.Name = "cbbAMorPM";
            this.cbbAMorPM.Size = new System.Drawing.Size(125, 28);
            this.cbbAMorPM.TabIndex = 1;
            // 
            // cbbMinute
            // 
            this.cbbMinute.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMinute.FormattingEnabled = true;
            this.cbbMinute.Location = new System.Drawing.Point(316, 100);
            this.cbbMinute.Name = "cbbMinute";
            this.cbbMinute.Size = new System.Drawing.Size(125, 28);
            this.cbbMinute.TabIndex = 1;
            // 
            // cbbHour
            // 
            this.cbbHour.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHour.FormattingEnabled = true;
            this.cbbHour.Location = new System.Drawing.Point(185, 100);
            this.cbbHour.Name = "cbbHour";
            this.cbbHour.Size = new System.Drawing.Size(125, 28);
            this.cbbHour.TabIndex = 1;
            // 
            // lblIfISleep
            // 
            this.lblIfISleep.AutoSize = true;
            this.lblIfISleep.BackColor = System.Drawing.Color.Transparent;
            this.lblIfISleep.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIfISleep.ForeColor = System.Drawing.Color.White;
            this.lblIfISleep.Location = new System.Drawing.Point(192, 235);
            this.lblIfISleep.Name = "lblIfISleep";
            this.lblIfISleep.Size = new System.Drawing.Size(375, 24);
            this.lblIfISleep.TabIndex = 0;
            this.lblIfISleep.Text = "Nếu tôi ngủ ngay bây giờ, tôi sẽ dậy vào lúc";
            // 
            // lblINeedWakeUp
            // 
            this.lblINeedWakeUp.AutoSize = true;
            this.lblINeedWakeUp.BackColor = System.Drawing.Color.Transparent;
            this.lblINeedWakeUp.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINeedWakeUp.ForeColor = System.Drawing.Color.White;
            this.lblINeedWakeUp.Location = new System.Drawing.Point(272, 45);
            this.lblINeedWakeUp.Name = "lblINeedWakeUp";
            this.lblINeedWakeUp.Size = new System.Drawing.Size(230, 24);
            this.lblINeedWakeUp.TabIndex = 0;
            this.lblINeedWakeUp.Text = "Tôi cần thức dậy vào lúc...";
            // 
            // tpgCalWater
            // 
            this.tpgCalWater.BackColor = System.Drawing.Color.White;
            this.tpgCalWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpgCalWater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpgCalWater.Controls.Add(this.btnSubWater);
            this.tpgCalWater.Controls.Add(this.btnAddWater);
            this.tpgCalWater.Controls.Add(this.ptbWaterCup);
            this.tpgCalWater.Controls.Add(this.textBox1);
            this.tpgCalWater.Controls.Add(this.label5);
            this.tpgCalWater.Controls.Add(this.label4);
            this.tpgCalWater.Controls.Add(this.label2);
            this.tpgCalWater.Location = new System.Drawing.Point(4, 34);
            this.tpgCalWater.Name = "tpgCalWater";
            this.tpgCalWater.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCalWater.Size = new System.Drawing.Size(776, 373);
            this.tpgCalWater.TabIndex = 2;
            this.tpgCalWater.Text = "Tính Lượng Nước";
            // 
            // btnSubWater
            // 
            this.btnSubWater.BackgroundImage = global::ToDoAplication.Properties.Resources.sub_button;
            this.btnSubWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSubWater.Location = new System.Drawing.Point(215, 190);
            this.btnSubWater.Name = "btnSubWater";
            this.btnSubWater.Size = new System.Drawing.Size(50, 50);
            this.btnSubWater.TabIndex = 5;
            this.btnSubWater.UseVisualStyleBackColor = true;
            // 
            // btnAddWater
            // 
            this.btnAddWater.BackgroundImage = global::ToDoAplication.Properties.Resources.add_button;
            this.btnAddWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddWater.Location = new System.Drawing.Point(500, 190);
            this.btnAddWater.Name = "btnAddWater";
            this.btnAddWater.Size = new System.Drawing.Size(50, 50);
            this.btnAddWater.TabIndex = 5;
            this.btnAddWater.UseVisualStyleBackColor = true;
            // 
            // ptbWaterCup
            // 
            this.ptbWaterCup.BackgroundImage = global::ToDoAplication.Properties.Resources.plastic_cup1;
            this.ptbWaterCup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbWaterCup.Location = new System.Drawing.Point(295, 130);
            this.ptbWaterCup.Name = "ptbWaterCup";
            this.ptbWaterCup.Size = new System.Drawing.Size(175, 175);
            this.ptbWaterCup.TabIndex = 4;
            this.ptbWaterCup.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(306, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 33);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "2.25 lít";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(300, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "_____________";
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.tctCalculator);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculator";
            this.ShowInTaskbar = false;
            this.Text = "frmCalculator";
            this.tctCalculator.ResumeLayout(false);
            this.tpgCalBMI.ResumeLayout(false);
            this.tpgCalBMI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWeight)).EndInit();
            this.tpgCalSleep.ResumeLayout(false);
            this.tpgCalSleep.PerformLayout();
            this.tpgCalWater.ResumeLayout(false);
            this.tpgCalWater.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWaterCup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctCalculator;
        private System.Windows.Forms.TabPage tpgCalBMI;
        private System.Windows.Forms.TabPage tpgCalSleep;
        private System.Windows.Forms.TabPage tpgCalWater;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbHeight;
        private System.Windows.Forms.PictureBox ptbWeight;
        private System.Windows.Forms.Label lblCm;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalBMI;
        private System.Windows.Forms.TextBox txtCommentBMI;
        private System.Windows.Forms.TextBox txtResultBMI;
        private System.Windows.Forms.Label lblCommentBMI;
        private System.Windows.Forms.Label lblResultBMI;
        private System.Windows.Forms.Label lblCalBMI;
        private System.Windows.Forms.Label lblINeedWakeUp;
        private System.Windows.Forms.Button btnZZZ;
        private System.Windows.Forms.Button btnCalTime;
        private System.Windows.Forms.ComboBox cbbAMorPM;
        private System.Windows.Forms.ComboBox cbbMinute;
        private System.Windows.Forms.ComboBox cbbHour;
        private System.Windows.Forms.Label lblIfISleep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox ptbWaterCup;
        private System.Windows.Forms.Button btnAddWater;
        private System.Windows.Forms.Button btnSubWater;
    }
}
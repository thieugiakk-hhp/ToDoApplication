
namespace ToDoAplication
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbBanner = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grbLoginSignin = new System.Windows.Forms.GroupBox();
            this.rbtSignUp = new System.Windows.Forms.RadioButton();
            this.rbtLogin = new System.Windows.Forms.RadioButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLoginSignup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBanner)).BeginInit();
            this.grbLoginSignin.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbBanner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 317);
            this.panel1.TabIndex = 0;
            // 
            // ptbBanner
            // 
            this.ptbBanner.BackgroundImage = global::ToDoAplication.Properties.Resources.Artboard_1;
            this.ptbBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbBanner.Location = new System.Drawing.Point(0, 0);
            this.ptbBanner.Name = "ptbBanner";
            this.ptbBanner.Size = new System.Drawing.Size(180, 317);
            this.ptbBanner.TabIndex = 0;
            this.ptbBanner.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(67, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 24);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(182, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 30);
            this.txtEmail.TabIndex = 2;
            // 
            // grbLoginSignin
            // 
            this.grbLoginSignin.Controls.Add(this.rbtSignUp);
            this.grbLoginSignin.Controls.Add(this.rbtLogin);
            this.grbLoginSignin.Location = new System.Drawing.Point(107, 30);
            this.grbLoginSignin.Name = "grbLoginSignin";
            this.grbLoginSignin.Size = new System.Drawing.Size(250, 75);
            this.grbLoginSignin.TabIndex = 3;
            this.grbLoginSignin.TabStop = false;
            // 
            // rbtSignUp
            // 
            this.rbtSignUp.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtSignUp.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSignUp.Location = new System.Drawing.Point(145, 26);
            this.rbtSignUp.Name = "rbtSignUp";
            this.rbtSignUp.Size = new System.Drawing.Size(100, 35);
            this.rbtSignUp.TabIndex = 0;
            this.rbtSignUp.TabStop = true;
            this.rbtSignUp.Text = "Đăng ký";
            this.rbtSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtSignUp.UseVisualStyleBackColor = true;
            // 
            // rbtLogin
            // 
            this.rbtLogin.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtLogin.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtLogin.Location = new System.Drawing.Point(6, 26);
            this.rbtLogin.Name = "rbtLogin";
            this.rbtLogin.Size = new System.Drawing.Size(100, 35);
            this.rbtLogin.TabIndex = 0;
            this.rbtLogin.TabStop = true;
            this.rbtLogin.Text = "Đăng nhập";
            this.rbtLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtLogin.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(67, 190);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 24);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(182, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.TabIndex = 2;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnLoginSignup);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.grbLoginSignin);
            this.pnlLogin.Controls.Add(this.txtEmail);
            this.pnlLogin.Controls.Add(this.lblEmail);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLogin.Location = new System.Drawing.Point(180, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(440, 317);
            this.pnlLogin.TabIndex = 4;
            // 
            // btnLoginSignup
            // 
            this.btnLoginSignup.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginSignup.Location = new System.Drawing.Point(182, 245);
            this.btnLoginSignup.Name = "btnLoginSignup";
            this.btnLoginSignup.Size = new System.Drawing.Size(100, 35);
            this.btnLoginSignup.TabIndex = 4;
            this.btnLoginSignup.Text = "OK";
            this.btnLoginSignup.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 317);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký - Đăng nhập";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBanner)).EndInit();
            this.grbLoginSignin.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbBanner;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grbLoginSignin;
        private System.Windows.Forms.RadioButton rbtSignUp;
        private System.Windows.Forms.RadioButton rbtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLoginSignup;
    }
}
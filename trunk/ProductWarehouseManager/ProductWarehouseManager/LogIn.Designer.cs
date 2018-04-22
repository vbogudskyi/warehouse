namespace ProductWarehouseManager
{
    partial class LogIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnklbl_SignUp = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_DateTime = new System.Windows.Forms.Label();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_BrowseRSA = new System.Windows.Forms.Button();
            this.lb_RSA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(80, 79);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(162, 123);
            this.panel1.TabIndex = 22;
            // 
            // lnklbl_SignUp
            // 
            this.lnklbl_SignUp.AutoSize = true;
            this.lnklbl_SignUp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklbl_SignUp.Location = new System.Drawing.Point(621, 264);
            this.lnklbl_SignUp.Name = "lnklbl_SignUp";
            this.lnklbl_SignUp.Size = new System.Drawing.Size(72, 14);
            this.lnklbl_SignUp.TabIndex = 21;
            this.lnklbl_SignUp.TabStop = true;
            this.lnklbl_SignUp.Text = "Sign Up Here";
            this.toolTip1.SetToolTip(this.lnklbl_SignUp, "Sign Up");
            this.lnklbl_SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_SignUp_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(623, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 20;
            this.label4.Text = "No Account?";
            // 
            // lb_DateTime
            // 
            this.lb_DateTime.AutoSize = true;
            this.lb_DateTime.Location = new System.Drawing.Point(172, 459);
            this.lb_DateTime.Name = "lb_DateTime";
            this.lb_DateTime.Size = new System.Drawing.Size(0, 13);
            this.lb_DateTime.TabIndex = 19;
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignIn.Location = new System.Drawing.Point(385, 248);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(90, 28);
            this.btn_SignIn.TabIndex = 17;
            this.btn_SignIn.Text = "Sign In";
            this.toolTip1.SetToolTip(this.btn_SignIn, "Sign In");
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(496, 148);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(197, 22);
            this.txt_Password.TabIndex = 16;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_UserId
            // 
            this.txt_UserId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserId.Location = new System.Drawing.Point(496, 98);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(197, 22);
            this.txt_UserId.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "E-mail: ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 56);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product WareHouse Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(307, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 293);
            this.panel2.TabIndex = 23;
            // 
            // btn_BrowseRSA
            // 
            this.btn_BrowseRSA.Location = new System.Drawing.Point(385, 198);
            this.btn_BrowseRSA.Name = "btn_BrowseRSA";
            this.btn_BrowseRSA.Size = new System.Drawing.Size(90, 28);
            this.btn_BrowseRSA.TabIndex = 24;
            this.btn_BrowseRSA.Text = "Browse RSA...";
            this.btn_BrowseRSA.UseVisualStyleBackColor = true;
            this.btn_BrowseRSA.Click += new System.EventHandler(this.btn_BrowseRSA_Click);
            // 
            // lb_RSA
            // 
            this.lb_RSA.AutoSize = true;
            this.lb_RSA.Location = new System.Drawing.Point(493, 202);
            this.lb_RSA.Name = "lb_RSA";
            this.lb_RSA.Size = new System.Drawing.Size(0, 13);
            this.lb_RSA.TabIndex = 25;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 375);
            this.Controls.Add(this.lb_RSA);
            this.Controls.Add(this.btn_BrowseRSA);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lnklbl_SignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_DateTime);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "Product WareHouse MS, Log In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnklbl_SignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_DateTime;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_BrowseRSA;
        private System.Windows.Forms.Label lb_RSA;
    }
}
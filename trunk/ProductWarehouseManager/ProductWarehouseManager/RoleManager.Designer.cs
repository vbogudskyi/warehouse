namespace ProductWarehouseManager
{
    partial class RoleManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleManager));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picbx_Suspend = new System.Windows.Forms.PictureBox();
            this.picbx_Delete = new System.Windows.Forms.PictureBox();
            this.picbx_Update = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Company = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbx_Role = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_LogIn = new System.Windows.Forms.TextBox();
            this.txt_RSA = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbx_RoleManager = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Suspend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Update)).BeginInit();
            this.SuspendLayout();
            // 
            // picbx_Suspend
            // 
            this.picbx_Suspend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbx_Suspend.BackgroundImage")));
            this.picbx_Suspend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbx_Suspend.Location = new System.Drawing.Point(186, 321);
            this.picbx_Suspend.Name = "picbx_Suspend";
            this.picbx_Suspend.Size = new System.Drawing.Size(26, 23);
            this.picbx_Suspend.TabIndex = 71;
            this.picbx_Suspend.TabStop = false;
            this.toolTip1.SetToolTip(this.picbx_Suspend, "Suspend/Unsuspend");
            // 
            // picbx_Delete
            // 
            this.picbx_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbx_Delete.BackgroundImage")));
            this.picbx_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbx_Delete.Location = new System.Drawing.Point(154, 321);
            this.picbx_Delete.Name = "picbx_Delete";
            this.picbx_Delete.Size = new System.Drawing.Size(26, 23);
            this.picbx_Delete.TabIndex = 70;
            this.picbx_Delete.TabStop = false;
            this.toolTip1.SetToolTip(this.picbx_Delete, "Delete");
            // 
            // picbx_Update
            // 
            this.picbx_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbx_Update.BackgroundImage")));
            this.picbx_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbx_Update.Location = new System.Drawing.Point(122, 321);
            this.picbx_Update.Name = "picbx_Update";
            this.picbx_Update.Size = new System.Drawing.Size(26, 23);
            this.picbx_Update.TabIndex = 69;
            this.picbx_Update.TabStop = false;
            this.toolTip1.SetToolTip(this.picbx_Update, "Update");
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(239, 321);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 24);
            this.btn_Save.TabIndex = 51;
            this.btn_Save.Text = "Save";
            this.toolTip1.SetToolTip(this.btn_Save, "Save");
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // txt_Company
            // 
            this.txt_Company.Location = new System.Drawing.Point(293, 286);
            this.txt_Company.Name = "txt_Company";
            this.txt_Company.Size = new System.Drawing.Size(100, 20);
            this.txt_Company.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Company";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(293, 241);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(100, 20);
            this.txt_IP.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "IP";
            // 
            // cmbx_Role
            // 
            this.cmbx_Role.Enabled = false;
            this.cmbx_Role.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Role.FormattingEnabled = true;
            this.cmbx_Role.Location = new System.Drawing.Point(293, 202);
            this.cmbx_Role.Name = "cmbx_Role";
            this.cmbx_Role.Size = new System.Drawing.Size(100, 24);
            this.cmbx_Role.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Roles";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(293, 159);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Password";
            // 
            // txt_LogIn
            // 
            this.txt_LogIn.Location = new System.Drawing.Point(293, 124);
            this.txt_LogIn.Name = "txt_LogIn";
            this.txt_LogIn.Size = new System.Drawing.Size(100, 20);
            this.txt_LogIn.TabIndex = 60;
            // 
            // txt_RSA
            // 
            this.txt_RSA.Location = new System.Drawing.Point(293, 86);
            this.txt_RSA.Name = "txt_RSA";
            this.txt_RSA.Size = new System.Drawing.Size(100, 20);
            this.txt_RSA.TabIndex = 59;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(293, 54);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 58;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(293, 21);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 20);
            this.txt_LastName.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "LOG IN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "RSA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Last Name";
            // 
            // lstbx_RoleManager
            // 
            this.lstbx_RoleManager.FormattingEnabled = true;
            this.lstbx_RoleManager.Location = new System.Drawing.Point(12, 12);
            this.lstbx_RoleManager.Name = "lstbx_RoleManager";
            this.lstbx_RoleManager.Size = new System.Drawing.Size(200, 303);
            this.lstbx_RoleManager.TabIndex = 52;
            // 
            // RoleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 375);
            this.Controls.Add(this.picbx_Suspend);
            this.Controls.Add(this.picbx_Delete);
            this.Controls.Add(this.picbx_Update);
            this.Controls.Add(this.txt_Company);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbx_Role);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_LogIn);
            this.Controls.Add(this.txt_RSA);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbx_RoleManager);
            this.Controls.Add(this.btn_Save);
            this.Name = "RoleManager";
            this.Text = "RoleManager";
            this.Load += new System.EventHandler(this.RoleManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Suspend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picbx_Suspend;
        private System.Windows.Forms.PictureBox picbx_Delete;
        private System.Windows.Forms.PictureBox picbx_Update;
        private System.Windows.Forms.TextBox txt_Company;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbx_Role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_LogIn;
        private System.Windows.Forms.TextBox txt_RSA;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbx_RoleManager;
        private System.Windows.Forms.Button btn_Save;
    }
}
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Save = new System.Windows.Forms.Button();
            this.ckbx_Select = new System.Windows.Forms.CheckBox();
            this.ckbx_Insert = new System.Windows.Forms.CheckBox();
            this.ckbx_Update = new System.Windows.Forms.CheckBox();
            this.ckbx_All = new System.Windows.Forms.CheckBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.clbx_Delete = new System.Windows.Forms.CheckBox();
            this.ckbx_User = new System.Windows.Forms.CheckBox();
            this.ckbx_BulkLoad = new System.Windows.Forms.CheckBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.ckbx_reports = new System.Windows.Forms.CheckBox();
            this.lstbx_RoleManager = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Serch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(258, 355);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 24);
            this.btn_Save.TabIndex = 51;
            this.btn_Save.Text = "Save";
            this.toolTip1.SetToolTip(this.btn_Save, "Save");
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // ckbx_Select
            // 
            this.ckbx_Select.AutoSize = true;
            this.ckbx_Select.Location = new System.Drawing.Point(6, 82);
            this.ckbx_Select.Name = "ckbx_Select";
            this.ckbx_Select.Size = new System.Drawing.Size(56, 17);
            this.ckbx_Select.TabIndex = 3;
            this.ckbx_Select.Text = "Select";
            this.toolTip1.SetToolTip(this.ckbx_Select, "Grant Select");
            this.ckbx_Select.UseVisualStyleBackColor = true;
            this.ckbx_Select.CheckStateChanged += new System.EventHandler(this.on_Checked);
            // 
            // ckbx_Insert
            // 
            this.ckbx_Insert.AutoSize = true;
            this.ckbx_Insert.Location = new System.Drawing.Point(6, 42);
            this.ckbx_Insert.Name = "ckbx_Insert";
            this.ckbx_Insert.Size = new System.Drawing.Size(52, 17);
            this.ckbx_Insert.TabIndex = 2;
            this.ckbx_Insert.Text = "Insert";
            this.toolTip1.SetToolTip(this.ckbx_Insert, "Grant Insert");
            this.ckbx_Insert.UseVisualStyleBackColor = true;
            this.ckbx_Insert.CheckStateChanged += new System.EventHandler(this.on_Checked);
            // 
            // ckbx_Update
            // 
            this.ckbx_Update.AutoSize = true;
            this.ckbx_Update.Location = new System.Drawing.Point(6, 62);
            this.ckbx_Update.Name = "ckbx_Update";
            this.ckbx_Update.Size = new System.Drawing.Size(61, 17);
            this.ckbx_Update.TabIndex = 1;
            this.ckbx_Update.Text = "Update";
            this.toolTip1.SetToolTip(this.ckbx_Update, "Grant Update");
            this.ckbx_Update.UseVisualStyleBackColor = true;
            this.ckbx_Update.CheckStateChanged += new System.EventHandler(this.on_Checked);
            // 
            // ckbx_All
            // 
            this.ckbx_All.AutoSize = true;
            this.ckbx_All.Location = new System.Drawing.Point(6, 22);
            this.ckbx_All.Name = "ckbx_All";
            this.ckbx_All.Size = new System.Drawing.Size(37, 17);
            this.ckbx_All.TabIndex = 0;
            this.ckbx_All.Text = "All";
            this.toolTip1.SetToolTip(this.ckbx_All, "Grant All");
            this.ckbx_All.UseVisualStyleBackColor = true;
            this.ckbx_All.CheckStateChanged += new System.EventHandler(this.on_Checked);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(389, 355);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 24);
            this.btn_Back.TabIndex = 73;
            this.btn_Back.Text = "Back";
            this.toolTip1.SetToolTip(this.btn_Back, "Back");
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // clbx_Delete
            // 
            this.clbx_Delete.AutoSize = true;
            this.clbx_Delete.Location = new System.Drawing.Point(6, 102);
            this.clbx_Delete.Name = "clbx_Delete";
            this.clbx_Delete.Size = new System.Drawing.Size(57, 17);
            this.clbx_Delete.TabIndex = 5;
            this.clbx_Delete.Text = "Delete";
            this.toolTip1.SetToolTip(this.clbx_Delete, "Grant Update");
            this.clbx_Delete.UseVisualStyleBackColor = true;
            this.clbx_Delete.CheckStateChanged += new System.EventHandler(this.on_Checked);
            // 
            // ckbx_User
            // 
            this.ckbx_User.AutoSize = true;
            this.ckbx_User.Location = new System.Drawing.Point(6, 122);
            this.ckbx_User.Name = "ckbx_User";
            this.ckbx_User.Size = new System.Drawing.Size(48, 17);
            this.ckbx_User.TabIndex = 6;
            this.ckbx_User.Text = "User";
            this.toolTip1.SetToolTip(this.ckbx_User, "Grant Update");
            this.ckbx_User.UseVisualStyleBackColor = true;
            this.ckbx_User.CheckStateChanged += new System.EventHandler(this.on_Checked);
            // 
            // ckbx_BulkLoad
            // 
            this.ckbx_BulkLoad.AutoSize = true;
            this.ckbx_BulkLoad.Location = new System.Drawing.Point(6, 162);
            this.ckbx_BulkLoad.Name = "ckbx_BulkLoad";
            this.ckbx_BulkLoad.Size = new System.Drawing.Size(91, 17);
            this.ckbx_BulkLoad.TabIndex = 7;
            this.ckbx_BulkLoad.Text = "Data Transfer";
            this.toolTip1.SetToolTip(this.ckbx_BulkLoad, "Grant Update");
            this.ckbx_BulkLoad.UseVisualStyleBackColor = true;
            this.ckbx_BulkLoad.CheckStateChanged += new System.EventHandler(this.on_Checked);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(137, 48);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 24);
            this.btn_Search.TabIndex = 76;
            this.btn_Search.Text = "Search";
            this.toolTip1.SetToolTip(this.btn_Search, "Search Users");
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // ckbx_reports
            // 
            this.ckbx_reports.AutoSize = true;
            this.ckbx_reports.Enabled = false;
            this.ckbx_reports.Location = new System.Drawing.Point(6, 142);
            this.ckbx_reports.Name = "ckbx_reports";
            this.ckbx_reports.Size = new System.Drawing.Size(97, 17);
            this.ckbx_reports.TabIndex = 4;
            this.ckbx_reports.Text = "Create Reports";
            this.toolTip1.SetToolTip(this.ckbx_reports, "Grant Create Reports");
            this.ckbx_reports.UseVisualStyleBackColor = true;
            this.ckbx_reports.CheckStateChanged += new System.EventHandler(this.on_Checked);
            // 
            // lstbx_RoleManager
            // 
            this.lstbx_RoleManager.FormattingEnabled = true;
            this.lstbx_RoleManager.Location = new System.Drawing.Point(12, 76);
            this.lstbx_RoleManager.Name = "lstbx_RoleManager";
            this.lstbx_RoleManager.Size = new System.Drawing.Size(200, 303);
            this.lstbx_RoleManager.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbx_BulkLoad);
            this.groupBox1.Controls.Add(this.ckbx_User);
            this.groupBox1.Controls.Add(this.clbx_Delete);
            this.groupBox1.Controls.Add(this.ckbx_reports);
            this.groupBox1.Controls.Add(this.ckbx_Select);
            this.groupBox1.Controls.Add(this.ckbx_Insert);
            this.groupBox1.Controls.Add(this.ckbx_Update);
            this.groupBox1.Controls.Add(this.ckbx_All);
            this.groupBox1.Location = new System.Drawing.Point(258, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 192);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grant Permissions";
            // 
            // txt_Serch
            // 
            this.txt_Serch.Location = new System.Drawing.Point(53, 22);
            this.txt_Serch.Name = "txt_Serch";
            this.txt_Serch.Size = new System.Drawing.Size(159, 20);
            this.txt_Serch.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Role";
            // 
            // RoleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 429);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Serch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstbx_RoleManager);
            this.Controls.Add(this.btn_Save);
            this.Name = "RoleManager";
            this.Text = "RoleManager";
            this.Load += new System.EventHandler(this.RoleManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox lstbx_RoleManager;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbx_Select;
        private System.Windows.Forms.CheckBox ckbx_Insert;
        private System.Windows.Forms.CheckBox ckbx_Update;
        private System.Windows.Forms.CheckBox ckbx_All;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.CheckBox ckbx_BulkLoad;
        private System.Windows.Forms.CheckBox ckbx_User;
        private System.Windows.Forms.CheckBox clbx_Delete;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Serch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckbx_reports;
    }
}
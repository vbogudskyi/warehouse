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
            this.picbx_Add = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lstbx_RoleManager = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbx_reports = new System.Windows.Forms.CheckBox();
            this.ckbx_Select = new System.Windows.Forms.CheckBox();
            this.ckbx_Insert = new System.Windows.Forms.CheckBox();
            this.ckbx_Update = new System.Windows.Forms.CheckBox();
            this.ckbx_All = new System.Windows.Forms.CheckBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Suspend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Add)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // picbx_Add
            // 
            this.picbx_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbx_Add.BackgroundImage")));
            this.picbx_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbx_Add.Location = new System.Drawing.Point(122, 321);
            this.picbx_Add.Name = "picbx_Add";
            this.picbx_Add.Size = new System.Drawing.Size(26, 23);
            this.picbx_Add.TabIndex = 69;
            this.picbx_Add.TabStop = false;
            this.toolTip1.SetToolTip(this.picbx_Add, "Add");
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
            // lstbx_RoleManager
            // 
            this.lstbx_RoleManager.FormattingEnabled = true;
            this.lstbx_RoleManager.Location = new System.Drawing.Point(12, 12);
            this.lstbx_RoleManager.Name = "lstbx_RoleManager";
            this.lstbx_RoleManager.Size = new System.Drawing.Size(200, 303);
            this.lstbx_RoleManager.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbx_reports);
            this.groupBox1.Controls.Add(this.ckbx_Select);
            this.groupBox1.Controls.Add(this.ckbx_Insert);
            this.groupBox1.Controls.Add(this.ckbx_Update);
            this.groupBox1.Controls.Add(this.ckbx_All);
            this.groupBox1.Location = new System.Drawing.Point(248, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 164);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grant Permissions";
            // 
            // ckbx_reports
            // 
            this.ckbx_reports.AutoSize = true;
            this.ckbx_reports.Location = new System.Drawing.Point(5, 111);
            this.ckbx_reports.Name = "ckbx_reports";
            this.ckbx_reports.Size = new System.Drawing.Size(97, 17);
            this.ckbx_reports.TabIndex = 4;
            this.ckbx_reports.Text = "Create Reports";
            this.toolTip1.SetToolTip(this.ckbx_reports, "Grant Create Reports");
            this.ckbx_reports.UseVisualStyleBackColor = true;
            // 
            // ckbx_Select
            // 
            this.ckbx_Select.AutoSize = true;
            this.ckbx_Select.Location = new System.Drawing.Point(6, 88);
            this.ckbx_Select.Name = "ckbx_Select";
            this.ckbx_Select.Size = new System.Drawing.Size(56, 17);
            this.ckbx_Select.TabIndex = 3;
            this.ckbx_Select.Text = "Select";
            this.toolTip1.SetToolTip(this.ckbx_Select, "Grant Select");
            this.ckbx_Select.UseVisualStyleBackColor = true;
            // 
            // ckbx_Insert
            // 
            this.ckbx_Insert.AutoSize = true;
            this.ckbx_Insert.Location = new System.Drawing.Point(5, 65);
            this.ckbx_Insert.Name = "ckbx_Insert";
            this.ckbx_Insert.Size = new System.Drawing.Size(52, 17);
            this.ckbx_Insert.TabIndex = 2;
            this.ckbx_Insert.Text = "Insert";
            this.toolTip1.SetToolTip(this.ckbx_Insert, "Grant Insert");
            this.ckbx_Insert.UseVisualStyleBackColor = true;
            // 
            // ckbx_Update
            // 
            this.ckbx_Update.AutoSize = true;
            this.ckbx_Update.Location = new System.Drawing.Point(6, 42);
            this.ckbx_Update.Name = "ckbx_Update";
            this.ckbx_Update.Size = new System.Drawing.Size(61, 17);
            this.ckbx_Update.TabIndex = 1;
            this.ckbx_Update.Text = "Update";
            this.toolTip1.SetToolTip(this.ckbx_Update, "Grant Update");
            this.ckbx_Update.UseVisualStyleBackColor = true;
            // 
            // ckbx_All
            // 
            this.ckbx_All.AutoSize = true;
            this.ckbx_All.Location = new System.Drawing.Point(6, 19);
            this.ckbx_All.Name = "ckbx_All";
            this.ckbx_All.Size = new System.Drawing.Size(37, 17);
            this.ckbx_All.TabIndex = 0;
            this.ckbx_All.Text = "All";
            this.toolTip1.SetToolTip(this.ckbx_All, "Grant All");
            this.ckbx_All.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(324, 321);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 24);
            this.btn_Cancel.TabIndex = 73;
            this.btn_Cancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btn_Cancel, "Save");
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // RoleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 375);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picbx_Suspend);
            this.Controls.Add(this.picbx_Delete);
            this.Controls.Add(this.picbx_Add);
            this.Controls.Add(this.lstbx_RoleManager);
            this.Controls.Add(this.btn_Save);
            this.Name = "RoleManager";
            this.Text = "RoleManager";
            this.Load += new System.EventHandler(this.RoleManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Suspend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Add)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picbx_Suspend;
        private System.Windows.Forms.PictureBox picbx_Delete;
        private System.Windows.Forms.PictureBox picbx_Add;
        private System.Windows.Forms.ListBox lstbx_RoleManager;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbx_reports;
        private System.Windows.Forms.CheckBox ckbx_Select;
        private System.Windows.Forms.CheckBox ckbx_Insert;
        private System.Windows.Forms.CheckBox ckbx_Update;
        private System.Windows.Forms.CheckBox ckbx_All;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
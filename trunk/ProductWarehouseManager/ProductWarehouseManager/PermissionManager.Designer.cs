namespace ProductWarehouseManager
{
    partial class PermissionManager
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
            this.lstbx_PermissionManager = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbx_All = new System.Windows.Forms.CheckBox();
            this.ckbx_Update = new System.Windows.Forms.CheckBox();
            this.ckbx_Insert = new System.Windows.Forms.CheckBox();
            this.ckbx_Select = new System.Windows.Forms.CheckBox();
            this.ckbx_reports = new System.Windows.Forms.CheckBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbx_PermissionManager
            // 
            this.lstbx_PermissionManager.FormattingEnabled = true;
            this.lstbx_PermissionManager.Location = new System.Drawing.Point(12, 12);
            this.lstbx_PermissionManager.Name = "lstbx_PermissionManager";
            this.lstbx_PermissionManager.Size = new System.Drawing.Size(200, 303);
            this.lstbx_PermissionManager.TabIndex = 53;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbx_reports);
            this.groupBox1.Controls.Add(this.ckbx_Select);
            this.groupBox1.Controls.Add(this.ckbx_Insert);
            this.groupBox1.Controls.Add(this.ckbx_Update);
            this.groupBox1.Controls.Add(this.ckbx_All);
            this.groupBox1.Location = new System.Drawing.Point(252, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 141);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grant Permissions";
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
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(258, 172);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 55;
            this.btn_Submit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btn_Submit, "Submit Sellection");
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // PermissionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 383);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstbx_PermissionManager);
            this.Name = "PermissionManager";
            this.Text = "PermissionManager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox lstbx_PermissionManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbx_reports;
        private System.Windows.Forms.CheckBox ckbx_Select;
        private System.Windows.Forms.CheckBox ckbx_Insert;
        private System.Windows.Forms.CheckBox ckbx_Update;
        private System.Windows.Forms.CheckBox ckbx_All;
        private System.Windows.Forms.Button btn_Submit;
    }
}
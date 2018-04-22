namespace ProductWarehouseManager
{
    partial class BulkLoad
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
            this.lsbx_BulkLoad = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsbx_Logs = new System.Windows.Forms.ListBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.btn_ClearLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbx_BulkLoad
            // 
            this.lsbx_BulkLoad.FormattingEnabled = true;
            this.lsbx_BulkLoad.Location = new System.Drawing.Point(12, 37);
            this.lsbx_BulkLoad.Name = "lsbx_BulkLoad";
            this.lsbx_BulkLoad.Size = new System.Drawing.Size(229, 342);
            this.lsbx_BulkLoad.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(356, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 366);
            this.panel2.TabIndex = 24;
            // 
            // lsbx_Logs
            // 
            this.lsbx_Logs.FormattingEnabled = true;
            this.lsbx_Logs.Location = new System.Drawing.Point(459, 37);
            this.lsbx_Logs.Name = "lsbx_Logs";
            this.lsbx_Logs.Size = new System.Drawing.Size(229, 342);
            this.lsbx_Logs.TabIndex = 25;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(255, 95);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 26;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(255, 137);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 27;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(255, 180);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 28;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(255, 53);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 29;
            this.btn_Browse.Text = "Browse...";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.Location = new System.Drawing.Point(255, 220);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearAll.TabIndex = 30;
            this.btn_ClearAll.Text = "Clear All";
            this.btn_ClearAll.UseVisualStyleBackColor = true;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_ClearLog
            // 
            this.btn_ClearLog.Location = new System.Drawing.Point(378, 220);
            this.btn_ClearLog.Name = "btn_ClearLog";
            this.btn_ClearLog.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearLog.TabIndex = 31;
            this.btn_ClearLog.Text = "Clear All";
            this.btn_ClearLog.UseVisualStyleBackColor = true;
            this.btn_ClearLog.Click += new System.EventHandler(this.btn_ClearLog_Click);
            // 
            // BulkLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 412);
            this.Controls.Add(this.btn_ClearLog);
            this.Controls.Add(this.btn_ClearAll);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.lsbx_Logs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lsbx_BulkLoad);
            this.Name = "BulkLoad";
            this.Text = "Data Transfer";
            this.Load += new System.EventHandler(this.BulkLoad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbx_BulkLoad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lsbx_Logs;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_ClearAll;
        private System.Windows.Forms.Button btn_ClearLog;
    }
}
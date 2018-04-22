namespace ProductWarehouseManager
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BulkLoad = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_RoleManage = new System.Windows.Forms.Button();
            this.btn_UserManage = new System.Windows.Forms.Button();
            this.btn_MyAcc = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_RetrieveProduct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Warehouse Product Manager";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(380, 31);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(0, 19);
            this.lbl_Name.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RetrieveProduct);
            this.groupBox1.Controls.Add(this.btn_BulkLoad);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 240);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // btn_BulkLoad
            // 
            this.btn_BulkLoad.AutoSize = true;
            this.btn_BulkLoad.Location = new System.Drawing.Point(6, 190);
            this.btn_BulkLoad.Name = "btn_BulkLoad";
            this.btn_BulkLoad.Size = new System.Drawing.Size(197, 29);
            this.btn_BulkLoad.TabIndex = 2;
            this.btn_BulkLoad.Text = "Bulk Load";
            this.btn_BulkLoad.UseVisualStyleBackColor = true;
            this.btn_BulkLoad.Click += new System.EventHandler(this.btn_BulkLoad_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.AutoSize = true;
            this.btn_Update.Location = new System.Drawing.Point(6, 138);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(197, 29);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Search/Update Product";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AutoSize = true;
            this.btn_Add.Location = new System.Drawing.Point(6, 35);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(197, 29);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add Product";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_RoleManage);
            this.groupBox2.Controls.Add(this.btn_UserManage);
            this.groupBox2.Controls.Add(this.btn_MyAcc);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(314, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User";
            // 
            // btn_RoleManage
            // 
            this.btn_RoleManage.AutoSize = true;
            this.btn_RoleManage.Location = new System.Drawing.Point(6, 138);
            this.btn_RoleManage.Name = "btn_RoleManage";
            this.btn_RoleManage.Size = new System.Drawing.Size(178, 29);
            this.btn_RoleManage.TabIndex = 2;
            this.btn_RoleManage.Text = "Role Management";
            this.btn_RoleManage.UseVisualStyleBackColor = true;
            this.btn_RoleManage.Click += new System.EventHandler(this.btn_RoleManage_Click);
            // 
            // btn_UserManage
            // 
            this.btn_UserManage.AutoSize = true;
            this.btn_UserManage.Location = new System.Drawing.Point(6, 87);
            this.btn_UserManage.Name = "btn_UserManage";
            this.btn_UserManage.Size = new System.Drawing.Size(178, 29);
            this.btn_UserManage.TabIndex = 1;
            this.btn_UserManage.Text = "User Management";
            this.btn_UserManage.UseVisualStyleBackColor = true;
            this.btn_UserManage.Click += new System.EventHandler(this.btn_UserManage_Click);
            // 
            // btn_MyAcc
            // 
            this.btn_MyAcc.AutoSize = true;
            this.btn_MyAcc.Location = new System.Drawing.Point(6, 35);
            this.btn_MyAcc.Name = "btn_MyAcc";
            this.btn_MyAcc.Size = new System.Drawing.Size(178, 29);
            this.btn_MyAcc.TabIndex = 0;
            this.btn_MyAcc.Text = "MyAccount";
            this.btn_MyAcc.UseVisualStyleBackColor = true;
            this.btn_MyAcc.Click += new System.EventHandler(this.btn_MyAcc_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(574, 395);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_RetrieveProduct
            // 
            this.btn_RetrieveProduct.AutoSize = true;
            this.btn_RetrieveProduct.Location = new System.Drawing.Point(6, 87);
            this.btn_RetrieveProduct.Name = "btn_RetrieveProduct";
            this.btn_RetrieveProduct.Size = new System.Drawing.Size(197, 29);
            this.btn_RetrieveProduct.TabIndex = 3;
            this.btn_RetrieveProduct.Text = "Retrieve Product";
            this.btn_RetrieveProduct.UseVisualStyleBackColor = true;
            this.btn_RetrieveProduct.Click += new System.EventHandler(this.btn_RetrieveProduct_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 456);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_UserManage;
        private System.Windows.Forms.Button btn_MyAcc;
        private System.Windows.Forms.Button btn_RoleManage;
        private System.Windows.Forms.Button btn_BulkLoad;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_RetrieveProduct;
    }
}
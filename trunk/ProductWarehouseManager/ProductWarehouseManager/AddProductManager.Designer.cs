namespace ProductWarehouseManager
{
    partial class AddProductManager
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
            this.lnklbl_SearchUpdate = new System.Windows.Forms.LinkLabel();
            this.cmbx_ProdType = new System.Windows.Forms.ComboBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_compName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grdvw_AddProduct = new System.Windows.Forms.DataGridView();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_DocName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_AddProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lnklbl_SearchUpdate
            // 
            this.lnklbl_SearchUpdate.AutoSize = true;
            this.lnklbl_SearchUpdate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklbl_SearchUpdate.Location = new System.Drawing.Point(13, 485);
            this.lnklbl_SearchUpdate.Name = "lnklbl_SearchUpdate";
            this.lnklbl_SearchUpdate.Size = new System.Drawing.Size(79, 14);
            this.lnklbl_SearchUpdate.TabIndex = 87;
            this.lnklbl_SearchUpdate.TabStop = true;
            this.lnklbl_SearchUpdate.Text = "Search/Update";
            this.toolTip1.SetToolTip(this.lnklbl_SearchUpdate, "Sign Up");
            this.lnklbl_SearchUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_SearchUpdate_LinkClicked);
            // 
            // cmbx_ProdType
            // 
            this.cmbx_ProdType.FormattingEnabled = true;
            this.cmbx_ProdType.Location = new System.Drawing.Point(370, 57);
            this.cmbx_ProdType.Name = "cmbx_ProdType";
            this.cmbx_ProdType.Size = new System.Drawing.Size(125, 21);
            this.cmbx_ProdType.TabIndex = 84;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(630, 57);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(125, 20);
            this.txt_Description.TabIndex = 83;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(630, 20);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(125, 20);
            this.txt_Quantity.TabIndex = 82;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(370, 20);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(125, 20);
            this.txt_Name.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = " Product Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Product Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Product Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Product Name";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(578, 96);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 85;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(680, 470);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 86;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 12);
            this.label1.TabIndex = 88;
            this.label1.Text = "*If you wish to search or update an existing product please navigate to the link " +
    "below";
            // 
            // cmbx_compName
            // 
            this.cmbx_compName.FormattingEnabled = true;
            this.cmbx_compName.Location = new System.Drawing.Point(118, 20);
            this.cmbx_compName.Name = "cmbx_compName";
            this.cmbx_compName.Size = new System.Drawing.Size(125, 21);
            this.cmbx_compName.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Company Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Document Name";
            // 
            // grdvw_AddProduct
            // 
            this.grdvw_AddProduct.AllowUserToOrderColumns = true;
            this.grdvw_AddProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvw_AddProduct.Location = new System.Drawing.Point(13, 137);
            this.grdvw_AddProduct.Name = "grdvw_AddProduct";
            this.grdvw_AddProduct.Size = new System.Drawing.Size(743, 312);
            this.grdvw_AddProduct.TabIndex = 93;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(578, 470);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(75, 23);
            this.btn_Upload.TabIndex = 94;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(681, 96);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 95;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_DocName
            // 
            this.txt_DocName.Location = new System.Drawing.Point(118, 54);
            this.txt_DocName.Name = "txt_DocName";
            this.txt_DocName.Size = new System.Drawing.Size(125, 20);
            this.txt_DocName.TabIndex = 96;
            // 
            // AddProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 540);
            this.Controls.Add(this.txt_DocName);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.grdvw_AddProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbx_compName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnklbl_SearchUpdate);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cmbx_ProdType);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddProductManager";
            this.Text = "Add Document";
            this.Load += new System.EventHandler(this.AddProductManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_AddProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbx_ProdType;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.LinkLabel lnklbl_SearchUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_compName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdvw_AddProduct;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_DocName;
    }
}
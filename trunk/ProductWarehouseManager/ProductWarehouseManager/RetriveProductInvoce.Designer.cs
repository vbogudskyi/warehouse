namespace ProductWarehouseManager
{
    partial class RetriveProductInvoce
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
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmbx_ProdType = new System.Windows.Forms.ComboBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_InvoiceDate = new System.Windows.Forms.TextBox();
            this.grdvw_AddProduct = new System.Windows.Forms.DataGridView();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_AddProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 102;
            this.label6.Text = "Invoice Date";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(381, 86);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 101;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cmbx_ProdType
            // 
            this.cmbx_ProdType.FormattingEnabled = true;
            this.cmbx_ProdType.Location = new System.Drawing.Point(416, 46);
            this.cmbx_ProdType.Name = "cmbx_ProdType";
            this.cmbx_ProdType.Size = new System.Drawing.Size(141, 21);
            this.cmbx_ProdType.TabIndex = 100;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(127, 83);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(141, 20);
            this.txt_Description.TabIndex = 99;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(416, 6);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(141, 20);
            this.txt_Quantity.TabIndex = 98;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(127, 46);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(141, 20);
            this.txt_Name.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = " Product Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Product Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Product Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Product Name";
            // 
            // txt_InvoiceDate
            // 
            this.txt_InvoiceDate.Location = new System.Drawing.Point(127, 6);
            this.txt_InvoiceDate.Name = "txt_InvoiceDate";
            this.txt_InvoiceDate.Size = new System.Drawing.Size(141, 20);
            this.txt_InvoiceDate.TabIndex = 106;
            // 
            // grdvw_AddProduct
            // 
            this.grdvw_AddProduct.AllowUserToOrderColumns = true;
            this.grdvw_AddProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvw_AddProduct.Location = new System.Drawing.Point(12, 130);
            this.grdvw_AddProduct.Name = "grdvw_AddProduct";
            this.grdvw_AddProduct.Size = new System.Drawing.Size(545, 312);
            this.grdvw_AddProduct.TabIndex = 107;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(381, 451);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(75, 23);
            this.btn_Upload.TabIndex = 109;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(482, 451);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 108;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(482, 86);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 110;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // RetriveProductInvoce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 486);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.grdvw_AddProduct);
            this.Controls.Add(this.txt_InvoiceDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cmbx_ProdType);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RetriveProductInvoce";
            this.Text = "Create Invoice";
            this.Load += new System.EventHandler(this.RetriveProductInvoce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_AddProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cmbx_ProdType;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_InvoiceDate;
        private System.Windows.Forms.DataGridView grdvw_AddProduct;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Delete;
    }
}
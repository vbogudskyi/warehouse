namespace ProductWarehouseManager
{
    partial class ProductManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManager));
            this.lstbx_ProductManager = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.picbx_Delete = new System.Windows.Forms.PictureBox();
            this.picbx_Add = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.picbx_Update = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Update)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbx_ProductManager
            // 
            this.lstbx_ProductManager.FormattingEnabled = true;
            this.lstbx_ProductManager.Location = new System.Drawing.Point(12, 12);
            this.lstbx_ProductManager.Name = "lstbx_ProductManager";
            this.lstbx_ProductManager.Size = new System.Drawing.Size(200, 199);
            this.lstbx_ProductManager.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Product Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Product Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = " Product Quantity";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(359, 12);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(155, 20);
            this.txt_Id.TabIndex = 60;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(359, 52);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(155, 20);
            this.txt_Name.TabIndex = 61;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(359, 92);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(155, 20);
            this.txt_Status.TabIndex = 62;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(359, 132);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(155, 20);
            this.txt_Quantity.TabIndex = 63;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(359, 172);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(155, 20);
            this.txt_Description.TabIndex = 64;
            // 
            // picbx_Delete
            // 
            this.picbx_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbx_Delete.BackgroundImage")));
            this.picbx_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbx_Delete.Location = new System.Drawing.Point(186, 213);
            this.picbx_Delete.Name = "picbx_Delete";
            this.picbx_Delete.Size = new System.Drawing.Size(26, 23);
            this.picbx_Delete.TabIndex = 72;
            this.picbx_Delete.TabStop = false;
            this.toolTip1.SetToolTip(this.picbx_Delete, "Delete");
            // 
            // picbx_Add
            // 
            this.picbx_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbx_Add.BackgroundImage")));
            this.picbx_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbx_Add.Location = new System.Drawing.Point(154, 213);
            this.picbx_Add.Name = "picbx_Add";
            this.picbx_Add.Size = new System.Drawing.Size(26, 23);
            this.picbx_Add.TabIndex = 71;
            this.picbx_Add.TabStop = false;
            this.toolTip1.SetToolTip(this.picbx_Add, "Add");
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(249, 212);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 24);
            this.btn_Save.TabIndex = 73;
            this.btn_Save.Text = "Save";
            this.toolTip1.SetToolTip(this.btn_Save, "Save");
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // picbx_Update
            // 
            this.picbx_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbx_Update.BackgroundImage")));
            this.picbx_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbx_Update.Location = new System.Drawing.Point(122, 214);
            this.picbx_Update.Name = "picbx_Update";
            this.picbx_Update.Size = new System.Drawing.Size(26, 23);
            this.picbx_Update.TabIndex = 74;
            this.picbx_Update.TabStop = false;
            this.toolTip1.SetToolTip(this.picbx_Update, "Update");
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 264);
            this.Controls.Add(this.picbx_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.picbx_Delete);
            this.Controls.Add(this.picbx_Add);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbx_ProductManager);
            this.Name = "ProductManager";
            this.Text = "ProductManager";
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx_ProductManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.PictureBox picbx_Delete;
        private System.Windows.Forms.PictureBox picbx_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picbx_Update;
    }
}
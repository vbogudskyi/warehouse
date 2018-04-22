using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductWarehouseManager
{
    public partial class UpdateProductManager : Form
    {
        List<string> data;

        public UpdateProductManager()
        {
            InitializeComponent();
        }

        private void UpdateProductManager_Load(object sender, EventArgs e)
        {
            data = new List<string>();
            ckbx_All.Checked = true;
          
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UpdateProductManager.ActiveForm.Close();
        }

        private void on_Change(object sender, EventArgs e)
        {
            String list = ((CheckBox)sender).Text;

            switch (list)
            {
                case "All":
                    {
                        if (ckbx_All.Checked)
                        {

                            data.Add("Product Id");
                            data.Add("Product Name");
                            data.Add("User Name");
                            data.Add("Product Type");
                            data.Add("Document Name");
                            data.Add("Document Id");

                            ckbx_ProdNumb.Enabled = false;
                            ckbx_ProdName.Enabled = false;
                            ckbx_UserName.Enabled = false;
                            ckbx_ProdType.Enabled = false;
                            ckbx_DocName.Enabled = false;
                            ckbx_DocNumb.Enabled = false;
                        }
                        else
                        {
                            data.Remove("Product Id");
                            data.Remove("Product Name");
                            data.Remove("User Name");
                            data.Remove("Product Type");
                            data.Remove("Document Name");
                            data.Remove("Document Id"); ;

                            ckbx_ProdNumb.Enabled = true;
                            ckbx_ProdName.Enabled = true;
                            ckbx_UserName.Enabled = true;
                            ckbx_ProdType.Enabled = true;
                            ckbx_DocName.Enabled = true;
                            ckbx_DocNumb.Enabled = true;
                        }

                        break;
                    }
                case "Product#":
                    {
                        if (ckbx_ProdNumb.Checked)
                        {
                            data.Add("Insert");
                        }
                        else
                        {
                            data.Remove("Insert");
                        }

                        break;
                    }
                case "ProductName":
                    {
                        if (ckbx_ProdName.Checked)
                        {
                            data.Add("Update");
                        }
                        else
                        {
                            data.Remove("Update");
                        }
                        break;
                    }
                case "UserName":
                    {
                        if (ckbx_UserName.Checked)
                        {
                            data.Add("Select");
                        }
                        else
                        {
                            data.Remove("Select");
                        }

                        break;
                    }
                case "Product Type":
                    {
                        if (ckbx_ProdType.Checked)
                        {
                            data.Add("Delete");
                        }
                        else
                        {
                            data.Remove("Delete");
                        }
                        break;
                    }
                case "Document Name":
                    {
                        if (ckbx_DocName.Checked)
                        {
                            data.Add("User");
                        }
                        else
                        {
                            data.Remove("User");
                        }
                        break;
                    }
                case "Document#":
                    {
                        if (ckbx_DocNumb.Checked)
                        {
                            data.Add("Data Transfer");
                        }
                        else
                        {
                            data.Remove("Data Transfer");
                        }
                        break;
                    }
              
            }
        }
    }
    
}

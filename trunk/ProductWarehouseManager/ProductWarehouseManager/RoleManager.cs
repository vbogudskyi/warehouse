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
    public partial class RoleManager : Form
    {
        String dataSearch;
        List<string> data;

        public RoleManager()
        {
            InitializeComponent();
        }

        private void RoleManager_Load(object sender, EventArgs e)
        {
            data = new List<string>();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            RoleManager.ActiveForm.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Need to add the complete logic
            dataSearch = txt_Serch.Text;

            lstbx_RoleManager.Items.Add(dataSearch);
        }



        private void btn_Save_Click(object sender, EventArgs e)
        {
          
            
        }

        private void on_Checked(object sender, EventArgs e)
        {
            String list = ((CheckBox)sender).Text;
            
            switch (list)
            {
                case "All":
                    {
                        if( ckbx_All.Checked){

                            data.Add("Insert");
                            data.Add("Update");
                            data.Add("Select");
                            data.Add("Delete");
                            data.Add("User");
                            //  data.Add("Create Reports");
                            data.Add("Data Transfer");

                            ckbx_Insert.Enabled = false;
                            ckbx_Update.Enabled = false;
                            ckbx_Select.Enabled = false;
                            clbx_Delete.Enabled = false;
                            ckbx_User.Enabled = false;
                            ckbx_BulkLoad.Enabled = false;
                        }
                        else
                        {
                            data.Remove("Insert");
                            data.Remove("Update");
                            data.Remove("Select");
                            data.Remove("Delete");
                            data.Remove("User");
                            //  data.Remove("Create Reports");
                            data.Remove("Data Transfer");

                            ckbx_Insert.Enabled = true;
                            ckbx_Update.Enabled = true;
                            ckbx_Select.Enabled = true;
                            clbx_Delete.Enabled = true;
                            ckbx_User.Enabled = true;
                            ckbx_BulkLoad.Enabled = true;
                        }

                        break;
                    }
                case "Insert":
                    {
                        if (ckbx_Insert.Checked)
                        {
                            data.Add("Insert");
                        }
                        else
                        {
                            data.Remove("Insert");
                        }
                           
                        break;
                    }
                case "Update":
                    {
                        if (ckbx_Update.Checked)
                        {
                            data.Add("Update");
                        }
                        else
                        {
                            data.Remove("Update");
                        }
                        break;
                    }
                case "Select":
                    {
                        if (ckbx_Select.Checked)
                        {
                            data.Add("Select");
                        }
                        else
                        {
                            data.Remove("Select");
                        }

                        break;
                    }
                case "Delete":
                    {
                        if (clbx_Delete.Checked)
                        {
                            data.Add("Delete");
                        }
                        else
                        {
                            data.Remove("Delete");
                        }
                        break;
                    }
                case "User":
                    {
                        if (ckbx_User.Checked)
                        {
                            data.Add("User");
                        }
                        else
                        {
                            data.Remove("User");
                        }
                        break;
                    }
                //case "Create Reports":
                //    {
                //        data.Add("Create Reports");
                //        break;
                //    }
                case "Data Transfer":
                    {
                        if (ckbx_BulkLoad.Checked)
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

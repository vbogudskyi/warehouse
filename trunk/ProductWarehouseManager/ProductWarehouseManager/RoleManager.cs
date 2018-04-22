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
           // String list = ((CheckBox)sender).Text;
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked)
            {
                switch (chk.Name)
                {
                    case "All":
                        {

                            data.Add("Insert");
                            data.Add("Update");
                            data.Add("Select");
                            data.Add("Delete");
                            data.Add("User");
                            //  data.Add("Create Reports");
                            data.Add("Data Transfer");


                            break;
                        }
                    case "Insert":
                        {
                            data.Add("Insert");
                            break;
                        }
                    case "Update":
                        {
                            data.Add("Update");
                            break;
                        }
                    case "Select":
                        {
                            data.Add("Select");
                            break;
                        }
                    case "Delete":
                        {
                            data.Add("Delete");
                            break;
                        }
                    case "User":
                        {
                            data.Add("User");
                            break;
                        }
                    //case "Create Reports":
                    //    {
                    //        data.Add("Create Reports");
                    //        break;
                    //    }
                    case "Data Transfer":
                        {
                            data.Add("Data Transfer");
                            break;
                        }
                }

            }
        }

        private void on_Checked(object sender, EventArgs e)
        {
            String list = ((CheckBox)sender).Text;
            switch (list)
            {
                case "All":
                    {
                        data.Add("Insert");
                        data.Add("Update");
                        data.Add("Select");
                        data.Add("Delete");
                        data.Add("User");
                        //  data.Add("Create Reports");
                        data.Add("Data Transfer");
                        break;
                    }
                case "Insert":
                    {
                        data.Add("Insert");
                        break;
                    }
                case "Update":
                    {
                        data.Add("Update");
                        break;
                    }
                case "Select":
                    {
                        data.Add("Select");
                        break;
                    }
                case "Delete":
                    {
                        data.Add("Delete");
                        break;
                    }
                case "User":
                    {
                        data.Add("User");
                        break;
                    }
                //case "Create Reports":
                //    {
                //        data.Add("Create Reports");
                //        break;
                //    }
                case "Data Transfer":
                    {
                        data.Add("Data Transfer");
                        break;
                    }
            }
        }
    
    }
}

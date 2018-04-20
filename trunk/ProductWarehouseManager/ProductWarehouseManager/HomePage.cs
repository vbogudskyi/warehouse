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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddProductManager add = new AddProductManager();
            add.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateProductManager update = new UpdateProductManager();
            update.Show();
        }

        private void btn_UserManage_Click(object sender, EventArgs e)
        {
            UserManager manager = new UserManager();
            manager.Show();
        }

        private void btn_RoleManage_Click(object sender, EventArgs e)
        {
            RoleManager role = new RoleManager();
            role.Show();
        }

        private void btn_MyAcc_Click(object sender, EventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            myAccount.Show();
        }

        private void btn_BulkLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.InitialDirectory = @"C:\";
            browse.FileName = "*.xls";
            if (browse.ShowDialog() == DialogResult.OK)
            {
                BulkLoad load = new BulkLoad();
                load.Show();
            }
        }
    }
}

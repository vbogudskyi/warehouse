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
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_FirstName.Enabled = true;
            txt_LastName.Enabled = true;
            txt_Password.Enabled = true;
            txt_Password2.Enabled = true;

            Button save = new Button();
            save.Size = new System.Drawing.Size(45, 23);
            save.Location = new Point(30, 289);
            save.Name = "Save";
            save.Show();

            if (txt_Password.Text != txt_Password2.Text || txt_Password.Text == "")
            {
                MessageBox.Show("Please make sure the password 2 is same as Pasword 1");
                txt_Password.Text = "";
                txt_Password2.Text = "";

            }
        }
    }
}

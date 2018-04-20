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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MyAccount.ActiveForm.Close();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_FirstName.Enabled = true;
            txt_LastName.Enabled = true;
            txt_Password.Enabled = true;
            txt_Password2.Enabled = true;

            btn_Save.Visible = true;


        }


        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (txt_Password.Text != txt_Password2.Text || txt_Password.Text == "")
            {
                MessageBox.Show("Please make sure the password 2 is same as Pasword 1");
                txt_Password.Text = "";
                txt_Password2.Text = "";

            }
            else
            {

            }
        }
    }
}

using ProductWarehouseManager.LogInSignUp;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text != txt_Password2.Text || txt_Password.Text == "")
            {
                MessageBox.Show("Please make sure the password 2 is same as Pasword 1");
                txt_Password.Text = "";
                txt_Password2.Text = "";

            }
            else
            {
               SignUpClass signUp = new SignUpClass();
               signUp.InsertData(txt_UserId.Text, txt_Password.Text, txt_FirstName.Text, txt_LastName.Text, txt_RSA.Text);
        
             txt_UserId.Text = "";
             txt_Password.Text = "";
             txt_Password2.Text = "";
             txt_FirstName.Text = "";
             txt_LastName.Text = "";
             txt_RSA.Text = "";
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.InitialDirectory = @"C:\";
            
            if (browse.ShowDialog() == DialogResult.OK)
            {
                //need to figure out how to select the RSA from the list
                MessageBox.Show("Need to finish the logic");
            }

        }
    }
}

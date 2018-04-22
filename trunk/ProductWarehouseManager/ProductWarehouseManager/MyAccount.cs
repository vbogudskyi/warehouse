using ProductWarehouseManager.Validation;
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

        private void MyAccount_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MyAccount.ActiveForm.Close();
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

            ValidatorContext validate = new ValidatorContext(new EmailValidator());
            ValidatorContext phone = new ValidatorContext(new PhoneValidator());



            if (validate.validation(txt_UserId.Text))
            {
                if (phone.validation(txt_Phone.Text))
                {
                    if (txt_Password.Text != txt_Password2.Text || txt_Password.Text == "")
                    {
                        MessageBox.Show("Please make sure the password 2 is same as Pasword 1");
                        txt_Password.Text = "";
                        txt_Password2.Text = "";

                    }
                    else
                    {
                        //////////need to finish
                        MessageBox.Show("Need to add the Logic");
                      //  SignUpClass signUp = new SignUpClass();
                       // signUp.InsertData(txt_UserId.Text, txt_Password.Text, txt_FirstName.Text, txt_LastName.Text, txt_RSA.Text);

                        txt_UserId.Text = "";
                        txt_Password.Text = "";
                        txt_Password2.Text = "";
                        txt_FirstName.Text = "";
                        txt_LastName.Text = "";
                        txt_Phone.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid phone!");
                }


            }
            else
            {
                MessageBox.Show("Please enter a valid e-mail!");
            }
        }
    }
}

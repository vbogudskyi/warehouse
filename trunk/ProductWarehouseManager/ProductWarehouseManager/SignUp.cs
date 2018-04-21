using ProductWarehouseManager.LogInSignUp;
using ProductWarehouseManager.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            ValidatorContext validate = new ValidatorContext();
          //  txt_UserId.Text = validate.SetValidation(new EmailValidator());

            if  (validate.SetValidation(new EmailValidator()))
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
                    txt_Phone.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid e-mail!");
            }
           
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.InitialDirectory = @"C:\Users\Nicolae\Documents\GitHub\warehouse\docs\vbohudskyi\rsa";
            browse.FileName = "*.rsa";
            browse.FilterIndex = 1;
            browse.Multiselect = false;


            if (browse.ShowDialog() == DialogResult.OK)
            {
                string fileName = browse.FileName;
                txt_RSA.Text = Path.GetFileNameWithoutExtension(fileName);
            }

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            SignUp.ActiveForm.Close();
        }
    }
}

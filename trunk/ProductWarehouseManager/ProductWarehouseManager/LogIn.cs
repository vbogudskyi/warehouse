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
    public partial class LogIn : Form
    {
        //Enter code here for your version of username and userpassword 
        LogInClass login = new LogInClass("admin", "1234");
        HomePage homePage;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            //define local variables from the user inputs 
            string user = txt_UserId.Text;
            string pass = txt_Password.Text;
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {
                MessageBox.Show("You are logged in successfully");
                homePage = new HomePage();
                homePage.Show();
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Login Error!");
            }
        }


        private void lnklbl_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Enter your code for registration form of your choice 
            // MessageBox.Show("Under development");
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}

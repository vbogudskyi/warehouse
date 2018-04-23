using ComponentsIntergrationMiddleware;
using ProductWarehouseManager.Classes;
using ProductWarehouseManager.LogInSignUp;
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
    public partial class LogIn : Form
    {
        //Enter code here for your version of username and userpassword 
        String rsa;

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            ComponentIntegrationFacade.INSTANCE.SafeUser.Logger = log;
        }

        //add in each class where insatanceFasade is called
        public void log(int code, String message)
        {
            if(code == 200)
            {
                ComponentIntegrationFacade.INSTANCE.SafeUser.Logger = null;
                HomePage homePage = new HomePage();
                homePage.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(message);
            }
        }
            


        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            //define local variables from the user inputs 
            string user = txt_UserId.Text;
            string pass = txt_Password.Text;

            ComponentIntegrationFacade.INSTANCE.SafeUser.login(user, pass, rsa);
            /*login = new LogInClass("admin", "1234");
            // ComponentIntegrationFacade.INSTANCE.SafeUser.login(user, pass, readRsa.readRsa());
          //  ComponentIntegrationFacade.INSTANCE.SafePermissions.grantPermissionForRole();



            login = new LogInClass("admin", "1234");
            check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {

                homePage = new HomePage();
                homePage.Show();
                Hide();
            }*/

            user = "";
            pass = "";
        }


        private void lnklbl_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btn_BrowseRSA_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.InitialDirectory = @"C:\";
            browse.FileName = "*.rsa";
            browse.FilterIndex = 1;
            browse.Multiselect = false;


            if (browse.ShowDialog() == DialogResult.OK)
            {
                string fileName = browse.FileName;
                lb_RSA.Text = Path.GetFileNameWithoutExtension(fileName);
                ReadRSA readRsa = new ReadRSA(fileName);
                rsa = readRsa.readRsa();

            }
        }
    }
}

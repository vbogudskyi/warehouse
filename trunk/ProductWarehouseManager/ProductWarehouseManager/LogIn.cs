﻿using ProductWarehouseManager.Classes;
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
        LogInClass login;
        HomePage homePage;
        ReadRSA readRsa;
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

            login = new LogInClass("admin", "1234");
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {

                homePage = new HomePage();
                homePage.Show();
                Hide();
            }

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
            browse.InitialDirectory = @"C:\Users\Nicolae\Documents\GitHub\warehouse\docs\vbohudskyi\rsa";
            browse.FileName = "*.rsa";
            browse.FilterIndex = 1;
            browse.Multiselect = false;


            if (browse.ShowDialog() == DialogResult.OK)
            {
                string fileName = browse.FileName;
                lb_RSA.Text = Path.GetFileNameWithoutExtension(fileName);
                readRsa = new ReadRSA(fileName);
                readRsa.readRsa();
                MessageBox.Show(readRsa.readRsa());

            }
        }
    }
}

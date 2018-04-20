using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProductWarehouseManager.LogInSignUp
{
    class SignUpClass
    {
        SqlConnection con;
        SqlCommand cmd;



        public SignUpClass()
        {
            con = new SqlConnection(@"Data Source=NICOLAE-PC\MYSQLSERVER;Initial Catalog=ProductWarehouse;Integrated Security=True");
        }

        public void InsertData(String login, String psw, String fname, String lname, String rsa)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO Users (UID,PSW,FNAME,LNAME,RSA,RID,CID) VALUES (@uid,@psw,@fname,@lname,@rsa,NEWID(),NEWID())", con);
                con.Open();
                cmd.Parameters.AddWithValue("uid", login);
                cmd.Parameters.AddWithValue("psw", psw);
                cmd.Parameters.AddWithValue("fname", fname);
                cmd.Parameters.AddWithValue("lname", lname);
                cmd.Parameters.AddWithValue("rsa", rsa);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Account Created Successfuly!");
                }
                else
                {
                    MessageBox.Show("Cannot Create the Account this time, Please try laters");
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}

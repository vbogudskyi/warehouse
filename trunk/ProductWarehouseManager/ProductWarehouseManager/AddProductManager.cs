using ProductWarehouseManager.Classes;
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
    public partial class AddProductManager : Form
    {
        DataTable dt;
        List<string> upload;
        Product product;
        public AddProductManager()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            AddProductManager.ActiveForm.Close();
              
        }

        private void AddProductManager_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Creation Date", typeof(DateTime));
            dt.Columns.Add("Company Name", typeof(string));
            dt.Columns.Add("Document Name", typeof(string));
            dt.Columns.Add("Product Name", typeof(string));
            dt.Columns.Add("Product Type", typeof(string));
            dt.Columns.Add("Product Quantity", typeof(int));
            dt.Columns.Add("Description", typeof(string));
            grdvw_AddProduct.DataSource = dt;

            upload = new List<string>();
        }



        private void btn_Add_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            string data = date.ToString();
            string data1 = cmbx_compName.Text;
            string data2 = cmbx_DocName.Text;
            string data3 = txt_Name.Text;
            string data4 = cmbx_ProdType.Text;
            string data5 = txt_Quantity.Text;
            string data6 = txt_Description.Text;

            try
            {
                DataRow dr = dt.NewRow();
               
                product = new Product(data, data1, data2, data3, data4, int.Parse(data5), data6);
                dt.Rows.Add(data, data1, data2, data3, data4, data5, data6);
                MessageBox.Show(product.ToString());
         
                upload.Add(product.ToString());
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }
    }
}

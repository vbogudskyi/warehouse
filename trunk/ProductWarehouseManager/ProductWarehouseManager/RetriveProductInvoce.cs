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
    public partial class RetriveProductInvoce : Form
    {

        DataTable dt;
        List<string> upload;
        Invoice invoice;

        public RetriveProductInvoce()
        {
            InitializeComponent();
        }

        private void RetriveProductInvoce_Load(object sender, EventArgs e)
        {

            dt = new DataTable();
            dt.Columns.Add("Invoice Date", typeof(DateTime));
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
            string data1 = txt_Name.Text;
            string data2 = cmbx_ProdType.Text;
            string data3 = txt_Quantity.Text;
            string data4 = txt_Description.Text;

            try
            {
                DataRow dr = dt.NewRow();

                invoice = new Invoice(data, data1, data2, int.Parse(data3), data4);
                dt.Rows.Add(data, data1, data2, data3, data4);
                MessageBox.Show(invoice.ToString());
              
                upload.Add(invoice.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            AddProductManager.ActiveForm.Close();
        }
    }
}

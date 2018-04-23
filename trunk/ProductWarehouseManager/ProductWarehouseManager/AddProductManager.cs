using ComponentsIntergrationMiddleware;
using ComponentsIntergrationMiddleware.api.bulk;
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
        DataRow dr;
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
            var companies = ComponentIntegrationFacade.INSTANCE.
                 SafeCompany.getAllCompanies();
            var types = ComponentIntegrationFacade.INSTANCE.SafeDocument.getAllProductTypes();
            cmbx_compName.Items.AddRange(companies.Select(cmp => cmp.Name).ToArray());
            cmbx_ProdType.Items.AddRange(types.Select(tp => tp.Name).ToArray());
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
            string data2 = txt_DocName.Text;
            string data3 = txt_Name.Text;
            string data4 = cmbx_ProdType.Text;
            string data5 = txt_Quantity.Text;
            string data6 = txt_Description.Text;

            try
            {

                Record document = new Record();
                document.CompanyName = data1;
                document.CreationDate = data;
                document.DocumentName = data2;
                document.ProductName = data3;
                document.ProductType = data4;
                document.ProductQuantity = int.Parse(data5);
                document.Description = data6;
                ComponentIntegrationFacade.INSTANCE.SafeDocument.addDocument(document);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.grdvw_AddProduct.SelectedRows)
                {

                    grdvw_AddProduct.Rows.RemoveAt(item.Index);
                }

                //nned to figure oyt why is out of index bounds
                string data = grdvw_AddProduct.SelectedRows[0].Cells[0].Value.ToString();
                string data1 = grdvw_AddProduct.SelectedRows[0].Cells[1].Value.ToString();
                string data2 = grdvw_AddProduct.SelectedRows[0].Cells[2].Value.ToString();
                string data3 = grdvw_AddProduct.SelectedRows[0].Cells[3].Value.ToString();
                string data4 = grdvw_AddProduct.SelectedRows[0].Cells[4].Value.ToString();
                string data5 = grdvw_AddProduct.SelectedRows[0].Cells[5].Value.ToString();
                string data6 = grdvw_AddProduct.SelectedRows[0].Cells[6].Value.ToString();
                product = new Product(data, data1, data2, data3, data4, int.Parse(data5), data6);

                upload.Remove(product.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void lnklbl_SearchUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateProductManager update = new UpdateProductManager();
            update.Show();
            Close();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Need to add the logic");
        }
    }
}

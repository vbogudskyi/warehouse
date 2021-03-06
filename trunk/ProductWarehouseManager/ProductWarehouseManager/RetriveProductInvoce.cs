﻿using ProductWarehouseManager.Classes;
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

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Need to add the logic");
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
                invoice = new Invoice(data, data1, data2, int.Parse(data3), data4);

                upload.Remove(invoice.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

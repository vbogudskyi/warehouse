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
    public partial class BulkLoad : Form
    {
        string fileName;
        string[] allFiles;
        string[] logs;

        public BulkLoad()
        {
            InitializeComponent();
        }
        private void BulkLoad_Load(object sender, EventArgs e)
        {

        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.InitialDirectory = @"C:\Users\Nicolae\Documents\GitHub\warehouse\docs\vbohudskyi\template";
            browse.FileName = "*.xls";
            browse.FilterIndex = 1;
            browse.Multiselect = true;

            if (browse.ShowDialog() == DialogResult.OK)
            {
                fileName = browse.FileName;
                allFiles = browse.FileNames;
                foreach (var item in allFiles)
                {
                    lsbx_BulkLoad.Items.Add(Path.GetFileName(item)).ToString();
                }

            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            ////////////////////////need to add teh code
            MessageBox.Show("Need to add teh logic");
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            //Remove a selected item from the list box and the array
            for (int n = lsbx_BulkLoad.SelectedIndices.Count - 1; n >= 0; n--)
            {

                string value = lsbx_BulkLoad.SelectedItem.ToString();

                int indexToRemove = Array.IndexOf(allFiles, value);

                allFiles = allFiles.Where((source, index) => index != indexToRemove).ToArray();

                lsbx_BulkLoad.Items.RemoveAt(lsbx_BulkLoad.SelectedIndices[n]);

                MessageBox.Show(Path.GetFileName(value).ToString() + "Removed from the list");

            }
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            BulkLoad.ActiveForm.Close();
        }


        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            lsbx_BulkLoad.Items.Clear();
            allFiles = null;
        }

        private void btn_ClearLog_Click(object sender, EventArgs e)
        {
            lsbx_Logs.Items.Clear();
            logs = null;
        }


    }
}

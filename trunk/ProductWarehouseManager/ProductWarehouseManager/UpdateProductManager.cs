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
    public partial class UpdateProductManager : Form
    {
        public UpdateProductManager()
        {
            InitializeComponent();
        }

        private void UpdateProductManager_Load(object sender, EventArgs e)
        {
            ckbx_All.Checked = true;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UpdateProductManager.ActiveForm.Close();
        }
    }
}

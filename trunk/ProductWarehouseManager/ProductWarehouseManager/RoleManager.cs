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
    public partial class RoleManager : Form
    {
        public RoleManager()
        {
            InitializeComponent();
        }

        private void RoleManager_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            RoleManager.ActiveForm.Close();
        }
    }
}

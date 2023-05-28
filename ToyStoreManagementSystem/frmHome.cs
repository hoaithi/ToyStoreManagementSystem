using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyStoreManagementSystem
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct.ShowDialog();
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee frmEmployee = new frmEmployee();
            frmEmployee.ShowDialog();
        }

        private void lblBill_Click(object sender, EventArgs e)
        {
            frmBill frmBill = new frmBill();
            frmBill.ShowDialog();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaCare
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
       
        public string UserId { get; set; }
       
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
                this.Visible = false;
            }
        }

        private void btnSeeProfile_Click(object sender, EventArgs e)
        {
            EmployeeSeeProfile emp = new EmployeeSeeProfile();
            emp.UserId = this.UserId;
            emp.Show();
            this.Visible = false;
        }

        private void bnChangePassword_Click(object sender, EventArgs e)
        {
            EmployeeChangePassord password = new EmployeeChangePassord();
            password.UserId = this.UserId;
            password.Show();
            this.Visible = false;
        }

        private void btmSellProduct_Click(object sender, EventArgs e)
        {
            EmployeeSellProduct sellProduct = new EmployeeSellProduct();
            sellProduct.UserId = this.UserId;
            sellProduct.Show();
            this.Visible = false;
        }
    }
}

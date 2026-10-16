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
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
         {
            try
            {
                string UserId = this.txtUserId.Text;
                string password = this.txtPassword.Text;


                DataAccess da = new DataAccess();
                DataSet ds;

                string sql = "select * from ManagerTb where ManagerId = '" + UserId + "' and Password = '" + password + "';";
                ds = da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    Admin fa = new Admin();
                    fa.UsrId = UserId; 
                    fa.Show();
                    this.Hide();
                }
                else
                {
                   
                    sql = "select * from EmployeeTb where EmpId = '" + UserId + "' and Password = '" + password + "';";
                    ds = da.ExecuteQuery(sql);

                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        Employee fe= new Employee();
                        fe.UserId = UserId; 
                        fe.Show();
                        this.Hide();
                    }

                
                    else
                    {
                        MessageBox.Show("Invalid Id or Password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please try again.\n" + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserId.Clear();
            this.txtPassword.Clear();
        }
    }
}



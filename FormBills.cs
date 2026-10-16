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
    public partial class FormBills : Form
    {
        public FormBills()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoIdGenerate();
        }
        public string Us { get; set; }
        private DataAccess Da { get; set; }
        
        private void AutoIdGenerate()
        {
            try
            {
                var sql = "SELECT MAX(BillsId) FROM BillsTb;";
                var dt = this.Da.ExecuteQueryTable(sql);

                string newId;

                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    string oldId = dt.Rows[0][0].ToString();
                    var s = oldId.Split('B');
                    int temp = Convert.ToInt32(s[1]);
                    newId = "B" + (++temp).ToString("D3");
                }
                else
                {
                    newId = "B001";

                    this.lblBillsId.Text = newId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Auto Id Generation Failed: " + ex.Message);
                this.lblBillsId.Text = "B001";
            }
        }


        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                //insert
                string query = @"insert into BillsTb  values(" + this.lblBillsId.Text + ",'" + this.lblCustomarName.Text + "', '" + "', " + this.lblTotalAmount.Text + ", '" + this.dateBillCreat.Text + "', '" + this.lblEmpId.Text + "');";
                var count = this.Da.ExecuteDMLQuery(query);
            }
            catch
            {
              
            }
            EmployeeSellProduct employee = new EmployeeSellProduct();
            employee.Show();
            this.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();

        }
    }
}

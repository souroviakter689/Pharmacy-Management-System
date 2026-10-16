using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmaCare
{
    public partial class EmployeeSellProduct : Form
    {
        private DataAccess Da { get; set; }
        public string UserId { get;internal set; }

        public EmployeeSellProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoBillIdGenerate();
            grdvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdvCart.MultiSelect = false;
        }
       
        public void PopulateGridView(string sql = "select * from MedicineTb;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.grdvProductList.AutoGenerateColumns = false;
            this.grdvProductList.DataSource = ds.Tables[0];
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Visible = false;
            }
        }

        private void AutoBillIdGenerate()
        {
            try
            {
                var query = "SELECT MAX(BillsId) FROM BillsTb;";
                var dt = this.Da.ExecuteQueryTable(query);

                string newId;

                if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    var oldId = dt.Rows[0][0].ToString();
                    var s = oldId.Split('B');
                    var temp = Convert.ToInt32(s[1]);
                    newId = "B" + (++temp).ToString("D3");
                }
                else
                {
                    newId = "B001"; 
                }

                this.txtBillId.Text = newId;
            }
            catch
            {
                this.txtBillId.Text = "B001";
            }
        }

        private void grdvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            var r = grdvProductList.Rows[e.RowIndex];


            var medId = r.Cells["Column1"].Value?.ToString() ?? "";
            var mname = r.Cells["Column2"].Value?.ToString() ?? "";
            var price = r.Cells["Column5"].Value?.ToString() ?? "0";
            var avail = r.Cells["Column6"].Value?.ToString() ?? "0";


            this.txtMedicineId.Text = medId;
            this.txtMName.Text = mname;
            this.txtPrice.Text = price;
            this.txtQuantity.Text = "1";
            this.lblPhone.Text = "Available: " + avail;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtMedicineId.Text) || string.IsNullOrWhiteSpace(this.txtQuantity.Text))
            {
                MessageBox.Show("Please select a product and enter quantity.");
                return;
            }

            string medId = this.txtMedicineId.Text;
            string mname = this.txtMName.Text;
            int qty = int.Parse(this.txtQuantity.Text);
            decimal price = decimal.Parse(this.txtPrice.Text);
            decimal total = qty * price;

            bool updated = false;

            foreach (DataGridViewRow row in grdvCart.Rows)
            {
                if (row.Cells["clmMedicineId"].Value.ToString() == medId)
                {
                    foreach (DataGridViewRow prow in grdvProductList.Rows)
                    {
                        if (prow.Cells["Column1"].Value.ToString() == medId) 
                        {
                            int available = Convert.ToInt32(prow.Cells["Column6"].Value); 
                            int oldQty = Convert.ToInt32(row.Cells["clmQuantity"].Value);

                            available += oldQty;
                            if (qty > available)
                            {
                                MessageBox.Show("Stock shortage! Available: " + available);
                                return;
                            }

                            prow.Cells["Column6"].Value = (available - qty).ToString();
                            break;
                        }
                    }

                    row.Cells["clmQuantity"].Value = qty;
                    row.Cells["Column7"].Value = (qty * price).ToString();
                    updated = true;
                    break;
                }
            }

            if (!updated)
            {
                foreach (DataGridViewRow prow in grdvProductList.Rows)
                {
                    if (prow.Cells["Column1"].Value.ToString() == medId)
                    {
                        int available = Convert.ToInt32(prow.Cells["Column6"].Value);
                        if (qty > available)
                        {
                            MessageBox.Show("Stock shortage! Available: " + available);
                            return;
                        }
                        prow.Cells["Column6"].Value = (available - qty).ToString();
                        break;
                    }
                }

                this.grdvCart.Rows.Add(medId, mname, price, qty, total);
               
            }

            this.txtMedicineId.Clear();
            this.txtMName.Clear();
            this.txtPrice.Clear();
            this.txtQuantity.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grdvCart.CurrentRow != null)
            {
                var row = grdvCart.CurrentRow;

                this.txtMedicineId.Text = row.Cells["clmMedicineId"].Value.ToString();
                this.txtMName.Text = row.Cells["clmMedicineName"].Value.ToString();
                this.txtPrice.Text = row.Cells["clmPrice"].Value.ToString();
                this.txtQuantity.Text = row.Cells["clmQuantity"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a product from cart to edit.");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in grdvCart.Rows)
            {
                if (row.Cells["Column7"].Value != null) 
                {
                    decimal rowTotal = Convert.ToDecimal(row.Cells["Column7"].Value);
                    grandTotal += rowTotal;
                }
            }

            txtGrandTotal.Text = grandTotal.ToString("0.00");
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtGrandTotal.Text))
            {
                MessageBox.Show("Please select products before creating the bill.");
                return;
            }

            try
            {
           
                foreach (DataGridViewRow cartRow in grdvCart.Rows)
                {
                    int medId = Convert.ToInt32(cartRow.Cells["clmMedicineId"].Value);
                    int qty = Convert.ToInt32(cartRow.Cells["clmQuantity"].Value);

                    
                    DataGridViewRow prodRow = null;
                    foreach (DataGridViewRow row in grdvProductList.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["Column1"].Value) == medId)
                        {
                            prodRow = row;
                            break;
                        }
                    }

                    if (prodRow == null)
                    {
                        MessageBox.Show("Medicine not found in list.");
                        return;
                    }

                    int available = Convert.ToInt32(prodRow.Cells["Column6"].Value); // Column6 = available stock

                    if (qty > available)
                    {
                        MessageBox.Show($"Not enough stock for Medicine ID {medId}");
                        return;
                    }

                    
                    string updateQuery = $@"
                UPDATE MedicineTb
                SET Quantity = {available - qty}
                WHERE MedicineId = {medId};";

                    this.Da.ExecuteDMLQuery(updateQuery);

                    
                    prodRow.Cells["Column6"].Value = (available - qty).ToString();
                }

                this.PopulateGridView(); 

                
                FormBills bills = new FormBills();
                bills.lblEmpId.Text = this.UserId;
                bills.lblCustomarName.Text = this.txtCustomerName.Text;
                bills.lblCustomerPhoneNo.Text = this.txtCustomerPhoneNo.Text;
                bills.lblTotalAmount.Text = this.txtGrandTotal.Text;

                var dt = this.Da.ExecuteQueryTable("SELECT TOP 1 BillsId FROM BillsTb ORDER BY BillsId DESC;");
                string newBillId = "B001";
                if (dt != null && dt.Rows.Count > 0)
                {
                    string oldId = dt.Rows[0][0].ToString();
                    int num = int.Parse(System.Text.RegularExpressions.Regex.Replace(oldId, "[^0-9]", ""));
                    newBillId = "B" + (num + 1).ToString("D3");
                }
                bills.lblBillsId.Text = newBillId;
                bills.dateBillCreat.Value = DateTime.Now;

                string insertQuery = $@"
            INSERT INTO BillsTb (BillsId, CustomerName, PhoneNo, TotalAmount, BillDate, EmpId)
            VALUES (
                '{bills.lblBillsId.Text}',
                '{bills.lblCustomarName.Text}',
                '{bills.lblCustomerPhoneNo.Text}',
                {bills.lblTotalAmount.Text},
                '{bills.dateBillCreat.Value:yyyy-MM-dd}',
                '{bills.lblEmpId.Text}'
            );";

                this.Da.ExecuteDMLQuery(insertQuery);

                bills.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating bill: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Employee employeePage = new Employee();
            employeePage.Show();
            this.Visible = false;
        }
    }
}


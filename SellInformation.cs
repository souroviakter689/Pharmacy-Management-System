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
    public partial class SellInformation : UserControl
    {
        public SellInformation()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private DataAccess Da { get; set; }
        public void PopulateGridView(string sql = "select * from BillsTb;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.grdvSellInfo.AutoGenerateColumns = false;
            this.grdvSellInfo.DataSource = ds.Tables[0];
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtAutoSearch.Clear();
            this.grdvSellInfo.ClearSelection();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string sql = @"SELECT * FROM BillsTb 
               WHERE BillsId LIKE '" + this.txtAutoSearch.Text + @"%' 
               OR CustomerName LIKE '" + this.txtAutoSearch.Text + @"%';";

                this.PopulateGridView(sql);
            }
            catch
            {
                MessageBox.Show("Error has occured");
            }
        }
    }
}

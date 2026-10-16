namespace PharmaCare
{
    partial class EmployeeSellProduct
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPhone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.lblPhone = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdvProductList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtMedicineId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMedicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdvCart = new System.Windows.Forms.DataGridView();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCustomerPhoneNo = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.llblCustomerPhoneNo = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvCart)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(144, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(196, 34);
            label2.TabIndex = 21;
            label2.Text = "Product List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(963, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 34);
            label3.TabIndex = 22;
            label3.Text = "Cart";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(652, 533);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 20);
            this.lblPhone.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 100);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PharmaCare.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(1331, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmaCare.Properties.Resources.pharma;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1331, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 39);
            this.button4.TabIndex = 48;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(125, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 55);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pharma Care Ltd";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdvProductList);
            this.panel2.Location = new System.Drawing.Point(12, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 306);
            this.panel2.TabIndex = 28;
            // 
            // grdvProductList
            // 
            this.grdvProductList.AllowUserToAddRows = false;
            this.grdvProductList.AllowUserToOrderColumns = true;
            this.grdvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.grdvProductList.Location = new System.Drawing.Point(0, 3);
            this.grdvProductList.MultiSelect = false;
            this.grdvProductList.Name = "grdvProductList";
            this.grdvProductList.RowHeadersWidth = 51;
            this.grdvProductList.RowTemplate.Height = 24;
            this.grdvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdvProductList.Size = new System.Drawing.Size(640, 300);
            this.grdvProductList.TabIndex = 2;
            this.grdvProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvProductList_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MedicineId";
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Medicine Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MName";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "generic";
            this.Column3.HeaderText = "Generic";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Type";
            this.Column4.HeaderText = "Type";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Price";
            this.Column5.FillWeight = 60F;
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Quantity";
            this.Column6.FillWeight = 70F;
            this.Column6.HeaderText = "Quantity";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Honeydew;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1244, 472);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 33);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Edit Cart\r\n";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BackColor = System.Drawing.Color.Honeydew;
            this.btnCreateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBill.Location = new System.Drawing.Point(522, 177);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(129, 47);
            this.btnCreateBill.TabIndex = 34;
            this.btnCreateBill.Text = "Create Bill";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Honeydew;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(685, 466);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(123, 40);
            this.btnConfirm.TabIndex = 35;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Medicine Id\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 48);
            this.label6.TabIndex = 37;
            this.label6.Text = "Medicine Name:\r\n\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 669);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Quantity:\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 722);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Price:\r\n";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(484, 770);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(138, 38);
            this.btnAddToCart.TabIndex = 40;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtMedicineId
            // 
            this.txtMedicineId.BackColor = System.Drawing.Color.Honeydew;
            this.txtMedicineId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMedicineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineId.Location = new System.Drawing.Point(420, 546);
            this.txtMedicineId.Name = "txtMedicineId";
            this.txtMedicineId.Size = new System.Drawing.Size(202, 29);
            this.txtMedicineId.TabIndex = 41;
            this.txtMedicineId.Text = "................................................";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Honeydew;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(420, 716);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(202, 29);
            this.txtPrice.TabIndex = 42;
            this.txtPrice.Text = "................................................";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Honeydew;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(420, 659);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(202, 29);
            this.txtQuantity.TabIndex = 43;
            this.txtQuantity.Text = "................................................";
            // 
            // txtMName
            // 
            this.txtMName.BackColor = System.Drawing.Color.Honeydew;
            this.txtMName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.Location = new System.Drawing.Point(420, 604);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(202, 29);
            this.txtMName.TabIndex = 44;
            this.txtMName.Text = "................................................";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = "Bill Id:\r\n";
            // 
            // txtBillId
            // 
            this.txtBillId.BackColor = System.Drawing.Color.Honeydew;
            this.txtBillId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillId.Location = new System.Drawing.Point(420, 490);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(202, 29);
            this.txtBillId.TabIndex = 46;
            this.txtBillId.Text = "................................................";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 770);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 41);
            this.button3.TabIndex = 47;
            this.button3.Text = "LogOut\r\n";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // clmQuantity
            // 
            this.clmQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmQuantity.DataPropertyName = "Quantity";
            this.clmQuantity.FillWeight = 80F;
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.MinimumWidth = 6;
            this.clmQuantity.Name = "clmQuantity";
            // 
            // clmPrice
            // 
            this.clmPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPrice.DataPropertyName = "Price";
            this.clmPrice.FillWeight = 60F;
            this.clmPrice.HeaderText = "Price";
            this.clmPrice.MinimumWidth = 6;
            this.clmPrice.Name = "clmPrice";
            // 
            // clmMedicineName
            // 
            this.clmMedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMedicineName.DataPropertyName = "MName";
            this.clmMedicineName.HeaderText = "Name";
            this.clmMedicineName.MinimumWidth = 6;
            this.clmMedicineName.Name = "clmMedicineName";
            // 
            // clmMedicineId
            // 
            this.clmMedicineId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMedicineId.DataPropertyName = "MedicineId";
            this.clmMedicineId.FillWeight = 60F;
            this.clmMedicineId.HeaderText = "Medicine Id";
            this.clmMedicineId.MinimumWidth = 6;
            this.clmMedicineId.Name = "clmMedicineId";
            // 
            // grdvCart
            // 
            this.grdvCart.AllowUserToAddRows = false;
            this.grdvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMedicineId,
            this.clmMedicineName,
            this.clmPrice,
            this.clmQuantity,
            this.Column7});
            this.grdvCart.Location = new System.Drawing.Point(685, 154);
            this.grdvCart.Name = "grdvCart";
            this.grdvCart.RowHeadersWidth = 51;
            this.grdvCart.RowTemplate.Height = 24;
            this.grdvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdvCart.Size = new System.Drawing.Size(685, 306);
            this.grdvCart.TabIndex = 24;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(184, 30);
            this.txtGrandTotal.Multiline = true;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(122, 30);
            this.txtGrandTotal.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(312, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 24);
            this.label10.TabIndex = 52;
            this.label10.Text = "Taka";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCustomerPhoneNo);
            this.panel3.Controls.Add(this.txtCustomerName);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.llblCustomerPhoneNo);
            this.panel3.Controls.Add(this.lblCustomerName);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtGrandTotal);
            this.panel3.Controls.Add(this.btnCreateBill);
            this.panel3.Location = new System.Drawing.Point(685, 521);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 240);
            this.panel3.TabIndex = 53;
            // 
            // txtCustomerPhoneNo
            // 
            this.txtCustomerPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhoneNo.Location = new System.Drawing.Point(246, 143);
            this.txtCustomerPhoneNo.Multiline = true;
            this.txtCustomerPhoneNo.Name = "txtCustomerPhoneNo";
            this.txtCustomerPhoneNo.Size = new System.Drawing.Size(207, 28);
            this.txtCustomerPhoneNo.TabIndex = 57;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(246, 88);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(207, 30);
            this.txtCustomerName.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 24);
            this.label12.TabIndex = 55;
            this.label12.Text = "Grand Total =";
            // 
            // llblCustomerPhoneNo
            // 
            this.llblCustomerPhoneNo.AutoSize = true;
            this.llblCustomerPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCustomerPhoneNo.Location = new System.Drawing.Point(24, 148);
            this.llblCustomerPhoneNo.Name = "llblCustomerPhoneNo";
            this.llblCustomerPhoneNo.Size = new System.Drawing.Size(205, 24);
            this.llblCustomerPhoneNo.TabIndex = 54;
            this.llblCustomerPhoneNo.Text = "Customer Phone No:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(24, 94);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(166, 24);
            this.lblCustomerName.TabIndex = 53;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // EmployeeSellProduct
            // 
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1400, 818);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtBillId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMedicineId);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grdvCart);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeSellProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Sell Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvCart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdvProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox txtMedicineId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMedicineId;
        private System.Windows.Forms.DataGridView grdvCart;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label llblCustomerPhoneNo;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPhoneNo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

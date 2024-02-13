namespace Billing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BMS = new System.Windows.Forms.Label();
            this.receipt = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingDatabaseDataSet = new Billing.BillingDatabaseDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.print = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Receiptform = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.breadcost = new System.Windows.Forms.Label();
            this.beanscost = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.Label();
            this.NumBread = new System.Windows.Forms.Label();
            this.NumBeans = new System.Windows.Forms.Label();
            this.ricecost = new System.Windows.Forms.Label();
            this.NumRice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.purchaseTableAdapter = new Billing.BillingDatabaseDataSetTableAdapters.PurchaseTableAdapter();
            this.panel1.SuspendLayout();
            this.receipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDatabaseDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.BMS);
            this.panel1.Controls.Add(this.receipt);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-3, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 560);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BMS
            // 
            this.BMS.AutoSize = true;
            this.BMS.Location = new System.Drawing.Point(250, 18);
            this.BMS.Name = "BMS";
            this.BMS.Size = new System.Drawing.Size(588, 52);
            this.BMS.TabIndex = 0;
            this.BMS.Text = "Billing Management System";
            this.BMS.Click += new System.EventHandler(this.label7_Click);
            // 
            // receipt
            // 
            this.receipt.Controls.Add(this.dataGridView1);
            this.receipt.Controls.Add(this.label12);
            this.receipt.Location = new System.Drawing.Point(594, 92);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(702, 380);
            this.receipt.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.totalPurchaseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchaseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-60, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(759, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalPurchaseDataGridViewTextBoxColumn
            // 
            this.totalPurchaseDataGridViewTextBoxColumn.DataPropertyName = "TotalPurchase";
            this.totalPurchaseDataGridViewTextBoxColumn.HeaderText = "TotalPurchase";
            this.totalPurchaseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalPurchaseDataGridViewTextBoxColumn.Name = "totalPurchaseDataGridViewTextBoxColumn";
            this.totalPurchaseDataGridViewTextBoxColumn.Width = 150;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "Purchase";
            this.purchaseBindingSource.DataSource = this.billingDatabaseDataSet;
            // 
            // billingDatabaseDataSet
            // 
            this.billingDatabaseDataSet.DataSetName = "BillingDatabaseDataSet";
            this.billingDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(192, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 32);
            this.label12.TabIndex = 13;
            this.label12.Text = "Receipt";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.print);
            this.panel4.Controls.Add(this.Reset);
            this.panel4.Controls.Add(this.Exit);
            this.panel4.Controls.Add(this.Receiptform);
            this.panel4.Controls.Add(this.Total);
            this.panel4.Location = new System.Drawing.Point(15, 478);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1058, 67);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(437, 0);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(162, 58);
            this.print.TabIndex = 4;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(661, 0);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(162, 58);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button4_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(893, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(162, 58);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Receiptform
            // 
            this.Receiptform.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receiptform.Location = new System.Drawing.Point(221, 0);
            this.Receiptform.Name = "Receiptform";
            this.Receiptform.Size = new System.Drawing.Size(162, 58);
            this.Receiptform.TabIndex = 1;
            this.Receiptform.Text = "Receipt";
            this.Receiptform.UseVisualStyleBackColor = true;
            this.Receiptform.Click += new System.EventHandler(this.button2_Click);
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(3, 3);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(162, 58);
            this.Total.TabIndex = 0;
            this.Total.Text = "Total";
            this.Total.UseVisualStyleBackColor = true;
            this.Total.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDown3);
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cost);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.breadcost);
            this.panel3.Controls.Add(this.beanscost);
            this.panel3.Controls.Add(this.product);
            this.panel3.Controls.Add(this.NumBread);
            this.panel3.Controls.Add(this.NumBeans);
            this.panel3.Controls.Add(this.ricecost);
            this.panel3.Controls.Add(this.NumRice);
            this.panel3.Location = new System.Drawing.Point(15, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 380);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(168, 311);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 39);
            this.numericUpDown3.TabIndex = 19;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(171, 195);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 57);
            this.numericUpDown2.TabIndex = 18;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(168, 72);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 57);
            this.numericUpDown1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantity";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.Location = new System.Drawing.Point(356, 12);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(76, 32);
            this.cost.TabIndex = 12;
            this.cost.Text = "Cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 32);
            this.label10.TabIndex = 11;
            // 
            // breadcost
            // 
            this.breadcost.AutoSize = true;
            this.breadcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadcost.Location = new System.Drawing.Point(343, 90);
            this.breadcost.Name = "breadcost";
            this.breadcost.Size = new System.Drawing.Size(91, 32);
            this.breadcost.TabIndex = 10;
            this.breadcost.Text = "10.00";
            // 
            // beanscost
            // 
            this.beanscost.AutoSize = true;
            this.beanscost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beanscost.Location = new System.Drawing.Point(343, 213);
            this.beanscost.Name = "beanscost";
            this.beanscost.Size = new System.Drawing.Size(91, 32);
            this.beanscost.TabIndex = 9;
            this.beanscost.Text = "10.00";
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.BackColor = System.Drawing.Color.Transparent;
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(21, 12);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(119, 32);
            this.product.TabIndex = 7;
            this.product.Text = "Product";
            // 
            // NumBread
            // 
            this.NumBread.AutoSize = true;
            this.NumBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumBread.Location = new System.Drawing.Point(21, 90);
            this.NumBread.Name = "NumBread";
            this.NumBread.Size = new System.Drawing.Size(95, 32);
            this.NumBread.TabIndex = 6;
            this.NumBread.Text = "Bread";
            // 
            // NumBeans
            // 
            this.NumBeans.AutoSize = true;
            this.NumBeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumBeans.Location = new System.Drawing.Point(21, 213);
            this.NumBeans.Name = "NumBeans";
            this.NumBeans.Size = new System.Drawing.Size(100, 32);
            this.NumBeans.TabIndex = 5;
            this.NumBeans.Text = "Beans";
            // 
            // ricecost
            // 
            this.ricecost.AutoSize = true;
            this.ricecost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ricecost.Location = new System.Drawing.Point(343, 311);
            this.ricecost.Name = "ricecost";
            this.ricecost.Size = new System.Drawing.Size(91, 32);
            this.ricecost.TabIndex = 2;
            this.ricecost.Text = "10.00";
            this.ricecost.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumRice
            // 
            this.NumRice.AutoSize = true;
            this.NumRice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumRice.Location = new System.Drawing.Point(21, 311);
            this.NumRice.Name = "NumRice";
            this.NumRice.Size = new System.Drawing.Size(75, 32);
            this.NumRice.TabIndex = 0;
            this.NumRice.Text = "Rice";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(15, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1281, 68);
            this.panel2.TabIndex = 0;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 524);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.receipt.ResumeLayout(false);
            this.receipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDatabaseDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel receipt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Total;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Receiptform;
        private System.Windows.Forms.Label ricecost;
        private System.Windows.Forms.Label NumRice;
        private System.Windows.Forms.Label product;
        private System.Windows.Forms.Label NumBread;
        private System.Windows.Forms.Label NumBeans;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label breadcost;
        private System.Windows.Forms.Label beanscost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BMS;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BillingDatabaseDataSet billingDatabaseDataSet;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private BillingDatabaseDataSetTableAdapters.PurchaseTableAdapter purchaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPurchaseDataGridViewTextBoxColumn;
    }
}


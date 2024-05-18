
namespace DKSystem
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
            this.date = new System.Windows.Forms.Label();
            this.orderNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInfo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.backBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.productInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(331, 40);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(53, 13);
            this.date.TabIndex = 2;
            this.date.Text = "05/18/24";
            // 
            // orderNum
            // 
            this.orderNum.AutoSize = true;
            this.orderNum.Location = new System.Drawing.Point(14, 73);
            this.orderNum.Name = "orderNum";
            this.orderNum.Size = new System.Drawing.Size(35, 13);
            this.orderNum.TabIndex = 1;
            this.orderNum.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDER";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // productInfo
            // 
            this.productInfo.AllowUserToAddRows = false;
            this.productInfo.AllowUserToDeleteRows = false;
            this.productInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity,
            this.Price});
            this.productInfo.Location = new System.Drawing.Point(12, 111);
            this.productInfo.Name = "productInfo";
            this.productInfo.ReadOnly = true;
            this.productInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productInfo.ShowCellErrors = false;
            this.productInfo.ShowCellToolTips = false;
            this.productInfo.ShowEditingIcon = false;
            this.productInfo.Size = new System.Drawing.Size(398, 274);
            this.productInfo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total: ";
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.Location = new System.Drawing.Point(320, 433);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(35, 13);
            this.totalPriceLbl.TabIndex = 5;
            this.totalPriceLbl.Text = "label4";
            // 
            // backBtn
            // 
            this.backBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBtn.FillColor = System.Drawing.Color.Silver;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(12, 645);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(74, 45);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(438, 702);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productInfo);
            this.Controls.Add(this.date);
            this.Controls.Add(this.orderNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(438, 702);
            this.Name = "Form1";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.productInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label date;
        public System.Windows.Forms.Label orderNum;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        public System.Windows.Forms.DataGridView productInfo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label totalPriceLbl;
        private Guna.UI2.WinForms.Guna2Button backBtn;
    }
}
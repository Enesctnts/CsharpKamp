
namespace EntityFrameworkDemo
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.tbxNameSearch = new System.Windows.Forms.TextBox();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.lblStockAmountSearch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIdSearch = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblUniPrice = new System.Windows.Forms.Label();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Black;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.ForeColor = System.Drawing.Color.Crimson;
            this.btnRemove.Location = new System.Drawing.Point(41, 29);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 38);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.Color.PaleGreen;
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblStockAmountUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdate.ForeColor = System.Drawing.Color.OrangeRed;
            this.gbxUpdate.Location = new System.Drawing.Point(294, 246);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(225, 175);
            this.gbxUpdate.TabIndex = 12;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.Location = new System.Drawing.Point(101, 139);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.BackColor = System.Drawing.Color.Bisque;
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(101, 76);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(100, 22);
            this.tbxUnitPriceUpdate.TabIndex = 5;
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.BackColor = System.Drawing.Color.Bisque;
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(101, 111);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(100, 22);
            this.tbxStockAmountUpdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.BackColor = System.Drawing.Color.Khaki;
            this.lblNameUpdate.ForeColor = System.Drawing.Color.Maroon;
            this.lblNameUpdate.Location = new System.Drawing.Point(9, 48);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(38, 14);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.BackColor = System.Drawing.Color.Khaki;
            this.lblUnitPriceUpdate.ForeColor = System.Drawing.Color.Maroon;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(9, 79);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(59, 14);
            this.lblUnitPriceUpdate.TabIndex = 2;
            this.lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.BackColor = System.Drawing.Color.Bisque;
            this.tbxNameUpdate.Location = new System.Drawing.Point(101, 45);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(100, 22);
            this.tbxNameUpdate.TabIndex = 4;
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.BackColor = System.Drawing.Color.Khaki;
            this.lblStockAmountUpdate.ForeColor = System.Drawing.Color.Maroon;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(9, 114);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(86, 14);
            this.lblStockAmountUpdate.TabIndex = 3;
            this.lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // gbxAdd
            // 
            this.gbxAdd.BackColor = System.Drawing.Color.LightBlue;
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxAdd.Controls.Add(this.tbxStockAmount);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.lblUnitPrice);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblStockAmount);
            this.gbxAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAdd.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbxAdd.Location = new System.Drawing.Point(41, 246);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(225, 175);
            this.gbxAdd.TabIndex = 11;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Product";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(101, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.BackColor = System.Drawing.Color.Bisque;
            this.tbxUnitPrice.Location = new System.Drawing.Point(101, 76);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(100, 22);
            this.tbxUnitPrice.TabIndex = 5;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.BackColor = System.Drawing.Color.Bisque;
            this.tbxStockAmount.Location = new System.Drawing.Point(101, 111);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(100, 22);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Khaki;
            this.lblName.ForeColor = System.Drawing.Color.Maroon;
            this.lblName.Location = new System.Drawing.Point(9, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 14);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.Khaki;
            this.lblUnitPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblUnitPrice.Location = new System.Drawing.Point(9, 79);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(59, 14);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.Bisque;
            this.tbxName.Location = new System.Drawing.Point(101, 45);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 22);
            this.tbxName.TabIndex = 4;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.BackColor = System.Drawing.Color.Khaki;
            this.lblStockAmount.ForeColor = System.Drawing.Color.Maroon;
            this.lblStockAmount.Location = new System.Drawing.Point(9, 114);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(86, 14);
            this.lblStockAmount.TabIndex = 3;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(41, 73);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(719, 160);
            this.dgwProducts.TabIndex = 10;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // tbxNameSearch
            // 
            this.tbxNameSearch.BackColor = System.Drawing.Color.Bisque;
            this.tbxNameSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxNameSearch.Location = new System.Drawing.Point(82, 45);
            this.tbxNameSearch.Name = "tbxNameSearch";
            this.tbxNameSearch.Size = new System.Drawing.Size(122, 22);
            this.tbxNameSearch.TabIndex = 15;
            this.tbxNameSearch.TextChanged += new System.EventHandler(this.tbxSerach_TextChanged);
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNameSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNameSearch.Location = new System.Drawing.Point(12, 48);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(38, 14);
            this.lblNameSearch.TabIndex = 16;
            this.lblNameSearch.Text = "Name";
            // 
            // lblStockAmountSearch
            // 
            this.lblStockAmountSearch.AutoSize = true;
            this.lblStockAmountSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblStockAmountSearch.Location = new System.Drawing.Point(12, 79);
            this.lblStockAmountSearch.Name = "lblStockAmountSearch";
            this.lblStockAmountSearch.Size = new System.Drawing.Size(59, 14);
            this.lblStockAmountSearch.TabIndex = 20;
            this.lblStockAmountSearch.Text = "Get By Id";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.lblUniPrice);
            this.groupBox1.Controls.Add(this.btnIdSearch);
            this.groupBox1.Controls.Add(this.btnMax);
            this.groupBox1.Controls.Add(this.tbxNameSearch);
            this.groupBox1.Controls.Add(this.btnMin);
            this.groupBox1.Controls.Add(this.lblStockAmountSearch);
            this.groupBox1.Controls.Add(this.lblNameSearch);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(550, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 175);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnIdSearch
            // 
            this.btnIdSearch.Location = new System.Drawing.Point(82, 75);
            this.btnIdSearch.Name = "btnIdSearch";
            this.btnIdSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIdSearch.Size = new System.Drawing.Size(122, 23);
            this.btnIdSearch.TabIndex = 21;
            this.btnIdSearch.Text = "Get By Id";
            this.btnIdSearch.UseVisualStyleBackColor = true;
            this.btnIdSearch.Click += new System.EventHandler(this.btnIdSearch_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(144, 111);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(60, 23);
            this.btnMax.TabIndex = 26;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(82, 111);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(56, 23);
            this.btnMin.TabIndex = 25;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblUniPrice
            // 
            this.lblUniPrice.AutoSize = true;
            this.lblUniPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblUniPrice.Location = new System.Drawing.Point(12, 114);
            this.lblUniPrice.Name = "lblUniPrice";
            this.lblUniPrice.Size = new System.Drawing.Size(63, 14);
            this.lblUniPrice.TabIndex = 27;
            this.lblUniPrice.Text = "Unit Price ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.TextBox tbxNameSearch;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.Label lblStockAmountSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnIdSearch;
        private System.Windows.Forms.Label lblUniPrice;
    }
}


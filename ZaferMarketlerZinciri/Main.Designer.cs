namespace ZaferMarketlerZinciri
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUProducts = new System.Windows.Forms.GroupBox();
            this.txtuType = new System.Windows.Forms.TextBox();
            this.lbluType = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbluAmount = new System.Windows.Forms.Label();
            this.lbluUnitPrice = new System.Windows.Forms.Label();
            this.lblUName = new System.Windows.Forms.Label();
            this.txtSamount = new System.Windows.Forms.TextBox();
            this.txtUprice = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStockAmount = new System.Windows.Forms.TextBox();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.pctLogout = new System.Windows.Forms.PictureBox();
            this.gbxUProducts.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(569, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 32);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Ürün Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUProducts
            // 
            this.gbxUProducts.Controls.Add(this.txtuType);
            this.gbxUProducts.Controls.Add(this.lbluType);
            this.gbxUProducts.Controls.Add(this.btnUpdate);
            this.gbxUProducts.Controls.Add(this.lbluAmount);
            this.gbxUProducts.Controls.Add(this.lbluUnitPrice);
            this.gbxUProducts.Controls.Add(this.lblUName);
            this.gbxUProducts.Controls.Add(this.txtSamount);
            this.gbxUProducts.Controls.Add(this.txtUprice);
            this.gbxUProducts.Controls.Add(this.txtUname);
            this.gbxUProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUProducts.ForeColor = System.Drawing.Color.White;
            this.gbxUProducts.Location = new System.Drawing.Point(782, 309);
            this.gbxUProducts.Name = "gbxUProducts";
            this.gbxUProducts.Size = new System.Drawing.Size(378, 214);
            this.gbxUProducts.TabIndex = 22;
            this.gbxUProducts.TabStop = false;
            this.gbxUProducts.Text = "Bir Ürünü Güncelle";
            // 
            // txtuType
            // 
            this.txtuType.Location = new System.Drawing.Point(171, 72);
            this.txtuType.Name = "txtuType";
            this.txtuType.Size = new System.Drawing.Size(141, 22);
            this.txtuType.TabIndex = 8;
            // 
            // lbluType
            // 
            this.lbluType.AutoSize = true;
            this.lbluType.Location = new System.Drawing.Point(66, 73);
            this.lbluType.Name = "lbluType";
            this.lbluType.Size = new System.Drawing.Size(32, 17);
            this.lbluType.TabIndex = 7;
            this.lbluType.Text = "Tip:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(171, 159);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 40);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbluAmount
            // 
            this.lbluAmount.AutoSize = true;
            this.lbluAmount.Location = new System.Drawing.Point(66, 130);
            this.lbluAmount.Name = "lbluAmount";
            this.lbluAmount.Size = new System.Drawing.Size(80, 17);
            this.lbluAmount.TabIndex = 5;
            this.lbluAmount.Text = "Stok Adedi:";
            // 
            // lbluUnitPrice
            // 
            this.lbluUnitPrice.AutoSize = true;
            this.lbluUnitPrice.Location = new System.Drawing.Point(66, 102);
            this.lbluUnitPrice.Name = "lbluUnitPrice";
            this.lbluUnitPrice.Size = new System.Drawing.Size(80, 17);
            this.lbluUnitPrice.TabIndex = 4;
            this.lbluUnitPrice.Text = "Birim Fiyatı:";
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Location = new System.Drawing.Point(66, 45);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(29, 17);
            this.lblUName.TabIndex = 3;
            this.lblUName.Text = "Ad:";
            // 
            // txtSamount
            // 
            this.txtSamount.Location = new System.Drawing.Point(171, 130);
            this.txtSamount.Name = "txtSamount";
            this.txtSamount.Size = new System.Drawing.Size(141, 22);
            this.txtSamount.TabIndex = 2;
            // 
            // txtUprice
            // 
            this.txtUprice.Location = new System.Drawing.Point(171, 102);
            this.txtUprice.Name = "txtUprice";
            this.txtUprice.Size = new System.Drawing.Size(141, 22);
            this.txtUprice.TabIndex = 1;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(171, 42);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(141, 22);
            this.txtUname.TabIndex = 0;
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.lblUnitPrice);
            this.gbxProduct.Controls.Add(this.txtPrice);
            this.gbxProduct.Controls.Add(this.txtType);
            this.gbxProduct.Controls.Add(this.lblType);
            this.gbxProduct.Controls.Add(this.btnAdd);
            this.gbxProduct.Controls.Add(this.lblName);
            this.gbxProduct.Controls.Add(this.lblStockAmount);
            this.gbxProduct.Controls.Add(this.txtName);
            this.gbxProduct.Controls.Add(this.txtStockAmount);
            this.gbxProduct.ForeColor = System.Drawing.Color.White;
            this.gbxProduct.Location = new System.Drawing.Point(125, 309);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(351, 214);
            this.gbxProduct.TabIndex = 21;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Yeni Ürün Ekle";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(55, 102);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(80, 17);
            this.lblUnitPrice.TabIndex = 11;
            this.lblUnitPrice.Text = "Birim Fiyatı:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(160, 102);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(141, 22);
            this.txtPrice.TabIndex = 10;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(160, 72);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(141, 22);
            this.txtType.TabIndex = 9;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(55, 73);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(32, 17);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Tip:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(160, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ürün Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ad:";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(55, 130);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(80, 17);
            this.lblStockAmount.TabIndex = 2;
            this.lblStockAmount.Text = "Stok Adedi:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtStockAmount
            // 
            this.txtStockAmount.Location = new System.Drawing.Point(160, 130);
            this.txtStockAmount.Name = "txtStockAmount";
            this.txtStockAmount.Size = new System.Drawing.Size(141, 22);
            this.txtStockAmount.TabIndex = 5;
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(269, 140);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(758, 89);
            this.dgwProducts.TabIndex = 20;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // pctLogout
            // 
            this.pctLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctLogout.BackgroundImage")));
            this.pctLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLogout.Location = new System.Drawing.Point(17, 21);
            this.pctLogout.Name = "pctLogout";
            this.pctLogout.Size = new System.Drawing.Size(88, 74);
            this.pctLogout.TabIndex = 24;
            this.pctLogout.TabStop = false;
            this.pctLogout.Click += new System.EventHandler(this.pctLogout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1282, 549);
            this.Controls.Add(this.pctLogout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUProducts);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.dgwProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Yönetim Paneli - Zafer Marketler Zinciri A.Ş.";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbxUProducts.ResumeLayout(false);
            this.gbxUProducts.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUProducts;
        private System.Windows.Forms.TextBox txtuType;
        private System.Windows.Forms.Label lbluType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbluAmount;
        private System.Windows.Forms.Label lbluUnitPrice;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.TextBox txtSamount;
        private System.Windows.Forms.TextBox txtUprice;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStockAmount;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.PictureBox pctLogout;
    }
}
namespace Product_List
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataZone = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdcut = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPriceUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataZone)).BeginInit();
            this.SuspendLayout();
            // 
            // DataZone
            // 
            this.DataZone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataZone.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataZone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataZone.Location = new System.Drawing.Point(328, 12);
            this.DataZone.Name = "DataZone";
            this.DataZone.RowHeadersWidth = 51;
            this.DataZone.RowTemplate.Height = 24;
            this.DataZone.Size = new System.Drawing.Size(458, 524);
            this.DataZone.TabIndex = 0;
            this.DataZone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataZone_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtProdcut
            // 
            this.txtProdcut.Location = new System.Drawing.Point(110, 46);
            this.txtProdcut.Name = "txtProdcut";
            this.txtProdcut.Size = new System.Drawing.Size(178, 22);
            this.txtProdcut.TabIndex = 2;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(110, 80);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(178, 22);
            this.txtStock.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(110, 116);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(178, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(110, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(110, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 29);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPriceUpdate
            // 
            this.txtPriceUpdate.Location = new System.Drawing.Point(110, 297);
            this.txtPriceUpdate.Name = "txtPriceUpdate";
            this.txtPriceUpdate.Size = new System.Drawing.Size(178, 22);
            this.txtPriceUpdate.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "UpdateP";
            // 
            // txtStockUpdate
            // 
            this.txtStockUpdate.Location = new System.Drawing.Point(110, 261);
            this.txtStockUpdate.Name = "txtStockUpdate";
            this.txtStockUpdate.Size = new System.Drawing.Size(178, 22);
            this.txtStockUpdate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "UpdateS";
            // 
            // txtProductUpdate
            // 
            this.txtProductUpdate.Location = new System.Drawing.Point(110, 227);
            this.txtProductUpdate.Name = "txtProductUpdate";
            this.txtProductUpdate.Size = new System.Drawing.Size(178, 22);
            this.txtProductUpdate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "UpdateN";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(110, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 548);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPriceUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStockUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdcut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataZone);
            this.Name = "Form1";
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdcut;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPriceUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
    }
}


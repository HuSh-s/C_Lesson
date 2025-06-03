using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product_Dal products = new Product_Dal();
        private void Form1_Load(object sender, EventArgs e)
        {
            DataZone.DataSource = products.Print();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            products.Add(new Products
            {
                Name = txtProdcut.Text,
                Stock = Convert.ToInt32(txtStock.Text),
                Price = Convert.ToInt32(txtPrice.Text),
            });
            DataZone.DataSource = products.Print();
            MessageBox.Show("Product Added !!!");
        }

        private void DataZone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductUpdate.Text = DataZone.CurrentRow.Cells[1].Value.ToString();
            txtStockUpdate.Text = DataZone.CurrentRow.Cells[2].Value.ToString();
            txtPriceUpdate.Text = DataZone.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Products update = new Products
            {
                Id = Convert.ToInt32(DataZone.CurrentRow.Cells[0].Value),
                Name = txtProductUpdate.Text,
                Stock= Convert.ToInt32(txtStockUpdate.Text),
                Price= Convert.ToInt32(txtPriceUpdate.Text)
            };
            products.Update(update);
            DataZone.DataSource = products.Print();
            MessageBox.Show("Data Updated !!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Products delete = new Products
            {
                Id = Convert.ToInt32(DataZone.CurrentRow.Cells[0].Value)
            };
            products.Delete(delete);
            DataZone.DataSource = products.Print();
            MessageBox.Show("Product Deleted !!!");
        }
    }
}

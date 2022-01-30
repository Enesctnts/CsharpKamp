using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();

        }

        private void LoadProduct()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void SearchProduct(string key)
        {
           
            dgwProducts.DataSource = _productDal.GetByName(key);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice=Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount=Convert.ToInt32(tbxStockAmount.Text)
            });

            LoadProduct();
            MessageBox.Show("Added!");

        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            LoadProduct();
            MessageBox.Show("Updated!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProduct();
            MessageBox.Show("Deleted!");

        }

        private void tbxSerach_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(tbxNameSearch.Text);
        }


        private void btnMin_Click(object sender, EventArgs e)
        {
             _productDal.GetByUnitPriceMin(2000);
            

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            _productDal.GetByUnitPriceMax(3000);
        }

        private void btnIdSearch_Click(object sender, EventArgs e)
        {
            _productDal.GetById(1);
        }
    }
}

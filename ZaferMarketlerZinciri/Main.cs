using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaferMarketlerZinciri
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();

        private void Main_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = txtName.Text,
                Type = txtType.Text,
                UnitPrice = Convert.ToDecimal(txtPrice.Text),
                StockAmount = Convert.ToInt32(txtStockAmount.Text)
            });
            MessageBox.Show("Ürün Başarılı Bir Şekilde Eklenmiştir!");
            txtName.Clear();
            txtType.Clear();
            txtPrice.Clear();
            txtStockAmount.Clear();
            LoadProducts();
        }

        void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAllProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                ID = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = txtUname.Text,
                Type = txtuType.Text,
                UnitPrice = Convert.ToDecimal(txtUprice.Text),
                StockAmount = Convert.ToInt32(txtSamount.Text)
            });
            MessageBox.Show("Ürün Başarılı Bir Şekilde Güncellenmiştir!");
            txtUname.Clear();
            txtuType.Clear();
            txtUprice.Clear();
            txtSamount.Clear();
            LoadProducts();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUname.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtuType.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtUprice.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            txtSamount.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                ID = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Ürün Başarılı Bir Şekilde Silinmiştir!");
            LoadProducts();
        }

        private void pctLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?","ÇIKIŞ",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
                MessageBox.Show("Çıkış Yapıldı!");
            }
            else
            {
                MessageBox.Show("Çıkış İptal Edildi!");
            }
        }
    }
}

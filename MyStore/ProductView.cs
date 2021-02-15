using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyStore
{
    public partial class ProductView : Form
    {
        Users users;
        ShoppingCart cart;
        Catalog catalog;
        Product product;

        public ProductView(string product_id)
        {
            users = new Users("data/MyStore.db");
            cart = new ShoppingCart("data/MyStore.db");
            catalog = new Catalog("data/MyStore.db");
            product = catalog.FindProduct(product_id);
            InitializeComponent();

            txtQuantity.Text = "1";
            labelDesc.Text = product.description;
            txtCost.Text = $"$ {product.price}";
            txtTotal.Text = $"$ {product.price}";
            if (File.Exists($"data/images/{product.image}")) picProduct.ImageLocation = $"data/images/{product.image}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (users.GetUserLogged() != null)
            {
                if (product.active)
                {
                    cart.AddProduct(product, Convert.ToInt32(txtQuantity.Text));
                    MessageBox.Show("Se agrego al carrito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este producto no se encuentra disponible actualmente");
                }
            }
            else
            {
                MessageBox.Show("Inicia Sesión para poder agregar productos a tu carrito!");
            }
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(txtQuantity.Text);
            if (q > 1)
            {
                q--;
                txtQuantity.Text = $"{q}";
                txtTotal.Text = $"$ {q * product.price}";
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(txtQuantity.Text);
            q++;
            txtQuantity.Text = $"{q}";
            txtTotal.Text = $"$ {q * product.price}";
        }
    }
}

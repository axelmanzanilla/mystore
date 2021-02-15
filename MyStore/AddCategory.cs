using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class AddCategory : Form
    {
        EditProduct edit;
        Product product;
        Admin admin;

        public AddCategory(EditProduct edit, Admin admin, Product product)
        {
            //Tomar los parametros del Forms Edit Product
            this.edit = edit;
            this.product = product;
            this.admin = admin;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Reinicia el forms Edit Product y le pasa la nueva categoria
            string category = null;
            if (txtCategory.Text.Length > 0) category = txtCategory.Text;  //Comprueba si hay algo escrito
            EditProduct edit2 = new EditProduct(admin, product, category);
            this.Close();
            edit.Close();
            edit2.Show();
        }
    }
}

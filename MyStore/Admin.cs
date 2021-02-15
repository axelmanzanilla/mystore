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

    public partial class Admin : Form
    {
        Catalog catalog;
        BindingList<Product> data;  //Para que el list se pueda actualizar en tiempo real

        public Admin()
        {
            data = new BindingList<Product>();
            catalog = new Catalog("data/MyStore.db");
            InitializeComponent();

            //Obtiene todos los productos y los muestra en el List
            catalog.GetAllProducts().ForEach(p => data.Add(p));
            listProducts.DataSource = data;
            listProducts.ValueMember = "description";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Abre el Forms EditProduct y le pasa el producto actualmente seleccionado
            EditProduct edit = new EditProduct(this, listProducts.SelectedItem as Product);
            edit.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Abre el Forms EditProduct
            EditProduct edit = new EditProduct(this);
            edit.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Elimina el producto seleccionado de la base de datos y luego del List
            catalog.RemoveProduct(listProducts.SelectedItem as Product);
            data.Remove(listProducts.SelectedItem as Product);
        }
    }
}

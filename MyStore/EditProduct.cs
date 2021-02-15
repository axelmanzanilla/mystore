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
    public partial class EditProduct : Form
    {
        Admin admin;
        Product product;
        Catalog catalog;
        string category;

        public EditProduct(Admin admin, Product product = null, string category = null)
        {
            this.admin = admin;
            this.product = product;
            this.category = category;
            catalog = new Catalog("data/MyStore.db");
            InitializeComponent();

            //Si se le paso una categoria nueva la agrega al ComboBox y lo selecciona
            List<string> categories = catalog.GetCategories();
            if (category != null) categories.Add(this.category);
            comboCategory.DataSource = categories;

            //Si se le paso un producto llena los TextBox con su informacion
            if(product != null)
            {
                txtId.ReadOnly = true;
                txtId.TabStop = false;
                txtId.Text = product.id;
                txtDescription.Text = product.description;
                comboCategory.SelectedItem = product.category;
                txtPrice.Text = $"{product.price}";
                checkActive.Checked = product.active;
                picProduct.ImageLocation = $"data/images/{product.image}";
            }
            if (category != null) comboCategory.SelectedItem = category;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string description = txtDescription.Text;
            string precio = txtPrice.Text;

            bool checkid = true;
            bool checkde = true;
            bool checkpr = false;

            //Si se va a agregar un nuevo producto verifica que el ID sea unico
            if (product == null)
            {
                if(catalog.GetAllProducts().Exists(p => p.id == id))
                {
                    checkid = false;
                }
            }

            //Si se esta creando un nuevo producto verifica que la descripcion no se repita.
            if (catalog.GetAllProducts().Exists(p => p.description == description))
            {
                checkde = false;

                //Si se esta editando un producto verifica que sea su misma descripcion
                if (product != null)
                {
                    if(catalog.GetAllProducts().Find(p=>p.id == product.id).description == description)
                    {
                        checkde = true;
                    }
                }
            }

            //Verifica que haya un precio escrito y que sea un Double
            if((precio.Length > 0) && double.TryParse(precio, out _))
            {
                checkpr = true;
            }

            //Mensajes de error
            if (!checkid) MessageBox.Show("Ya existe un producto con ese ID!");
            else if (!checkde) MessageBox.Show("Ya existe un producto con esa descripción!");
            else if (!checkpr) MessageBox.Show("Ingrese un precio correcto!");
            else
            {
                //Crea un nuevo producto con las caracteristicas obtenidas del usuario
                string newimage = Path.GetFileName(picProduct.ImageLocation);
                if (!File.Exists($"data/images/{newimage}")) File.Copy(picProduct.ImageLocation, $"data/images/{newimage}");

                Product auxProduct = new Product(id,
                                                 description,
                                                 comboCategory.SelectedItem.ToString(),
                                                 Convert.ToDecimal(precio),
                                                 newimage,
                                                 checkActive.Checked);

                //Si se esta editando actualiza el producto, en caso contrario crea un nuevo producto
                if (product != null)
                {
                    catalog.UpdateProduct(auxProduct);
                    MessageBox.Show("El producto se ha actualizado correctamente!");
                }
                else
                {
                    catalog.AddProduct(auxProduct);
                    MessageBox.Show("El producto se ha agregado correctamente!");
                }

                this.Close();
                admin.Close();
                Admin admin2 = new Admin();
                admin2.Show();
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();  //Abre el administrador de archivos para cargar un archivo
            open.Filter = "Image Files(*.jpg; *.jpeg ; *.png;)|*.jpg; *.jpeg; *.png;";  //Archivos admitidos
            if (open.ShowDialog() == DialogResult.OK)
            {
                picProduct.ImageLocation = open.FileName;  //Establece la imagen
            }
        }

        private void picProduct_Click(object sender, EventArgs e)
        {
            btnImage.PerformClick();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo es admitido numeros y puntos en el TxtPrice
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Solo se puede poner 1 punto
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            //Abre el Forms AddCategory
            AddCategory add = new AddCategory(this, admin, product);
            add.Show();
        }
    }
}

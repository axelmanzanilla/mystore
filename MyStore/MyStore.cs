using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace MyStore
{
    public partial class MyStore : Form
    {
        Catalog catalog;
        Users users;

        public MyStore()
        {
            //Carga la base de datos
            catalog = new Catalog("data/MyStore.db");
            users = new Users("data/MyStore.db");

            InitializeComponent();

            //Crea los Panels de todos los productos activos
            MakePanels(catalog.GetActiveProducts());

            //Crea el ComboBox de categorias y le agrega una nueva: "Todas"
            List<string> categories = new List<string> { "Todas" };
            catalog.GetCategories().ForEach(c => categories.Add(c));
            comboCategories.DataSource = categories;

            //Si no hay usuario logueado el menu solo muestra el boton para iniciar sesion
            if (users.GetUserLogged() == null)
            {
                panelUser.Visible = false;
                btnSesion.Text = "Iniciar Sesión";
                panelProfile.Size = new Size(89, 50);
            }
            else
            {
                //Si hay usuario logueado despliega todas las opciones y el Panel se agranda
                profilePicture.ImageLocation = $"data/images/{users.GetUserLogged().image}";
                txtMsg.Text = "Bienvenido, " + users.GetUserLogged().firstname;
                btnSesion.Text = "Cerrar Sesión";

                if (users.GetUserLogged().username == "admin")
                {
                    panelAdmin.Visible = true;
                }
                else
                {
                    panelProfile.Size = new Size(89, 105);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Busca todos los productos que coincidan con lo escrito en el TextBox y hace los Panels
            List<Product> p = catalog.FindProductsWithMaxFilter(txtBuscar.Text);
            MakePanels(p);
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            //Despliega u Oculta el Panel que muestra el menu del usuario al presionar su foto de perfil
            panelProfile.Visible = !panelProfile.Visible;
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            //Si hay un usuario logueado lo elimina de la base de datos y cierra la aplicacion
            if (users.GetUserLogged() != null)
            {
                users.DeleteUserLogged();
                Application.Restart();
            }
            else
            {
                //Abre el Forms LogIn
                LogIn logIn = new LogIn();
                logIn.Show();
            }
        }

        private void linkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abre el Forms Profile
            Profile profile = new Profile();
            profile.Show();
        }

        private void linkCarrito_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();                                    //Esconde el Forms
            Cart cart = new Cart();                         //Crea el Forms Cart
            cart.FormClosed += (s, args) => this.Close();   //Le agrega la funcion de que cierre el Forms escondido cuando se cierre el Forms Cart
            cart.Show();                                    //Muestra el Forms Cart
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Busca los productos con los filtros establecidos por el usuario y con la descripcion escrita en el TextBox
            List<Product> productsfiltred = catalog.FindProductsWithFilter(txtBuscar.Text,
                                                                           comboCategories.SelectedItem.ToString(),
                                                                           txtMin.Text,
                                                                           txtMax.Text,
                                                                           onlyAvailable.Checked);

            MakePanels(productsfiltred);
        }

        private void MakePanels(List<Product> products)
        {
            //Por cada producto en la lista de productos que le pasen a esta funcion hace un panel con la imagen y descripcion
            panelProducts.Controls.Clear();

            foreach(Product product in products)
            {
                //PictureBox con la imagen del producto
                PictureBox picture = new PictureBox();
                picture.Name = $"{product.id}";
                picture.Dock = DockStyle.Top;
                picture.Size = new Size(162, 120);
                if (File.Exists($"data/images/{product.image}")) picture.ImageLocation = $"data/images/{product.image}";
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Click += new EventHandler(pic_Click);

                //RichTextBox con la descripcion del producto
                RichTextBox text = new RichTextBox();
                text.BorderStyle = BorderStyle.None;
                text.Dock = DockStyle.Bottom;
                text.Location = new Point(0, 126);
                text.ScrollBars = RichTextBoxScrollBars.None;
                text.Size = new Size(162, 54);
                text.Font = new Font("Microsoft Sans Serif", 9.75f);
                text.Text = $"{product.description}";
                text.Enabled = false;

                //Panel contenedor
                Panel panel = new Panel();
                panel.Size = new Size(162, 180);
                panel.Name = $"{product.id}";
                panel.Controls.Add(picture);
                panel.Controls.Add(text);
                panel.Click += new EventHandler(panel_Click);

                //FlowPanel principal
                panelProducts.Controls.Add(panel);
            }
        }

        private void linkMostrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Muestra u oculta el panel de los filtros
            panelFiltros.Visible = !panelFiltros.Visible;
            if(panelFiltros.Visible) linkMostrar.Text = "Ocultar Filtros";
            else linkMostrar.Text = "Mostrar Filtros";
        }

        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            //Aplica los filtros establecidos por el usuario y los despliega
            List<Product> productsfiltred = productsfiltred = catalog.FindProductsWithFilter(txtBuscar.Text,
                                                                                             comboCategories.SelectedItem.ToString(),
                                                                                             txtMin.Text,
                                                                                             txtMax.Text,
                                                                                             onlyAvailable.Checked);
            MakePanels(productsfiltred);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Reinicia los filtros y los aplica
            comboCategories.SelectedIndex = 0;
            txtMin.Clear();
            txtMax.Clear();
            onlyAvailable.Checked = true;
            btnAplicar.PerformClick();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            //Abre el Forms ProductView
            ProductView view = new ProductView((sender as Panel).Name);
            view.Show();
        }

        private void pic_Click(object sender, EventArgs e)
        {
            //Abre el Forms ProductView
            ProductView view = new ProductView((sender as PictureBox).Name);
            view.Show();
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abre el Forms Admin
            Admin admin = new Admin();
            admin.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Activa los botones con un enter
        private void txtMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAplicar.PerformClick();
        }

        private void txtMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAplicar.PerformClick();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnBuscar.PerformClick();
        }
    }
}

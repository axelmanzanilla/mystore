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
    public partial class Cart : Form
    {
        Users users;
        ShoppingCart cart;

        public Cart()
        {
            //Obtener la base de datos
            users = new Users("data/MyStore.db");
            cart = new ShoppingCart("data/MyStore.db");
            InitializeComponent();
            if (cart.GetCart().Count > 0) panelEmpty.Visible = false;  //Si hay productos en el carrito quita el mensaje
            GeneratePanels();  //Genera todos los Paneles que muestran la lista de productos en el carrito
            CalculateTotalPrice();
            profilePicture.ImageLocation = $"data/images/{users.GetUserLogged().image}";

            //Si el usuario es el admin le habilita un Panel adicional
            if (users.GetUserLogged().username == "admin")
            {
                panelAdmin.Visible = true;
            }
            else
            {
                panelProfile.Size = new Size(89, 80);
            }
        }

        public void GeneratePanels()
        {
            //Por cada producto que haya en el carrito se crea un Panel con varios controles dentro
            foreach (Product product in cart.GetCart())
            {
                //Label de la descripcion del producto
                Label label = new Label();
                label.Size = new Size(413, 33);
                label.Font = new Font("Microsoft Sans Serif", 21.75f);
                label.Text = product.description;
                label.Location = new Point(9, 17);

                //Label "Cantidad:"
                Label label2 = new Label();
                label2.Text = "Cantidad:";
                label2.Font = new Font("Microsoft Sans Serif", 8.25f);
                label2.Size = new Size(52, 13);
                label2.Location = new Point(32, 64);

                //Label "Precio total:"
                Label label3 = new Label();
                label3.Text = "Precio total:";
                label3.Font = new Font("Microsoft Sans Serif", 8.25f);
                label3.Size = new Size(63, 13);
                label3.Location = new Point(206, 64);

                //TextBox que da la cantidad de productos de un mismo ID
                TextBox text = new TextBox();
                text.Name = $"{product.id}q";
                text.Location = new Point(90, 61);
                text.Size = new Size(100, 20);
                text.Font = new Font("Microsoft Sans Serif", 8.25f);
                text.Text = cart.GetQuantity(product).ToString();
                text.ReadOnly = true;

                //TextBox que da el precio total por producto
                TextBox text2 = new TextBox();
                text2.Name = $"{product.id}p";
                text2.Location = new Point(275, 61);
                text2.Size = new Size(100, 20);
                text2.Font = new Font("Microsoft Sans Serif", 8.25f);
                text2.Text = $"$ {cart.GetQuantity(product) * product.price}";
                text2.ReadOnly = true;

                //Button para quitar un producto
                Button button = new Button();
                button.Name = $"{product.id}";
                button.Location = new Point(390, 55);
                button.Size = new Size(79, 28);
                button.Font = new Font("Microsoft Sans Serif", 9f);
                button.Text = "Quitar uno";
                button.Click += new EventHandler(minus_Click);

                //Button para quitar todos los productos de un mismo ID
                Button button2 = new Button();
                button2.Name = $"{product.id}";
                button2.Location = new Point(847, 33);
                button2.Size = new Size(64, 39);
                button2.Font = new Font("Microsoft Sans Serif", 9f);
                button2.Text = "Quitar todos";
                button2.Click += new EventHandler(erase_Click);

                //Panel que contiene a todos los controles anteriores
                Panel panel = new Panel();
                panel.Name = $"{product.id}pnl";
                panel.Size = new Size(933, 100);
                panel.Controls.Add(label);
                panel.Controls.Add(label2);
                panel.Controls.Add(label3);
                panel.Controls.Add(text);
                panel.Controls.Add(text2);
                panel.Controls.Add(button);
                panel.Controls.Add(button2);

                //Agregar los Panels al FlowPanel principal
                pnlCart.Controls.Add(panel);
            }
        }

        private void picMain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void linkCarrito_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            //Despliega u Oculta el Panel que muestra el menu del usuario al presionar su foto de perfil
            panelProfile.Visible = !panelProfile.Visible;
        }

        private void linkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abre el Forms Profile
            Profile profile = new Profile();
            profile.Show();
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abre el Forms Admin
            Admin admin = new Admin();
            admin.Show();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            //Borra el usuario actualmente logueado de la base de datos y luego reinicia la aplicacion
            users.DeleteUserLogged();
            Application.Restart();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            //Si hay productos en el carrito los borra todos y reinicia la aplicacion
            if (cart.GetCart().Count > 0)
            {
                cart.Clear();
                MessageBox.Show("Se han comprado todos los productos!");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Tu carrito está vacío!");
            }
                
        }

        private void minus_Click(object sender, EventArgs e)
        {
            //Borra 1 producto
            Product product = cart.GetCart().Find(p => p.id == (sender as Button).Name);           //Obtiene el producto seleccionado
            cart.RemoveFirstProduct(product);                                                      //Remueve 1 producto de la base de datos
            Controls.Find($"{product.id}q", true)[0].Text = cart.GetQuantity(product).ToString();  //Actualiza la cantidad y el precio total
            Controls.Find($"{product.id}p", true)[0].Text = $"$ {product.price * cart.GetQuantity(product)}";

            //Si al borrar 1 producto se llega a 0 se activa la funcion para "erase_Click"
            if (cart.GetQuantity(product) == 0) erase_Click(sender, e);

            CalculateTotalPrice();
        }

        private void erase_Click(object sender, EventArgs e)
        {
            //Borra todos los productos de un mismo ID
            Product product = cart.GetCart().Find(p => p.id == (sender as Button).Name);
            cart.RemoveAllProducts(product);
            Controls.Find($"{product.id}pnl", true)[0].Visible = false;
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            txtTotal.Text = $"$ {cart.CalculateTotalCost()}";
        }

        private void linkInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
    }
}
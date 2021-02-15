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
    public partial class SignUp : Form
    {
        Users users;

        public SignUp()
        {
            users = new Users("data/MyStore.db");
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text.Length == 0 ||
                txtLast.Text.Length == 0 ||
                txtUsername.Text.Length == 0 ||
                txtCheckPass.Text.Length == 0)
            {
                MessageBox.Show("Llene todos los campos!");
                
            }
            else if (txtPass.Text.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener al menos 4 caracteres!");
            }
            else if(txtPass.Text != txtCheckPass.Text)
            {
            }
            else
            {
                users.CreateUser(txtFirst.Text, txtLast.Text, txtUsername.Text, txtPass.Text);
                MessageBox.Show("Usuario registrado con Éxito!");
                users.InsertUserLogged(txtUsername.Text);
                Application.Restart();
                this.Close();
            }
        }

        private void txtCheckPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text != txtCheckPass.Text) labelPassword.Visible = true;
            else labelPassword.Visible = false;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (users.UserExists(txtUsername.Text)) labelUsername.Visible = true;
            else labelUsername.Visible = false;
        }

        private void txtCheckPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnCrear.PerformClick();
        }
    }
}

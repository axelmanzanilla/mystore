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
    public partial class LogIn : Form
    {
        Users users;

        public LogIn()
        {
            users = new Users("data/MyStore.db");
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            if(txtUser.Text.Length > 0 && txtPass.Text.Length > 0)
            {
                if (!users.UserExists(txtUser.Text))
                {
                    MessageBox.Show("El usuario ingresado no existe!");
                }
                else if (!users.isThePassword(txtUser.Text, txtPass.Text))
                {
                    MessageBox.Show("Contraseña incorrecta!");
                }
                else
                {
                    users.InsertUserLogged(txtUser.Text);
                    this.Close();
                    Application.Restart();
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos!");
            }
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Close();
            signUp.Show();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Length == 0) labelErrorUser.Visible = true;
            else labelErrorUser.Visible = false;
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogIn.PerformClick();
        }

        private void LogIn_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

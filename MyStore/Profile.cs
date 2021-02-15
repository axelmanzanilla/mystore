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
    public partial class Profile : Form
    {
        Users users;

        public Profile()
        {
            users = new Users("data/MyStore.db");
            InitializeComponent();
            imgProfile.ImageLocation = $"data/images/{users.GetUserLogged().image}";
            txtFirst.Text = users.GetUserLogged().firstname;
            txtLast.Text = users.GetUserLogged().lastname;
            txtUser.Text = users.GetUserLogged().username;
            txtPass.Text = users.GetUserLogged().password;
        }

        private void btnShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = '\0';
        }

        private void btnShow_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text.Length == 0 ||
                txtLast.Text.Length == 0 ||
                txtUser.Text.Length == 0 ||
                txtPass.Text.Length == 0)
            {
                MessageBox.Show("Llene todos los campos!");

            }
            else if (txtPass.Text.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener al menos 4 caracteres!");
            }
            else if (users.UserExists(txtUser.Text) && txtUser.Text != users.GetUserLogged().username)
            {
                MessageBox.Show("Ese nombre de usuario ya está en uso!");
            }
            else
            {
                string newimage = Path.GetFileName(imgProfile.ImageLocation);
                if (!File.Exists($"data/images/{newimage}")) File.Copy(imgProfile.ImageLocation, $"data/images/{newimage}");
                
                users.UpdateUser(txtFirst.Text, txtLast.Text, txtUser.Text, txtPass.Text, newimage);
                MessageBox.Show("Datos guardados con Éxito!");
                this.Close();
                Application.Restart();
            }
        }

        private void linkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Confirm confirm = new Confirm();
            confirm.Show();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg ; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imgProfile.ImageLocation = open.FileName;
            }
        }

        private void imgProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg ; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imgProfile.ImageLocation = open.FileName;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;

namespace MyStore
{
    public partial class Confirm : Form
    {
        SQLiteConn db;

        public Confirm()
        {
            db = new SQLiteConn("data/MyStore.db", true);
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Se borra el usuario de la base de datos y se reinicia la aplicacion
            int id = db.GetUserLogged().id;
            db.ExecuteNonQuery($"DELETE FROM user_logged AS ul WHERE ul.user_id = {id}; " +
                               $"DELETE FROM shoppingcarts AS sc WHERE sc.user_id = {id}; " +
                               $"DELETE FROM users AS u WHERE u.id = {id}");
            MessageBox.Show("La cuenta ha sido borrada!");
            Application.Restart();
        }
    }
}

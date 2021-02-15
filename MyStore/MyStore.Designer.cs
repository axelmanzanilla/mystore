
namespace MyStore
{
    partial class MyStore
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyStore));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelProfile = new System.Windows.Forms.FlowLayoutPanel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.linkPerfil = new System.Windows.Forms.LinkLabel();
            this.linkCarrito = new System.Windows.Forms.LinkLabel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.linkAdmin = new System.Windows.Forms.LinkLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSesion = new System.Windows.Forms.Button();
            this.panelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.onlyAvailable = new System.Windows.Forms.CheckBox();
            this.comboCategories = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkMostrar = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panelProfile);
            this.panel1.Controls.Add(this.panelProducts);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 681);
            this.panel1.TabIndex = 0;
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.Gainsboro;
            this.panelProfile.Controls.Add(this.panelUser);
            this.panelProfile.Controls.Add(this.panelAdmin);
            this.panelProfile.Controls.Add(this.panel7);
            this.panelProfile.Location = new System.Drawing.Point(1043, 95);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(89, 126);
            this.panelProfile.TabIndex = 3;
            this.panelProfile.Visible = false;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.linkPerfil);
            this.panelUser.Controls.Add(this.linkCarrito);
            this.panelUser.Location = new System.Drawing.Point(3, 3);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(86, 50);
            this.panelUser.TabIndex = 0;
            // 
            // linkPerfil
            // 
            this.linkPerfil.AutoSize = true;
            this.linkPerfil.Location = new System.Drawing.Point(10, 30);
            this.linkPerfil.Name = "linkPerfil";
            this.linkPerfil.Size = new System.Drawing.Size(60, 13);
            this.linkPerfil.TabIndex = 2;
            this.linkPerfil.TabStop = true;
            this.linkPerfil.Text = "Editar Perfil";
            this.linkPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPerfil_LinkClicked);
            // 
            // linkCarrito
            // 
            this.linkCarrito.AutoSize = true;
            this.linkCarrito.Location = new System.Drawing.Point(12, 7);
            this.linkCarrito.Name = "linkCarrito";
            this.linkCarrito.Size = new System.Drawing.Size(56, 13);
            this.linkCarrito.TabIndex = 1;
            this.linkCarrito.TabStop = true;
            this.linkCarrito.Text = "Ver Carrito";
            this.linkCarrito.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCarrito_LinkClicked);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.linkAdmin);
            this.panelAdmin.Location = new System.Drawing.Point(3, 59);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(86, 18);
            this.panelAdmin.TabIndex = 1;
            this.panelAdmin.Visible = false;
            // 
            // linkAdmin
            // 
            this.linkAdmin.AutoSize = true;
            this.linkAdmin.Location = new System.Drawing.Point(13, 3);
            this.linkAdmin.Name = "linkAdmin";
            this.linkAdmin.Size = new System.Drawing.Size(54, 13);
            this.linkAdmin.TabIndex = 2;
            this.linkAdmin.TabStop = true;
            this.linkAdmin.Text = "Inventario";
            this.linkAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdmin_LinkClicked);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnSesion);
            this.panel7.Location = new System.Drawing.Point(3, 83);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(86, 42);
            this.panel7.TabIndex = 2;
            // 
            // btnSesion
            // 
            this.btnSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.Location = new System.Drawing.Point(10, 2);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(64, 39);
            this.btnSesion.TabIndex = 3;
            this.btnSesion.Text = "Iniciar Sesión";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // panelProducts
            // 
            this.panelProducts.AutoScroll = true;
            this.panelProducts.Location = new System.Drawing.Point(295, 95);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(860, 586);
            this.panelProducts.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panelFiltros);
            this.panel3.Controls.Add(this.linkMostrar);
            this.panel3.Location = new System.Drawing.Point(0, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 586);
            this.panel3.TabIndex = 1;
            // 
            // panelFiltros
            // 
            this.panelFiltros.Controls.Add(this.onlyAvailable);
            this.panelFiltros.Controls.Add(this.comboCategories);
            this.panelFiltros.Controls.Add(this.btnAplicar);
            this.panelFiltros.Controls.Add(this.btnBorrar);
            this.panelFiltros.Controls.Add(this.txtMax);
            this.panelFiltros.Controls.Add(this.txtMin);
            this.panelFiltros.Controls.Add(this.label3);
            this.panelFiltros.Controls.Add(this.label2);
            this.panelFiltros.Controls.Add(this.label1);
            this.panelFiltros.Location = new System.Drawing.Point(0, 33);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(289, 553);
            this.panelFiltros.TabIndex = 3;
            this.panelFiltros.Visible = false;
            // 
            // onlyAvailable
            // 
            this.onlyAvailable.AutoSize = true;
            this.onlyAvailable.Checked = true;
            this.onlyAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onlyAvailable.Location = new System.Drawing.Point(12, 139);
            this.onlyAvailable.Name = "onlyAvailable";
            this.onlyAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.onlyAvailable.Size = new System.Drawing.Size(102, 17);
            this.onlyAvailable.TabIndex = 5;
            this.onlyAvailable.Text = "Solo disponibles";
            this.onlyAvailable.UseVisualStyleBackColor = true;
            // 
            // comboCategories
            // 
            this.comboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategories.FormattingEnabled = true;
            this.comboCategories.Location = new System.Drawing.Point(85, 26);
            this.comboCategories.Name = "comboCategories";
            this.comboCategories.Size = new System.Drawing.Size(187, 21);
            this.comboCategories.TabIndex = 4;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(197, 172);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 2;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(85, 172);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar Filtros";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(105, 92);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(167, 20);
            this.txtMax.TabIndex = 0;
            this.txtMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMax_KeyDown);
            this.txtMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(105, 66);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(167, 20);
            this.txtMin.TabIndex = 0;
            this.txtMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMin_KeyDown);
            this.txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMin_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Precio máximo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio minimo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria:";
            // 
            // linkMostrar
            // 
            this.linkMostrar.AutoSize = true;
            this.linkMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkMostrar.LinkColor = System.Drawing.Color.Black;
            this.linkMostrar.Location = new System.Drawing.Point(83, 10);
            this.linkMostrar.Name = "linkMostrar";
            this.linkMostrar.Size = new System.Drawing.Size(110, 20);
            this.linkMostrar.TabIndex = 0;
            this.linkMostrar.TabStop = true;
            this.linkMostrar.Text = "Mostrar Filtros";
            this.linkMostrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMostrar_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtMsg);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.profilePicture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 89);
            this.panel2.TabIndex = 0;
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.SystemColors.Control;
            this.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsg.Enabled = false;
            this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(937, 12);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.Size = new System.Drawing.Size(100, 60);
            this.txtMsg.TabIndex = 10;
            this.txtMsg.TabStop = false;
            this.txtMsg.Text = "No has iniciado sesión";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MyStore.Properties.Resources.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 83);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(813, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 44);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(295, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(512, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profilePicture.ErrorImage = null;
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.InitialImage = null;
            this.profilePicture.Location = new System.Drawing.Point(1043, 0);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(89, 89);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.profilePicture_Click);
            // 
            // MyStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1155, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyStore";
            this.panel1.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel panelProfile;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.LinkLabel linkCarrito;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.LinkLabel linkAdmin;
        private System.Windows.Forms.LinkLabel linkPerfil;
        private System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.FlowLayoutPanel panelProducts;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.LinkLabel linkMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.ComboBox comboCategories;
        private System.Windows.Forms.CheckBox onlyAvailable;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAplicar;
    }
}



namespace MyStore
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.pnlCart = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEmpty = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.FlowLayoutPanel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.linkPerfil = new System.Windows.Forms.LinkLabel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.linkAdmin = new System.Windows.Forms.LinkLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSesion = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkInicio = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.pnlCart.SuspendLayout();
            this.panelEmpty.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMsg);
            this.panel2.Controls.Add(this.picMain);
            this.panel2.Controls.Add(this.profilePicture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 89);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Carrito de compras";
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
            this.txtMsg.TabIndex = 0;
            this.txtMsg.TabStop = false;
            this.txtMsg.Text = "No has iniciado sesión";
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.Color.Transparent;
            this.picMain.BackgroundImage = global::MyStore.Properties.Resources.logo;
            this.picMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMain.Location = new System.Drawing.Point(3, 3);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(286, 83);
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            this.picMain.Click += new System.EventHandler(this.picMain_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profilePicture.Location = new System.Drawing.Point(1043, 0);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(89, 89);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.profilePicture_Click);
            // 
            // pnlCart
            // 
            this.pnlCart.AutoScroll = true;
            this.pnlCart.Controls.Add(this.panelEmpty);
            this.pnlCart.Location = new System.Drawing.Point(0, 92);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(961, 589);
            this.pnlCart.TabIndex = 2;
            // 
            // panelEmpty
            // 
            this.panelEmpty.Controls.Add(this.label4);
            this.panelEmpty.Location = new System.Drawing.Point(3, 3);
            this.panelEmpty.Name = "panelEmpty";
            this.panelEmpty.Size = new System.Drawing.Size(958, 223);
            this.panelEmpty.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(543, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tu carrito actualmente se encuentra vacío :(";
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.Gainsboro;
            this.panelProfile.Controls.Add(this.panelUser);
            this.panelProfile.Controls.Add(this.panelAdmin);
            this.panelProfile.Controls.Add(this.panel7);
            this.panelProfile.Location = new System.Drawing.Point(1043, 92);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(89, 101);
            this.panelProfile.TabIndex = 4;
            this.panelProfile.Visible = false;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.linkPerfil);
            this.panelUser.Location = new System.Drawing.Point(3, 3);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(86, 21);
            this.panelUser.TabIndex = 0;
            // 
            // linkPerfil
            // 
            this.linkPerfil.AutoSize = true;
            this.linkPerfil.Location = new System.Drawing.Point(10, 4);
            this.linkPerfil.Name = "linkPerfil";
            this.linkPerfil.Size = new System.Drawing.Size(60, 13);
            this.linkPerfil.TabIndex = 2;
            this.linkPerfil.TabStop = true;
            this.linkPerfil.Text = "Editar Perfil";
            this.linkPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPerfil_LinkClicked);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.linkAdmin);
            this.panelAdmin.Location = new System.Drawing.Point(3, 30);
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
            this.panel7.Location = new System.Drawing.Point(3, 54);
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
            this.btnSesion.Text = "Cerrar Sesión";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1021, 178);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(122, 20);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TabStop = false;
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(1032, 256);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(64, 39);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Pagar";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(981, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total:";
            // 
            // linkInicio
            // 
            this.linkInicio.AutoSize = true;
            this.linkInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkInicio.Location = new System.Drawing.Point(993, 213);
            this.linkInicio.Name = "linkInicio";
            this.linkInicio.Size = new System.Drawing.Size(139, 20);
            this.linkInicio.TabIndex = 0;
            this.linkInicio.TabStop = true;
            this.linkInicio.Text = "Seguir comprando";
            this.linkInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInicio_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1052, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "o";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkInicio);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.pnlCart);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyStore";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.pnlCart.ResumeLayout(false);
            this.panelEmpty.ResumeLayout(false);
            this.panelEmpty.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.FlowLayoutPanel pnlCart;
        private System.Windows.Forms.FlowLayoutPanel panelProfile;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.LinkLabel linkPerfil;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.LinkLabel linkAdmin;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelEmpty;
        private System.Windows.Forms.Label label4;
    }
}
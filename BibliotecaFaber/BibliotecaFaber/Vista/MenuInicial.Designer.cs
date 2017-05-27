namespace BibliotecaFaber.Vista {
    partial class MenuInicial {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial));
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDevolverLibro = new System.Windows.Forms.PictureBox();
            this.boton_gestionCliente = new System.Windows.Forms.PictureBox();
            this.boton_logout = new System.Windows.Forms.PictureBox();
            this.boton_prestamoLibros = new System.Windows.Forms.PictureBox();
            this.boton_buscarLibros = new System.Windows.Forms.PictureBox();
            this.boton_gestionLibros = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDevolverLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_gestionCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_prestamoLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_buscarLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_gestionLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion Libros";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(363, 78);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(71, 13);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar Libros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prestamo Libros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cerrar Sesion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gestion Clientes";
            // 
            // buttonDevolverLibro
            // 
            this.buttonDevolverLibro.Image = global::BibliotecaFaber.Properties.Resources.book_devolver1;
            this.buttonDevolverLibro.Location = new System.Drawing.Point(217, 108);
            this.buttonDevolverLibro.Name = "buttonDevolverLibro";
            this.buttonDevolverLibro.Size = new System.Drawing.Size(50, 51);
            this.buttonDevolverLibro.TabIndex = 11;
            this.buttonDevolverLibro.TabStop = false;
            this.buttonDevolverLibro.Click += new System.EventHandler(this.buttonDevolverLibro_Click);
            // 
            // boton_gestionCliente
            // 
            this.boton_gestionCliente.BackgroundImage = global::BibliotecaFaber.Properties.Resources.User_32;
            this.boton_gestionCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_gestionCliente.Location = new System.Drawing.Point(59, 109);
            this.boton_gestionCliente.Name = "boton_gestionCliente";
            this.boton_gestionCliente.Size = new System.Drawing.Size(50, 50);
            this.boton_gestionCliente.TabIndex = 9;
            this.boton_gestionCliente.TabStop = false;
            this.boton_gestionCliente.Click += new System.EventHandler(this.gestionClientes_click);
            // 
            // boton_logout
            // 
            this.boton_logout.BackgroundImage = global::BibliotecaFaber.Properties.Resources.Window_App_List_Close_32;
            this.boton_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_logout.Location = new System.Drawing.Point(373, 109);
            this.boton_logout.Name = "boton_logout";
            this.boton_logout.Size = new System.Drawing.Size(50, 50);
            this.boton_logout.TabIndex = 7;
            this.boton_logout.TabStop = false;
            this.boton_logout.Click += new System.EventHandler(this.logout_click);
            // 
            // boton_prestamoLibros
            // 
            this.boton_prestamoLibros.BackgroundImage = global::BibliotecaFaber.Properties.Resources.Book_Bookmarks_32;
            this.boton_prestamoLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_prestamoLibros.Location = new System.Drawing.Point(217, 25);
            this.boton_prestamoLibros.Name = "boton_prestamoLibros";
            this.boton_prestamoLibros.Size = new System.Drawing.Size(50, 50);
            this.boton_prestamoLibros.TabIndex = 5;
            this.boton_prestamoLibros.TabStop = false;
            this.boton_prestamoLibros.Click += new System.EventHandler(this.prestamoLibros_click);
            // 
            // boton_buscarLibros
            // 
            this.boton_buscarLibros.BackgroundImage = global::BibliotecaFaber.Properties.Resources.Book_Search_32__1_;
            this.boton_buscarLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_buscarLibros.Location = new System.Drawing.Point(373, 25);
            this.boton_buscarLibros.Name = "boton_buscarLibros";
            this.boton_buscarLibros.Size = new System.Drawing.Size(50, 50);
            this.boton_buscarLibros.TabIndex = 3;
            this.boton_buscarLibros.TabStop = false;
            this.boton_buscarLibros.Click += new System.EventHandler(this.buscarLibros_click);
            // 
            // boton_gestionLibros
            // 
            this.boton_gestionLibros.BackgroundImage = global::BibliotecaFaber.Properties.Resources.Book_32;
            this.boton_gestionLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_gestionLibros.Location = new System.Drawing.Point(59, 25);
            this.boton_gestionLibros.Name = "boton_gestionLibros";
            this.boton_gestionLibros.Size = new System.Drawing.Size(50, 50);
            this.boton_gestionLibros.TabIndex = 1;
            this.boton_gestionLibros.TabStop = false;
            this.boton_gestionLibros.Click += new System.EventHandler(this.gestionLibros_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Devolver Libros";
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 190);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDevolverLibro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boton_gestionCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boton_logout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton_prestamoLibros);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.boton_buscarLibros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_gestionLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuInicial_FormClosed);
            this.Load += new System.EventHandler(this.MenuInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonDevolverLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_gestionCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_prestamoLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_buscarLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_gestionLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox boton_gestionLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox boton_buscarLibros;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.PictureBox boton_prestamoLibros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox boton_logout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox boton_gestionCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox buttonDevolverLibro;
        private System.Windows.Forms.Label label2;
    }
}
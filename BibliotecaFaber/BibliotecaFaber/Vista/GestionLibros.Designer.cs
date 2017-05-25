namespace BibliotecaFaber.Vista {
    partial class GestionLibros {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionLibros));
            this.tblLibros = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblUb = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.chkPrestamo = new System.Windows.Forms.CheckBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tablaEstante = new System.Windows.Forms.PictureBox();
            this.picModificar = new System.Windows.Forms.PictureBox();
            this.picEliminar = new System.Windows.Forms.PictureBox();
            this.picAgregar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEstante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLibros
            // 
            this.tblLibros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLibros.Location = new System.Drawing.Point(12, 12);
            this.tblLibros.MultiSelect = false;
            this.tblLibros.Name = "tblLibros";
            this.tblLibros.ReadOnly = true;
            this.tblLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblLibros.ShowEditingIcon = false;
            this.tblLibros.Size = new System.Drawing.Size(660, 259);
            this.tblLibros.TabIndex = 0;
            this.tblLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblLibros_CellContentClick);
            this.tblLibros.SelectionChanged += new System.EventHandler(this.tblLibros_SelectionChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 277);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(12, 303);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(12, 329);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(47, 13);
            this.lblEditorial.TabIndex = 3;
            this.lblEditorial.Text = "Editorial:";
            // 
            // lblUb
            // 
            this.lblUb.AutoSize = true;
            this.lblUb.Location = new System.Drawing.Point(12, 398);
            this.lblUb.Name = "lblUb";
            this.lblUb.Size = new System.Drawing.Size(58, 13);
            this.lblUb.TabIndex = 4;
            this.lblUb.Text = "Ubicación:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 274);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(325, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(65, 300);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(325, 20);
            this.txtAutor.TabIndex = 7;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(65, 326);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(325, 20);
            this.txtEditorial.TabIndex = 8;
            // 
            // chkPrestamo
            // 
            this.chkPrestamo.AutoSize = true;
            this.chkPrestamo.Enabled = false;
            this.chkPrestamo.Location = new System.Drawing.Point(396, 354);
            this.chkPrestamo.Name = "chkPrestamo";
            this.chkPrestamo.Size = new System.Drawing.Size(86, 17);
            this.chkPrestamo.TabIndex = 9;
            this.chkPrestamo.Text = "En Prestamo";
            this.chkPrestamo.UseVisualStyleBackColor = true;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(396, 395);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(37, 20);
            this.txtUbicacion.TabIndex = 16;
            this.txtUbicacion.TextChanged += new System.EventHandler(this.txtUbicacion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(65, 352);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(325, 20);
            this.txtCodigo.TabIndex = 18;
            // 
            // tablaEstante
            // 
            this.tablaEstante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tablaEstante.Image = global::BibliotecaFaber.Properties.Resources.error_tabla;
            this.tablaEstante.Location = new System.Drawing.Point(65, 395);
            this.tablaEstante.Name = "tablaEstante";
            this.tablaEstante.Size = new System.Drawing.Size(325, 71);
            this.tablaEstante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tablaEstante.TabIndex = 15;
            this.tablaEstante.TabStop = false;
            // 
            // picModificar
            // 
            this.picModificar.BackgroundImage = global::BibliotecaFaber.Properties.Resources.Pencil_32;
            this.picModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picModificar.Location = new System.Drawing.Point(510, 342);
            this.picModificar.Name = "picModificar";
            this.picModificar.Size = new System.Drawing.Size(50, 50);
            this.picModificar.TabIndex = 14;
            this.picModificar.TabStop = false;
            this.picModificar.Click += new System.EventHandler(this.picModificar_Click);
            // 
            // picEliminar
            // 
            this.picEliminar.BackgroundImage = global::BibliotecaFaber.Properties.Resources.Book_Close_32;
            this.picEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picEliminar.Location = new System.Drawing.Point(566, 342);
            this.picEliminar.Name = "picEliminar";
            this.picEliminar.Size = new System.Drawing.Size(50, 50);
            this.picEliminar.TabIndex = 13;
            this.picEliminar.TabStop = false;
            // 
            // picAgregar
            // 
            this.picAgregar.BackgroundImage = global::BibliotecaFaber.Properties.Resources.Book_Add_32;
            this.picAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picAgregar.Location = new System.Drawing.Point(622, 342);
            this.picAgregar.Name = "picAgregar";
            this.picAgregar.Size = new System.Drawing.Size(50, 50);
            this.picAgregar.TabIndex = 12;
            this.picAgregar.TabStop = false;
            this.picAgregar.Click += new System.EventHandler(this.picAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(623, 398);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.boton_volver);
            // 
            // GestionLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 478);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.tablaEstante);
            this.Controls.Add(this.picModificar);
            this.Controls.Add(this.picEliminar);
            this.Controls.Add(this.picAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkPrestamo);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblUb);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tblLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Libros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionLibros_FormClosed);
            this.Load += new System.EventHandler(this.GestionLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEstante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblLibros;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblUb;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.CheckBox chkPrestamo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picModificar;
        private System.Windows.Forms.PictureBox picEliminar;
        private System.Windows.Forms.PictureBox picAgregar;
        private System.Windows.Forms.PictureBox tablaEstante;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}
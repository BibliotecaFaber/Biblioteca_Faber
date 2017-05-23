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
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLibros
            // 
            this.tblLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLibros.Location = new System.Drawing.Point(12, 12);
            this.tblLibros.Name = "tblLibros";
            this.tblLibros.Size = new System.Drawing.Size(660, 259);
            this.tblLibros.TabIndex = 0;
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
            this.lblUb.Location = new System.Drawing.Point(12, 364);
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
            this.chkPrestamo.Location = new System.Drawing.Point(447, 277);
            this.chkPrestamo.Name = "chkPrestamo";
            this.chkPrestamo.Size = new System.Drawing.Size(86, 17);
            this.chkPrestamo.TabIndex = 9;
            this.chkPrestamo.Text = "En Prestamo";
            this.chkPrestamo.UseVisualStyleBackColor = true;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(76, 364);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(31, 13);
            this.lblUbicacion.TabIndex = 10;
            this.lblUbicacion.Text = "????";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GestionLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.chkPrestamo);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblUb);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tblLibros);
            this.Name = "GestionLibros";
            this.Text = "GestionLibros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionLibros_FormClosed);
            this.Load += new System.EventHandler(this.GestionLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblLibros)).EndInit();
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
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace BibliotecaFaber {
    partial class BuscarLibros {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarLibros));
            this.buscarButton = new System.Windows.Forms.Button();
            this.tablaLibros = new System.Windows.Forms.DataGridView();
            this.nombrelibroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.PictureBox();
            this.imgEstante = new System.Windows.Forms.PictureBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstante)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(459, 11);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(73, 22);
            this.buscarButton.TabIndex = 0;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarClick);
            // 
            // tablaLibros
            // 
            this.tablaLibros.AllowUserToAddRows = false;
            this.tablaLibros.AllowUserToDeleteRows = false;
            this.tablaLibros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLibros.Location = new System.Drawing.Point(12, 49);
            this.tablaLibros.MultiSelect = false;
            this.tablaLibros.Name = "tablaLibros";
            this.tablaLibros.ReadOnly = true;
            this.tablaLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaLibros.Size = new System.Drawing.Size(541, 229);
            this.tablaLibros.TabIndex = 1;
            this.tablaLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaLibros_CellContentClick);
            this.tablaLibros.SelectionChanged += new System.EventHandler(this.tablaLibros_SelectionChanged);
            // 
            // nombrelibroTextBox
            // 
            this.nombrelibroTextBox.Location = new System.Drawing.Point(125, 11);
            this.nombrelibroTextBox.Name = "nombrelibroTextBox";
            this.nombrelibroTextBox.Size = new System.Drawing.Size(262, 20);
            this.nombrelibroTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Libro";
            // 
            // botonVolver
            // 
            this.botonVolver.Image = global::BibliotecaFaber.Properties.Resources.Volver;
            this.botonVolver.Location = new System.Drawing.Point(260, 394);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(45, 48);
            this.botonVolver.TabIndex = 4;
            this.botonVolver.TabStop = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Clicked);
            // 
            // imgEstante
            // 
            this.imgEstante.Location = new System.Drawing.Point(165, 293);
            this.imgEstante.Name = "imgEstante";
            this.imgEstante.Size = new System.Drawing.Size(257, 83);
            this.imgEstante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEstante.TabIndex = 5;
            this.imgEstante.TabStop = false;
            this.imgEstante.Click += new System.EventHandler(this.imgEstante_Click);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(36, 293);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(123, 13);
            this.lblUbicacion.TabIndex = 6;
            this.lblUbicacion.Text = "Ubicación en el Estante:";
            // 
            // BuscarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 454);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.imgEstante);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombrelibroTextBox);
            this.Controls.Add(this.tablaLibros);
            this.Controls.Add(this.buscarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de Libros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.volverMenu);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.DataGridView tablaLibros;
        private System.Windows.Forms.TextBox nombrelibroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox botonVolver;
        private System.Windows.Forms.PictureBox imgEstante;
        private System.Windows.Forms.Label lblUbicacion;
    }
}


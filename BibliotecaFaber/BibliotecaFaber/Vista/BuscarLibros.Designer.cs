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
            this.buscarButton = new System.Windows.Forms.Button();
            this.tablaLibros = new System.Windows.Forms.DataGridView();
            this.nombrelibroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonVolver)).BeginInit();
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
            this.botonVolver.Location = new System.Drawing.Point(257, 284);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(45, 48);
            this.botonVolver.TabIndex = 4;
            this.botonVolver.TabStop = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Clicked);
            // 
            // BuscarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 334);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombrelibroTextBox);
            this.Controls.Add(this.tablaLibros);
            this.Controls.Add(this.buscarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de Libros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.volverMenu);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.DataGridView tablaLibros;
        private System.Windows.Forms.TextBox nombrelibroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox botonVolver;
    }
}


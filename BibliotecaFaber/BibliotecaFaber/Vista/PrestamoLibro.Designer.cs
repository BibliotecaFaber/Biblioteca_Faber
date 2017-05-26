namespace BibliotecaFaber.Vista {
    partial class PrestamoLibro {
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
            this.runTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.tablaLibros = new System.Windows.Forms.DataGridView();
            this.tablaLibrosParaPrestar = new System.Windows.Forms.DataGridView();
            this.buttonRealizarPrestamo = new System.Windows.Forms.PictureBox();
            this.buttonPrestar = new System.Windows.Forms.PictureBox();
            this.buttonNoPrestar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLibrosDisponibles = new System.Windows.Forms.Label();
            this.labelLibroAPrestar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibrosParaPrestar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRealizarPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrestar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoPrestar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // runTextBox
            // 
            this.runTextBox.Location = new System.Drawing.Point(155, 20);
            this.runTextBox.Name = "runTextBox";
            this.runTextBox.Size = new System.Drawing.Size(162, 20);
            this.runTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RUN del Cliente";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(355, 17);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(71, 25);
            this.buttonConfirmar.TabIndex = 4;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Clicked);
            // 
            // tablaLibros
            // 
            this.tablaLibros.AllowUserToAddRows = false;
            this.tablaLibros.AllowUserToDeleteRows = false;
            this.tablaLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLibros.Location = new System.Drawing.Point(26, 65);
            this.tablaLibros.MultiSelect = false;
            this.tablaLibros.Name = "tablaLibros";
            this.tablaLibros.ReadOnly = true;
            this.tablaLibros.Size = new System.Drawing.Size(448, 110);
            this.tablaLibros.TabIndex = 3;
            this.tablaLibros.SelectionChanged += new System.EventHandler(this.tablaLibros_SelectionChanged);
            // 
            // tablaLibrosParaPrestar
            // 
            this.tablaLibrosParaPrestar.AllowUserToAddRows = false;
            this.tablaLibrosParaPrestar.AllowUserToDeleteRows = false;
            this.tablaLibrosParaPrestar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaLibrosParaPrestar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.tablaLibrosParaPrestar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLibrosParaPrestar.Location = new System.Drawing.Point(26, 229);
            this.tablaLibrosParaPrestar.MultiSelect = false;
            this.tablaLibrosParaPrestar.Name = "tablaLibrosParaPrestar";
            this.tablaLibrosParaPrestar.ReadOnly = true;
            this.tablaLibrosParaPrestar.Size = new System.Drawing.Size(448, 104);
            this.tablaLibrosParaPrestar.TabIndex = 5;
            this.tablaLibrosParaPrestar.SelectionChanged += new System.EventHandler(this.tablaLibrosParaPrestar_SelectionChanged);
            // 
            // buttonRealizarPrestamo
            // 
            this.buttonRealizarPrestamo.Image = global::BibliotecaFaber.Properties.Resources.rsz_confirm;
            this.buttonRealizarPrestamo.Location = new System.Drawing.Point(151, 339);
            this.buttonRealizarPrestamo.Name = "buttonRealizarPrestamo";
            this.buttonRealizarPrestamo.Size = new System.Drawing.Size(49, 48);
            this.buttonRealizarPrestamo.TabIndex = 7;
            this.buttonRealizarPrestamo.TabStop = false;
            this.buttonRealizarPrestamo.Click += new System.EventHandler(this.buttonRealizarPrestamo_Click);
            // 
            // buttonPrestar
            // 
            this.buttonPrestar.Image = global::BibliotecaFaber.Properties.Resources.rsz_arrowdown;
            this.buttonPrestar.Location = new System.Drawing.Point(279, 181);
            this.buttonPrestar.Name = "buttonPrestar";
            this.buttonPrestar.Size = new System.Drawing.Size(44, 42);
            this.buttonPrestar.TabIndex = 6;
            this.buttonPrestar.TabStop = false;
            this.buttonPrestar.Click += new System.EventHandler(this.buttonPrestar_Click);
            // 
            // buttonNoPrestar
            // 
            this.buttonNoPrestar.Image = global::BibliotecaFaber.Properties.Resources.rsz_arrowup;
            this.buttonNoPrestar.Location = new System.Drawing.Point(155, 181);
            this.buttonNoPrestar.Name = "buttonNoPrestar";
            this.buttonNoPrestar.Size = new System.Drawing.Size(45, 42);
            this.buttonNoPrestar.TabIndex = 0;
            this.buttonNoPrestar.TabStop = false;
            this.buttonNoPrestar.Click += new System.EventHandler(this.buttonNoPrestar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BibliotecaFaber.Properties.Resources.Volver;
            this.pictureBox1.Location = new System.Drawing.Point(279, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.volverMenu);
            // 
            // labelLibrosDisponibles
            // 
            this.labelLibrosDisponibles.AutoSize = true;
            this.labelLibrosDisponibles.Location = new System.Drawing.Point(23, 49);
            this.labelLibrosDisponibles.Name = "labelLibrosDisponibles";
            this.labelLibrosDisponibles.Size = new System.Drawing.Size(92, 13);
            this.labelLibrosDisponibles.TabIndex = 8;
            this.labelLibrosDisponibles.Text = "Libros Disponibles";
            // 
            // labelLibroAPrestar
            // 
            this.labelLibroAPrestar.AutoSize = true;
            this.labelLibroAPrestar.Location = new System.Drawing.Point(32, 212);
            this.labelLibroAPrestar.Name = "labelLibroAPrestar";
            this.labelLibroAPrestar.Size = new System.Drawing.Size(80, 13);
            this.labelLibroAPrestar.TabIndex = 9;
            this.labelLibroAPrestar.Text = "Libros a Prestar";
            // 
            // PrestamoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 396);
            this.Controls.Add(this.labelLibroAPrestar);
            this.Controls.Add(this.labelLibrosDisponibles);
            this.Controls.Add(this.buttonRealizarPrestamo);
            this.Controls.Add(this.buttonPrestar);
            this.Controls.Add(this.buttonNoPrestar);
            this.Controls.Add(this.tablaLibrosParaPrestar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.tablaLibros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrestamoLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamo de Libros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.prestamoLibro_CLOSED);
            this.Load += new System.EventHandler(this.PrestamoLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibrosParaPrestar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRealizarPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrestar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNoPrestar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox runTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.DataGridView tablaLibros;
        private System.Windows.Forms.DataGridView tablaLibrosParaPrestar;
        private System.Windows.Forms.PictureBox buttonNoPrestar;
        private System.Windows.Forms.PictureBox buttonPrestar;
        private System.Windows.Forms.PictureBox buttonRealizarPrestamo;
        private System.Windows.Forms.Label labelLibrosDisponibles;
        private System.Windows.Forms.Label labelLibroAPrestar;
    }
}
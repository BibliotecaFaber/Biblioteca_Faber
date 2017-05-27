namespace BibliotecaFaber.Vista {
    partial class DevolverLibros {
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
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolverLibros));
            this.label1 = new System.Windows.Forms.Label();
            this.runTextBox = new System.Windows.Forms.TextBox();
            this.tablaPrestamos = new System.Windows.Forms.DataGridView();
            this.buttonDevolverLibro = new System.Windows.Forms.PictureBox();
            this.buttonVolver = new System.Windows.Forms.PictureBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDevolverLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUN Cliente";
            // 
            // runTextBox
            // 
            this.runTextBox.Location = new System.Drawing.Point(207, 17);
            this.runTextBox.Name = "runTextBox";
            this.runTextBox.Size = new System.Drawing.Size(185, 20);
            this.runTextBox.TabIndex = 1;
            // 
            // tablaPrestamos
            // 
            this.tablaPrestamos.AllowUserToAddRows = false;
            this.tablaPrestamos.AllowUserToDeleteRows = false;
            this.tablaPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPrestamos.Location = new System.Drawing.Point(25, 60);
            this.tablaPrestamos.MultiSelect = false;
            this.tablaPrestamos.Name = "tablaPrestamos";
            this.tablaPrestamos.ReadOnly = true;
            this.tablaPrestamos.Size = new System.Drawing.Size(628, 151);
            this.tablaPrestamos.TabIndex = 2;
            this.tablaPrestamos.SelectionChanged += new System.EventHandler(this.tablaPrestamos_SelectionChanged);
            // 
            // buttonDevolverLibro
            // 
            this.buttonDevolverLibro.Image = global::BibliotecaFaber.Properties.Resources.rsz_confirm;
            this.buttonDevolverLibro.Location = new System.Drawing.Point(166, 217);
            this.buttonDevolverLibro.Name = "buttonDevolverLibro";
            this.buttonDevolverLibro.Size = new System.Drawing.Size(48, 46);
            this.buttonDevolverLibro.TabIndex = 3;
            this.buttonDevolverLibro.TabStop = false;
            this.buttonDevolverLibro.Click += new System.EventHandler(this.buttonDevolverLibro_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Image = global::BibliotecaFaber.Properties.Resources.Volver;
            this.buttonVolver.Location = new System.Drawing.Point(429, 217);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(43, 46);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.TabStop = false;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(416, 17);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(69, 24);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // DevolverLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 268);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonDevolverLibro);
            this.Controls.Add(this.tablaPrestamos);
            this.Controls.Add(this.runTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevolverLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolver Libros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DevolverLibros_FormClosed);
            this.Load += new System.EventHandler(this.DevolverLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDevolverLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox runTextBox;
        private System.Windows.Forms.DataGridView tablaPrestamos;
        private System.Windows.Forms.PictureBox buttonDevolverLibro;
        private System.Windows.Forms.PictureBox buttonVolver;
        private System.Windows.Forms.Button buttonBuscar;
    }
}
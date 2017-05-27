namespace BibliotecaFaber.Vista {
    partial class GestionClientes {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClientes));
            this.tblClientes = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.picModificar = new System.Windows.Forms.PictureBox();
            this.picEliminar = new System.Windows.Forms.PictureBox();
            this.picAddUsr = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.rutTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.picVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUsr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // tblClientes
            // 
            this.tblClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tblClientes.Location = new System.Drawing.Point(12, 12);
            this.tblClientes.MultiSelect = false;
            this.tblClientes.Name = "tblClientes";
            this.tblClientes.ReadOnly = true;
            this.tblClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblClientes.ShowEditingIcon = false;
            this.tblClientes.Size = new System.Drawing.Size(684, 299);
            this.tblClientes.TabIndex = 0;
            this.tblClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblClientes_CellContentClick);
            this.tblClientes.SelectionChanged += new System.EventHandler(this.tblClientes_SelectionChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 332);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(12, 358);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(27, 13);
            this.lblRut.TabIndex = 2;
            this.lblRut.Text = "Rut:";
            // 
            // picModificar
            // 
            this.picModificar.BackgroundImage = global::BibliotecaFaber.Properties.Resources.Pencil_32;
            this.picModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picModificar.Location = new System.Drawing.Point(502, 332);
            this.picModificar.Name = "picModificar";
            this.picModificar.Size = new System.Drawing.Size(50, 50);
            this.picModificar.TabIndex = 5;
            this.picModificar.TabStop = false;
            this.picModificar.Click += new System.EventHandler(this.picModificar_Click);
            // 
            // picEliminar
            // 
            this.picEliminar.BackgroundImage = global::BibliotecaFaber.Properties.Resources.User_Close_32;
            this.picEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picEliminar.Location = new System.Drawing.Point(571, 332);
            this.picEliminar.Name = "picEliminar";
            this.picEliminar.Size = new System.Drawing.Size(50, 50);
            this.picEliminar.TabIndex = 4;
            this.picEliminar.TabStop = false;
            this.picEliminar.Click += new System.EventHandler(this.picEliminar_Click);
            // 
            // picAddUsr
            // 
            this.picAddUsr.BackgroundImage = global::BibliotecaFaber.Properties.Resources.User_Add_32;
            this.picAddUsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picAddUsr.Location = new System.Drawing.Point(636, 332);
            this.picAddUsr.Name = "picAddUsr";
            this.picAddUsr.Size = new System.Drawing.Size(50, 50);
            this.picAddUsr.TabIndex = 3;
            this.picAddUsr.TabStop = false;
            this.picAddUsr.Click += new System.EventHandler(this.agregarClienteDB);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(65, 329);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(411, 20);
            this.nombreTextBox.TabIndex = 9;
            // 
            // rutTextBox
            // 
            this.rutTextBox.Location = new System.Drawing.Point(65, 355);
            this.rutTextBox.Name = "rutTextBox";
            this.rutTextBox.Size = new System.Drawing.Size(191, 20);
            this.rutTextBox.TabIndex = 10;
            // 
            // edadTextBox
            // 
            this.edadTextBox.Location = new System.Drawing.Point(303, 355);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(173, 20);
            this.edadTextBox.TabIndex = 11;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(65, 384);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(191, 20);
            this.telefonoTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(303, 384);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(173, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // picVolver
            // 
            this.picVolver.Image = ((System.Drawing.Image)(resources.GetObject("picVolver.Image")));
            this.picVolver.Location = new System.Drawing.Point(636, 390);
            this.picVolver.Name = "picVolver";
            this.picVolver.Size = new System.Drawing.Size(50, 50);
            this.picVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picVolver.TabIndex = 14;
            this.picVolver.TabStop = false;
            this.picVolver.Click += new System.EventHandler(this.volverMenu);
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 452);
            this.Controls.Add(this.picVolver);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(this.rutTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picModificar);
            this.Controls.Add(this.picEliminar);
            this.Controls.Add(this.picAddUsr);
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tblClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gestionCliente_closed);
            this.Load += new System.EventHandler(this.GestionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUsr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblClientes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.PictureBox picAddUsr;
        private System.Windows.Forms.PictureBox picEliminar;
        private System.Windows.Forms.PictureBox picModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox rutTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox picVolver;
    }
}
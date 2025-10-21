namespace Laboratorio14
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.tsbNuevo = new System.Windows.Forms.Button();
            this.tsbGuardar = new System.Windows.Forms.Button();
            this.tsbCancelar = new System.Windows.Forms.Button();
            this.tsbEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tstId = new System.Windows.Forms.TextBox();
            this.tsbBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.BackColor = System.Drawing.SystemColors.Window;
            this.tsbNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.BackgroundImage")));
            this.tsbNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbNuevo.Location = new System.Drawing.Point(12, 12);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(36, 34);
            this.tsbNuevo.TabIndex = 0;
            this.tsbNuevo.UseVisualStyleBackColor = false;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.BackColor = System.Drawing.SystemColors.Window;
            this.tsbGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.BackgroundImage")));
            this.tsbGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbGuardar.Location = new System.Drawing.Point(54, 12);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(36, 34);
            this.tsbGuardar.TabIndex = 1;
            this.tsbGuardar.UseVisualStyleBackColor = false;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.tsbCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.BackgroundImage")));
            this.tsbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbCancelar.Location = new System.Drawing.Point(96, 12);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(36, 34);
            this.tsbCancelar.TabIndex = 2;
            this.tsbCancelar.UseVisualStyleBackColor = false;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.tsbEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.BackgroundImage")));
            this.tsbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbEliminar.Location = new System.Drawing.Point(138, 12);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(36, 34);
            this.tsbEliminar.TabIndex = 3;
            this.tsbEliminar.UseVisualStyleBackColor = false;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por id:";
            // 
            // tstId
            // 
            this.tstId.Location = new System.Drawing.Point(268, 20);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(100, 20);
            this.tstId.TabIndex = 5;
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.tsbBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.BackgroundImage")));
            this.tsbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbBuscar.Location = new System.Drawing.Point(374, 12);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(36, 34);
            this.tsbBuscar.TabIndex = 6;
            this.tsbBuscar.UseVisualStyleBackColor = false;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 107);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(78, 20);
            this.txtId.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(12, 184);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(485, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(155, 184);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(120, 20);
            this.txtStock.TabIndex = 14;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnSalir.Location = new System.Drawing.Point(15, 229);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 33);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 275);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsbBuscar);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsbEliminar);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbGuardar);
            this.Controls.Add(this.tsbNuevo);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tsbNuevo;
        private System.Windows.Forms.Button tsbGuardar;
        private System.Windows.Forms.Button tsbCancelar;
        private System.Windows.Forms.Button tsbEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tstId;
        private System.Windows.Forms.Button tsbBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnSalir;
    }
}


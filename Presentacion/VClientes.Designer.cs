namespace Presentacion
{
    partial class VClientes
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
            this.components = new System.ComponentModel.Container();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.CKBEstado = new System.Windows.Forms.CheckBox();
            this.LblFechaIngreso = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.Lbapellidos = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombres = new System.Windows.Forms.Label();
            this.TxtClienteId = new System.Windows.Forms.TextBox();
            this.LblClienteId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.TxtFechaIngreso = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTNLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVClientes
            // 
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Location = new System.Drawing.Point(12, 343);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.Size = new System.Drawing.Size(776, 206);
            this.DGVClientes.TabIndex = 30;
            this.DGVClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClientes_CellDoubleClick);
            // 
            // CKBEstado
            // 
            this.CKBEstado.AutoSize = true;
            this.CKBEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKBEstado.Location = new System.Drawing.Point(371, 201);
            this.CKBEstado.Name = "CKBEstado";
            this.CKBEstado.Size = new System.Drawing.Size(75, 20);
            this.CKBEstado.TabIndex = 29;
            this.CKBEstado.Text = "Estado";
            this.CKBEstado.UseVisualStyleBackColor = true;
            // 
            // LblFechaIngreso
            // 
            this.LblFechaIngreso.AutoSize = true;
            this.LblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaIngreso.Location = new System.Drawing.Point(23, 201);
            this.LblFechaIngreso.Name = "LblFechaIngreso";
            this.LblFechaIngreso.Size = new System.Drawing.Size(132, 16);
            this.LblFechaIngreso.TabIndex = 23;
            this.LblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(109, 161);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(194, 22);
            this.TxtApellidos.TabIndex = 22;
            // 
            // Lbapellidos
            // 
            this.Lbapellidos.AutoSize = true;
            this.Lbapellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbapellidos.Location = new System.Drawing.Point(23, 164);
            this.Lbapellidos.Name = "Lbapellidos";
            this.Lbapellidos.Size = new System.Drawing.Size(77, 16);
            this.Lbapellidos.TabIndex = 21;
            this.Lbapellidos.Text = "Apellidos:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(109, 126);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(194, 22);
            this.TxtNombre.TabIndex = 20;
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(23, 129);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(74, 16);
            this.LblNombres.TabIndex = 19;
            this.LblNombres.Text = "Nombres:";
            // 
            // TxtClienteId
            // 
            this.TxtClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClienteId.Location = new System.Drawing.Point(109, 94);
            this.TxtClienteId.Name = "TxtClienteId";
            this.TxtClienteId.Size = new System.Drawing.Size(170, 22);
            this.TxtClienteId.TabIndex = 18;
            // 
            // LblClienteId
            // 
            this.LblClienteId.AutoSize = true;
            this.LblClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClienteId.Location = new System.Drawing.Point(23, 97);
            this.LblClienteId.Name = "LblClienteId";
            this.LblClienteId.Size = new System.Drawing.Size(72, 16);
            this.LblClienteId.TabIndex = 17;
            this.LblClienteId.Text = "Cliente Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Menu de Clientes";
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardar.Location = new System.Drawing.Point(37, 254);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(98, 33);
            this.BTNGuardar.TabIndex = 32;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEliminar.Location = new System.Drawing.Point(162, 253);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(101, 34);
            this.BTNEliminar.TabIndex = 33;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // TxtFechaIngreso
            // 
            this.TxtFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaIngreso.Location = new System.Drawing.Point(161, 198);
            this.TxtFechaIngreso.Name = "TxtFechaIngreso";
            this.TxtFechaIngreso.Size = new System.Drawing.Size(194, 22);
            this.TxtFechaIngreso.TabIndex = 34;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpiar.Location = new System.Drawing.Point(276, 253);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(101, 34);
            this.BTNLimpiar.TabIndex = 35;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // VClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.TxtFechaIngreso);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.DGVClientes);
            this.Controls.Add(this.CKBEstado);
            this.Controls.Add(this.LblFechaIngreso);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.Lbapellidos);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.TxtClienteId);
            this.Controls.Add(this.LblClienteId);
            this.Controls.Add(this.label1);
            this.Name = "VClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VClientes";
            this.Load += new System.EventHandler(this.VClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.CheckBox CKBEstado;
        private System.Windows.Forms.Label LblFechaIngreso;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label Lbapellidos;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.TextBox TxtClienteId;
        private System.Windows.Forms.Label LblClienteId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.TextBox TxtFechaIngreso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BTNLimpiar;
    }
}
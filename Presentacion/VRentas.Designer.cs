namespace Presentacion
{
    partial class VRentas
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
            this.DGVRentas = new System.Windows.Forms.DataGridView();
            this.TxtPrecioRenta = new System.Windows.Forms.TextBox();
            this.LblPrecioRenta = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblExistencia = new System.Windows.Forms.Label();
            this.LblAutores = new System.Windows.Forms.Label();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtRentaId = new System.Windows.Forms.TextBox();
            this.LblPeliculaID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblInventario = new System.Windows.Forms.Label();
            this.TxtFechaRenta = new System.Windows.Forms.TextBox();
            this.TxtFechaRetorno = new System.Windows.Forms.TextBox();
            this.CBPeliculaId = new System.Windows.Forms.ComboBox();
            this.CBCLienteId = new System.Windows.Forms.ComboBox();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtInventario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRentas
            // 
            this.DGVRentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRentas.Location = new System.Drawing.Point(12, 343);
            this.DGVRentas.Name = "DGVRentas";
            this.DGVRentas.Size = new System.Drawing.Size(776, 206);
            this.DGVRentas.TabIndex = 30;
            this.DGVRentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRentas_CellDoubleClick_1);
            // 
            // TxtPrecioRenta
            // 
            this.TxtPrecioRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioRenta.Location = new System.Drawing.Point(146, 311);
            this.TxtPrecioRenta.Name = "TxtPrecioRenta";
            this.TxtPrecioRenta.Size = new System.Drawing.Size(170, 22);
            this.TxtPrecioRenta.TabIndex = 28;
            // 
            // LblPrecioRenta
            // 
            this.LblPrecioRenta.AutoSize = true;
            this.LblPrecioRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioRenta.Location = new System.Drawing.Point(21, 317);
            this.LblPrecioRenta.Name = "LblPrecioRenta";
            this.LblPrecioRenta.Size = new System.Drawing.Size(119, 16);
            this.LblPrecioRenta.TabIndex = 27;
            this.LblPrecioRenta.Text = "Precio de Renta";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(109, 280);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(185, 22);
            this.TxtCantidad.TabIndex = 26;
            // 
            // LblExistencia
            // 
            this.LblExistencia.AutoSize = true;
            this.LblExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExistencia.Location = new System.Drawing.Point(21, 280);
            this.LblExistencia.Name = "LblExistencia";
            this.LblExistencia.Size = new System.Drawing.Size(69, 16);
            this.LblExistencia.TabIndex = 25;
            this.LblExistencia.Text = "Cantidad";
            // 
            // LblAutores
            // 
            this.LblAutores.AutoSize = true;
            this.LblAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutores.Location = new System.Drawing.Point(23, 201);
            this.LblAutores.Name = "LblAutores";
            this.LblAutores.Size = new System.Drawing.Size(95, 16);
            this.LblAutores.TabIndex = 23;
            this.LblAutores.Text = "Fecha Renta";
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenero.Location = new System.Drawing.Point(23, 164);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(76, 16);
            this.LblGenero.TabIndex = 21;
            this.LblGenero.Text = "PeliculaId";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(23, 129);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(72, 16);
            this.LblNombre.TabIndex = 19;
            this.LblNombre.Text = "Cliente Id";
            // 
            // TxtRentaId
            // 
            this.TxtRentaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRentaId.Location = new System.Drawing.Point(109, 94);
            this.TxtRentaId.Name = "TxtRentaId";
            this.TxtRentaId.Size = new System.Drawing.Size(170, 22);
            this.TxtRentaId.TabIndex = 18;
            // 
            // LblPeliculaID
            // 
            this.LblPeliculaID.AutoSize = true;
            this.LblPeliculaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeliculaID.Location = new System.Drawing.Point(23, 97);
            this.LblPeliculaID.Name = "LblPeliculaID";
            this.LblPeliculaID.Size = new System.Drawing.Size(65, 16);
            this.LblPeliculaID.TabIndex = 17;
            this.LblPeliculaID.Text = "Renta Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Menu de Rentas de peliculas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fecha Retorno";
            // 
            // LblInventario
            // 
            this.LblInventario.AutoSize = true;
            this.LblInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInventario.Location = new System.Drawing.Point(361, 286);
            this.LblInventario.Name = "LblInventario";
            this.LblInventario.Size = new System.Drawing.Size(106, 16);
            this.LblInventario.TabIndex = 33;
            this.LblInventario.Text = "Total a Pagar:";
            // 
            // TxtFechaRenta
            // 
            this.TxtFechaRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaRenta.Location = new System.Drawing.Point(124, 201);
            this.TxtFechaRenta.Name = "TxtFechaRenta";
            this.TxtFechaRenta.Size = new System.Drawing.Size(170, 22);
            this.TxtFechaRenta.TabIndex = 35;
            // 
            // TxtFechaRetorno
            // 
            this.TxtFechaRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaRetorno.Location = new System.Drawing.Point(138, 239);
            this.TxtFechaRetorno.Name = "TxtFechaRetorno";
            this.TxtFechaRetorno.Size = new System.Drawing.Size(170, 22);
            this.TxtFechaRetorno.TabIndex = 36;
            // 
            // CBPeliculaId
            // 
            this.CBPeliculaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPeliculaId.FormattingEnabled = true;
            this.CBPeliculaId.Location = new System.Drawing.Point(109, 159);
            this.CBPeliculaId.Name = "CBPeliculaId";
            this.CBPeliculaId.Size = new System.Drawing.Size(185, 26);
            this.CBPeliculaId.TabIndex = 37;
            this.CBPeliculaId.SelectedIndexChanged += new System.EventHandler(this.CBPeliculaId_SelectedIndexChanged);
            this.CBPeliculaId.SelectedValueChanged += new System.EventHandler(this.CBPeliculaId_SelectedValueChanged);
            // 
            // CBCLienteId
            // 
            this.CBCLienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCLienteId.FormattingEnabled = true;
            this.CBCLienteId.Location = new System.Drawing.Point(109, 127);
            this.CBCLienteId.Name = "CBCLienteId";
            this.CBCLienteId.Size = new System.Drawing.Size(185, 26);
            this.CBCLienteId.TabIndex = 38;
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardar.Location = new System.Drawing.Point(377, 106);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTNGuardar.TabIndex = 39;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEliminar.Location = new System.Drawing.Point(377, 135);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 40;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TxtInventario
            // 
            this.TxtInventario.Location = new System.Drawing.Point(473, 286);
            this.TxtInventario.Name = "TxtInventario";
            this.TxtInventario.Size = new System.Drawing.Size(100, 20);
            this.TxtInventario.TabIndex = 41;
            // 
            // VRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.TxtInventario);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.CBCLienteId);
            this.Controls.Add(this.CBPeliculaId);
            this.Controls.Add(this.TxtFechaRetorno);
            this.Controls.Add(this.TxtFechaRenta);
            this.Controls.Add(this.LblInventario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVRentas);
            this.Controls.Add(this.TxtPrecioRenta);
            this.Controls.Add(this.LblPrecioRenta);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.LblExistencia);
            this.Controls.Add(this.LblAutores);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtRentaId);
            this.Controls.Add(this.LblPeliculaID);
            this.Controls.Add(this.label1);
            this.Name = "VRentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.VRentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRentas;
        private System.Windows.Forms.TextBox TxtPrecioRenta;
        private System.Windows.Forms.Label LblPrecioRenta;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblExistencia;
        private System.Windows.Forms.Label LblAutores;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtRentaId;
        private System.Windows.Forms.Label LblPeliculaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblInventario;
        private System.Windows.Forms.TextBox TxtFechaRenta;
        private System.Windows.Forms.TextBox TxtFechaRetorno;
        private System.Windows.Forms.ComboBox CBPeliculaId;
        private System.Windows.Forms.ComboBox CBCLienteId;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TxtInventario;
    }
}
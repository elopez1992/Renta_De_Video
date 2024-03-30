namespace Presentacion
{
    partial class VPeliculas
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblPeliculaID = new System.Windows.Forms.Label();
            this.TxtPeliculaId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.TxtAutores = new System.Windows.Forms.TextBox();
            this.LblAutores = new System.Windows.Forms.Label();
            this.TxtExistencia = new System.Windows.Forms.TextBox();
            this.LblExistencia = new System.Windows.Forms.Label();
            this.TxtPrecioRenta = new System.Windows.Forms.TextBox();
            this.LblPrecioRenta = new System.Windows.Forms.Label();
            this.CKBEstado = new System.Windows.Forms.CheckBox();
            this.DGVPeliculas = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu de Peliculas";
            // 
            // LblPeliculaID
            // 
            this.LblPeliculaID.AutoSize = true;
            this.LblPeliculaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeliculaID.Location = new System.Drawing.Point(23, 77);
            this.LblPeliculaID.Name = "LblPeliculaID";
            this.LblPeliculaID.Size = new System.Drawing.Size(80, 16);
            this.LblPeliculaID.TabIndex = 1;
            this.LblPeliculaID.Text = "Pelicula Id";
            // 
            // TxtPeliculaId
            // 
            this.TxtPeliculaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPeliculaId.Location = new System.Drawing.Point(109, 74);
            this.TxtPeliculaId.Name = "TxtPeliculaId";
            this.TxtPeliculaId.Size = new System.Drawing.Size(170, 22);
            this.TxtPeliculaId.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(109, 106);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(170, 22);
            this.TxtNombre.TabIndex = 4;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(23, 109);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(62, 16);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtGenero
            // 
            this.TxtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGenero.Location = new System.Drawing.Point(109, 141);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(170, 22);
            this.TxtGenero.TabIndex = 6;
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenero.Location = new System.Drawing.Point(23, 144);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(58, 16);
            this.LblGenero.TabIndex = 5;
            this.LblGenero.Text = "Genero";
            // 
            // TxtAutores
            // 
            this.TxtAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAutores.Location = new System.Drawing.Point(109, 178);
            this.TxtAutores.Name = "TxtAutores";
            this.TxtAutores.Size = new System.Drawing.Size(170, 22);
            this.TxtAutores.TabIndex = 8;
            // 
            // LblAutores
            // 
            this.LblAutores.AutoSize = true;
            this.LblAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutores.Location = new System.Drawing.Point(23, 181);
            this.LblAutores.Name = "LblAutores";
            this.LblAutores.Size = new System.Drawing.Size(60, 16);
            this.LblAutores.TabIndex = 7;
            this.LblAutores.Text = "Autores";
            // 
            // TxtExistencia
            // 
            this.TxtExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExistencia.Location = new System.Drawing.Point(107, 217);
            this.TxtExistencia.Name = "TxtExistencia";
            this.TxtExistencia.Size = new System.Drawing.Size(170, 22);
            this.TxtExistencia.TabIndex = 10;
            // 
            // LblExistencia
            // 
            this.LblExistencia.AutoSize = true;
            this.LblExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExistencia.Location = new System.Drawing.Point(21, 220);
            this.LblExistencia.Name = "LblExistencia";
            this.LblExistencia.Size = new System.Drawing.Size(78, 16);
            this.LblExistencia.TabIndex = 9;
            this.LblExistencia.Text = "Existencia";
            // 
            // TxtPrecioRenta
            // 
            this.TxtPrecioRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioRenta.Location = new System.Drawing.Point(146, 251);
            this.TxtPrecioRenta.Name = "TxtPrecioRenta";
            this.TxtPrecioRenta.Size = new System.Drawing.Size(170, 22);
            this.TxtPrecioRenta.TabIndex = 12;
            // 
            // LblPrecioRenta
            // 
            this.LblPrecioRenta.AutoSize = true;
            this.LblPrecioRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioRenta.Location = new System.Drawing.Point(21, 257);
            this.LblPrecioRenta.Name = "LblPrecioRenta";
            this.LblPrecioRenta.Size = new System.Drawing.Size(119, 16);
            this.LblPrecioRenta.TabIndex = 11;
            this.LblPrecioRenta.Text = "Precio de Renta";
            // 
            // CKBEstado
            // 
            this.CKBEstado.AutoSize = true;
            this.CKBEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKBEstado.Location = new System.Drawing.Point(332, 256);
            this.CKBEstado.Name = "CKBEstado";
            this.CKBEstado.Size = new System.Drawing.Size(75, 20);
            this.CKBEstado.TabIndex = 14;
            this.CKBEstado.Text = "Estado";
            this.CKBEstado.UseVisualStyleBackColor = true;
            // 
            // DGVPeliculas
            // 
            this.DGVPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPeliculas.Location = new System.Drawing.Point(12, 323);
            this.DGVPeliculas.Name = "DGVPeliculas";
            this.DGVPeliculas.Size = new System.Drawing.Size(776, 206);
            this.DGVPeliculas.TabIndex = 15;
            this.DGVPeliculas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPeliculas_CellDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(109, 294);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTNGuardar.TabIndex = 16;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(202, 294);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 17;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Location = new System.Drawing.Point(283, 294);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNLimpiar.TabIndex = 18;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // VPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.DGVPeliculas);
            this.Controls.Add(this.CKBEstado);
            this.Controls.Add(this.TxtPrecioRenta);
            this.Controls.Add(this.LblPrecioRenta);
            this.Controls.Add(this.TxtExistencia);
            this.Controls.Add(this.LblExistencia);
            this.Controls.Add(this.TxtAutores);
            this.Controls.Add(this.LblAutores);
            this.Controls.Add(this.TxtGenero);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtPeliculaId);
            this.Controls.Add(this.LblPeliculaID);
            this.Controls.Add(this.label1);
            this.Name = "VPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPeliculas";
            this.Load += new System.EventHandler(this.VPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPeliculaID;
        private System.Windows.Forms.TextBox TxtPeliculaId;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.TextBox TxtAutores;
        private System.Windows.Forms.Label LblAutores;
        private System.Windows.Forms.TextBox TxtExistencia;
        private System.Windows.Forms.Label LblExistencia;
        private System.Windows.Forms.TextBox TxtPrecioRenta;
        private System.Windows.Forms.Label LblPrecioRenta;
        private System.Windows.Forms.CheckBox CKBEstado;
        private System.Windows.Forms.DataGridView DGVPeliculas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNLimpiar;
    }
}
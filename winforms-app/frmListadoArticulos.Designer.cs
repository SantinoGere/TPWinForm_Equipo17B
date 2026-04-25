namespace winforms_app
{
    partial class frmListadoArticulos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvArticulos;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.lblFiltradoRapido = new System.Windows.Forms.Label();
            this.txtFiltradoRapido = new System.Windows.Forms.TextBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lblMarcaFiltro = new System.Windows.Forms.Label();
            this.cboxMarcaFiltro = new System.Windows.Forms.ComboBox();
            this.lblCategoriaFiltro = new System.Windows.Forms.Label();
            this.cboxCategoriaFiltro = new System.Windows.Forms.ComboBox();
            this.lblPrecioFiltro = new System.Windows.Forms.Label();
            this.cboxPrecioFiltro = new System.Windows.Forms.ComboBox();
            this.nPrecioFiltro = new System.Windows.Forms.NumericUpDown();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrecioFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(13, 38);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(560, 263);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(13, 307);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(94, 307);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(175, 307);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(256, 307);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnVerDetalle.TabIndex = 7;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            // 
            // lblFiltradoRapido
            // 
            this.lblFiltradoRapido.AutoSize = true;
            this.lblFiltradoRapido.Location = new System.Drawing.Point(13, 13);
            this.lblFiltradoRapido.Name = "lblFiltradoRapido";
            this.lblFiltradoRapido.Size = new System.Drawing.Size(78, 13);
            this.lblFiltradoRapido.TabIndex = 8;
            this.lblFiltradoRapido.Text = "Filtrado Rapido";
            // 
            // txtFiltradoRapido
            // 
            this.txtFiltradoRapido.Location = new System.Drawing.Point(94, 10);
            this.txtFiltradoRapido.Name = "txtFiltradoRapido";
            this.txtFiltradoRapido.Size = new System.Drawing.Size(282, 20);
            this.txtFiltradoRapido.TabIndex = 9;
            this.txtFiltradoRapido.TextChanged += new System.EventHandler(this.txtFiltradoRapido_TextChanged);
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(601, 38);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(80, 13);
            this.lblFiltroAvanzado.TabIndex = 10;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado";
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(753, 33);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(62, 23);
            this.btnLimpiarFiltro.TabIndex = 11;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lblMarcaFiltro
            // 
            this.lblMarcaFiltro.AutoSize = true;
            this.lblMarcaFiltro.Location = new System.Drawing.Point(613, 71);
            this.lblMarcaFiltro.Name = "lblMarcaFiltro";
            this.lblMarcaFiltro.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaFiltro.TabIndex = 12;
            this.lblMarcaFiltro.Text = "Marca";
            // 
            // cboxMarcaFiltro
            // 
            this.cboxMarcaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarcaFiltro.FormattingEnabled = true;
            this.cboxMarcaFiltro.Location = new System.Drawing.Point(668, 68);
            this.cboxMarcaFiltro.Name = "cboxMarcaFiltro";
            this.cboxMarcaFiltro.Size = new System.Drawing.Size(147, 21);
            this.cboxMarcaFiltro.TabIndex = 13;
            // 
            // lblCategoriaFiltro
            // 
            this.lblCategoriaFiltro.AutoSize = true;
            this.lblCategoriaFiltro.Location = new System.Drawing.Point(601, 101);
            this.lblCategoriaFiltro.Name = "lblCategoriaFiltro";
            this.lblCategoriaFiltro.Size = new System.Drawing.Size(52, 13);
            this.lblCategoriaFiltro.TabIndex = 14;
            this.lblCategoriaFiltro.Text = "Categoria";
            // 
            // cboxCategoriaFiltro
            // 
            this.cboxCategoriaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoriaFiltro.FormattingEnabled = true;
            this.cboxCategoriaFiltro.Location = new System.Drawing.Point(668, 98);
            this.cboxCategoriaFiltro.Name = "cboxCategoriaFiltro";
            this.cboxCategoriaFiltro.Size = new System.Drawing.Size(147, 21);
            this.cboxCategoriaFiltro.TabIndex = 15;
            // 
            // lblPrecioFiltro
            // 
            this.lblPrecioFiltro.AutoSize = true;
            this.lblPrecioFiltro.Location = new System.Drawing.Point(613, 137);
            this.lblPrecioFiltro.Name = "lblPrecioFiltro";
            this.lblPrecioFiltro.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioFiltro.TabIndex = 16;
            this.lblPrecioFiltro.Text = "Precio";
            // 
            // cboxPrecioFiltro
            // 
            this.cboxPrecioFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPrecioFiltro.FormattingEnabled = true;
            this.cboxPrecioFiltro.Location = new System.Drawing.Point(668, 134);
            this.cboxPrecioFiltro.Name = "cboxPrecioFiltro";
            this.cboxPrecioFiltro.Size = new System.Drawing.Size(41, 21);
            this.cboxPrecioFiltro.TabIndex = 17;
            // 
            // nPrecioFiltro
            // 
            this.nPrecioFiltro.DecimalPlaces = 2;
            this.nPrecioFiltro.Location = new System.Drawing.Point(715, 135);
            this.nPrecioFiltro.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nPrecioFiltro.Name = "nPrecioFiltro";
            this.nPrecioFiltro.Size = new System.Drawing.Size(100, 20);
            this.nPrecioFiltro.TabIndex = 18;
            this.nPrecioFiltro.ThousandsSeparator = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(685, 33);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(62, 23);
            this.btnFiltrar.TabIndex = 19;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 363);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.nPrecioFiltro);
            this.Controls.Add(this.cboxPrecioFiltro);
            this.Controls.Add(this.lblPrecioFiltro);
            this.Controls.Add(this.cboxCategoriaFiltro);
            this.Controls.Add(this.lblCategoriaFiltro);
            this.Controls.Add(this.cboxMarcaFiltro);
            this.Controls.Add(this.lblMarcaFiltro);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.txtFiltradoRapido);
            this.Controls.Add(this.lblFiltradoRapido);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "frmListadoArticulos";
            this.Text = "Listado de Artículos";
            this.Load += new System.EventHandler(this.frmListadoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrecioFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Label lblFiltradoRapido;
        private System.Windows.Forms.TextBox txtFiltradoRapido;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lblMarcaFiltro;
        private System.Windows.Forms.ComboBox cboxMarcaFiltro;
        private System.Windows.Forms.Label lblCategoriaFiltro;
        private System.Windows.Forms.ComboBox cboxCategoriaFiltro;
        private System.Windows.Forms.Label lblPrecioFiltro;
        private System.Windows.Forms.ComboBox cboxPrecioFiltro;
        private System.Windows.Forms.NumericUpDown nPrecioFiltro;
        private System.Windows.Forms.Button btnFiltrar;
    }
}

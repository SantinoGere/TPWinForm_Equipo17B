namespace winforms_app
{
    partial class frmAltaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaArticulo));
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.btnAgregarUrl = new System.Windows.Forms.Button();
            this.lwUrlImagen = new System.Windows.Forms.ListView();
            this.btnAltaArticulo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFaltanteCodigoArticulo = new System.Windows.Forms.Label();
            this.lblNombreFaltante = new System.Windows.Forms.Label();
            this.btnBorrarSeleccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Location = new System.Drawing.Point(12, 38);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(96, 13);
            this.lblCodigoArticulo.TabIndex = 0;
            this.lblCodigoArticulo.Text = "Codigo de Articulo:";
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(114, 35);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(177, 20);
            this.txtCodigoArticulo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(61, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(68, 106);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // cboxMarca
            // 
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(114, 103);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(177, 21);
            this.cboxMarca.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(53, 138);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(114, 135);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(177, 21);
            this.cboxCategoria.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(42, 181);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(114, 181);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(177, 96);
            this.rtxtDescripcion.TabIndex = 4;
            this.rtxtDescripcion.Text = "";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(68, 297);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio:";
            // 
            // nPrecio
            // 
            this.nPrecio.DecimalPlaces = 3;
            this.nPrecio.Location = new System.Drawing.Point(114, 295);
            this.nPrecio.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nPrecio.Name = "nPrecio";
            this.nPrecio.Size = new System.Drawing.Size(120, 20);
            this.nPrecio.TabIndex = 5;
            this.nPrecio.ThousandsSeparator = true;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(31, 335);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(77, 13);
            this.lblUrlImagen.TabIndex = 12;
            this.lblUrlImagen.Text = "Urls Imagenes:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(115, 330);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(176, 20);
            this.txtUrlImagen.TabIndex = 6;
            // 
            // btnAgregarUrl
            // 
            this.btnAgregarUrl.Location = new System.Drawing.Point(297, 330);
            this.btnAgregarUrl.Name = "btnAgregarUrl";
            this.btnAgregarUrl.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarUrl.TabIndex = 7;
            this.btnAgregarUrl.Text = "Agregar";
            this.btnAgregarUrl.UseVisualStyleBackColor = true;
            this.btnAgregarUrl.Click += new System.EventHandler(this.btnAgregarUrl_Click);
            // 
            // lwUrlImagen
            // 
            this.lwUrlImagen.HideSelection = false;
            this.lwUrlImagen.Location = new System.Drawing.Point(115, 356);
            this.lwUrlImagen.Name = "lwUrlImagen";
            this.lwUrlImagen.Size = new System.Drawing.Size(176, 82);
            this.lwUrlImagen.TabIndex = 15;
            this.lwUrlImagen.UseCompatibleStateImageBehavior = false;
            this.lwUrlImagen.View = System.Windows.Forms.View.List;
            // 
            // btnAltaArticulo
            // 
            this.btnAltaArticulo.Location = new System.Drawing.Point(71, 446);
            this.btnAltaArticulo.Name = "btnAltaArticulo";
            this.btnAltaArticulo.Size = new System.Drawing.Size(85, 23);
            this.btnAltaArticulo.TabIndex = 8;
            this.btnAltaArticulo.Text = "Dar Alta";
            this.btnAltaArticulo.UseVisualStyleBackColor = true;
            this.btnAltaArticulo.Click += new System.EventHandler(this.btnAltaArticulo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(206, 446);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFaltanteCodigoArticulo
            // 
            this.lblFaltanteCodigoArticulo.AutoSize = true;
            this.lblFaltanteCodigoArticulo.Location = new System.Drawing.Point(298, 38);
            this.lblFaltanteCodigoArticulo.Name = "lblFaltanteCodigoArticulo";
            this.lblFaltanteCodigoArticulo.Size = new System.Drawing.Size(0, 13);
            this.lblFaltanteCodigoArticulo.TabIndex = 16;
            // 
            // lblNombreFaltante
            // 
            this.lblNombreFaltante.AutoSize = true;
            this.lblNombreFaltante.Location = new System.Drawing.Point(297, 77);
            this.lblNombreFaltante.Name = "lblNombreFaltante";
            this.lblNombreFaltante.Size = new System.Drawing.Size(0, 13);
            this.lblNombreFaltante.TabIndex = 17;
            // 
            // btnBorrarSeleccion
            // 
            this.btnBorrarSeleccion.Location = new System.Drawing.Point(297, 359);
            this.btnBorrarSeleccion.Name = "btnBorrarSeleccion";
            this.btnBorrarSeleccion.Size = new System.Drawing.Size(100, 23);
            this.btnBorrarSeleccion.TabIndex = 19;
            this.btnBorrarSeleccion.Text = "Borrar Seleccion";
            this.btnBorrarSeleccion.UseVisualStyleBackColor = true;
            this.btnBorrarSeleccion.Click += new System.EventHandler(this.button1_Click);
            //
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 483);
            this.Controls.Add(this.btnBorrarSeleccion);
            this.Controls.Add(this.lblNombreFaltante);
            this.Controls.Add(this.lblFaltanteCodigoArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAltaArticulo);
            this.Controls.Add(this.lwUrlImagen);
            this.Controls.Add(this.btnAgregarUrl);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.nPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.lblCodigoArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 522);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(415, 522);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nPrecio;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button btnAgregarUrl;
        private System.Windows.Forms.ListView lwUrlImagen;
        private System.Windows.Forms.Button btnAltaArticulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFaltanteCodigoArticulo;
        private System.Windows.Forms.Label lblNombreFaltante;
        private System.Windows.Forms.Button btnBorrarSeleccion;
    }
}

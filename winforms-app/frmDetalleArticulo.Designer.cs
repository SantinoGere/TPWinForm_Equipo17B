namespace winforms_app
{
    partial class frmDetalleArticulo
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
            this.pboxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTextoCodigo = new System.Windows.Forms.Label();
            this.lblTextoMarca = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTextoCategoria = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadImagenes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxImagenArticulo
            // 
            this.pboxImagenArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxImagenArticulo.Location = new System.Drawing.Point(12, 12);
            this.pboxImagenArticulo.Name = "pboxImagenArticulo";
            this.pboxImagenArticulo.Size = new System.Drawing.Size(250, 250);
            this.pboxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagenArticulo.TabIndex = 0;
            this.pboxImagenArticulo.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 306);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(15, 322);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.ReadOnly = true;
            this.rtxtDescripcion.Size = new System.Drawing.Size(444, 133);
            this.rtxtDescripcion.TabIndex = 2;
            this.rtxtDescripcion.Text = "";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(89, 268);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(38, 23);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(133, 268);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(38, 23);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(268, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 24);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Titulo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(279, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblTextoCodigo
            // 
            this.lblTextoCodigo.AutoSize = true;
            this.lblTextoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoCodigo.Location = new System.Drawing.Point(343, 53);
            this.lblTextoCodigo.Name = "lblTextoCodigo";
            this.lblTextoCodigo.Size = new System.Drawing.Size(79, 16);
            this.lblTextoCodigo.TabIndex = 7;
            this.lblTextoCodigo.Text = "placeholder";
            // 
            // lblTextoMarca
            // 
            this.lblTextoMarca.AutoSize = true;
            this.lblTextoMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoMarca.Location = new System.Drawing.Point(343, 86);
            this.lblTextoMarca.Name = "lblTextoMarca";
            this.lblTextoMarca.Size = new System.Drawing.Size(79, 16);
            this.lblTextoMarca.TabIndex = 9;
            this.lblTextoMarca.Text = "placeholder";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(285, 86);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 16);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca:";
            // 
            // lblTextoCategoria
            // 
            this.lblTextoCategoria.AutoSize = true;
            this.lblTextoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoCategoria.Location = new System.Drawing.Point(343, 118);
            this.lblTextoCategoria.Name = "lblTextoCategoria";
            this.lblTextoCategoria.Size = new System.Drawing.Size(79, 16);
            this.lblTextoCategoria.TabIndex = 11;
            this.lblTextoCategoria.Text = "placeholder";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(264, 118);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(279, 151);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio:";
            // 
            // nPrecio
            // 
            this.nPrecio.DecimalPlaces = 3;
            this.nPrecio.Location = new System.Drawing.Point(346, 147);
            this.nPrecio.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nPrecio.Name = "nPrecio";
            this.nPrecio.ReadOnly = true;
            this.nPrecio.Size = new System.Drawing.Size(113, 20);
            this.nPrecio.TabIndex = 13;
            // 
            // lblCantidadImagenes
            // 
            this.lblCantidadImagenes.AutoSize = true;
            this.lblCantidadImagenes.Location = new System.Drawing.Point(238, 268);
            this.lblCantidadImagenes.Name = "lblCantidadImagenes";
            this.lblCantidadImagenes.Size = new System.Drawing.Size(24, 13);
            this.lblCantidadImagenes.TabIndex = 14;
            this.lblCantidadImagenes.Text = "0/0";
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 463);
            this.Controls.Add(this.lblCantidadImagenes);
            this.Controls.Add(this.nPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTextoCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblTextoMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblTextoCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.pboxImagenArticulo);
            this.MaximumSize = new System.Drawing.Size(487, 502);
            this.MinimumSize = new System.Drawing.Size(487, 502);
            this.Name = "frmDetalleArticulo";
            this.Text = "Detalle de Articulo";
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxImagenArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTextoCodigo;
        private System.Windows.Forms.Label lblTextoMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTextoCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nPrecio;
        private System.Windows.Forms.Label lblCantidadImagenes;
    }
}
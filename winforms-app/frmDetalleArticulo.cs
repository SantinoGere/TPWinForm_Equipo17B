using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winforms_app
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo = null;
        private ImagenNegocio imagenNegocio = new ImagenNegocio();
        public int id
        {
            get { return articulo.Id; }
        }
        int cantidadImagenes = 0;
        int imagenActual = 0;
        
        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            try
            {
                this.articulo.Imagenes = new List<Imagen>();
                this.articulo.Imagenes = imagenNegocio.GetImagenes(this.articulo.Id);
                cantidadImagenes = this.articulo.Imagenes.Count;
            }
            catch
            {
                this.articulo.Imagenes = null;
                lblCantidadImagenes.Text = "";
            }
        }

        private void actualizarContadorImagenes()
        {
            lblCantidadImagenes.Text = imagenActual+1 + "/" + cantidadImagenes;

        }


        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {

            nPrecio.Controls[0].Visible = false;
            try
            {
                lblNombre.Text = articulo.Nombre;
                lblTextoCodigo.Text = articulo.Codigo;
                lblTextoMarca.Text = articulo.Marca.Descripcion;
                lblTextoCategoria.Text = articulo.Categoria.Descripcion;
                nPrecio.Value = articulo.Precio;
                rtxtDescripcion.Text = articulo.Descripcion;

                if(articulo.Imagenes != null)
                {
                    try
                    {
                        pboxImagenArticulo.Load(articulo.Imagenes[imagenActual].UrlImagen);
                        actualizarContadorImagenes();


                    }
                    catch
                    {
                        pboxImagenArticulo.Load("https://capacitacion.fundacionbancopampa.com.ar/wp-content/uploads/2024/09/placeholder-4.png");

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (cantidadImagenes > 1 && cantidadImagenes > imagenActual+1)
            {
                imagenActual++;
                pboxImagenArticulo.Load(articulo.Imagenes[imagenActual].UrlImagen);
                actualizarContadorImagenes();


            }

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (imagenActual > 0)
            {
                imagenActual--;
                pboxImagenArticulo.Load(articulo.Imagenes[imagenActual].UrlImagen);
                actualizarContadorImagenes();

            }

        }
    }
}

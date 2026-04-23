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
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            nPrecio.Controls[0].Visible = false;

            try
            {
                cboxMarca.DataSource = marca.listar();
                cboxMarca.ValueMember = "Id";
                cboxMarca.DisplayMember = "Descripcion";
                cboxCategoria.DataSource = categoria.listar();
                cboxCategoria.ValueMember = "Id";
                cboxCategoria.DisplayMember = "Descripcion";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAgregarUrl_Click(object sender, EventArgs e)
        {
            if(txtUrlImagen != null)
            {
                string nuevaUrl = txtUrlImagen.Text;
                lwUrlImagen.Items.Add(nuevaUrl);
                txtUrlImagen.Text = null;

            }
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltaArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            articulo = new Articulo();

            articulo.Codigo = txtCodigoArticulo.Text;
            articulo.Nombre = txtNombre.Text;
            if(cboxMarca.SelectedItem != null)
            {
                articulo.Marca = (Marca)cboxMarca.SelectedItem;
            }
            else
            {
                string descripcionMarca = cboxMarca.Text;
                articulo.Marca = new Marca();
                articulo.Marca.Descripcion = descripcionMarca;
                articulo.Marca.Id = negocioMarca.agregarDevolverId(descripcionMarca);
            }
            if(cboxCategoria.SelectedItem != null)
            {
                articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;
            }
            else
            {
                string descripcionCategoria = cboxCategoria.Text;
                articulo.Categoria = new Categoria();
                articulo.Categoria.Descripcion = descripcionCategoria;
                articulo.Categoria.Id = negocioCategoria.agregarDevolverId(descripcionCategoria);
            }
            articulo.Descripcion = rtxtDescripcion.Text;
            articulo.Precio = nPrecio.Value;

            if(lwUrlImagen.Text != null)
            {
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                int idArticulo = negocio.agregarDevolverId(articulo);

                for(int i =0;i<lwUrlImagen.Items.Count;i++)
                {
                    string url = lwUrlImagen.Items[i].Text;
                    imagenNegocio.agregar(idArticulo, url);
                }

            }
            else
            {
                negocio.agregar(articulo);

            }


            Close();
        }
    }
}

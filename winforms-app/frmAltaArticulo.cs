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
            articulo = new Articulo();

            articulo.Codigo = txtCodigoArticulo.Text;
            articulo.Nombre = txtNombre.Text;
            articulo.Marca = (Marca)cboxMarca.SelectedItem;
            articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;
            articulo.Descripcion = rtxtDescripcion.Text;
            articulo.Precio = nPrecio.Value;

            negocio.agregar(articulo);

            Close();
        }
    }
}

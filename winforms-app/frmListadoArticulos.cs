using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winforms_app
{
    public partial class frmListadoArticulos : Form
    {
        public frmListadoArticulos()
        {
            InitializeComponent();
        }

        private void frmListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> articulos = negocio.listar();
            dgvArticulos.DataSource = articulos;
            dgvArticulos.Columns["Id"].Visible = false;

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                lblNombre.Text = seleccionado.Nombre;
                lblDescripcion.Text = seleccionado.Descripcion;

                if (seleccionado.Imagenes != null && seleccionado.Imagenes.Count > 0)
                {
                    try
                    {
                        pbArticulo.Load(seleccionado.Imagenes[0].UrlImagen);
                    }
                    catch
                    {
                        pbArticulo.Load("https://via.placeholder.com/150");
                    }
                }
                else
                {
                    pbArticulo.Load("https://via.placeholder.com/150");
                }
            }
        }
    }
}

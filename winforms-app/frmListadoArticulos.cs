using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winforms_app
{
    public partial class frmListadoArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmListadoArticulos()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarFiltro()
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            nPrecioFiltro.Controls[0].Visible = false;

            try
            {
                cboxMarcaFiltro.DataSource = marca.listar();
                cboxMarcaFiltro.ValueMember = "Id";
                cboxMarcaFiltro.DisplayMember = "Descripcion";
                cboxCategoriaFiltro.DataSource = categoria.listar();
                cboxCategoriaFiltro.ValueMember = "Id";
                cboxCategoriaFiltro.DisplayMember = "Descripcion";

                cboxMarcaFiltro.SelectedIndex = -1;
                cboxMarcaFiltro.Text = "";
                cboxCategoriaFiltro.SelectedIndex = -1;
                cboxCategoriaFiltro.Text = "";

                cboxPrecioFiltro.Items.Add(">");
                cboxPrecioFiltro.Items.Add("<");
                cboxPrecioFiltro.Items.Add("=");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmListadoArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cargarFiltro();
            
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvArticulos.CurrentRow != null)
            //{
            //    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            //    lblNombre.Text = seleccionado.Nombre;
            //    lblDescripcion.Text = seleccionado.Descripcion;

            //    if (seleccionado.Imagenes != null && seleccionado.Imagenes.Count > 0)
            //    {
            //        try
            //        {
            //            pbArticulo.Load(seleccionado.Imagenes[0].UrlImagen);
            //        }
            //        catch
            //        {
            //            pbArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQeJQeJyzgAzTEVqXiGe90RGBFhfp_4RcJJMQ&s");
            //        }
            //    }
            //    else
            //    {
            //        pbArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQeJQeJyzgAzTEVqXiGe90RGBFhfp_4RcJJMQ&s");
            //    }
            //}
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();

        }

        private void txtFiltradoRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltradoRapido.Text;

            if(filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Codigo.ToLower().Contains(filtro.ToLower()));
                
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            try
            {
                dgvArticulos.DataSource = listaFiltrada;
                dgvArticulos.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            ArticuloNegocio negocio = new ArticuloNegocio();
            string marca, categoria, criterio;
            decimal precio;

            try
            {
                marca = cboxMarcaFiltro.Text; categoria = cboxCategoriaFiltro.Text;
                criterio = cboxPrecioFiltro.Text;
                precio = nPrecioFiltro.Value;

                listaFiltrada = negocio.filtrar(marca, categoria, criterio, precio);
                dgvArticulos.DataSource = listaFiltrada;
                dgvArticulos.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            cargar();
            cboxMarcaFiltro.SelectedIndex = -1;
            cboxMarcaFiltro.Text = "";
            cboxCategoriaFiltro.SelectedIndex = -1;
            cboxCategoriaFiltro.Text = "";
            cboxPrecioFiltro.SelectedIndex = -1;
            cboxPrecioFiltro.Text = "";
            nPrecioFiltro.Value = 0;

        }

        private void btnEliminar_Click(object sender, EventArgs e) //ELIMINACION FISICA
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminar el Articulo?", "Eliminando",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            try
            {
                foreach(var item in Application.OpenForms)
                {
                    if(item.GetType() == typeof(frmDetalleArticulo))
                    {
                        frmDetalleArticulo aux = (frmDetalleArticulo)item;
                        if(aux.id == articulo.Id)
                        {
                            MessageBox.Show("Ya hay una ventana para detalle de ese articulo");
                            return;
                        }
                    }
                }
                frmDetalleArticulo detalle = new frmDetalleArticulo(articulo);
                detalle.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al ver detalle del artiuclo");
            }

        }

      //  private void btnEliminarMarca_Click(object sender, EventArgs e)
      //  {
      //    MarcaNegocio negocio = new MarcaNegocio();

      //    try
      //  {
      //    if (cboxMarca.SelectedItem != null)
      //  {
      //      Marca seleccionada = (Marca)cboxMarca.SelectedItem;

      //      var respuesta = MessageBox.Show(
      //          "¿Seguro querés eliminar esta marca?",
      //          "Eliminar",
      //          MessageBoxButtons.YesNo,
      //          MessageBoxIcon.Warning);

      //      if (respuesta == DialogResult.Yes)
      //      {
      //          negocio.eliminar(seleccionada.Id);
      //          MessageBox.Show("Marca eliminada");

      //          cboxMarca.DataSource = new MarcaNegocio().listar();
      //          cboxMarca.SelectedIndex = -1;
      //      }
      //    }
      //  }
      //     catch (Exception ex)
      //    {
      //     MessageBox.Show(ex.Message);
      //    }
      // }

      // private void btnEliminarCategoria_Click(object sender, EventArgs e)
      //{
      //  CategoriaNegocio negocio = new CategoriaNegocio();

      //  try
      //  {
      //  if (cboxCategoria.SelectedItem != null)
      //  {
      //      Categoria seleccionada = (Categoria)cboxCategoria.SelectedItem;

      //      var respuesta = MessageBox.Show(
      //          "¿Seguro querés eliminar esta categoría?",
      //          "Eliminar",
      //          MessageBoxButtons.YesNo,
      //          MessageBoxIcon.Warning);

      //      if (respuesta == DialogResult.Yes)
      //      {
      //          negocio.eliminar(seleccionada.Id);
      //          MessageBox.Show("Categoría eliminada");

      //          cboxCategoria.DataSource = new CategoriaNegocio().listar();
      //          cboxCategoria.SelectedIndex = -1;
      //       }
      //   }
      //}
      //    catch (Exception ex)
      //   {
      //     MessageBox.Show(ex.Message);
      //   }
      //}
    }
}

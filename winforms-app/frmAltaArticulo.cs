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
        List<string> listaUrls = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            this.articulo = articulo;
            Text = "Modificar articulo";
            btnAltaArticulo.Text = "Modificar";
            articulo.Imagenes = imagenNegocio.GetImagenes(articulo.Id);
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

                if (articulo != null)
                {
                    //txtId.Text = articulo.Id;
                    txtCodigoArticulo.Text = articulo.Codigo;
                    txtNombre.Text= articulo.Nombre;
                    rtxtDescripcion.Text = articulo.Descripcion;
                    //txtMarca.Text = articulo.Marca.ToString();
                    cboxMarca.SelectedValue = articulo.Marca.Id;
                    //txtCategoria = articulo.Categoria.ToString();
                    cboxCategoria.SelectedValue = articulo.Categoria.Id;
                    //txtPrecio.Text = articulo.Precio.ToString();
                    nPrecio.Value = articulo.Precio;
                    listaUrls = new List<string>();

                    //txtUrlImagen.Text = articulo.Imagenes.ToString();
                    if (articulo.Imagenes.Count > 0)
                    {
                        try
                        {
                            foreach (Imagen url in articulo.Imagenes)
                            {
                                lwUrlImagen.Items.Add(url.UrlImagen);
                            }
                            //pbxArticulo.Load(articulo.Imagenes.ToString());
                        }
                        catch (Exception ex)
                        {
                            //pbxArticulo.Load("");
                        }
                    }
                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAgregarUrl_Click(object sender, EventArgs e)
        {
            if(txtUrlImagen.Text.ToLower().Contains("http"))
            {
                string nuevaUrl = txtUrlImagen.Text;
                lwUrlImagen.Items.Add(nuevaUrl);
                txtUrlImagen.Text = null;
                if(articulo != null)
                {
                    listaUrls.Add(nuevaUrl);

                }

            }
            else
            {
                MessageBox.Show("ingrese una url valida");
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
            //articulo = new Articulo();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                if(txtCodigoArticulo.Text == "" || txtNombre.Text == "")
                {
                    MessageBox.Show("El codigo y nombre del articulo no deben estar vacios para agregar uno nuevo!");
                    if (txtCodigoArticulo.Text == "")
                        lblFaltanteCodigoArticulo.Text = "!Faltante";
                    if (txtNombre.Text == "")
                        lblNombreFaltante.Text = "!Faltante";
                    return;
                }
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

                
                if (articulo.Id != 0) {
                    negocio.modificar(articulo);
                    if(listaUrls.Count > 0)
                    {
                        ImagenNegocio imagenNegocio = new ImagenNegocio();
                        foreach (string url in listaUrls)
                        {
                            imagenNegocio.agregar(articulo.Id, url);
                        }
                        
                    }
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    if(lwUrlImagen.Items.Count > 0)
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
                    MessageBox.Show("Agregado exitosamente");
                }
                    
                Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (articulo.Id != 0)
                {
                    ImagenNegocio imagenNegocio = new ImagenNegocio();
                    foreach (ListViewItem url in lwUrlImagen.SelectedItems)
                    {
                        lwUrlImagen.Items.Remove(url);
                        imagenNegocio.eliminar(url.Text);
                    }

                }
                else
                {
                    foreach (ListViewItem url in lwUrlImagen.SelectedItems)
                    {
                        lwUrlImagen.Items.Remove(url);
                    }

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al intentar borrar url");
            }

        }
    }
}

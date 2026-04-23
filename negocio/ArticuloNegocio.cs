using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, Precio, M.Descripcion Marca, C.Descripcion Categoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id");

            datos.ejecutarLectura(); 

            while (datos.Lector.Read())
            {
                Articulo aux = new Articulo();
                aux.Id = (int)datos.Lector["Id"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Marca = new Marca();
                aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                lista.Add(aux);
            }

            return lista;
        }

        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio)values(@codigo,@nombre,@descripcion,@idMarca,@idCategoria,@precio)");
                datos.setearParametros("@codigo", articulo.Codigo);
                datos.setearParametros("@nombre",articulo.Nombre);
                datos.setearParametros("@descripcion",articulo.Descripcion);
                datos.setearParametros("@idMarca",articulo.Marca.Id);
                datos.setearParametros("@idCategoria",articulo.Categoria.Id);
                datos.setearParametros("@precio",articulo.Precio);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public int agregarDevolverId(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            int id = 0;

            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) Output INSERTED.Id values(@codigo,@nombre,@descripcion,@idMarca,@idCategoria,@precio)");
                datos.setearParametros("@codigo", articulo.Codigo);
                datos.setearParametros("@nombre",articulo.Nombre);
                datos.setearParametros("@descripcion",articulo.Descripcion);
                datos.setearParametros("@idMarca",articulo.Marca.Id);
                datos.setearParametros("@idCategoria",articulo.Categoria.Id);
                datos.setearParametros("@precio",articulo.Precio);
                id = datos.ejecutarDevolverId();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            return id;

        }
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // eliminar imágenes primero
                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @id");
                datos.limpiarParametros();
                datos.setearParametros("@id", id);
                datos.ejecutarAccion();

                // eliminar artículo
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @id");
                datos.limpiarParametros();
                datos.setearParametros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

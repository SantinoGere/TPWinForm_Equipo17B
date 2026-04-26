using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public int agregarDevolverId(string categoria)
        {
            AccesoDatos datos = new AccesoDatos();
            int id = 0;

            try
            {
                datos.setearConsulta("insert into CATEGORIAS(descripcion) Output INSERTED.Id values(@marca)");
                datos.setearParametros("@marca", categoria);
                id = datos.ejecutarDevolverId();

            }
            catch (Exception ex)
            {

                throw;
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
              datos.setearConsulta("SELECT COUNT(*) FROM ARTICULOS WHERE IdCategoria = @id");
              datos.setearParametros("@id", id);
              int cantidad = datos.ejecutarEscalar();

           if (cantidad > 0)
               throw new Exception("No se puede eliminar la categoría porque está asociada a artículos.");

                datos.setearConsulta("DELETE FROM CATEGORIAS WHERE Id = @id");
                datos.limpiarParametros();
                datos.setearParametros("@id", id);
                datos.ejecutarAccion();
           }
           catch (Exception)
           {
                throw;
           }
           finally
           {
               datos.cerrarConexion();
           }
        }
    }
} 

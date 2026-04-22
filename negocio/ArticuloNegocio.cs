using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

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
}

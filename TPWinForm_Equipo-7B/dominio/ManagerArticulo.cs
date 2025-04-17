using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConexionDB;
using System.Reflection;

namespace dominio
{
    public class ManagerArticulo
    {
        public List<Articulo> Listar()
        {
            List<Articulo>lista = new List<Articulo>();
            Admin_Datos database = new Admin_Datos();

            try
            {
                database.setearConsulta("SELECT A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria FROM Articulos A INNER JOIN Marcas M ON A.Id = M.Id INNER JOIN Categorias C ON A.Id = C.Id");
                database.ejecutarLectura();

                while (database.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Codigo = (string)database.Lector["Codigo"];

                    articulo.Nombre = (string)database.Lector["Nombre"];
                    articulo.Descripcion = (string)database.Lector["Descripcion"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Nombre = (string)database.Lector["Marca"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Nombre = (string)database.Lector["Categoria"];

                    articulo.Imagenes = new List<Imagen>();

                    lista.Add(articulo);
                }
                


                //articulo.Imagen.URL = (string)reader["ImagenURL"];

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                database.cerrarConexion();
            }
        }
    }
}

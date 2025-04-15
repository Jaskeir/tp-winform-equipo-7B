using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TPWinForm_Equipo_7B
{
    internal class ManagerArticulo
    {
        public List<Articulo> Listar()
        {
            List<Articulo>lista = new List<Articulo>();
            
            // Creo los elementos que necesito para establecer una conexión con una DB
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                cmd.Connection = connection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, I.ImagenUrl AS ImagenURL FROM Articulos A INNER JOIN Marcas M ON A.Id = M.Id INNER JOIN Categorias C ON A.IdMarca = C.Id INNER JOIN Imagenes I ON A.Id = I.IdArticulo";

                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.Codigo = (string)reader["Codigo"];
                    articulo.Nombre = (string)reader["Nombre"];
                    articulo.Descripcion = (string)reader["Descripcion"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Nombre = (string)reader["Marca"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Nombre = (string)reader["Categoria"];
                    articulo.Imagen = new Imagen();
                    articulo.Imagen.URL = (string)reader["Categoria"];

                    lista.Add(articulo);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

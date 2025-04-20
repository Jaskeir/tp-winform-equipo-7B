using ConexionDB;
using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class imagenesDatos
    {
        public List<Imagen> Listar(int id)
        {
            List<Imagen> lista = new List<Imagen>();

            Admin_Datos database = new Admin_Datos();

            try
            {
                database.setearConsulta("SELECT ImagenUrl FROM Imagenes WHERE IdArticulo = @id");
                database.setearParametro("@id", id);
                database.ejecutarLectura();

                while (database.Lector.Read())
                {
                    lista.Add(new Imagen((string)database.Lector["ImagenUrl"]));
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                database.cerrarConexion();
            }
            return lista;
        }

        public bool addImages(Articulo articulo)
        {
            Admin_Datos database = new Admin_Datos();
            articulosDatos articulosDatos = new articulosDatos();
            int idArticulo = articulosDatos.getId(articulo);
            
            try
            {
                foreach (Imagen img in articulo.Imagenes)
                {
                    database.setearConsulta("INSERT INTO Imagenes (IdArticulo, ImagenUrl) VALUES (@id, @url)");
                    database.setearParametro("@id", idArticulo);
                    database.setearParametro("@url", img.Url);
                    database.ejecutarAccion();
                }
                return true;
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

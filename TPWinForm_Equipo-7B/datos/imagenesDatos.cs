using ConexionDB;
using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        public void updateImages(Articulo articulo, List<Imagen> imgsCache)
        {
            // Comparar si las imagenes que tiene actualmente, ya las tenía:
            foreach (Imagen img in articulo.Imagenes)
            {
                if (!imgsCache.Contains(img))
                {
                    addImage(articulo.Id, img.Url);
                }
            }
            // Comparar si las imagenes que tenía antes, las sigue teniendo, o fueron modificadas:
            foreach (Imagen img in imgsCache)
            {
                if (!articulo.Imagenes.Contains(img))
                {
                    removeImage(articulo.Id, img.Url);
                }
            }
        }

        public bool addImage(int idArticulo, string url)
        {
            Admin_Datos database = new Admin_Datos();
            try
            {
                database.setearConsulta("INSERT INTO Imagenes (IdArticulo, ImagenUrl) VALUES (@id, @url)");
                database.setearParametro("@id", idArticulo);
                database.setearParametro("@url", url);
                database.ejecutarAccion();
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

        public bool addImages(Articulo articulo)
        {
            Admin_Datos database = new Admin_Datos();
            articulosDatos articulosDatos = new articulosDatos();
            int idArticulo = articulosDatos.getId(articulo);
            foreach (Imagen img in articulo.Imagenes)
            {
                addImage(idArticulo, img.Url);
            }
            return true;
        }

        public bool removeImage(int idArticulo, string url)
        {
            Admin_Datos database = new Admin_Datos();
            try
            {
                database.setearConsulta("DELETE FROM Imagenes WHERE IdArticulo = @id AND ImagenUrl = @url");
                database.setearParametro("@id", idArticulo);
                database.setearParametro("@url", url);
                database.ejecutarAccion();
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

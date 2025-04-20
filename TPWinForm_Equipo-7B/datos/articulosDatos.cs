using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using ConexionDB;
using dominio;
using System.Web;
using datos;
using System.Windows.Forms;

namespace dominio
{
    public class articulosDatos
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            Admin_Datos ConsultaDatabaseArticulos = new Admin_Datos();
            imagenesDatos imagenesDatos = new imagenesDatos();

            try
            {
                ConsultaDatabaseArticulos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, Precio FROM Articulos A INNER JOIN Marcas M ON A.IdMarca = M.Id INNER JOIN Categorias C ON A.IdCategoria = C.Id");
                ConsultaDatabaseArticulos.ejecutarLectura();

                while (ConsultaDatabaseArticulos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)ConsultaDatabaseArticulos.Lector["Id"];
                    articulo.Codigo = (string)ConsultaDatabaseArticulos.Lector["Codigo"];
                    articulo.Nombre = (string)ConsultaDatabaseArticulos.Lector["Nombre"];
                    articulo.Descripcion = (string)ConsultaDatabaseArticulos.Lector["Descripcion"];
                    articulo.Marca.Nombre = (string)ConsultaDatabaseArticulos.Lector["Marca"];
                    articulo.Categoria.Nombre = (string)ConsultaDatabaseArticulos.Lector["Categoria"];
                    articulo.Precio = Math.Round((decimal)ConsultaDatabaseArticulos.Lector["Precio"], 2); // Casteo a decimal y redondeo a 2 decimales, no es posible castear a float o int, porque el el SQL está declarado como MONEY
                    articulo.Imagenes = imagenesDatos.Listar(articulo.Id);

                    lista.Add(articulo);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                ConsultaDatabaseArticulos.cerrarConexion();
            }
            return lista;
        }

        public bool updateArticle(Articulo articulo, List<Imagen> oldImgCache)
        {
            Admin_Datos databaseArticulos = new Admin_Datos();
            imagenesDatos imagenManager = new imagenesDatos();
            try
            {
                Console.WriteLine("Actualizando " + articulo.Id);
                databaseArticulos.setearConsulta("UPDATE Articulos SET Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio WHERE Id = @id");
                databaseArticulos.setearParametro("@id", articulo.Id);
                databaseArticulos.setearParametro("@codigo", articulo.Codigo);
                databaseArticulos.setearParametro("@nombre", articulo.Nombre);
                databaseArticulos.setearParametro("@descripcion", articulo.Descripcion);
                databaseArticulos.setearParametro("@idMarca", articulo.Marca.Id);
                databaseArticulos.setearParametro("@idCategoria", articulo.Categoria.Id);
                databaseArticulos.setearParametro("@precio", articulo.Precio);
                databaseArticulos.ejecutarAccion();

                imagenManager.updateImages(articulo, oldImgCache);

                MessageBox.Show("Artículo actualizado", "Actualizar artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                databaseArticulos.cerrarConexion();
            }
        }

        public bool addArticle(Articulo articulo)
        {
            Admin_Datos databaseArticulos = new Admin_Datos();
            imagenesDatos imagenManager = new imagenesDatos();

            try
            {
                databaseArticulos.setearConsulta("INSERT INTO Articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio)");
                databaseArticulos.setearParametro("@codigo", articulo.Codigo);
                databaseArticulos.setearParametro("@nombre", articulo.Nombre);
                databaseArticulos.setearParametro("@descripcion", articulo.Descripcion);
                databaseArticulos.setearParametro("@idMarca", articulo.Marca.Id);
                databaseArticulos.setearParametro("@idCategoria", articulo.Categoria.Id);
                databaseArticulos.setearParametro("@precio", articulo.Precio);

                databaseArticulos.ejecutarAccion();

                imagenManager.addImages(articulo);

                MessageBox.Show("Artículo añadido", "Añadir artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                databaseArticulos.cerrarConexion();
            }
        }

        public bool removeArticle(Articulo articulo)
        {
            Admin_Datos databaseArticulos = new Admin_Datos();
            imagenesDatos imagenManager = new imagenesDatos();
            try
            {
                databaseArticulos.setearConsulta("DELETE FROM Articulos WHERE Id = @id");
                databaseArticulos.setearParametro("@id", articulo.Id);
                databaseArticulos.ejecutarAccion();
                imagenManager.removeAllImages(articulo);
                MessageBox.Show("Artículo eliminado", "Eliminar artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                databaseArticulos.cerrarConexion();
            }
        }

        public int getId(Articulo articulo)
        {
            Admin_Datos database = new Admin_Datos();
            try
            {
                database.setearConsulta("SELECT Id FROM Articulos WHERE Codigo = @codigo");
                database.setearParametro("@codigo", articulo.Codigo);
                database.ejecutarLectura();

                if (database.Lector.Read())
                {
                    return (int)database.Lector["Id"];
                }
                else
                {
                    return 0;
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
        }

        //
        public List<Articulo> Busqueda(string marca,string categoria,string codigo ,string nombre)
        {
            List<Articulo> lista = new List<Articulo>();
            Admin_Datos ConsultaDatabaseArticulos = new Admin_Datos();
            //
            try
            {
                string datos = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, Precio FROM Articulos A INNER JOIN Marcas M ON A.Id = M.Id INNER JOIN Categorias C ON A.Id = C.Id And ";

                /////////////////////////////completar consulta segun filtro
                datos += "Codigo like '%" + codigo + "%' and Nombre like '%" + nombre + "%'";

                //" and M.Descripcion like '%"+ marca + "%' and C.Descripcion like '%" + categoria + "%'";//para filtrar por marca
                
               
                ////////////////////////////////////

                ConsultaDatabaseArticulos.setearConsulta(datos);
                ConsultaDatabaseArticulos.ejecutarLectura();

                Admin_Datos consultaDatabaseImagenes = new Admin_Datos();

                while (ConsultaDatabaseArticulos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Codigo = (string)ConsultaDatabaseArticulos.Lector["Codigo"];

                    articulo.Nombre = (string)ConsultaDatabaseArticulos.Lector["Nombre"];
                    articulo.Descripcion = (string)ConsultaDatabaseArticulos.Lector["Descripcion"];
                    articulo.Marca.Nombre = (string)ConsultaDatabaseArticulos.Lector["Marca"];
                    articulo.Categoria.Nombre = (string)ConsultaDatabaseArticulos.Lector["Categoria"];
                    articulo.Precio = Math.Round((decimal)ConsultaDatabaseArticulos.Lector["Precio"], 2); // Casteo a decimal y redondeo a 2 decimales, no es posible castear a float o int, porque el el SQL está declarado como MONEY

                    try
                    {
                        consultaDatabaseImagenes.setearConsulta("SELECT ImagenURL FROM Imagenes WHERE IdArticulo = " + ConsultaDatabaseArticulos.Lector["Id"]);
                        consultaDatabaseImagenes.ejecutarLectura();

                        while (consultaDatabaseImagenes.Lector.Read())
                        {
                            articulo.Imagenes.Add(new Imagen((string)consultaDatabaseImagenes.Lector["ImagenURL"]));
                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                    finally
                    {
                        consultaDatabaseImagenes.cerrarConexion();
                    }


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
                ConsultaDatabaseArticulos.cerrarConexion();
            }
        }
        //
    }
}

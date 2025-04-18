﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using ConexionDB;
using dominio;
using System.Web;

namespace dominio
{
    public class articulosDatos
    {
        public List<Articulo> Listar()
        {
            List<Articulo>lista = new List<Articulo>();
            Admin_Datos ConsultaDatabaseArticulos = new Admin_Datos();

            try
            {
                ConsultaDatabaseArticulos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, Precio FROM Articulos A INNER JOIN Marcas M ON A.Id = M.Id INNER JOIN Categorias C ON A.Id = C.Id");
                ConsultaDatabaseArticulos.ejecutarLectura();

                Admin_Datos consultaDatabaseImagenes = new Admin_Datos();

                while (ConsultaDatabaseArticulos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Codigo = (string)ConsultaDatabaseArticulos.Lector["Codigo"];

                    articulo.Nombre = (string)ConsultaDatabaseArticulos.Lector["Nombre"];
                    articulo.Descripcion = (string)ConsultaDatabaseArticulos.Lector["Descripcion"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Nombre = (string)ConsultaDatabaseArticulos.Lector["Marca"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Nombre = (string)ConsultaDatabaseArticulos.Lector["Categoria"];
                    articulo.Imagenes = new List<Imagen>();
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
                    } finally
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
                    articulo.Marca = new Marca();
                    articulo.Marca.Nombre = (string)ConsultaDatabaseArticulos.Lector["Marca"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Nombre = (string)ConsultaDatabaseArticulos.Lector["Categoria"];
                    articulo.Imagenes = new List<Imagen>();
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

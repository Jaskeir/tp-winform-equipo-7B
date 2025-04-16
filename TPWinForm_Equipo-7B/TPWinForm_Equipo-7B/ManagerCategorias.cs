using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_Equipo_7B
{
    class ManagerCategorias
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            Admin_Datos datos = new Admin_Datos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion From Categorias");
                datos.ejecutarLectura();


                while (datos.Lector.Read())

                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];


                    // VERIFICAR POSIBLES NULL 
                    if(!(datos.Lector["Descripcion"] is DBNull))
                    {
                        aux.Nombre = (string)datos.Lector["Descripcion"];
                    }
                    // FIN VERIFICAR POSIBLES NULL
                    

                    lista.Add(aux);
                }

                return lista;
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


        public void agregarCategoria(Categoria nueva)
        {

            Admin_Datos datos = new Admin_Datos();
            try
            {
                datos.setearConsulta("Insert into Categorias(Descripcion)values('" + nueva.Nombre + "')");
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

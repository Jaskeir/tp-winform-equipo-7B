using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace dominio
{
   
    public class Admin_Marca
    {
        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            Admin_Datos datos = new Admin_Datos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From MARCAS");
                datos.ejecutarLectura();
 

                while (datos.Lector.Read()) 
                
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre= (string)datos.Lector["Descripcion"];
                   
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

        
        public void agregar(Marca nuevo)
        {
            Admin_Datos datos = new Admin_Datos();

            try
            {
                datos.setearConsulta("Insert into MARCAS (Descripcion)values('" + nuevo.Nombre + "')");
                
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
        ///////////////////
        public void eliminar(int id)
        {
            try
            {
                Admin_Datos datos = new Admin_Datos();
                datos.setearConsulta("delete from MARCAS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //////////////////////
    }
}

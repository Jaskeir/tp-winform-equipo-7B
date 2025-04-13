using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.SqlClient;



namespace TPWinForm_Equipo_7B
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
                    aux.Nombre= (string)datos.Lector["Nombre"];
                   
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
    }
}

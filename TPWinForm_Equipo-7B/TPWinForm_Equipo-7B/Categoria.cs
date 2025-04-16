using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_Equipo_7B
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; } // EN BD ESTA COMO DESCRIPCION


        public override string ToString()
        {
            return Nombre;  // EN BD ESTA COMO DESCRIPCION

        }
    }
}

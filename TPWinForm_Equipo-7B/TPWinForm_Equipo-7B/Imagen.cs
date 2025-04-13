using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_Equipo_7B
{
    public class Imagen
    {
        public int Id { get; set; }
        public int Id_art { get; set; }
        public string URL { get; set; }


        public override string ToString()
        {
            return URL;

        }
    }
}

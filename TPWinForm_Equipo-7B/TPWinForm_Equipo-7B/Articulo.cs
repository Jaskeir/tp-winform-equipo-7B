using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TPWinForm_Equipo_7B
{
    public class Articulo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca_art {  get; set; }
        public Categoria Categoria_art{ get; set; }
        public Imagen UrlImagen_art { get; set; }

    }
}

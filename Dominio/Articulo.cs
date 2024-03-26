using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Articulo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string UrlImagen { get; set; }
        public int Precio { get; set; }

        public Categoria Categoria  { get; set; }

        //se trabaja con el atributo "color", pero en la base de datos se toma en cuenta como "marca", con el fin de no modificar la db
        public Color color { get; set; }
    }                                      
}

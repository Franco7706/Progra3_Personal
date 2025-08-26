using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Ejemplo2
{
    public class Articulo :  Publicacion
    {
        public Articulo(string nombre, string[] autores, int año) : base(nombre, autores, año)
        {
        }
    }
}

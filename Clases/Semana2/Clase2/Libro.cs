using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Ejemplo2
{
    public class Libro : Publicacion
    {
        private string edicion;
        private string lugar;
        private string editorial;
        public Libro(string nombre, string autor, int año, string edicion, string lugar, string editorial) : base(nombre, autor, año)
        {
            this.Edicion = edicion;
            this.Lugar = lugar;
            this.Editorial = editorial;
        }
        public Libro(string nombre, string[] autores, int año, string edicion, string lugar, string editorial) : base(nombre, autores, año)
        {
            this.Edicion = edicion;
            this.Lugar = lugar;
            this.Editorial = editorial;
        }
        public string Edicion { get => edicion; set => edicion = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public override string MetodoAbstracto()
        {
            return "soy un libro";
        }
    }
}

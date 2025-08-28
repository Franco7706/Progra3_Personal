using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Ejemplo2
{
    public class Articulo :  Publicacion
    {
        private string revista;
        private int volumen;
        private int numero;
        private string mes;

        public Articulo(string nombre, string autor, int año,string revista,int volumen, int numero, string mes) : base(nombre, autor, año)
        {
            this.Revista = revista;
            this.Volumen = volumen;
            this.Numero= numero;
            this.Mes = mes;
        }

        public string Revista { get => revista; set => revista = value; }
        public int Volumen { get => volumen; set => volumen = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Mes { get => mes; set => mes = value; }

        public override string MetodoAbstracto()
        {
            return "Soy un articulo";
        }
    }
}

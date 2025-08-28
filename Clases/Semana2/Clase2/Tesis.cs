using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Ejemplo2
{
    public class Tesis : Publicacion
    {
        private string clase;
        private string departamento;
        private string institucion;
        private string ciudad;
        private string estado;
        public Tesis(string nombre, string autor, int año, string clase, string departamento, string institucion, string ciudad, string estado) : base(nombre, autor, año)
        {
            this.Clase = clase;
            this.Departamento = departamento;
            this.Institucion = institucion;
            this.Ciudad = ciudad;
            this.Estado = estado;
        }

        public string Clase { get => clase; set => clase = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Institucion { get => institucion; set => institucion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Estado { get => estado; set => estado = value; }

        public override string MetodoAbstracto()
        {
            return "Soy una tesis";
        }
    }
}

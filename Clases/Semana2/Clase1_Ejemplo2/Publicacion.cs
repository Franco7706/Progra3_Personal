using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Ejemplo2
{
    public class Publicacion
    {
        private string nombre;
        private string[] autores;
        private int cantidad_autores;
        private int año;

        public string Nombre { get => nombre; set => nombre = value; }
        public string[] Autores { get => autores; set => autores = value; }
        public int Cantidad_autores { get => cantidad_autores; set => cantidad_autores = value; }
        public int Año { get => año; set => año = value; }

        public Publicacion(string nombre, string autor, int año)
        {
            this.Nombre = nombre;
            this.Autores = new string[1];
            this.Autores[0] = autor;
            this.Cantidad_autores = 1;
            this.Año = año;
        }
        public Publicacion(Publicacion publicacion)
        {
            this.Nombre = publicacion.Nombre;
            this.Autores = new string[publicacion.Autores.Length];
            for (int i = 0; i < publicacion.Autores.Length; i++)
            {
                this.Autores[i] = publicacion.Autores[i];
            }
            this.Cantidad_autores = publicacion.Autores.Length;
            this.Año = publicacion.Año;
        }
        public Publicacion(string nombre, string[] autores, int año)
        {
            this.Nombre = nombre;
            this.Autores = new string[autores.Length];
            for (int i = 0; i < autores.Length; i++)
            {
                this.Autores[i] = autores[i];
            }
            this.Cantidad_autores = autores.Length;
            this.Año = año;
        }
        public override string ToString()
        {
            string referencia = "[1] ";
            for (int i = 0; i < this.Cantidad_autores; i++)
            {
                if (i != 0)
                {
                    if(i==this.Cantidad_autores - 1)
                    {
                        referencia += " and ";
                    }
                    else
                    {
                        referencia += ", ";
                    }
                }
                
                referencia += Autores[i];
                
            }
            referencia += ". " + Nombre + ", " + Año + ".";
            return referencia;
        }

        public void Referenciar()
        {
            Console.WriteLine(this);
        }

        
    }
}

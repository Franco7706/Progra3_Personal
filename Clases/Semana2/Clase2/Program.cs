using Clase1_Ejemplo2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BindingList<Publicacion> publicaciones=new BindingList<Publicacion>();

            publicaciones.Add(new Libro("El Quijote", new string[] { "Cervantes" }, 1605,"Ed.1","España", "Editorial1"));
            publicaciones.Add(new Articulo("La relatividad", "Einstein", 1905,"Science",2,10, "May"));
            foreach (var publicacion in publicaciones)
            {
                Console.WriteLine(publicacion.ToString());
                Console.WriteLine(publicacion.MetodoAbstracto());
                Publicacion.orden_publicacion++;
            }
        }
    }
}

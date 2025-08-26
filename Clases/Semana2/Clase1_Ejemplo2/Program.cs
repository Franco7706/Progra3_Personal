using System;

namespace Clase1_Ejemplo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Publicacion publicacion = new Publicacion("Relacional de Aguiloso", "Codd", 1970);
            //Console.WriteLine(publicacion);
            //publicacion.Nombre = "DER de Cueva";
            string[] autores = new string[] { "Gamma", "Helm", "Johnson", "Vlissides" };
            Publicacion publicacion = new Publicacion("Design Patterns: Elements of Reusable Object-Oriented Software", autores, 1994);
            publicacion.Referenciar();
            autores[0]="Cueva";
            Publicacion publicacion2 = new Publicacion(publicacion);
            publicacion2.Referenciar();
        }
    }
}

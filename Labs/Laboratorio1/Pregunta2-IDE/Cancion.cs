using System;
using System.ComponentModel;

namespace Pregunta2_IDE
{
    public class Cancion
    {
        private string titulo;
        private string otrotitulo;
        private BindingList<string> interpretes;
        private BindingList<string> compositores;
        private Genero? generoMusical;
        private string album;
        private int? opus;
        private int? subOpus;
        private string dedicatoria;

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string OtroTitulo { get { return otrotitulo; } set { otrotitulo = value; } }
        public Genero? GeneroMusical { get { return generoMusical; } set { generoMusical = value; } }
        public string Album { get { return album; } set { album = value; } }
        public int? Opus { get { return opus; } set { opus = value; } }
        public int? SubOpus { get { return subOpus; } set { subOpus = value; } }
        public string Dedicatoria { get { return dedicatoria; } set { dedicatoria = value; } }

        public void agregarInterprete(string interprete)
        {
            if (!string.IsNullOrEmpty(interprete))
            {
                interpretes.Add(interprete);
            }
        }

        public void agregarCompositor(string compositor)
        {
            if (!string.IsNullOrEmpty(compositor))
            {
                compositores.Add(compositor);
            }
        }
        public Cancion()
        {
            interpretes = new BindingList<string>();
            compositores = new BindingList<string>();
            titulo = null;
            otrotitulo = null;
            album= null;
            opus = null;
            subOpus = null;
            dedicatoria = null;
            generoMusical = null;
        }

        public override string ToString()
        {
            string reporte= "TITULO: "+ titulo + "\n";
            if (otrotitulo != null)
            {
                reporte += "TAMBIEN CONOCIDA COMO: " + otrotitulo + "\n";
            }
            if (interpretes.Count > 0)
            {
                reporte += "INTERPRETADO POR: ";
                for (int i = 0; i < interpretes.Count; i++)
                {
                    reporte += interpretes[i];
                    if (i < interpretes.Count - 1)
                    {
                        reporte += ", ";
                    }
                }
                reporte += "\n";
            }
            if(compositores.Count > 0)
            {
                reporte += "COMPUESTO POR: ";
                for (int i = 0; i < compositores.Count; i++)
                {
                    reporte += compositores[i];
                    if (i < compositores.Count - 1)
                    {
                        reporte += ", ";
                    }
                }
                reporte += "\n";
            }
            reporte+="GENERO MUSICAL: " + generoMusical + "\n";
            if(album != null)
            {
                reporte += "ALBUM: " + album + "\n";
            }
            if (opus != null)
            {
                reporte += "OPUS: " + opus;

                if (subOpus != null)
                {
                    reporte += " SUB-OPUS: " + subOpus + "\n";
                }
                else reporte += "\n";
            }
            if (dedicatoria != null)
            {
                reporte += "DEDICADO A: " + dedicatoria + "\n";
            }
            return reporte;
        }
    }
}

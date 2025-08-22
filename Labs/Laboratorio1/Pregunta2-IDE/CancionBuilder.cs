using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2_IDE
{
    internal class CancionBuilder
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

        public CancionBuilder()
        {
            interpretes = new BindingList<string>();
            compositores = new BindingList<string>();
            titulo = null;
            otrotitulo = null;
            album = null;
            opus = null;
            subOpus = null;
            dedicatoria = null;
            generoMusical = null;
        }
        public CancionBuilder ConTitulo(string titulo)
        {
            this.titulo = titulo;
            return this;
        }
        public CancionBuilder TambienConocidaComo(string otrotitulo)
        {
            this.otrotitulo = otrotitulo;
            return this;
        }
        
        public CancionBuilder InterpretadoPor(string interprete)
        {
            if (!string.IsNullOrEmpty(interprete))
            {
                interpretes.Add(interprete);
            }
            return this;
        }
        public CancionBuilder CompuestoPor(string compositor)
        {
            if (!string.IsNullOrEmpty(compositor))
            {
                compositores.Add(compositor);
            }
            return this;
        }
        public CancionBuilder DelGenero(Genero genero)
        {
            this.generoMusical = genero;
            return this;
        }
        public CancionBuilder EnElAlbum(string album)
        {
            this.album = album;
            return this;
        }
        public CancionBuilder IdentificadoConOpus(int opus)
        {
            this.opus = opus;
            return this;
        }
        public CancionBuilder IdentificadoConSubOpus(int subOpus)
        {
            this.subOpus = subOpus;
            return this;
        }
        public CancionBuilder DedicadoA(string dedicatoria)
        {
            this.dedicatoria = dedicatoria;
            return this;
        }

        public Cancion BuildCancion()
        {
            Cancion cancion = new Cancion
            {
                Titulo = this.titulo,
                OtroTitulo = this.otrotitulo,
                GeneroMusical = this.generoMusical,
                Album = this.album,
                Opus = this.opus,
                SubOpus = this.subOpus,
                Dedicatoria = this.dedicatoria
            };
            foreach (var interprete in interpretes)
            {
                cancion.agregarInterprete(interprete);
            }
            foreach (var compositor in compositores)
            {
                cancion.agregarCompositor(compositor);
            }
            return cancion;
        }
    }
}

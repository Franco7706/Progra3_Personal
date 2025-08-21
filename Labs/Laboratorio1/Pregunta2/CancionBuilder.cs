using System;
using System.ComponentModel;

namespace Pregunta2{
	public class CancionBuilder{
		
		public string titulo;
		public string otroTitulo;
		public BindingList<string> interpretes;
		public BindingList<string> compositores;
		public Genero? generoMusical;
		public string album;
		public int? opus;
		public int? subOpus;
		public string dedicatoria;
		
		public string Titulo{get{return titulo;} set{this.titulo=value;}}
		public string OtroTitulo{get{return otroTitulo;} set{this.otroTitulo=value;}}

		public void agregarInterprete(string interprete){
			this.interpretes.Add(interprete);
		}
		public void agregarCompositor(string compositor){
			this.compositores.Add(compositor);
		}
		public Genero? GeneroMusical{get{return generoMusical;} set{this.generoMusical=value;}}
		public string Album{get{return album;} set{this.album=value;}}
		public int? Opus{get{return opus;} set{this.opus=value;}}
		public int? SubOpus{get{return subOpus;} set{this.subOpus=value;}}
		public string Dedicatoria{get{return dedicatoria;} set{this.dedicatoria=value;}}
		
		public CancionBuilder(){
			this.titulo = null;
			this.otroTitulo = null;
			this.interpretes = new BindingList<string>();
			this.compositores = new BindingList<string>();
			this.generoMusical = null;
			this.dedicatoria = null;
			this.album = null;
			this.opus = null;
			this.subOpus = null;
		}
		
		public CancionBuilder ConTitulo(string titulo){
			this.titulo=titulo;
			return this;
		}
		public CancionBuilder TambienConocidaComo(string otroTitulo){
			this.otroTitulo=otroTitulo;
			return this;
		}
		public CancionBuilder InterpretadoPor(string interprete){
			this.agregarInterprete(interprete);
			return this;
		}
		public CancionBuilder CompuestoPor(string compositor){
			this.agregarCompositor(compositor);
			return this;
		}
		public CancionBuilder DelGenero(Genero genero){
			this.generoMusical=genero;
			return this;
		}
		public CancionBuilder EnElAlbum(string album){
			this.album=album;
			return this;
		}
		public CancionBuilder IdentificadoConOpus(int opus){
			this.opus=opus;
			return this;
		}
		public CancionBuilder IdentificadoConSubOpus(int subOpus){
			this.subOpus=subOpus;
			return this;
		}
		public CancionBuilder DedicadoA(string dedicatoria){
			this.dedicatoria=dedicatoria;
			return this;
		}
		
		
		public Cancion BuildCancion (){
			Cancion cancion = new Cancion();
			cancion.Titulo = this.titulo;
			cancion.OtroTitulo = this.otroTitulo;
			foreach(string interprete in interpretes){
				cancion.agregarInterprete(interprete);
			}
			foreach(string compositor in compositores){
				cancion.agregarCompositor(compositor);
			}
			cancion.GeneroMusical = this.generoMusical;
			cancion.Album = this.album;
			cancion.Opus = this.opus;
			cancion.SubOpus = this.subOpus;
			cancion.Dedicatoria = this.dedicatoria;
			return cancion;
		}
		
	}
}
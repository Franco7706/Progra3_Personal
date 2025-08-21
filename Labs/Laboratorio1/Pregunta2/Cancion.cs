using System;
using System.ComponentModel;

namespace Pregunta2{
	public class Cancion{
		
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
		
		public Cancion(){
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
		
		public override string ToString(){
			string reporte = "TÍTULO: " + this.titulo + "\n";
			if(otroTitulo != null) reporte += "TAMBIEN CONOCIDA COMO: " + this.otroTitulo + "\n";
			if(this.interpretes.Count > 0){
				reporte += "INTERPRETADA POR: ";
				for(int i=0;i<this.interpretes.Count;i++){
					if(i>0)
						reporte+=", ";
					reporte += interpretes[i];
				}
				reporte+="\n";
			}
			if(this.compositores.Count > 0){
				reporte += "COMPUESTA POR: ";
				for(int i=0;i<this.compositores.Count;i++){
					if(i>0)
						reporte+=", ";
					reporte += compositores[i];
				}
				reporte+="\n";
			}
			reporte += "TIPO: ";
			switch(this.GeneroMusical){
				case Genero.FOLKLORE:
					reporte += "Folklore";
					break;
				case Genero.CLASICA:
					reporte += "Clasica";
					break;
			}
			reporte += "\n";
			if(this.Album != null) reporte+= "ALBUM: " + this.Album + "\n";
			if(this.Opus != null){
				reporte += "OPUS: " +this.Opus;
				if(this.subOpus != null) reporte += " SUBOPUS: " + this.SubOpus;
				reporte += "\n";
			}
			if(this.Dedicatoria != null) reporte += "DEDICADO A: " + this.Dedicatoria + "\n";
			return reporte;
		}
	}
}
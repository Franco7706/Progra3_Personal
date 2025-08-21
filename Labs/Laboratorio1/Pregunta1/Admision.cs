using System;
using System.ComponentModel;

namespace Pregunta1 {
	
	public class Admision {
		private BindingList<FichaEvaluacion> listaFichas;
		private int cantidad_admitidos;
		private int cantidad_postulantes;
		
		public Admision(){
			this.listaFichas = new BindingList<FichaEvaluacion>();
			this.cantidad_admitidos = 0;
			this.cantidad_postulantes = 0;
		}
		
		public void agregarFichaDeEvaluacion(FichaEvaluacion ficha){
			FichaEvaluacion fichaCopia = new FichaEvaluacion(ficha);
			listaFichas.Add(fichaCopia);
			this.cantidad_postulantes++;
			if(ficha.Estado_candidato == Estado.ADMITIDO){
				this.cantidad_admitidos++;
			}
		}
		
		public override string ToString(){
			string reporte = "PROCESO DE ADMISION:";
			reporte += this.cantidad_postulantes + " postulantes, " + this.cantidad_admitidos  + " admitidos\n";
			reporte += "\tLISTA DE ADMITIDOS: \n";
			foreach(FichaEvaluacion ficha in listaFichas){
				if(ficha.Estado_candidato == Estado.ADMITIDO){
					reporte += "\t\t" + ficha.Candidato + "\n";
				}
			}
			return reporte;
		}
	}
}

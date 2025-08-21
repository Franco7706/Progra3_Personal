using System;
using System.ComponentModel;

namespace Pregunta3{
	public class Factura : Comprobante{
		private string ruc;
		private string razon_social;
		
		public string Ruc{get{return ruc;} set{ruc=value;}}
		public string Razon_social{get{return razon_social;} set{razon_social=value;}}
		
		public Factura(string ruc,string razon_social){
			this.ruc=ruc;
			this.razon_social=razon_social;
		}
		
		public override string ToString(){
			string reporte = "FACTURA\nCLIENTE:\n";
			reporte+="\tRUC: "+ruc+"\n"+"\tRazón Social: "+razon_social+"\n";
			reporte+=imprimeDatos();
			return reporte;
		}
	}
}
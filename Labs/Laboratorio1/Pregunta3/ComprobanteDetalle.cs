using System;
using System.ComponentModel;

namespace Pregunta3{
	public class ComprobanteDetalle{
		
		private int? numero;
		private string producto;
		private int? cantidad;
		private double? precio;
		private double? subtotal;
		
		public int? Numero{get{return numero;} set{numero=value;}}
		public string Producto{get{return producto;} set{producto=value;}}
		public int? Cantidad{get{return cantidad;} set{cantidad=value;}}
		public double? Precio{get{return precio;} set{precio=value;}}
		public double? Subtotal{get{return subtotal;} set{subtotal=value;}}
		
		public ComprobanteDetalle(){
			numero=null;
			producto=null;
			cantidad=null;
			precio=null;
			subtotal=null;
		}
		
		public ComprobanteDetalle(int numero,string producto,int cantidad,double precio){
			this.numero=numero;
			this.producto=producto;
			this.cantidad=cantidad;
			this.precio=precio;
			this.subtotal=precio*cantidad*(Constantes.IGV+1);
		}
		
		
		public override string ToString(){
			string reporte=string.Format("{0:00}",numero)+" "+producto+"     "+
			string.Format("{0:00}",cantidad)+
			"   "+string.Format("{0:0.00}",precio)+"  "+Constantes.IGV*100+",0 % "+
			string.Format("{0:0.00}",subtotal)+"\n";
			return reporte;
		}
	}
}
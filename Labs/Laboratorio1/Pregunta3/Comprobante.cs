using System;
using System.ComponentModel;

namespace Pregunta3{
	public class Comprobante{
		private BindingList<ComprobanteDetalle> lista_detalles;
		private double? total;
		
		public Comprobante(){
			lista_detalles = new BindingList<ComprobanteDetalle>();
			total=0;
		}
		public double? Total{get{return total;} set{total=value;}}
		
		public void agregarDetalle(string producto, int cantidad, double precio){
			ComprobanteDetalle nuevoDetalle = new ComprobanteDetalle(lista_detalles.Count+1,
			producto,cantidad,precio);
			lista_detalles.Add(nuevoDetalle);
			total+=nuevoDetalle.Subtotal;
		}
		public string imprimeDatos(){
			string reporte="DETALLE:\n";
			reporte+="\tNo Desc.	Cant. Precio IGV   subTotal\n";
			for (int i=0;i<lista_detalles.Count;i++){
				reporte+="\t"+lista_detalles[i];
			}
			reporte+="TOTAL: "+string.Format("{0:0.00}",total)+" %\n";
			return reporte;
		}
		
		public override string ToString(){
			string reporte = "BOLETA DE PAGO\n";
			reporte+=imprimeDatos();
			return reporte;
		}
	}
}
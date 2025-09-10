package pe.edu.pucp.progra03.lab04.entidad;

public class Columna {
    private String nombre;
    private TipoDeDato tipoDeDato;
    public Columna(String nombre, TipoDeDato tipoDeDato) {
        this.nombre = nombre;
        this.tipoDeDato = tipoDeDato;
    }
    @Override
    public String toString(){
        String reporte = nombre+","+tipoDeDato;
        return reporte;
    }
    public TipoDeDato getTipoDeDato() {
        return tipoDeDato;
    }
}

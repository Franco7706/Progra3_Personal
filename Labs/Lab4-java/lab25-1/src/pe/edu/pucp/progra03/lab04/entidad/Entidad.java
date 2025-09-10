package pe.edu.pucp.progra03.lab04.entidad;

import java.util.ArrayList;

public class Entidad {
    private String nombre;
    protected ArrayList<Columna> listaColumnas;
    private ArrayList<Fila> listaFilas;
    public Entidad(String nombre,ArrayList<Columna> listaColumnas){
        this.nombre = nombre;
        this.listaColumnas = listaColumnas;
        listaFilas = new ArrayList<>();
    }
    public void insertarFila(){
        listaFilas.add(new Fila());
    }
    public void agregarEnteroEnFila(Integer entero){
        listaFilas.getLast().insertarEntero(entero);
    }
    public void agregarCadenaEnFila(String cadena){
        listaFilas.getLast().insertarCadena(cadena);
    }
    @Override
    public String toString(){
        String reporte="";
        for(Columna columna:listaColumnas){
            reporte+=columna.toString()+";";
        }
        reporte+="\n";
        for(Fila fila:listaFilas){
            reporte+=fila.toString()+"\n";
        }
        return reporte;
    }
}

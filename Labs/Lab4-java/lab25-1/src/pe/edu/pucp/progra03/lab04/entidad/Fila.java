package pe.edu.pucp.progra03.lab04.entidad;

import java.util.ArrayList;

public class Fila {
    private ArrayList<Object> listaDatos;
    public Fila(){
        listaDatos = new ArrayList<>();
    }
    public void insertarEntero(Integer dato){
        listaDatos.add(dato);
    }
    public void insertarCadena(String dato){
        listaDatos.add(dato);
    }
    public Object obtenerDato(Integer indice){
        return listaDatos.get(indice);
    }
    @Override
    public String toString(){
        String res="";
        for(Object dato:listaDatos){
            res+=dato.toString()+",";
        }
        return res;
    }
}

package pe.edu.pucp.progra03.lab04.entidad.persistencia;

import pe.edu.pucp.progra03.lab04.entidad.Columna;
import pe.edu.pucp.progra03.lab04.entidad.Entidad;
import pe.edu.pucp.progra03.lab04.entidad.TipoDeDato;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.ArrayList;

public class EntidadPersistente extends Entidad {
    private String nombreArchivo;
    public EntidadPersistente(String nombre, ArrayList<Columna> ListaColumnas) {
        super(nombre, ListaColumnas);
        nombreArchivo = nombre+".csv";
    }
    public void salvarEnArchivo(){
        try {
            FileWriter writer = new FileWriter(nombreArchivo);
            writer.write(super.toString());
            writer.close();
        }
        catch(java.io.IOException ioe){
            throw new RuntimeException(ioe);
        }
    }
    public void cargarDesdeArchivo() {
        try {
            BufferedReader reader = new BufferedReader(new FileReader(nombreArchivo));
            String linea;
            linea = reader.readLine();
            String[] columnas = linea.split(";");
            super.listaColumnas=new ArrayList<>();
            for (String columna : columnas) {
                String[] columnasAux = columna.split(",");
                super.listaColumnas.add(new Columna(columnasAux[0], TipoDeDato.valueOf(columnasAux[1])));
            }
            while ((linea = reader.readLine()) != null) {
                String[] fila = linea.split(",");
                super.insertarFila();
                for (int i = 0; i < super.listaColumnas.size(); i++) {
                    if (listaColumnas.get(i).getTipoDeDato() == TipoDeDato.CADENA) {
                        super.agregarCadenaEnFila(fila[i]);
                    } else {
                        super.agregarEnteroEnFila(Integer.parseInt(fila[i]));
                    }
                }
            }
        }
        catch (java.io.IOException ioe){
            throw new RuntimeException(ioe);
        }
    }
}

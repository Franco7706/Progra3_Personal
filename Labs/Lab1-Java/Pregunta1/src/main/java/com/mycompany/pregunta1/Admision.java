/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.pregunta1;

import java.util.ArrayList;

/**
 *
 * @author Usuario
 */
public class Admision {
    private ArrayList<FichaEvaluacion> lista_fichas;
    private int cantidad_admitidos;
    private int cantidad_postulantes;

    public Admision() {
        lista_fichas = new ArrayList<>();
        cantidad_admitidos=0;
        cantidad_postulantes=0;
    }
    
    public void agregarFichaDeEvaluacion(FichaEvaluacion fichaEvaluacion){
        lista_fichas.add(new FichaEvaluacion(fichaEvaluacion));
        if(fichaEvaluacion.getEstado_candidato()==Estado.ADMITIDO){
            cantidad_admitidos++;
        }
        cantidad_postulantes++;
    }
    @Override
    public String toString(){
        String reporte=String.format("PROCESO DE ADMISION: %d postulantes, %d admitidos\n",
                cantidad_postulantes,cantidad_admitidos);
        reporte+="\tLISTA DE ADMITIDOS:\n";
        for(FichaEvaluacion ficha : lista_fichas){
            if(ficha.getEstado_candidato()==Estado.ADMITIDO)
                reporte+="\t\t"+ficha.getCandidato();
        }
        return reporte;
    }
}

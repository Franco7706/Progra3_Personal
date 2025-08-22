/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.pregunta1;

import java.time.LocalDateTime;

/**
 *
 * @author Usuario
 */
public class FichaEvaluacion {
    private Postulante candidato;
    private LocalDateTime fecha_hora;
    private int evaluacion_expediente;
    private int evaluacion_entrevista;
    private int evaluacion_examen;
    private Estado estado_candidato;
    private static int PUNTAJE_MINIMO = 75;

    public FichaEvaluacion() {
        candidato=null;
        fecha_hora=null;
        estado_candidato=null;
    }

    public FichaEvaluacion(Postulante candidato, LocalDateTime fecha_hora, int evaluacion_expediente, int evaluacion_entrevista, int evaluacion_examen, Estado estado_candidato) {
        this.candidato = new Postulante(candidato);
        this.fecha_hora = fecha_hora;
        this.evaluacion_expediente = evaluacion_expediente;
        this.evaluacion_entrevista = evaluacion_entrevista;
        this.evaluacion_examen = evaluacion_examen;
        this.estado_candidato = estado_candidato;
    }
    
    public FichaEvaluacion(FichaEvaluacion fichaEvaluacion){
        this.candidato = new Postulante(fichaEvaluacion.getCandidato());
        this.fecha_hora = fichaEvaluacion.getFecha_hora();
        this.evaluacion_expediente = fichaEvaluacion.getEvaluacion_expediente();
        this.evaluacion_entrevista = fichaEvaluacion.getEvaluacion_entrevista();
        this.evaluacion_examen = fichaEvaluacion.getEvaluacion_examen();
        this.estado_candidato = fichaEvaluacion.getEstado_candidato();
    }
    /**
     * @return the candidato
     */
    public Postulante getCandidato() {
        return candidato;
    }

    /**
     * @param candidato the candidato to set
     */
    public void setCandidato(Postulante candidato) {
        this.candidato = candidato;
    }

    /**
     * @return the fecha_hora
     */
    public LocalDateTime getFecha_hora() {
        return fecha_hora;
    }

    /**
     * @param fecha_hora the fecha_hora to set
     */
    public void setFecha_hora(LocalDateTime fecha_hora) {
        this.fecha_hora = fecha_hora;
    }

    /**
     * @return the evaluacion_expediente
     */
    public int getEvaluacion_expediente() {
        return evaluacion_expediente;
    }

    /**
     * @param evaluacion_expediente the evaluacion_expediente to set
     */
    public void setEvaluacion_expediente(int evaluacion_expediente) {
        this.evaluacion_expediente = evaluacion_expediente;
    }

    /**
     * @return the evaluacion_entrevista
     */
    public int getEvaluacion_entrevista() {
        return evaluacion_entrevista;
    }

    /**
     * @param evaluacion_entrevista the evaluacion_entrevista to set
     */
    public void setEvaluacion_entrevista(int evaluacion_entrevista) {
        this.evaluacion_entrevista = evaluacion_entrevista;
    }

    /**
     * @return the evaluacion_examen
     */
    public int getEvaluacion_examen() {
        return evaluacion_examen;
    }

    /**
     * @param evaluacion_examen the evaluacion_examen to set
     */
    public void setEvaluacion_examen(int evaluacion_examen) {
        this.evaluacion_examen = evaluacion_examen;
    }

    /**
     * @return the estado_candidato
     */
    public Estado getEstado_candidato() {
        int total=evaluacion_entrevista+evaluacion_examen+evaluacion_expediente;
        if(total>=PUNTAJE_MINIMO){
            estado_candidato=Estado.ADMITIDO;
        } else{
            estado_candidato=Estado.NO_ADMITIDO;
        }
        return estado_candidato;
    }

    /**
     * @param estado_candidato the estado_candidato to set
     */
    public void setEstado_candidato(Estado estado_candidato) {
        this.estado_candidato = estado_candidato;
    }
    
    
}

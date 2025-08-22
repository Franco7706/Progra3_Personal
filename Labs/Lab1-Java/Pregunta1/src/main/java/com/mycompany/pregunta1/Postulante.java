/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.pregunta1;


/**
 *
 * @author Usuario
 */
public class Postulante {
    private String paterno;
    private String materno;
    private String nombre;
    private String dni;
    
    public Postulante(){
        paterno=null;
        materno=null;
        nombre=null;
        dni=null;
    }
    
    @Override
    public String toString(){
        return String.format("%s %s, %s (%s)\n",
                paterno, materno, nombre, dni);
    }
    
    public Postulante(String paterno,String materno,
            String nombre, String dni){
        this.paterno=paterno;
        this.materno=materno;
        this.nombre=nombre;
        this.dni=dni;
    }
    
    public Postulante(Postulante postulante){
        setPaterno(postulante.paterno);
        setMaterno(postulante.materno);
        setNombre(postulante.nombre);
        setDni(postulante.dni);
    }
    /**
     * @return the paterno
     */
    public String getPaterno() {
        return paterno;
    }

    /**
     * @param paterno the paterno to set
     */
    public void setPaterno(String paterno) {
        this.paterno = paterno;
    }

    /**
     * @return the materno
     */
    public String getMaterno() {
        return materno;
    }

    /**
     * @param materno the materno to set
     */
    public void setMaterno(String materno) {
        this.materno = materno;
    }

    /**
     * @return the nombre
     */
    public String getNombre() {
        return nombre;
    }

    /**
     * @param nombre the nombre to set
     */
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    /**
     * @return the dni
     */
    public String getDni() {
        return dni;
    }

    /**
     * @param dni the dni to set
     */
    public void setDni(String dni) {
        this.dni = dni;
    }
    
    
}

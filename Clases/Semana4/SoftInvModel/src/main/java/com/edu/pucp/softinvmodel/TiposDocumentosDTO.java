/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.edu.pucp.softinvmodel;

/**
 *
 * @author Usuario
 */
public class TiposDocumentosDTO {
    private Integer tipoDocumentoId;
    private String nombre;
    
    
    public TiposDocumentosDTO(){
        tipoDocumentoId=null;
        nombre=null;
    }
    
    public TiposDocumentosDTO(Integer tipoDocumentoId, String nombre){
        this.tipoDocumentoId=tipoDocumentoId;
        this.nombre=nombre;
    }

    /**
     * @return the tipoDocumentoId
     */
    public Integer getTipoDocumentoId() {
        return tipoDocumentoId;
    }

    /**
     * @param tipoDocumentoId the tipoDocumentoId to set
     */
    public void setTipoDocumentoId(Integer tipoDocumentoId) {
        this.tipoDocumentoId = tipoDocumentoId;
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
    
    
}

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.edu.pucp.softinvmodel;

/**
 *
 * @author Usuario
 */
public class AlmacenesDTO {
    private Integer AlmacenId;
    private String nombre;
    private Boolean almacen_central;

    public AlmacenesDTO() {
        AlmacenId=null;
        nombre=null;
        almacen_central=null;
    }

    public AlmacenesDTO(Integer AlmacenId, String nombre, Boolean almacen_central) {
        this.AlmacenId = AlmacenId;
        this.nombre = nombre;
        this.almacen_central = almacen_central;
    }

    /**
     * @return the AlmacenId
     */
    public Integer getAlmacenId() {
        return AlmacenId;
    }

    /**
     * @param AlmacenId the AlmacenId to set
     */
    public void setAlmacenId(Integer AlmacenId) {
        this.AlmacenId = AlmacenId;
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
     * @return the almacen_central
     */
    public Boolean getAlmacen_central() {
        return almacen_central;
    }

    /**
     * @param almacen_central the almacen_central to set
     */
    public void setAlmacen_central(Boolean almacen_central) {
        this.almacen_central = almacen_central;
    }
    
    
}

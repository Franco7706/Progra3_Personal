/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.pregunta1;
import java.time.LocalDateTime;
/**
 *
 * @author Usuario
 */
public class Pregunta1 {

    public static void main(String[] args) {
        Admision admision = new Admision();

        // Primer Postulante
        Postulante postulante1 = new Postulante();
        postulante1.setPaterno("Pérez");
        postulante1.setMaterno("Deza");
        postulante1.setNombre("Juan Alonso");
        postulante1.setDni("75355946B");
        
        FichaEvaluacion ficha1 = new FichaEvaluacion();
        ficha1.setCandidato(postulante1);
        ficha1.setFecha_hora(LocalDateTime.of(2025, 2, 20, 14, 0, 0));
        ficha1.setEvaluacion_expediente(22);
        ficha1.setEvaluacion_entrevista(47);
        ficha1.setEvaluacion_examen(18);
        admision.agregarFichaDeEvaluacion(ficha1);

        // Segundo Postulante
        Postulante postulante2 = new Postulante();
        postulante2.setPaterno("León");
        postulante2.setMaterno("Mendoza");
        postulante2.setNombre("Carmen");
        postulante2.setDni("87332141Z");

        FichaEvaluacion ficha2 = new FichaEvaluacion();
        ficha2.setCandidato(postulante2);
        ficha2.setFecha_hora(LocalDateTime.of(2025, 2, 20, 14, 30, 0));
        ficha2.setEvaluacion_expediente(12);
        ficha2.setEvaluacion_entrevista(22);
        ficha2.setEvaluacion_examen(17);
        admision.agregarFichaDeEvaluacion(ficha2);

        // Tercer Postulante
        Postulante postulante3 = new Postulante();
        postulante3.setPaterno("Sandoval");
        postulante3.setMaterno("García");
        postulante3.setNombre("Eric");
        postulante3.setDni("73734226K");

        FichaEvaluacion ficha3 = new FichaEvaluacion();
        ficha3.setCandidato(postulante3);
        ficha3.setFecha_hora(LocalDateTime.of(2025, 2, 20, 15, 0, 0));
        ficha3.setEvaluacion_expediente(15);
        ficha3.setEvaluacion_entrevista(45);
        ficha3.setEvaluacion_examen(23);
        admision.agregarFichaDeEvaluacion(ficha3);

        System.out.println(admision);
    }
}

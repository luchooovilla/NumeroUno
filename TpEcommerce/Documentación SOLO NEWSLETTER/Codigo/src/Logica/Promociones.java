/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Logica;

import java.time.LocalDate;

public class Promociones {

    private int id;
    private String titulo;
    private LocalDate fechaInicio;
    private LocalDate fechaFinalizacion;
    private String descripcion;

    public Promociones() {
    }

    public Promociones(int id, String titulo, LocalDate fechaInicio, LocalDate fechaFinalizacion, String descripcion) {
        this.fechaInicio = fechaInicio;
        this.fechaFinalizacion = fechaFinalizacion;
        this.descripcion = descripcion;
        this.id = id;
        this.titulo = titulo;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public LocalDate getFechaInicio() {
        return fechaInicio;
    }

    public void setFechaInicio(LocalDate fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public LocalDate getFechaFinalizacion() {
        return fechaFinalizacion;
    }

    public void setFechaFinalizacion(LocalDate fechaFinalizacion) {
        this.fechaFinalizacion = fechaFinalizacion;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    @Override
    public String toString() {
        return "Promociones{" + "id=" + id + ", titulo=" + titulo + ", fechaInicio=" + fechaInicio + ", fechaFinalizacion=" + fechaFinalizacion + ", descripcion=" + descripcion + '}';
    }

}

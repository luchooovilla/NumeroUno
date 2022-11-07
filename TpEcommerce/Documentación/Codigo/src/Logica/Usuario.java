/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Logica;

import java.util.ArrayList;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import javax.swing.JOptionPane;

public class Usuario {

    private int id;
    private String email;
    private boolean aceptaNovedades;
    private String nombre;
    private String apellido;
    

    public Usuario() {
    }

    public Usuario(int id, String email, boolean aceptaNovedades, String nombre, String apellido) {
        
        
        if(validarDatos(nombre, apellido, email)){
            
            this.nombre = nombre;
            this.apellido=apellido;
            this.email = email;
            this.id = id;
            this.aceptaNovedades = aceptaNovedades;
            
        } 
        
        else {
            
            JOptionPane.showMessageDialog(null, "Datos incorrecto");
            System.exit(0);
            
        }
        
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public boolean getAceptaNovedades() {
        return aceptaNovedades;
    }

    public void setAceptaNovedades(boolean aceptaNovedades) {
        this.aceptaNovedades = aceptaNovedades;
    }
    
    public boolean validarDatos(String nombre, String apellido, String correo){
        
        if(validarNombre(nombre)&&validarNombre(apellido)&&validarEmail(correo)){
            return true;
        }
        
        else return false;
        
    }
    
    public boolean validarEmail(String correo){
    
    Pattern patron = Pattern.compile("^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@"
                                    + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$");
    
    Matcher mat = patron.matcher(correo);        
    return mat.find();
        
    }
    
    public static boolean validarNombre(String nombre) {

        return nombre.matches("^([A-Z]{1}[a-z]+[ ]*){1,2}$");

    }

    
    @Override
    public String toString() {
        return "Usuario{" + "id=" + id + ", email=" + email + ", aceptaNovedades=" + aceptaNovedades + ", nombre=" + nombre + ", apellido=" + apellido + '}';
    }

}

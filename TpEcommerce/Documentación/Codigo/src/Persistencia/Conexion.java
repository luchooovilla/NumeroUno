/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Persistencia;

import java.sql.Connection;
import java.sql.*;


public class Conexion {
    Connection cx;
    String bd="ecommerce";
    String url="jdbc:mysql://localhost:3306/";
    String user="root";
    String password="Exaktus";
    
    
    public Connection conectar(){
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            cx=(Connection)DriverManager.getConnection(url+bd,user,password);
            System.out.println("SE CONECTO A "+bd);
        } catch (ClassNotFoundException |SQLException ex) {
            System.out.println("NO SE CONECTO A "+bd);
        }
        return cx;
    }
    
    public void desconectar(){
        try {
            cx.close();
            System.out.println("Se desconecto");
        } catch (SQLException ex) {
            System.out.println("No se pudo cerrar conexion");
        }
    }
    
}

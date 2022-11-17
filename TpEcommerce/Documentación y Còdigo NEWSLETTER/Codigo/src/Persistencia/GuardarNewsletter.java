/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Persistencia;

import Logica.Newsletter;
import Logica.Usuario;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.SQLException;
import java.sql.*;
import java.sql.Connection;

public class GuardarNewsletter {
   
    Conexion c;
    
    public GuardarNewsletter(){
        c=new Conexion();
    }
    
    public boolean guardarUsuario(Newsletter news){
        
        try {
            String sql="INSERT INTO newsletter(idUsuario,idPromocion) values (?,?)";
            PreparedStatement ps=c.conectar().prepareStatement(sql);
            ps.setInt(1, news.getIdUsuario());
            ps.setInt(2, news.getIdPromocion());
            ps.execute();
            ps.close();
            ps=null;
            
            c.desconectar();
            
            return true;
        } catch (SQLException ex) {
            System.out.println("No se inserto registro "+ex);
            return false;
        }

    }
} 
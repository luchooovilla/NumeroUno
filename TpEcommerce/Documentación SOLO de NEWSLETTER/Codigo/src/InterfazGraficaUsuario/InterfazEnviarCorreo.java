/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package InterfazGraficaUsuario;

import Logica.EnviarCorreo;
import Logica.Promociones;
import Logica.Usuario;
import java.util.ArrayList;

/**
 *
 * @author Usuario
 */
public class InterfazEnviarCorreo extends javax.swing.JFrame {

    ArrayList<Usuario> usuarios = new ArrayList<>();
    ArrayList<String> correos = new ArrayList<>();
    Promociones promo;
    private String subject;
    private String content;

    /**
     * Creates new form InterfazNewsletter
     */
    public InterfazEnviarCorreo(ArrayList user, Promociones promo) {
        content = promo.getDescripcion() + "\nFecha finalizacion: " + promo.getFechaFinalizacion();
        subject = promo.getTitulo();

        initComponents();
        
        setLocationRelativeTo(this);

        this.usuarios = user;
        this.promo = promo;

        

        txtContent.setText(content);
        txtSubject.setText(subject);
        //setVisible(true);

        for (int i = 0; i < user.size(); i++)
        {

            if (usuarios.get(i).getAceptaNovedades())
            {

                correos.add(usuarios.get(i).getEmail());

            }

        }
        
        ponerCorreos();
    }

    public void ponerCorreos() {

        StringBuilder direcciones = new StringBuilder();
        boolean primero = true;

        if (primero)
        {
            direcciones.append(correos);
        } else
        {

            direcciones.append(";");
            direcciones.append(correos);
        }

        txtTo.setText(direcciones.toString());

    }
    private int ban=0;
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        btnSendEmail = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        txtTo = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        txtSubject = new javax.swing.JTextField();
        jScrollPane1 = new javax.swing.JScrollPane();
        txtContent = new javax.swing.JTextArea();
        jLabel4 = new javax.swing.JLabel();
        btnMostrarDatos = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jPanel1.setBackground(new java.awt.Color(255, 0, 0));
        jPanel1.setForeground(new java.awt.Color(0, 204, 255));

        btnSendEmail.setText("Enviar correo");
        btnSendEmail.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSendEmailActionPerformed(evt);
            }
        });

        jLabel1.setFont(new java.awt.Font("Eras Demi ITC", 0, 18)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 0, 0));
        jLabel1.setText("Enviar correo ");

        txtTo.setName("txtTo"); // NOI18N
        txtTo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtToActionPerformed(evt);
            }
        });

        jLabel2.setForeground(new java.awt.Color(0, 0, 0));
        jLabel2.setText("Enviar a:");

        jLabel3.setForeground(new java.awt.Color(0, 0, 0));
        jLabel3.setText("Asunto:");

        txtContent.setColumns(20);
        txtContent.setRows(5);
        jScrollPane1.setViewportView(txtContent);

        jLabel4.setForeground(new java.awt.Color(0, 0, 0));
        jLabel4.setText("Contenido:");

        btnMostrarDatos.setText("Historial");
        btnMostrarDatos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMostrarDatosActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(220, 220, 220)
                        .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 131, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(50, 50, 50)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel2)
                            .addComponent(jLabel3)
                            .addComponent(jLabel4))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addComponent(btnSendEmail, javax.swing.GroupLayout.PREFERRED_SIZE, 141, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 34, Short.MAX_VALUE)
                                .addComponent(btnMostrarDatos, javax.swing.GroupLayout.PREFERRED_SIZE, 141, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addComponent(txtTo)
                            .addComponent(txtSubject)
                            .addComponent(jScrollPane1))))
                .addContainerGap(66, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addComponent(jLabel1)
                .addGap(32, 32, 32)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtTo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel2))
                .addGap(18, 18, 18)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(txtSubject, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 117, Short.MAX_VALUE)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addComponent(jLabel4)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addGap(18, 18, 18)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnSendEmail)
                    .addComponent(btnMostrarDatos))
                .addGap(27, 27, 27))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents
    
    ArrayList<Usuario> historial=new ArrayList<>();
    
    private void btnSendEmailActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSendEmailActionPerformed
        for (int i = 0; i < usuarios.size(); i++)
        {

            if (usuarios.get(i).getAceptaNovedades())
            {
                EnviarCorreo n = new EnviarCorreo(usuarios.get(i).getEmail(), promo);
                n.guardar(usuarios.get(i).getId(), promo.getId());
                historial.add(usuarios.get(i));
                ban=1;
            } 
        }
        
        
        
    }//GEN-LAST:event_btnSendEmailActionPerformed

    
    
    private void txtToActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtToActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtToActionPerformed

    private void btnMostrarDatosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMostrarDatosActionPerformed
        InterfazMostrarDatos mostrarDatos= new InterfazMostrarDatos(historial, promo);
        mostrarDatos.setVisible(true);
        /*if(ban!=0){
        
        
        }
        
        else {
            
            InterfazMostrarDatos mostrarDatos= new InterfazMostrarDatos();
            mostrarDatos.setVisible(true);
            
        }*/
    }//GEN-LAST:event_btnMostrarDatosActionPerformed

    /**
     * @param args the command line arguments
     */

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnMostrarDatos;
    private javax.swing.JButton btnSendEmail;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextArea txtContent;
    private javax.swing.JTextField txtSubject;
    private javax.swing.JTextField txtTo;
    // End of variables declaration//GEN-END:variables
}

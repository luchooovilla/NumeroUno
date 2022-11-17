/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Logica;

import InterfazGraficaUsuario.InterfazEnviarCorreo;
import Persistencia.GuardarNewsletter;
import java.util.Properties;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.NoSuchProviderException;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.AddressException;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;
import javax.swing.JOptionPane;

public class EnviarCorreo extends javax.swing.JFrame {

    private static String emailFrom = "micailu55@gmail.com";
    private static String passwordFrom = "xkzjnuldunfdrolx";
    private String emailTo;
    private String subject;
    private String content;

    private Properties mProperties;
    private Session mSession;
    private MimeMessage mCorreo;
    Promociones promo;

    @Override
    public String toString() {
        return "Newsletter{" + "emailTo=" + emailTo + ", subject=" + subject + ", content=" + content + '}';
    }

    public EnviarCorreo(String email, Promociones promo) {
        this.promo = promo;
        emailTo = email;
        content = promo.getDescripcion() + "\nFecha finalizacion: " + promo.getFechaFinalizacion();
        subject = promo.getTitulo();

        mProperties = new Properties();

        iniciar();
    }

    public EnviarCorreo() {

    }

    private void iniciar() {
        createEmail();
        sendEmail();
        
    }

    private void createEmail() {

        // Simple mail transfer protocol
        mProperties.put("mail.smtp.host", "smtp.gmail.com");
        mProperties.put("mail.smtp.ssl.trust", "smtp.gmail.com");
        mProperties.setProperty("mail.smtp.starttls.enable", "true");
        mProperties.setProperty("mail.smtp.port", "587");
        mProperties.setProperty("mail.smtp.user", emailFrom);
        mProperties.setProperty("mail.smtp.ssl.protocols", "TLSv1.2");
        mProperties.setProperty("mail.smtp.auth", "true");

        mSession = Session.getDefaultInstance(mProperties);

        try
        {
            mCorreo = new MimeMessage(mSession);
            mCorreo.setFrom(new InternetAddress(emailFrom));
            mCorreo.setRecipient(Message.RecipientType.TO, new InternetAddress(emailTo));
            mCorreo.setSubject(subject);
            mCorreo.setText(content, "ISO-8859-1", "html");

        } catch (AddressException ex)
        {
            Logger.getLogger(InterfazEnviarCorreo.class.getName()).log(Level.SEVERE, null, ex);
        } catch (MessagingException ex)
        {
            Logger.getLogger(InterfazEnviarCorreo.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private void sendEmail() {
        try
        {
            Transport mTransport = mSession.getTransport("smtp");
            mTransport.connect(emailFrom, passwordFrom);
            mTransport.sendMessage(mCorreo, mCorreo.getRecipients(Message.RecipientType.TO));
            mTransport.close();

            JOptionPane.showMessageDialog(null, "Correo enviado");
        } catch (NoSuchProviderException ex)
        {
            Logger.getLogger(InterfazEnviarCorreo.class.getName()).log(Level.SEVERE, null, ex);

        } catch (MessagingException ex)
        {
            Logger.getLogger(InterfazEnviarCorreo.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    public void guardar(int idUsuario, int idPromocion) {

        Newsletter n = new Newsletter(idUsuario, idPromocion);
        GuardarNewsletter dao;

        dao = new GuardarNewsletter();
        if (dao.guardarUsuario(n))
        {
            JOptionPane.showMessageDialog(null, "Registro exitoso");
        } else
        {
            JOptionPane.showMessageDialog(null, "Error: Vuelva a intentarlo");
        }

    }
}

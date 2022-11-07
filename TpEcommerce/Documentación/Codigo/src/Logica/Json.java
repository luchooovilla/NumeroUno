package Logica;

import InterfazGraficaUsuario.InterfazEnviarCorreo;
import Persistencia.GuardarNewsletter;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.reflect.TypeToken;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintWriter;
import java.time.LocalDate;
import java.time.temporal.ChronoUnit;
import java.util.ArrayList;
import javax.swing.JOptionPane;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

public class Json {

    public static void main(String[] args) throws JSONException, IOException {

        ArrayList<Usuario> user = new ArrayList<>();

        JSONParser parser = new JSONParser();

        try
        {

            Object json = parser.parse(new FileReader("usuarios.json"));
            String cadena = String.valueOf(json);
            //System.out.println(cadena);
            JSONArray arregloJson = new JSONArray(cadena);

            for (int indice = 0; indice < arregloJson.length(); indice++)
            {
                JSONObject posibleUsuario = arregloJson.getJSONObject(indice);

                int id = posibleUsuario.getInt("id");
                String nombre = posibleUsuario.getString("nombre");
                String apellido = posibleUsuario.getString("apellido");
                boolean acepta = posibleUsuario.getBoolean("aceptaNovedades");
                String email = posibleUsuario.getString("email");

                Usuario u = new Usuario(id, email, acepta, nombre, apellido);
                user.add(u);

            }

            System.out.println("--------------JSON de usuarios que se recibe--------------------");

            for (int i = 0; i < user.size(); i++)
            {
                System.out.println(user.get(i).toString());
            }

            System.out.println("\n\n");

        } catch (FileNotFoundException e)
        {
        } catch (IOException e)
        {
        } catch (ParseException e)
        {
        }

        ArrayList<Promociones> promocion = new ArrayList<>();

        JSONParser parser1 = new JSONParser();

        try
        {

            Object json = parser1.parse(new FileReader("promociones.json"));
            String cadena = String.valueOf(json);
            //System.out.println(cadena);

            JSONArray arregloJson = new JSONArray(cadena);

            JSONArray fechaf = new JSONArray(cadena);

            JSONArray fechai = new JSONArray(cadena);

            for (int indice = 0; indice < arregloJson.length(); indice++)
            {
                JSONObject posiblePromo = arregloJson.getJSONObject(indice);

                int id = posiblePromo.getInt("id");
                String titulo = posiblePromo.getString("titulo");
                String descripcion = posiblePromo.getString("descripcion");
                fechaf = posiblePromo.getJSONArray("fechaFinal");
                fechai = posiblePromo.getJSONArray("fechaInicio");

                LocalDate fechaFinal = LocalDate.now();
                LocalDate fechaInicio = LocalDate.now();

                int i = 0;
                for (; i < fechaf.length(); i++)
                {

                    int j = fechaf.getInt(i);
                    int k = fechaf.getInt(i + 1);
                    int l = fechaf.getInt(i + 2);
                    fechaFinal = LocalDate.of(j, k, l);

                    int a = fechai.getInt(i);
                    int b = fechai.getInt(i + 1);
                    int c = fechai.getInt(i + 2);
                    fechaInicio = LocalDate.of(a, b, c);

                    i = fechaf.length();

                }

                Promociones p = new Promociones(id, titulo, fechaInicio, fechaFinal, descripcion);

                promocion.add(p);

            }

            System.out.println("--------------JSON de promociones que se recibe--------------------");

            for (int i = 0; i < promocion.size(); i++)
            {
                System.out.println(promocion.get(i).toString());
            }

        } catch (FileNotFoundException e)
        {
        } catch (IOException e)
        {
        } catch (ParseException e)
        {
        }

        ArrayList<Usuario> usuarioAcepta = new ArrayList<>();

        for (int i = 0; i < user.size(); i++)
        {
            if (user.get(i).getAceptaNovedades())
            {
                usuarioAcepta.add(user.get(i));
            }
        }

        EnviarCorreo ec;

        int ban = promocion.size();

        for (int i = 0; i < promocion.size(); i++)
        {

            if (ChronoUnit.YEARS.MONTHS.DAYS.between(promocion.get(i).getFechaInicio(), LocalDate.now()) == 0)
            {

                InterfazEnviarCorreo interfaz = new InterfazEnviarCorreo(usuarioAcepta, promocion.get(i));
                interfaz.setVisible(true);
                

            } else
            {

                ban--;

            }

        }

        if (ban == 0)
        {

            JOptionPane.showMessageDialog(null, "No hay promociones disponibles");

        }

        Gson gson = new Gson();

        java.lang.reflect.Type listType = new TypeToken<ArrayList<Usuario>>() {
        }.getType();
        String jsonArray = gson.toJson(user);
        ArrayList<Usuario> arrayDeJson = gson.fromJson(jsonArray, listType);

        System.out.println("\n");
        try ( PrintWriter pw = new PrintWriter(new File("json.txt")))
        {
            System.out.println("--------------JSON de usuarios que aceptan recibir newsletter para enviar a manejo de usuarios--------------------");
            for (Usuario usuario : arrayDeJson)
            {

                if (usuario.getAceptaNovedades())
                {
                    System.out.print(usuario);
                    final Gson prettyGson = new GsonBuilder().setPrettyPrinting().create();
                    final String representacionBonita = prettyGson.toJson(usuario);

                    pw.write(representacionBonita);
                    pw.flush();
                }

            }
        }

       
    }
}

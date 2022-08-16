namespace CirculoSangre
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Asociado asociado = new Asociado();
            Cuota cuota = new Cuota();
            Interfaz interfaz = new Interfaz();
            Gestor gestor = new Gestor();
            interfaz.SolicitarRegistro(asociado);
            gestor.GestionarRegistro(asociado, cuota);

        }
    }
}
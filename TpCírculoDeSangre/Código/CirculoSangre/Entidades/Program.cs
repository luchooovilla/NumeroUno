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

            var validation = new ValidacionAsociado();
            var resultado = validation.Validate(asociado); //Guardar resultados de validacion
            if (resultado.IsValid)
            {
                interfaz.mostrarLista(asociado);
            }
            else
            {
                foreach (var error in resultado.Errors)
                {
                    Console.WriteLine(error.PropertyName + ": " + error.ErrorMessage);
                }
            }
        }
    }
}
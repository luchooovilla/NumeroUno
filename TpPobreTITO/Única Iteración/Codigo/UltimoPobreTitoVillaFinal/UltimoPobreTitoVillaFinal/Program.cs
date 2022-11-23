using UltimoPobreTitoVillaFinal.Clases;
using UltimoPobreTitoVillaFinal.Interfaz;
using System.Data.SqlClient;

namespace UltimoPobreTitoVillaFinal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static frmMenuInicio menu = new frmMenuInicio(); 
        public static frmInicioSesion iniciosesion = new frmInicioSesion();
        public static frmRegistroNuevoUsuario registrousuario = new frmRegistroNuevoUsuario();
        public static frmRegistroRECLAMO registroreclamo = new frmRegistroRECLAMO();        
        public static Controller controller = new Controller();
        public static SqlConnection conexion = new SqlConnection(As New System.Data.SqlClient.SqlConnection(@"C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\");
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(menu);
        }
    }
}
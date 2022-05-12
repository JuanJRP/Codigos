namespace PROYECTO_FINAL_ESTRUCTURA_DE_DATOS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Listas-------------------------------------------------------
            List<string> usuarios_Administradores = new List<string>();
            List<string> Contraseñas_Administradores = new List<string>();
            List<string> usuarios_Profesores = new List<string>();
            List<string> Contraseñas_Profesores = new List<string>();
            List<string> usuarios_Estudiantes = new List<string>();
            List<string> Contraseñas_Estudiantes = new List<string>();
            //-------------------------------------------------------------
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio(usuarios_Administradores, Contraseñas_Administradores,
                usuarios_Profesores, Contraseñas_Profesores,
                usuarios_Estudiantes, Contraseñas_Estudiantes));
        }
    }
}
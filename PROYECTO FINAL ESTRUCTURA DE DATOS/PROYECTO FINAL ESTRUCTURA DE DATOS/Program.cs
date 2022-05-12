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
            List<string> Contrase�as_Administradores = new List<string>();
            List<string> usuarios_Profesores = new List<string>();
            List<string> Contrase�as_Profesores = new List<string>();
            List<string> usuarios_Estudiantes = new List<string>();
            List<string> Contrase�as_Estudiantes = new List<string>();
            //-------------------------------------------------------------
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio(usuarios_Administradores, Contrase�as_Administradores,
                usuarios_Profesores, Contrase�as_Profesores,
                usuarios_Estudiantes, Contrase�as_Estudiantes));
        }
    }
}
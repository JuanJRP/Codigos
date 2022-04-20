namespace Taken
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int aux = 0;
            string[] userR = new string[5];
            string[] passwordR = new string[5];
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio(userR,passwordR,aux));
        }
    }
}
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
            List<string> userList = new List<string>();
            List<string> passwordList = new List<string>();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio(userList,passwordList,aux));
        }
    }
}
namespace Login
{
    public class Persona
    {
        public string usuarioR { get; set; }
        public string contraseñaR { get; set; }
        public string usuarioL { get; set; }
        public string contraseñaL { get; set; }

        //metodo de validacion -------------------------------------------------------------------
        public bool validar()
        {
            bool result = false;
            if (this.usuarioR == this.usuarioL && this.contraseñaR == this.contraseñaL)
            {
                result = true;
            }
            return result;
        }
        //-----------------------------------------------------------------------------------------

        //Menu del switchInico --------------------------------------------------------------------
        public int menuInicio(int ansRegistro = 0)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Ingrese el numero de la opcion");
            Console.WriteLine("");
            Console.WriteLine("1) Registrarse.");
            Console.WriteLine("2) Login.");
            Console.WriteLine("==============================");
            Console.Write("Opcion: ");  
            ansRegistro = int.Parse(Console.ReadLine());
            Console.Clear();
            return ansRegistro;
        }
        //------------------------------------------------------------------------------------------

        //Menu del switchCambios -------------------------------------------------------------------
        public int menuCambios(string user,string contraseña,int ansCasos = 0)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine($"Usuario Actual: {user}");
            Console.WriteLine($"Contraseña Actual: {contraseña}");
            Console.WriteLine("==========================================");
            Console.WriteLine("Ingrese el numero de la opcion");
            Console.WriteLine("");
            Console.WriteLine("1) Cambiar Usuario."); 
            Console.WriteLine("2) Cambiar contraseña.");
            Console.WriteLine("3) Cambiar Usuario y Contraseña.");
            Console.WriteLine("4) Cerrar Sesion");
            Console.WriteLine("==========================================");
            Console.Write("Opcion: ");
            ansCasos = int.Parse(Console.ReadLine());
            Console.Clear();
            return ansCasos;
        }
        //------------------------------------------------------------------------------------------
    }
    public class Principal
    {
        public static void Main()
        {
            bool cerrar = false, sig = false;
            int ansRegistro, ansCasos;
            Persona person = new Persona();

            do
            {
                switch (ansRegistro = person.menuInicio())
                {
                    //Registrarse --------------------------------------------------------------
                    case 1:
                        Console.WriteLine("===========================");
                        Console.WriteLine("Regitrarse");
                        Console.WriteLine("===========================");
                        Console.WriteLine(" ");
                        Console.Write("Usuario: ");
                        person.usuarioR = Console.ReadLine();
                        Console.Write("Contraseña: ");
                        person.contraseñaR = Console.ReadLine();
                        Console.Clear();
                        break;
                    //---------------------------------------------------------------------------

                    //Login----------------------------------------------------------------------
                    case 2:
                        Console.WriteLine("===========================");
                        Console.WriteLine("Login");
                        Console.WriteLine("===========================");
                        Console.WriteLine(" ");
                        Console.Write("Ingrese su usuario: ");
                        person.usuarioL = Console.ReadLine();
                        Console.Write("ingrese su contraseña: ");
                        person.contraseñaL = Console.ReadLine();
                        Console.Clear();
                        //-----------------------------------------------------------------------

                        //Verificar Datos de login con registro----------------------------------
                        if (person.validar() == true)
                        {
                            do
                            {
                                //Menus Casos--------------------------------------------------------
                                switch (ansCasos = person.menuCambios(person.usuarioR, person.contraseñaR))
                                {
                                    //Cambiar contraseña---------------------------------------------
                                    case 1:
                                        Console.Write("Ingrese su nuevo usuario: ");
                                        person.usuarioR = Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    //---------------------------------------------------------------

                                    //Cambiar Usuario------------------------------------------------
                                    case 2:
                                        Console.Write("Ingrese su nueva contraseña: ");
                                        person.contraseñaR = Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    //----------------------------------------------------------------

                                    //Cambiar Usuario y Contraseña------------------------------------
                                    case 3:
                                        Console.Write("Ingrese su nuevo usuario: ");
                                        person.usuarioR = Console.ReadLine();
                                        Console.Write("Ingrese su nueva contraseña: ");
                                        person.contraseñaR = Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    //----------------------------------------------------------------

                                    //Cerrar sesion---------------------------------------------------
                                    case 4:
                                        sig = true;
                                        break;
                                        //----------------------------------------------------------------
                                }
                                //Menus Casos---------------------------------------------------------
                            } while (sig != true);

                        }
                        else
                        {
                            Console.WriteLine("***************************************");
                            Console.WriteLine("La informacion ingresada es incorrecta.");
                            Console.WriteLine("***************************************");
                        }
                        //-------------------------------------------------------------------------
                        break;
                }

            } while (cerrar != true);
        }
    }
}
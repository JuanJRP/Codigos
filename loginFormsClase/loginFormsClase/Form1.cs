namespace loginFormsClase
{
    public partial class Form1 : Form
    {
        public Form1(string pa,string s)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtUL_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            register register = new register();
        }
    }
}

/*namespace sebastian
{
    public class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }

        //crear metodo
        public Persona(string _julian, string _contraseña, string _name)
        {
            this.usuario = _julian;
            this.contraseña = _contraseña;
            this.Name = _name;

        }
        public bool validar(string _name, string _pass)
        {
            bool result = false;
            if (this.usuario == _name && this.contraseña == _pass)
            {
                result = true;
            }

            return result;
        }


    }
    public class Principal
    {
        public static void Main()
        {
            Persona usuario = new Persona("Andrea", "1234", "Sebas");
            Console.WriteLine("usuario  : " + usuario.usuario);
            Console.WriteLine("Contraseña  : " + usuario.contraseña);
            Console.WriteLine("Nombre  : " + usuario.Name);

            string name = "", pass = "";

            do
            {
                Console.WriteLine("Digite usuario");
                name = Console.ReadLine();
                Console.WriteLine("Digite contraseña");
                pass = Console.ReadLine();

            } while (usuario.validar(name, pass) == false);


            if (usuario.validar(name, pass) == true)
            {
                Console.WriteLine("bienvenido");
            }
            else
            {
                Console.WriteLine("Usuario o contraseña erroneo");
            }
        }
    }
}*/
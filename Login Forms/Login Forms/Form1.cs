namespace Login_Forms
{
    public partial class Form1 : Form
    {
        public class Datos2
        {
            public string usuarioL { get; set; }
            public string contraseñaL { get; set; }
            public string usuarioR { get; set; }
            public string contraseñaR { get; set; }
        }
        public Form1(string usuario, string contraseña)
        {
            MessageBox.Show(usuario, contraseña);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos2 datos2 = new Datos2();
            
            datos2.usuarioL = textBox1.Text;
            datos2.contraseñaL = textBox2.Text;

            if(datos2.usuarioR == datos2.usuarioL && datos2.contraseñaR == datos2.contraseñaL)
            {
                MessageBox.Show("si");
            }
            else
            {
                MessageBox.Show($"no {datos2.usuarioL}=={datos2.usuarioR}");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();
            this.Hide();

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
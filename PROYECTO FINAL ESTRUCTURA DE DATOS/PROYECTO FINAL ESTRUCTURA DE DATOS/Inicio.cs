namespace PROYECTO_FINAL_ESTRUCTURA_DE_DATOS
{
    public partial class Inicio : Form
    {
        //Listas-------------------------------------------------------
        List<string> usuarios_Administradores = new List<string>();
        List<string> Contrase�as_Administradores = new List<string>();
        List<string> usuarios_Profesores = new List<string>();
        List<string> Contrase�as_Profesores = new List<string>();
        List<string> usuarios_Estudiantes = new List<string>();
        List<string> Contrase�as_Estudiantes = new List<string>();
        //-------------------------------------------------------------
        public Inicio(List<string> u_Administradores, List<string> C_Administradores,
            List<string> u_Profesores, List<string> C_Profesores,
            List<string> u_Estudiantes, List<string> C_Estudiantes)
        {
            this.usuarios_Administradores = u_Administradores;
            this.Contrase�as_Administradores = C_Administradores;
            this.usuarios_Profesores = u_Profesores;
            this.Contrase�as_Profesores = C_Profesores;
            this.usuarios_Estudiantes = u_Estudiantes;
            this.Contrase�as_Estudiantes = C_Estudiantes;
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matricularse matricularse = new Matricularse(usuarios_Administradores, Contrase�as_Administradores,
                usuarios_Profesores, Contrase�as_Profesores,
                usuarios_Estudiantes, Contrase�as_Estudiantes);
            matricularse.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(usuarios_Administradores, Contrase�as_Administradores,
                usuarios_Profesores, Contrase�as_Profesores, 
                usuarios_Estudiantes, Contrase�as_Estudiantes);
            login.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}

/*

Para la opci�n 1, los requerimientos b�sicos que se deben incluir en el programa es simplemente roles de tutores,
estudiantes y administrativos y que se puedan hacer registros y ver notas de asignaturas y seguimiento, entre otros y
que su equipo considere.

Opci�n dos: Nivel intermedio.
Los equipos que se ubiquen en este nivel, adem�s de las condiciones generales y b�sicas, se acojan a los siguientes
requerimientos propios de este nivel intermedio, si cumplen con todo simplemente sacaran nota de 5,0 directamente en
el proyecto final.
Requerimientos:
1. Donde los administrativos puedan al menos:
a) Registrar estudiantes, tutores, padres y asignaturas
b) Asignar asignaturas por tutores
c) Que se puedan editar asignaturas para todos los grados.
d) Imprimir en f�sico los reportes de calificaciones para entregar notas a los padres cada periodo.
2. Donde los estudiantes puedan:
e) Matricularse con sus datos personales incluyendo nombres completos de sus padres.
f) Ver su seguimiento y sus promedios.
3. Donde los profesores puedan:
a) Ver sus asignaturas con sus alumnos
b) Editar o programar el seguimiento de sus asignaturas con los porcentajes de evaluaci�n por ejemplo 30%,
30% y 40% para un 100%
c) Registrar faltas
d) Ver promedios.
Para este nivel la interfaz gr�fica para el usuario ser�a ideal.
*/
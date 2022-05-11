namespace PROYECTO_FINAL_ESTRUCTURA_DE_DATOS
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matricularse matricularse = new Matricularse();
            matricularse.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

/*

Para la opción 1, los requerimientos básicos que se deben incluir en el programa es simplemente roles de tutores,
estudiantes y administrativos y que se puedan hacer registros y ver notas de asignaturas y seguimiento, entre otros y
que su equipo considere.

Opción dos: Nivel intermedio.
Los equipos que se ubiquen en este nivel, además de las condiciones generales y básicas, se acojan a los siguientes
requerimientos propios de este nivel intermedio, si cumplen con todo simplemente sacaran nota de 5,0 directamente en
el proyecto final.
Requerimientos:
1. Donde los administrativos puedan al menos:
a) Registrar estudiantes, tutores, padres y asignaturas
b) Asignar asignaturas por tutores
c) Que se puedan editar asignaturas para todos los grados.
d) Imprimir en físico los reportes de calificaciones para entregar notas a los padres cada periodo.
2. Donde los estudiantes puedan:
e) Matricularse con sus datos personales incluyendo nombres completos de sus padres.
f) Ver su seguimiento y sus promedios.
3. Donde los profesores puedan:
a) Ver sus asignaturas con sus alumnos
b) Editar o programar el seguimiento de sus asignaturas con los porcentajes de evaluación por ejemplo 30%,
30% y 40% para un 100%
c) Registrar faltas
d) Ver promedios.
Para este nivel la interfaz gráfica para el usuario sería ideal.
*/
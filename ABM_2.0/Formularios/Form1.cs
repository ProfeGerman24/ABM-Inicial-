using Clases;
namespace Formularios
{
    public partial class Form1 : Form
    {
        List<Alumno> listaFormulario;
        public Form1()
        {
            InitializeComponent();
            listaFormulario = new List<Alumno>();

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLista frmListado = new FrmLista(listaFormulario);
            frmListado.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumno nuevoAlumno = new FrmAlumno();
            if (nuevoAlumno.ShowDialog() == DialogResult.OK)
            {
                listaFormulario.Add(nuevoAlumno.AlumnoFormulario);
                MessageBox.Show("Alumno agregado");
            }
            else
            {
                MessageBox.Show("Accion cancelada");

            }
        }
    }
}

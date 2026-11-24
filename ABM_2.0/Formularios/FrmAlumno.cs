using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
namespace Formularios
{
    public partial class FrmAlumno : Form
    {
        Alumno alumnoFormulario;
        public FrmAlumno()
        {
            InitializeComponent();
        }

        public Alumno AlumnoFormulario
        {
            get
            {
                return alumnoFormulario;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int legajo = int.Parse(txtLegajo.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            float nota = float.Parse(txtNota.Text);


            alumnoFormulario = new Alumno(legajo, nombre, apellido, nota);

            this.DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}

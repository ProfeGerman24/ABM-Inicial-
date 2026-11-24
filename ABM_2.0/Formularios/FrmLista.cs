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
    public partial class FrmLista: Form
    {
        List<Alumno> listaFrm;
        public FrmLista()
        {
            InitializeComponent();
        }
        public FrmLista(List<Alumno> lista):this() 
        {
            listaFrm = lista;
            foreach(Alumno a in listaFrm)
            {
                this.listBox1.Items.Add(a.ToString());
            }
        }




    }
}

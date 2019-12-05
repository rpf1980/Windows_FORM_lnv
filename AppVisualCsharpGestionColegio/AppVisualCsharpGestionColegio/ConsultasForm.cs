using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVisualCsharpGestionColegio
{
    public partial class ConsultasForm : Form
    {
        InfoAlumnoForm infoAlumno = null;
        InfoProfesorForm infoProfesor = null;
        InfoAsignaturaForm infoAsignaturas = null;

        public ConsultasForm()
        {
            InitializeComponent();
        }

        //Btn ALUMNO
        private void button1_Click(object sender, EventArgs e)
        {
            infoAlumno = new InfoAlumnoForm();
            infoAlumno.Show();
        }

        //Btn PROFESOR
        private void button2_Click(object sender, EventArgs e)
        {
            infoProfesor = new InfoProfesorForm();
            infoProfesor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            infoAsignaturas = new InfoAsignaturaForm();
            infoAsignaturas.Show();
        }
    }
}

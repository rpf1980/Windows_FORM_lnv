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
    public partial class MenuInicioForm : Form
    {
        // Intancias con las clases Forms de la app
        AlumnoForm alumnoForm = null;
        ProfesorForm profesorForm = null;
        AsignaturasForm asignaturasForm = null;
        ConsultasForm consultasForm = null;

        public MenuInicioForm()
        {
            InitializeComponent();       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Btn ALUMNO
        private void button1_Click(object sender, EventArgs e)
        {
            alumnoForm = new AlumnoForm();
            alumnoForm.Show();
        }

        //Btn PROFESOR
        private void button2_Click(object sender, EventArgs e)
        {
            profesorForm = new ProfesorForm();
            profesorForm.Show();
        }

        // Btn ASIGNATURAS
        private void button3_Click(object sender, EventArgs e)
        {
            asignaturasForm = new AsignaturasForm();
            asignaturasForm.Show();
        }

        private void MenuInicioForm_Load(object sender, EventArgs e)
        {

        }

        // Btn CONSULTAS
        private void button5_Click(object sender, EventArgs e)
        {
            consultasForm = new ConsultasForm();
            consultasForm.Show();          
        }
    }
}

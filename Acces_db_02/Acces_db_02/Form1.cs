using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acces_db_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aLUMNOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aLUMNOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_profesorDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_profesorDataSet.ALUMNOS' Puede moverla o quitarla según sea necesario.
            this.aLUMNOSTableAdapter.Fill(this.db_profesorDataSet.ALUMNOS);

        }

        //=======================   BLOQUE CÓDIGO ALUMNO    ===========================

        //Btn SALIR ( ALUMNO )
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Btn GUARDAR ( ALUMNO )
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Btn MODIFICAR ( ALUMNO )
        private void button3_Click(object sender, EventArgs e)
        {

        }

        //Btn ELIMINAR ( ALUMNO )
        private void button4_Click(object sender, EventArgs e)
        {

        }

        //Btn AÑADIR ( ALUMNO )
        private void idBtnAddAlumno_Click(object sender, EventArgs e)
        {

        }
    }
}

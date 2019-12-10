using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access_bd_01
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
            this.tableAdapterManager.UpdateAll(this.bdatosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdatosDataSet.ASIGNATURA' Puede moverla o quitarla según sea necesario.
            this.aSIGNATURATableAdapter.Fill(this.bdatosDataSet.ASIGNATURA);
            // TODO: esta línea de código carga datos en la tabla 'bdatosDataSet.PROFESORES' Puede moverla o quitarla según sea necesario.
            this.pROFESORESTableAdapter.Fill(this.bdatosDataSet.PROFESORES);
            // TODO: esta línea de código carga datos en la tabla 'bdatosDataSet.ALUMNOS' Puede moverla o quitarla según sea necesario.
            this.aLUMNOSTableAdapter.Fill(this.bdatosDataSet.ALUMNOS);

        }

        //==================  BLOQUE CÓDIGO ALUMNO  =====================

        //Btn SALIR ALUMNO
        private void idBtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Btn AÑADIR ALUMNO
        private void idBtnAdd_Click(object sender, EventArgs e)
        {
            //Para agregar nuevo registro
            aLUMNOSBindingSource.AddNew();

            panelAlumno.Enabled = true;     //Habilitamos panel de campos
            idBtnGuardar.Enabled = true;    //Habilitamos btn GUARDAR

            //Situamos el foco en en campo dni
            dniTextBox.Focus();
        }

        //Btn MODIFICAR ALUMNO
        private void idBtnModificar_Click(object sender, EventArgs e)
        {
            panelAlumno.Enabled = true;
            idBtnGuardar.Enabled = true;
            dniTextBox.Focus();
        }

        //Btn GUARDAR ALUMNO
        private void idBtnGuardar_Click(object sender, EventArgs e)
        {
            this.aLUMNOSBindingSource.EndEdit();
            this.aLUMNOSTableAdapter.Update(bdatosDataSet.ALUMNOS);
            this.aLUMNOSDataGridView.Refresh();

            panelAlumno.Enabled = false;
            idBtnGuardar.Enabled = false;
            MessageBox.Show("Origen de datos actualizados");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bdatosDataSet.HasChanges())
            {
                this.aLUMNOSTableAdapter.Update(this.bdatosDataSet.ALUMNOS);
                this.pROFESORESTableAdapter.Update(this.bdatosDataSet.PROFESORES);
                this.bdatosDataSet.AcceptChanges();
                             
                MessageBox.Show("Origen de datos actualizados");
            }
        }

        //==================  BLOQUE CÓDIGO PROFESOR  =====================

        //Btn SALIR PROFESOR
        private void idBtnSalirProf_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Btn AÑADIR PROFESOR
        private void idBtnAddProf_Click(object sender, EventArgs e)
        {
            //Para agregar nuevo registro
            pROFESORESBindingSource.AddNew();

            panelProf.Enabled = true;           //Habilitamos panel de campos
            idBtnGuardarProf.Enabled = true;    //Habilitamos btn GUARDAR

            //Situamos el foco en en campo dni
            dniTextProf.Focus();
        }

        //Btn MODIFICAR PROFESOR
        private void button3_Click(object sender, EventArgs e)
        {
            panelProf.Enabled = true;
            idBtnGuardarProf.Enabled = true;
            dniTextProf.Focus();
        }

        //Btn GUARDAR PROFESOR
        private void idBtnGuardarProf_Click(object sender, EventArgs e)
        {
            this.pROFESORESBindingSource.EndEdit();
            this.pROFESORESTableAdapter.Update(bdatosDataSet.PROFESORES);
            this.pROFESORESDataGridView.Refresh();

            panelProf.Enabled = false;
            idBtnGuardarProf.Enabled = false;
            MessageBox.Show("Origen de datos actualizados");
        }

        //==================  BLOQUE CÓDIGO ASIGNATURA  =====================

        //Btn SALIR ASIG
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Btn AÑADIR ASIG
        private void idBtnAddAsig_Click(object sender, EventArgs e)
        {
            //Para agregar nuevo registro
            aSIGNATURABindingSource.AddNew();

            panelAsig.Enabled = true;           //Habilitamos panel de campos
            idBtnGuardarAsig.Enabled = true;    //Habilitamos btn GUARDAR

            //Situamos el foco en en campo dni
            idNombreAsig.Focus();
        }

        //Btn GUARDAR ASIG
        private void idBtnGuardarAsig_Click(object sender, EventArgs e)
        {
            this.aSIGNATURABindingSource.EndEdit();
            this.aSIGNATURATableAdapter.Update(bdatosDataSet.ASIGNATURA);
            this.aSIGNATURADataGridView.Refresh();

            panelAsig.Enabled = false;
            idBtnGuardarAsig.Enabled = false;
            MessageBox.Show("Origen de datos actualizados");
        }

        //Btn MODIFICAR ASIG
        private void idBtnModAsig_Click(object sender, EventArgs e)
        {
            panelAsig.Enabled = true;
            idBtnGuardarAsig.Enabled = true;
            idNombreAsig.Focus();
        }

        //Btn ELIMINAR ASIG
        private void idBtnEliminarAsig_Click(object sender, EventArgs e)
        {

        }
    }
}

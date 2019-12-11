using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessProyecto_09
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
            this.tableAdapterManager.UpdateAll(this.dataAcces_09DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataAcces_09DataSet.ASIGNATURA' Puede moverla o quitarla según sea necesario.
            this.aSIGNATURATableAdapter.Fill(this.dataAcces_09DataSet.ASIGNATURA);
            // TODO: esta línea de código carga datos en la tabla 'dataAcces_09DataSet.PROFESORES' Puede moverla o quitarla según sea necesario.
            this.pROFESORESTableAdapter.Fill(this.dataAcces_09DataSet.PROFESORES);
            // TODO: esta línea de código carga datos en la tabla 'dataAcces_09DataSet.ALUMNOS' Puede moverla o quitarla según sea necesario.
            this.aLUMNOSTableAdapter.Fill(this.dataAcces_09DataSet.ALUMNOS);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dataAcces_09DataSet.HasChanges())
            {
                this.aLUMNOSTableAdapter.Update(this.dataAcces_09DataSet.ALUMNOS);
                this.pROFESORESTableAdapter.Update(this.dataAcces_09DataSet.PROFESORES);
                this.dataAcces_09DataSet.AcceptChanges();
            }
        }

        //================  BLOQUE CÓDIGO ALUMNOS ==================

        //Btn AÑADIR ( Alumno )
        private void idBtnAddAlumno_Click(object sender, EventArgs e)
        {
            //Para agregar nuevo registro
            aLUMNOSBindingSource.AddNew();

            panelAlumno.Enabled = true;     //Habilitamos panel de campos
            idBtnGuardarAlumno.Enabled = true;    //Habilitamos btn GUARDAR

            //Situamos el foco en en campo dni
            idTxtDniAlumno.Focus();
        }

        //Btn GUARDAR ( Alumno )
        private void idBtnGuardarAlumno_Click(object sender, EventArgs e)
        {
            this.aLUMNOSBindingSource.EndEdit();
            this.aLUMNOSTableAdapter.Update(dataAcces_09DataSet.ALUMNOS);
            this.aLUMNOSDataGridView.Refresh();

            panelAlumno.Enabled = false;
            idBtnGuardarAlumno.Enabled = false;
            MessageBox.Show("Origen de datos actualizados");
        }

        //Btn MODIFICAR ( Alumno )
        private void idBtnModifAlumno_Click(object sender, EventArgs e)
        {
            panelAlumno.Enabled = true;
            idBtnGuardarAlumno.Enabled = true;
            idTxtDniAlumno.Focus();
        }

        //Btn ELIMINAR ( Alumno )
        private void idBtnEliminarAlumno_Click(object sender, EventArgs e)
        {
            aLUMNOSBindingSource.RemoveCurrent();
            MessageBox.Show("Origen de datos actualizados");
        }

        //Btn SALIR ( Alumno )
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aLUMNOSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //================  BLOQUE CÓDIGO PROFESORES ==================

        //Btn AÑADIR ( Profesores )
        private void idBtnAddProf_Click(object sender, EventArgs e)
        {
           
            pROFESORESBindingSource.AddNew();
            panelProfesor.Enabled = true;
            idBtnGuardarProf.Enabled = true;

            //Situamos el foco en en campo dni
            idTxtDniProf.Focus();
        }

        //Btn GUARDAR ( Profesores )
        private void idBtnGuardarProf_Click(object sender, EventArgs e)
        {
            this.pROFESORESBindingSource.EndEdit();
            this.pROFESORESTableAdapter.Update(dataAcces_09DataSet.PROFESORES);
            this.pROFESORESDataGridView.Refresh();

            panelProfesor.Enabled = false;
            idBtnGuardarProf.Enabled = false;
            MessageBox.Show("Origen de datos actualizados");
        }

        //Btn MODIFICAR ( Profesores )
        private void idBtnModProf_Click(object sender, EventArgs e)
        {
            panelProfesor.Enabled = true;
            idBtnGuardarProf.Enabled = true;
            idTxtDniProf.Focus();
        }

        //Btn ELIMINAR ( Profesores )
        private void idBtnEliminarProf_Click(object sender, EventArgs e)
        {
            pROFESORESBindingSource.RemoveCurrent();
            MessageBox.Show("Origen de datos actualizados");
        }

        //Btn SALIR ( Profesores )
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //===============   BLOQUE CÓDIGO ASIGNATURA  ================

        //Btn AÑADIR ( Asignatura )
        private void idBtnAddAsig_Click(object sender, EventArgs e)
        {
            aSIGNATURABindingSource.AddNew();
            panelAsig.Enabled = true;
            idBtnGuardarAsig.Enabled = true;

            //Situamos el foco en en campo dni
            idTxtIdAsig.Focus();
        }

        //Btn GUARDAR ( Asignatura )
        private void idBtnGuardarAsig_Click(object sender, EventArgs e)
        {
            this.aSIGNATURABindingSource.EndEdit();
            this.aSIGNATURATableAdapter.Update(dataAcces_09DataSet.ASIGNATURA);
            //this.aSIGNATURADataGridView.Refresh();

            panelAsig.Enabled = false;
            idBtnGuardarAsig.Enabled = false;
            MessageBox.Show("Origen de datos actualizados");
        }

        //Btn MODIFICAR ( Asignatura )
        private void idBtnModifAsig_Click(object sender, EventArgs e)
        {
            panelAsig.Enabled = true;
            idBtnGuardarAsig.Enabled = true;
            idTxtIdAsig.Focus();
        }

        //Btn ELIMINAR ( Asignatura )
        private void idBtnEliminarAsig_Click(object sender, EventArgs e)
        {
            aSIGNATURABindingSource.RemoveCurrent();
            MessageBox.Show("Origen de datos actualizados");
        }

        //Btn SALIR ( Asignatura )
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
    }
}

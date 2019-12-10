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
            // TODO: esta línea de código carga datos en la tabla 'db_profesorDataSet.PROFESORES' Puede moverla o quitarla según sea necesario.
            this.pROFESORESTableAdapter.Fill(this.db_profesorDataSet.PROFESORES);
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
            this.aLUMNOSBindingSource.EndEdit();
            this.aLUMNOSTableAdapter.Update(db_profesorDataSet.ALUMNOS);
            this.aLUMNOSDataGridView.Refresh();

            panelAlumno.Enabled = false;
            idBtnGuardarAlumno.Enabled = false;
            MessageBox.Show("Origen de datos actualizados");
        }

        //Btn MODIFICAR ( ALUMNO )
        private void button3_Click(object sender, EventArgs e)
        {
            panelAlumno.Enabled = true;
            idBtnGuardarAlumno.Enabled = true;
            idTxtDniAlumno.Focus();
        }

        //Btn ELIMINAR ( ALUMNO )
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el registro?", "Borra registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.aLUMNOSTableAdapter.Delete(Convert.ToInt32(idTxtDniAlumno.Text));
                this.db_profesorDataSet.PROFESORES.Rows.RemoveAt(this.aLUMNOSDataGridView.CurrentCell.RowIndex);
                this.aLUMNOSTableAdapter.Update(db_profesorDataSet.ALUMNOS);
            }
        }

        //Btn AÑADIR ( ALUMNO )
        private void idBtnAddAlumno_Click(object sender, EventArgs e)
        {
            //Para agregar nuevo registro
            aLUMNOSBindingSource.AddNew();

            panelAlumno.Enabled = true;     //Habilitamos panel de campos
            idBtnGuardarAlumno.Enabled = true;    //Habilitamos btn GUARDAR

            //Situamos el foco en en campo dni
            idTxtDniAlumno.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (db_profesorDataSet.HasChanges())
            {
                this.aLUMNOSTableAdapter.Update(this.db_profesorDataSet.ALUMNOS);
                
                this.db_profesorDataSet.AcceptChanges();

                MessageBox.Show("Origen de datos actualizados");
            }
        }
    }
}

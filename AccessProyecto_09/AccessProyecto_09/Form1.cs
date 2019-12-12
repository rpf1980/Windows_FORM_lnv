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
        int posicion = 0;
        DataTable t = new DataTable("CONSULTA_EDAD");       
        DataRow r;
        List<string> listaResultado = new List<string>();

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

        //Btn CONSULTA MAYOR 21 AÑOS
        private void button1_Click(object sender, EventArgs e)
        {
            t.Columns.Add("dni", typeof(string));
            t.Columns.Add("nombre", typeof(string));
            t.Columns.Add("direccion", typeof(string));
            t.Columns.Add("telefono", typeof(int));
            t.Columns.Add("fecha", typeof(DateTime));

            //Recorremos la tabla alumnos para buscar la consulta ( edad > 21 )

            for (int i = 0; i < dataAcces_09DataSet.ALUMNOS.Rows.Count; i++)
            {
                for (int j = 0; j < tablaMayorEdad.Rows.Count; j++)
                {
                    DateTime nacimiento = Convert.ToDateTime(dataAcces_09DataSet.ALUMNOS.Rows[i]["F_NACIM"].ToString());
                    int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;

                    if (edad > 21)
                    {
                        // Creamos un array con los valores que vamos a insertar
                        // en el segundo control DataGridView.
                        object[] valores = {dataAcces_09DataSet.ALUMNOS.Rows[i]["DNI"].ToString(),
                                            dataAcces_09DataSet.ALUMNOS.Rows[i]["NOMBRE"].ToString(),
                                            dataAcces_09DataSet.ALUMNOS.Rows[i]["DIRECCION"].ToString(),
                                            dataAcces_09DataSet.ALUMNOS.Rows[i]["TELEFONO"].ToString(),
                                            dataAcces_09DataSet.ALUMNOS.Rows[i]["F_NACIM"].ToString()};

                        //Creamos un nuevo objeto DataGridRow()
                        DataGridViewRow row = new DataGridViewRow();

                        // Creamos las celdas y las rellenamos con los valores existentes
                        // en el array.

                        //https://social.msdn.microsoft.com/Forums/es-ES/0587f655-d437-4270-837d-5c3707e68cc5/pasar-filas-seleccionadas-de-un-datagridview-a-otro-y-ese-otro-convertirlo-en-un-datatable-c-2010?forum=netfxes
                        row.CreateCells(aLUMNOSDataGridView, valores);
                    }
                }                
            }
        } 
    }
}

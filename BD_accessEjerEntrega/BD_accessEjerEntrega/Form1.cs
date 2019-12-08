using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_accessEjerEntrega
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
            this.tableAdapterManager.UpdateAll(this.bD_ejercicioAccessDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_ejercicioAccessDataSet.ALUMNOS' Puede moverla o quitarla según sea necesario.
            this.aLUMNOSTableAdapter.Fill(this.bD_ejercicioAccessDataSet.ALUMNOS);

        }
    }
}

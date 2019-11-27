using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo01_db
{
    public partial class FormBaseDatos : Form
    {
        public FormBaseDatos()
        {
            InitializeComponent();           
        }

        //btn ATRÁS
        private void button1_Click(object sender, EventArgs e)
        {
            personalBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personalBindingSource.MoveNext();
        }

        private void FormBaseDatos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejemplo1DataSet.Ejemplo1' Puede moverla o quitarla según sea necesario.
            //this.tableAdapterManager1.Fill(form2DataSet.Ejemplo1);
        }
    }
}

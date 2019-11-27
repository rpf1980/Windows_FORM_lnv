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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejemplo1DataSet.Ejemplo1' Puede moverla o quitarla según sea necesario.
            this.ejemplo1TableAdapter.Fill(this.ejemplo1DataSet.Ejemplo1);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ejemplo1DataSet.HasChanges())
            {
                this.ejemplo1TableAdapter.Update(this.ejemplo1DataSet.Ejemplo1);
                this.ejemplo1DataSet.AcceptChanges();
                MessageBox.Show("Origen de datos actualizado");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoFicherosXML
{
    public partial class Form1 : Form
    {
        CamposRegistro formAddcliente = null;
        ModificaForm formModificar = null;
        MostrarDatosForm mostrarDatosForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        // Pasamos al siguiente FORM
        private void button1_Click(object sender, EventArgs e)
        {
            // Vamos al form que permite rellenar los campos de 
            // registro de nuestro cliente
            formAddcliente = new CamposRegistro();
            formAddcliente.Show();
        }

        // MODIFICAR CLIENTES
        private void button2_Click(object sender, EventArgs e)
        {
            // Pasamos a la vista CamposRegistro
            formModificar = new ModificaForm();
            formModificar.Show();          
        }


        // MOSTRAR DATOS
        private void button4_Click(object sender, EventArgs e)
        {
            // Pasamos a MostrarDatosForm
            mostrarDatosForm = new MostrarDatosForm();
            mostrarDatosForm.Show();
        }
    }
}

﻿using System;
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
        CamposRegistro formAddcliente = new CamposRegistro();

        public Form1()
        {
            InitializeComponent();
        }

        // Pasamos al siguiente FORM
        private void button1_Click(object sender, EventArgs e)
        {
            // Vamos al form que permite rellenar los campos de 
            // registro de nuestro cliente
            formAddcliente.Show();
        }

        // MODIFICAR CLIENTES
        private void button2_Click(object sender, EventArgs e)
        {
            // Pasamos a la vista CamposRegistro
            formAddcliente.Show();

            // Cargamos datos del cliente en los campos


            // Guardamos los cambios 
        }
    }
}

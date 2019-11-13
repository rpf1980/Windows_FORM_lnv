using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace BancoFicherosXML
{
    public partial class CamposRegistro : Form
    {
        string strDni = "";
        string strNombre = "";
        string strDireccion = "";
        int edad = 0;
        int tlfn = 0;
        int cc = 0;

        List<Cliente> listaClientes = new List<Cliente>();

        public CamposRegistro()
        {
            InitializeComponent();
        }

        private void CamposRegistro_Load(object sender, EventArgs e)
        {

        }

        // Btn GUARDAR ( aquí va la lógica del creación del xml y registro de datos
        private void idGuardarRegistro_Click(object sender, EventArgs e)
        {
            FileStream fichero = new FileStream("datos.xml", FileMode.Create);
            Cliente cliente = new Cliente();
            Banco banco = new Banco();

            // Guardamos los campos registrados
            strDni = idDniRegistro.Text;
            strNombre = idRegistroNombre.Text;
            strDireccion = idDireccRegistro.Text;
            edad = Convert.ToInt32(idEdadRegistro.Text);
            tlfn = Convert.ToInt32(idTlfnRegistro.Text);
            cc = Convert.ToInt32(idCCregistro.Text);

            // Damos valores a los atributos del objeto cliente
            cliente.Dni = strDni;
            cliente.Nombre = strNombre;
            cliente.Direccion = strDireccion;
            cliente.Edad = edad;
            cliente.Tlfn = tlfn;
            cliente.Cc = cc;

            // Añadimos el cliente a la lista del objeto banco
            banco.AddCliente(cliente);

            // Creamos el fichero XML
            
        }
    }
}

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

        // Objeto BANCO creado en ámbito global de clase
        // para que NO se machaquen los datos de los clientes en la lista
        Banco banco = new Banco();

        public CamposRegistro()
        {
            InitializeComponent();
        }

        public CamposRegistro(Banco banco)
        {
            this.banco = banco;
        }

        private void CamposRegistro_Load(object sender, EventArgs e)
        {

        }

        // Btn GUARDAR ( aquí va la lógica del creación del xml y registro de datos
        private void idGuardarRegistro_Click(object sender, EventArgs e)
        {          
            FileStream fichero = new FileStream("data.xml", FileMode.Create);
            Cliente cliente = new Cliente();         

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

            // Creamos el formateador XML
            XmlSerializer format = new XmlSerializer(banco.GetType());
            format.Serialize(fichero, banco);

            fichero.Close();
        }

        // LIMPIAR campos del form
        private void idLimpiarRegistro_Click(object sender, EventArgs e)
        {           
            idDniRegistro.Text = "";
            idRegistroNombre.Text = "";
            idDireccRegistro.Text = "";
            idEdadRegistro.Text = "";
            idTlfnRegistro.Text = "";
            idCCregistro.Text = "";
        }
    }
}

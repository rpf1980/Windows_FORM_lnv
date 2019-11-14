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
using System.Xml.Linq;

namespace BancoFicherosXML
{
    public partial class ModificaForm : Form
    {
        int pos = -1;
        Banco banco = new Banco();
        Cliente cliente = new Cliente();

        public ModificaForm()
        {
            InitializeComponent();
        }

        // Btn SIGUIENTE
        private void button1_Click(object sender, EventArgs e)
        {                               
            FileStream fichero = new FileStream("data.xml", FileMode.Open);     

            // Ingresa el DNI y guardamos su valor
            string strDni = idTextDni.Text;

            //Creamos el formateador XML
            XmlSerializer format = new XmlSerializer(banco.GetType());
            
            // Aquí queda deserializado el XML y guarda la lista de clientes
            banco = (Banco)format.Deserialize(fichero);          

            // Recorremos la lista de clientes para validar el DNI que buscamos
            for (int i = 0; i < banco.ListaClientes.Count; i++)
            {
                if (banco.ListaClientes[i].Dni == strDni)
                {
                    pos = i; // Aquí tenemos la posición del cliente en la lista 
                    cliente = banco.ListaClientes[i];
                    i = banco.ListaClientes.Count;
                }
            }
            fichero.Close();

            // Asignamos los datos del cliente a cada texbox          
            idCampoStrDni.Text = cliente.Dni;
            idTextNombre.Text = cliente.Nombre;
            idTextDireccion.Text = cliente.Direccion;
            idTextEdad.Text = Convert.ToString(cliente.Edad);
            idTextTlfn.Text = Convert.ToString(cliente.Tlfn);
            idTextCC.Text = Convert.ToString(cliente.Cc);
        }


        // Btn MODIFICAR
        private void button2_Click(object sender, EventArgs e)
        {
            string strDni = "";
            string strNombre = "";
            string strDireccion = "";
            int edad = 0;
            int tlfn = 0;
            int cc = 0;

            FileStream fichero = new FileStream("data.xml", FileMode.Create);
            
            // Guardamos los campos registrados
            strDni = idCampoStrDni.Text;
            strNombre = idTextNombre.Text;
            strDireccion = idTextDireccion.Text;
            edad = Convert.ToInt32(idTextEdad.Text);
            tlfn = Convert.ToInt32(idTextTlfn.Text);
            cc = Convert.ToInt32(idTextCC.Text);

            // Damos valores a los atributos del objeto cliente
            cliente.Dni = strDni;
            cliente.Nombre = strNombre;
            cliente.Direccion = strDireccion;
            cliente.Edad = edad;
            cliente.Tlfn = tlfn;
            cliente.Cc = cc;

            // Añadimos el cliente a la lista del objeto banco
            // Si pos no es igual a -1 quiere decir que hay un cliente seleccionado y podríamos modificarlo
            if(pos != -1)
            {
                banco.ModificarCliente(cliente, pos);

                // Creamos el formateador XML
                XmlSerializer format = new XmlSerializer(banco.GetType());
                format.Serialize(fichero, banco);
            }         
            fichero.Close();
        }


        // ELIMINAR CLIENTE
        private void idBtnEliminar_Click(object sender, EventArgs e)
        {
            FileStream fichero = new FileStream("data.xml", FileMode.Create);

            if (pos != -1)
            {
                banco.EliminaCliente(pos);

                // Creamos el formateador XML
                XmlSerializer format = new XmlSerializer(banco.GetType());
                format.Serialize(fichero, banco);
            }
            fichero.Close();

            // Poner campos vacíos
        }
    }
}

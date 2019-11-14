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
    public partial class ModificaForm : Form
    {
        Banco banco = new Banco();
        //CamposRegistro formRegistro = new CamposRegistro(banco);

        public ModificaForm()
        {
            InitializeComponent();
        }

        // Btn SIGUIENTE
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Banco banco = new Banco();
            FileStream fichero;
            fichero = new FileStream("datos.xml", FileMode.Open);

            // Ingresa el DNI y guardamos su valor
            string strDni = idTextDni.Text;

            //Creamos el formateador XML
            XmlSerializer format = new XmlSerializer(banco.GetType());
            format.Serialize(fichero, banco);

            // Leemos datos del XML
            
            while (fichero.Position < fichero.Length)
            {
                banco = (Banco)format.Deserialize(fichero);
            }

            //foreach(banco.ListaClientes : items)
            //{

            //}
            fichero.Close();
            //Console.WriteLine("Nombre Empleado:{0}", emp2.LE[1].Nombre);

        }
    }
}

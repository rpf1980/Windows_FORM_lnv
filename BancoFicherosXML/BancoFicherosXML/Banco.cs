using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFicherosXML
{
    class Banco
    {
        //Atributos
        List<Cliente> listaClientes = new List<Cliente>();

        //Constructores
        public Banco() {}

        public Banco(List<Cliente> listaClientes)
        {
            this.ListaClientes = listaClientes;
        }

        //Getter && Setter
        internal List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }
        
        //Métodos
        public void AddCliente(Cliente cliente)
        {
            this.listaClientes.Add(cliente);
        }

        /*private string dni;
        private string nombre;
        private string direccion;
        private int edad;
        private int tlfn;
        private int cc;*/

        public Cliente ModificarCliente(string dni)
        {
            Cliente cli = null;
            for (int i = 0; i < this.listaClientes.Count; i++)
            {
                string docDni = this.listaClientes[i].Dni;

                if(docDni.Equals(dni))
                {
                    cli = this.listaClientes[i];
                }
            }
            return cli;
        }
        
        public void EliminaCliente(Cliente cliente)
        {
            for (int i = 0; i < this.listaClientes.Count; i++)
            {
                if(this.listaClientes[i] == cliente)
                {
                    this.listaClientes.RemoveAt(i);
                }
            }
        }
    }
}

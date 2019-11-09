using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorV05
{
    public partial class FormPaginaInicio : Form
    {
        public string strNewPagInit;

        public FormPaginaInicio()
        {
            InitializeComponent();
        }

        public FormPaginaInicio(string strPaginaInicio)
        {
            InitializeComponent();
            this.strNewPagInit = "";
        }

        private void FormPaginaInicio_Load(object sender, EventArgs e)
        {

        }

        Form1 form1 = null;
        private void button1_Click(object sender, EventArgs e)
        {
            //this.strNewPagInit = richTextBox1.Text;
            this.Dispose();
        }
    }
}

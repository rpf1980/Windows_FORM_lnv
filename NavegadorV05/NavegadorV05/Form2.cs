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
    public partial class Form2 : Form
    {
        public Form2(string strQuevieneDelForm1)
        {
            InitializeComponent();
            listBox1.Items.Add(strQuevieneDelForm1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        Form1 instanciaForm1 = null;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clickItem = listBox1.SelectedItem.ToString();
            instanciaForm1 = new Form1();
            instanciaForm1.idTbUrl.Text = clickItem;
        }
    }
}

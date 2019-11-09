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
    public partial class Form1 : Form
    {
        static string strPaginaInicio = "https://www.google.es/search?q=";

        public Form1()
        {
            InitializeComponent();

            //Adaptar formulario al screen de nuestro pc
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        //Al cargar la APP
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.es");
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webBrowser1.DocumentTitle;
        }

        //Click GO ( flechita tras url )
        Form2 ff22 = null;
        private void idBtnUrl_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
                web.Navigate(idTbUrl.Text);
            ff22 = new Form2(web.Url.ToString());
        }

        //Click NUEVA PESTAÑA
        WebBrowser webTab = null;
        private void idTstripNewTab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Nueva pestaña";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("https://www.google.es");
            idTbUrl.Text = "https://www.google.es";
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
        }

        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1 = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            tabControl1.SelectedTab.Text = webTab.DocumentTitle;
        }

        //Click BACK
        private void idTstripBack_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if(web != null)
            {
                if (web.CanGoBack)
                    web.GoBack();
            }
        }

        //Click FORWARD
        private void idTstripGoForward_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                    web.GoForward();
            }
        }

        //Click Enter en url direcciones
        private void idTbUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)ConsoleKey.Enter)
            {
                WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(idTbUrl.Text);                  
                }
            }                       
        }

        //Click ELIMINAR PESTAÑA
        private void idTstripRemoveTab_Click(object sender, EventArgs e)
        {
            if(tabControl1.TabCount > 1)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                this.tabControl1.SelectedIndex = this.tabControl1.TabCount - 2;
            }
        }

        //Click REFRESH
        private void idTstripRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        //Click HOME
        private void idTstripHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        //Click estrellita FAVORITO ( es uno de los botones se ven directamente sin abrir nada )
        private void idTstripFavorite_Click(object sender, EventArgs e)
        {
            idListaFavoritos.Items.Add(webBrowser1.Url.ToString());
        }

        //Click cuando seleccionamos Item de LISTA FAVORITOS ( comboBox dentro de CONFIGURACIÓN )
        private void idListaFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1 = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            webBrowser1.Navigate(idListaFavoritos.SelectedItem.ToString());
        }

        //Click GUARDAR
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        //Click VISTA PREVIA
        private void vistaPreviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        //Click IMPRIMIR
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        //Click SALIR
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Click CONFIGURAR PÁGINA
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPageSetupDialog();
        }

        //Click HISTORIAL

        private void idHistorial_Click(object sender, EventArgs e)
        {
            ff22.Show();
        }

        //Click PROPIEDADES
        private void pROPIEDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPropertiesDialog();
        }

        //Click HISTORIAL   
        private void idConfigHistorial_Click(object sender, EventArgs e)
        {
            ff22.Show();
        }


        //Click PÁGINA INICIO
        FormPaginaInicio formPagInit = null;
        private void páginaInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPagInit = new FormPaginaInicio();
            formPagInit.Show();
        }


        //Click BÚSQUEDA
        private void búsquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }
    }
}

namespace NavegadorV05
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MENU = new System.Windows.Forms.MenuStrip();
            this.aRCHIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURACIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idListaFavoritos = new System.Windows.Forms.ToolStripComboBox();
            this.pROPIEDADESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonesMenu = new System.Windows.Forms.ToolStrip();
            this.BarraUrl = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.idTbUrl = new System.Windows.Forms.ToolStripTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.idBtnUrl = new System.Windows.Forms.ToolStripButton();
            this.idTstripBack = new System.Windows.Forms.ToolStripButton();
            this.idTstripGoForward = new System.Windows.Forms.ToolStripButton();
            this.idTstripRefresh = new System.Windows.Forms.ToolStripButton();
            this.idTstripHome = new System.Windows.Forms.ToolStripButton();
            this.idTstripFavorite = new System.Windows.Forms.ToolStripButton();
            this.idTstripNewTab = new System.Windows.Forms.ToolStripButton();
            this.idTstripRemoveTab = new System.Windows.Forms.ToolStripButton();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaPreviaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páginaInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idConfigHistorial = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU.SuspendLayout();
            this.BotonesMenu.SuspendLayout();
            this.BarraUrl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENU
            // 
            this.MENU.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRCHIVOToolStripMenuItem,
            this.cONFIGURACIÓNToolStripMenuItem,
            this.pROPIEDADESToolStripMenuItem});
            this.MENU.Location = new System.Drawing.Point(0, 0);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(800, 30);
            this.MENU.TabIndex = 0;
            this.MENU.Text = "MENU";
            // 
            // aRCHIVOToolStripMenuItem
            // 
            this.aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.vistaPreviaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.imprimirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            this.aRCHIVOToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.aRCHIVOToolStripMenuItem.Text = "ARCHIVO";
            // 
            // cONFIGURACIÓNToolStripMenuItem
            // 
            this.cONFIGURACIÓNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.páginaInicioToolStripMenuItem,
            this.idConfigHistorial,
            this.búsquedaToolStripMenuItem,
            this.idListaFavoritos});
            this.cONFIGURACIÓNToolStripMenuItem.Name = "cONFIGURACIÓNToolStripMenuItem";
            this.cONFIGURACIÓNToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.cONFIGURACIÓNToolStripMenuItem.Text = "CONFIGURACIÓN";
            // 
            // idListaFavoritos
            // 
            this.idListaFavoritos.Name = "idListaFavoritos";
            this.idListaFavoritos.Size = new System.Drawing.Size(121, 28);
            this.idListaFavoritos.Text = "LISTA FAVORITOS";
            this.idListaFavoritos.SelectedIndexChanged += new System.EventHandler(this.idListaFavoritos_SelectedIndexChanged);
            // 
            // pROPIEDADESToolStripMenuItem
            // 
            this.pROPIEDADESToolStripMenuItem.Name = "pROPIEDADESToolStripMenuItem";
            this.pROPIEDADESToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.pROPIEDADESToolStripMenuItem.Text = "PROPIEDADES";
            this.pROPIEDADESToolStripMenuItem.Click += new System.EventHandler(this.pROPIEDADESToolStripMenuItem_Click);
            // 
            // BotonesMenu
            // 
            this.BotonesMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BotonesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idTstripBack,
            this.idTstripGoForward,
            this.idTstripRefresh,
            this.idTstripHome,
            this.idTstripFavorite,
            this.idTstripNewTab,
            this.idTstripRemoveTab});
            this.BotonesMenu.Location = new System.Drawing.Point(0, 30);
            this.BotonesMenu.Name = "BotonesMenu";
            this.BotonesMenu.Size = new System.Drawing.Size(800, 31);
            this.BotonesMenu.TabIndex = 1;
            this.BotonesMenu.Text = "toolStrip1";
            // 
            // BarraUrl
            // 
            this.BarraUrl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraUrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.idTbUrl,
            this.idBtnUrl});
            this.BarraUrl.Location = new System.Drawing.Point(0, 61);
            this.BarraUrl.Name = "BarraUrl";
            this.BarraUrl.Size = new System.Drawing.Size(800, 31);
            this.BarraUrl.TabIndex = 2;
            this.BarraUrl.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(118, 28);
            this.toolStripLabel1.Text = "DIRECCIÓN URL:";
            // 
            // idTbUrl
            // 
            this.idTbUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idTbUrl.Name = "idTbUrl";
            this.idTbUrl.Size = new System.Drawing.Size(300, 31);
            this.idTbUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTbUrl_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 358);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(786, 323);
            this.webBrowser1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // idBtnUrl
            // 
            this.idBtnUrl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.idBtnUrl.Image = global::NavegadorV05.Properties.Resources.go;
            this.idBtnUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.idBtnUrl.Name = "idBtnUrl";
            this.idBtnUrl.Size = new System.Drawing.Size(29, 28);
            this.idBtnUrl.Text = "toolStripButton1";
            this.idBtnUrl.Click += new System.EventHandler(this.idBtnUrl_Click);
            // 
            // idTstripBack
            // 
            this.idTstripBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.idTstripBack.Image = global::NavegadorV05.Properties.Resources.left_icon;
            this.idTstripBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.idTstripBack.Name = "idTstripBack";
            this.idTstripBack.Size = new System.Drawing.Size(29, 28);
            this.idTstripBack.Text = "toolStripButton1";
            this.idTstripBack.Click += new System.EventHandler(this.idTstripBack_Click);
            // 
            // idTstripGoForward
            // 
            this.idTstripGoForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.idTstripGoForward.Image = global::NavegadorV05.Properties.Resources.right_icon;
            this.idTstripGoForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.idTstripGoForward.Name = "idTstripGoForward";
            this.idTstripGoForward.Size = new System.Drawing.Size(29, 28);
            this.idTstripGoForward.Text = "toolStripButton2";
            this.idTstripGoForward.Click += new System.EventHandler(this.idTstripGoForward_Click);
            // 
            // idTstripRefresh
            // 
            this.idTstripRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.idTstripRefresh.Image = global::NavegadorV05.Properties.Resources.Arrow_reload_5_icon;
            this.idTstripRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.idTstripRefresh.Name = "idTstripRefresh";
            this.idTstripRefresh.Size = new System.Drawing.Size(29, 28);
            this.idTstripRefresh.Text = "toolStripButton3";
            this.idTstripRefresh.Click += new System.EventHandler(this.idTstripRefresh_Click);
            // 
            // idTstripHome
            // 
            this.idTstripHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.idTstripHome.Image = global::NavegadorV05.Properties.Resources.house;
            this.idTstripHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.idTstripHome.Name = "idTstripHome";
            this.idTstripHome.Size = new System.Drawing.Size(29, 28);
            this.idTstripHome.Text = "toolStripButton4";
            this.idTstripHome.Click += new System.EventHandler(this.idTstripHome_Click);
            // 
            // idTstripFavorite
            // 
            this.idTstripFavorite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.idTstripFavorite.Image = global::NavegadorV05.Properties.Resources.live_favorites;
            this.idTstripFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.idTstripFavorite.Name = "idTstripFavorite";
            this.idTstripFavorite.Size = new System.Drawing.Size(29, 28);
            this.idTstripFavorite.Text = "toolStripButton5";
            this.idTstripFavorite.Click += new System.EventHandler(this.idTstripFavorite_Click);
            // 
            // idTstripNewTab
            // 
            this.idTstripNewTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.idTstripNewTab.Image = global::NavegadorV05.Properties.Resources.add_insert;
            this.idTstripNewTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.idTstripNewTab.Name = "idTstripNewTab";
            this.idTstripNewTab.Size = new System.Drawing.Size(29, 28);
            this.idTstripNewTab.Text = "toolStripButton6";
            this.idTstripNewTab.Click += new System.EventHandler(this.idTstripNewTab_Click);
            // 
            // idTstripRemoveTab
            // 
            this.idTstripRemoveTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.idTstripRemoveTab.Image = global::NavegadorV05.Properties.Resources.delete_icon;
            this.idTstripRemoveTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.idTstripRemoveTab.Name = "idTstripRemoveTab";
            this.idTstripRemoveTab.Size = new System.Drawing.Size(29, 28);
            this.idTstripRemoveTab.Text = "toolStripButton7";
            this.idTstripRemoveTab.Click += new System.EventHandler(this.idTstripRemoveTab_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::NavegadorV05.Properties.Resources.Actions_document_save_as_icon;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // vistaPreviaToolStripMenuItem
            // 
            this.vistaPreviaToolStripMenuItem.Image = global::NavegadorV05.Properties.Resources.ojo;
            this.vistaPreviaToolStripMenuItem.Name = "vistaPreviaToolStripMenuItem";
            this.vistaPreviaToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.vistaPreviaToolStripMenuItem.Text = "Vista previa";
            this.vistaPreviaToolStripMenuItem.Click += new System.EventHandler(this.vistaPreviaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::NavegadorV05.Properties.Resources.Configuration_icon;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            this.toolStripMenuItem1.Text = "Configurar página";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = global::NavegadorV05.Properties.Resources.printer;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::NavegadorV05.Properties.Resources.Log_Out_icon;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // páginaInicioToolStripMenuItem
            // 
            this.páginaInicioToolStripMenuItem.Image = global::NavegadorV05.Properties.Resources.number_1_icon;
            this.páginaInicioToolStripMenuItem.Name = "páginaInicioToolStripMenuItem";
            this.páginaInicioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.páginaInicioToolStripMenuItem.Text = "Página inicio";
            this.páginaInicioToolStripMenuItem.Click += new System.EventHandler(this.páginaInicioToolStripMenuItem_Click);
            // 
            // idConfigHistorial
            // 
            this.idConfigHistorial.Image = global::NavegadorV05.Properties.Resources.Folder_URL_History_icon1;
            this.idConfigHistorial.Name = "idConfigHistorial";
            this.idConfigHistorial.Size = new System.Drawing.Size(224, 26);
            this.idConfigHistorial.Text = "Historial";
            this.idConfigHistorial.Click += new System.EventHandler(this.idConfigHistorial_Click);
            // 
            // búsquedaToolStripMenuItem
            // 
            this.búsquedaToolStripMenuItem.Image = global::NavegadorV05.Properties.Resources.Search_find;
            this.búsquedaToolStripMenuItem.Name = "búsquedaToolStripMenuItem";
            this.búsquedaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.búsquedaToolStripMenuItem.Text = "Búsqueda";
            this.búsquedaToolStripMenuItem.Click += new System.EventHandler(this.búsquedaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BarraUrl);
            this.Controls.Add(this.BotonesMenu);
            this.Controls.Add(this.MENU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MENU;
            this.Name = "Form1";
            this.Text = "NAVEGADOR I.E.S ALMUNIA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            this.BotonesMenu.ResumeLayout(false);
            this.BotonesMenu.PerformLayout();
            this.BarraUrl.ResumeLayout(false);
            this.BarraUrl.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MENU;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaPreviaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURACIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem páginaInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem búsquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROPIEDADESToolStripMenuItem;
        private System.Windows.Forms.ToolStrip BotonesMenu;
        private System.Windows.Forms.ToolStripButton idTstripBack;
        private System.Windows.Forms.ToolStripButton idTstripGoForward;
        private System.Windows.Forms.ToolStripButton idTstripRefresh;
        private System.Windows.Forms.ToolStripButton idTstripHome;
        private System.Windows.Forms.ToolStripButton idTstripFavorite;
        private System.Windows.Forms.ToolStripButton idTstripNewTab;
        private System.Windows.Forms.ToolStripButton idTstripRemoveTab;
        private System.Windows.Forms.ToolStrip BarraUrl;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton idBtnUrl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripComboBox idListaFavoritos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripTextBox idTbUrl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem idConfigHistorial;
    }
}


namespace Acces_db_02
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label dIRECCIONLabel;
            System.Windows.Forms.Label tELEFONOLabel;
            System.Windows.Forms.Label f_NACIMLabel;
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.idBtnDelAlumno = new System.Windows.Forms.Button();
            this.idBtnModifAlumno = new System.Windows.Forms.Button();
            this.idBtnGuardarAlumno = new System.Windows.Forms.Button();
            this.idBtnAddAlumno = new System.Windows.Forms.Button();
            this.panelAlumno = new System.Windows.Forms.Panel();
            this.idTxtDniAlumno = new System.Windows.Forms.TextBox();
            this.f_NACIMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTxtTlfnAlumno = new System.Windows.Forms.TextBox();
            this.idTxtNombreAlumno = new System.Windows.Forms.TextBox();
            this.idTxtDireccAlumno = new System.Windows.Forms.TextBox();
            this.aLUMNOSDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.aLUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_profesorDataSet = new Acces_db_02.db_profesorDataSet();
            this.aLUMNOSTableAdapter = new Acces_db_02.db_profesorDataSetTableAdapters.ALUMNOSTableAdapter();
            this.tableAdapterManager = new Acces_db_02.db_profesorDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFESORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROFESORESTableAdapter = new Acces_db_02.db_profesorDataSetTableAdapters.PROFESORESTableAdapter();
            this.pROFESORESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dNILabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            dIRECCIONLabel = new System.Windows.Forms.Label();
            tELEFONOLabel = new System.Windows.Forms.Label();
            f_NACIMLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_profesorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESORESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(29, 36);
            dNILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(53, 20);
            dNILabel.TabIndex = 1;
            dNILabel.Text = "DNI:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(29, 68);
            nOMBRELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(98, 20);
            nOMBRELabel.TabIndex = 3;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // dIRECCIONLabel
            // 
            dIRECCIONLabel.AutoSize = true;
            dIRECCIONLabel.Location = new System.Drawing.Point(29, 100);
            dIRECCIONLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dIRECCIONLabel.Name = "dIRECCIONLabel";
            dIRECCIONLabel.Size = new System.Drawing.Size(125, 20);
            dIRECCIONLabel.TabIndex = 5;
            dIRECCIONLabel.Text = "DIRECCION:";
            // 
            // tELEFONOLabel
            // 
            tELEFONOLabel.AutoSize = true;
            tELEFONOLabel.Location = new System.Drawing.Point(29, 132);
            tELEFONOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tELEFONOLabel.Name = "tELEFONOLabel";
            tELEFONOLabel.Size = new System.Drawing.Size(116, 20);
            tELEFONOLabel.TabIndex = 7;
            tELEFONOLabel.Text = "TELEFONO:";
            // 
            // f_NACIMLabel
            // 
            f_NACIMLabel.AutoSize = true;
            f_NACIMLabel.Location = new System.Drawing.Point(29, 165);
            f_NACIMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            f_NACIMLabel.Name = "f_NACIMLabel";
            f_NACIMLabel.Size = new System.Drawing.Size(103, 20);
            f_NACIMLabel.TabIndex = 9;
            f_NACIMLabel.Text = "F_NACIM:";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(3, 4);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1076, 606);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.idBtnDelAlumno);
            this.tabPage1.Controls.Add(this.idBtnModifAlumno);
            this.tabPage1.Controls.Add(this.idBtnGuardarAlumno);
            this.tabPage1.Controls.Add(this.idBtnAddAlumno);
            this.tabPage1.Controls.Add(this.panelAlumno);
            this.tabPage1.Controls.Add(this.aLUMNOSDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1068, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ALUMNOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(770, 505);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 41);
            this.button5.TabIndex = 16;
            this.button5.Text = "SALIR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // idBtnDelAlumno
            // 
            this.idBtnDelAlumno.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnDelAlumno.Location = new System.Drawing.Point(770, 446);
            this.idBtnDelAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.idBtnDelAlumno.Name = "idBtnDelAlumno";
            this.idBtnDelAlumno.Size = new System.Drawing.Size(229, 41);
            this.idBtnDelAlumno.TabIndex = 15;
            this.idBtnDelAlumno.Text = "ELIMINAR";
            this.idBtnDelAlumno.UseVisualStyleBackColor = true;
            this.idBtnDelAlumno.Click += new System.EventHandler(this.button4_Click);
            // 
            // idBtnModifAlumno
            // 
            this.idBtnModifAlumno.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnModifAlumno.Location = new System.Drawing.Point(770, 388);
            this.idBtnModifAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.idBtnModifAlumno.Name = "idBtnModifAlumno";
            this.idBtnModifAlumno.Size = new System.Drawing.Size(229, 41);
            this.idBtnModifAlumno.TabIndex = 14;
            this.idBtnModifAlumno.Text = "MODIFICAR";
            this.idBtnModifAlumno.UseVisualStyleBackColor = true;
            this.idBtnModifAlumno.Click += new System.EventHandler(this.button3_Click);
            // 
            // idBtnGuardarAlumno
            // 
            this.idBtnGuardarAlumno.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnGuardarAlumno.Location = new System.Drawing.Point(770, 332);
            this.idBtnGuardarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.idBtnGuardarAlumno.Name = "idBtnGuardarAlumno";
            this.idBtnGuardarAlumno.Size = new System.Drawing.Size(229, 41);
            this.idBtnGuardarAlumno.TabIndex = 13;
            this.idBtnGuardarAlumno.Text = "GUARDAR";
            this.idBtnGuardarAlumno.UseVisualStyleBackColor = true;
            this.idBtnGuardarAlumno.Click += new System.EventHandler(this.button2_Click);
            // 
            // idBtnAddAlumno
            // 
            this.idBtnAddAlumno.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnAddAlumno.Location = new System.Drawing.Point(770, 271);
            this.idBtnAddAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.idBtnAddAlumno.Name = "idBtnAddAlumno";
            this.idBtnAddAlumno.Size = new System.Drawing.Size(229, 41);
            this.idBtnAddAlumno.TabIndex = 12;
            this.idBtnAddAlumno.Text = "AÑADIR";
            this.idBtnAddAlumno.UseVisualStyleBackColor = true;
            this.idBtnAddAlumno.Click += new System.EventHandler(this.idBtnAddAlumno_Click);
            // 
            // panelAlumno
            // 
            this.panelAlumno.Controls.Add(this.idTxtDniAlumno);
            this.panelAlumno.Controls.Add(dNILabel);
            this.panelAlumno.Controls.Add(this.f_NACIMDateTimePicker);
            this.panelAlumno.Controls.Add(f_NACIMLabel);
            this.panelAlumno.Controls.Add(nOMBRELabel);
            this.panelAlumno.Controls.Add(this.idTxtTlfnAlumno);
            this.panelAlumno.Controls.Add(this.idTxtNombreAlumno);
            this.panelAlumno.Controls.Add(tELEFONOLabel);
            this.panelAlumno.Controls.Add(dIRECCIONLabel);
            this.panelAlumno.Controls.Add(this.idTxtDireccAlumno);
            this.panelAlumno.Enabled = false;
            this.panelAlumno.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAlumno.Location = new System.Drawing.Point(33, 306);
            this.panelAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.panelAlumno.Name = "panelAlumno";
            this.panelAlumno.Size = new System.Drawing.Size(605, 239);
            this.panelAlumno.TabIndex = 11;
            // 
            // idTxtDniAlumno
            // 
            this.idTxtDniAlumno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "DNI", true));
            this.idTxtDniAlumno.Location = new System.Drawing.Point(177, 31);
            this.idTxtDniAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.idTxtDniAlumno.Name = "idTxtDniAlumno";
            this.idTxtDniAlumno.Size = new System.Drawing.Size(144, 27);
            this.idTxtDniAlumno.TabIndex = 2;
            // 
            // f_NACIMDateTimePicker
            // 
            this.f_NACIMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aLUMNOSBindingSource, "F_NACIM", true));
            this.f_NACIMDateTimePicker.Location = new System.Drawing.Point(177, 159);
            this.f_NACIMDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.f_NACIMDateTimePicker.Name = "f_NACIMDateTimePicker";
            this.f_NACIMDateTimePicker.Size = new System.Drawing.Size(416, 27);
            this.f_NACIMDateTimePicker.TabIndex = 10;
            // 
            // idTxtTlfnAlumno
            // 
            this.idTxtTlfnAlumno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "TELEFONO", true));
            this.idTxtTlfnAlumno.Location = new System.Drawing.Point(177, 127);
            this.idTxtTlfnAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.idTxtTlfnAlumno.Name = "idTxtTlfnAlumno";
            this.idTxtTlfnAlumno.Size = new System.Drawing.Size(144, 27);
            this.idTxtTlfnAlumno.TabIndex = 8;
            // 
            // idTxtNombreAlumno
            // 
            this.idTxtNombreAlumno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "NOMBRE", true));
            this.idTxtNombreAlumno.Location = new System.Drawing.Point(177, 63);
            this.idTxtNombreAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.idTxtNombreAlumno.Name = "idTxtNombreAlumno";
            this.idTxtNombreAlumno.Size = new System.Drawing.Size(293, 27);
            this.idTxtNombreAlumno.TabIndex = 4;
            // 
            // idTxtDireccAlumno
            // 
            this.idTxtDireccAlumno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "DIRECCION", true));
            this.idTxtDireccAlumno.Location = new System.Drawing.Point(177, 95);
            this.idTxtDireccAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.idTxtDireccAlumno.Name = "idTxtDireccAlumno";
            this.idTxtDireccAlumno.Size = new System.Drawing.Size(416, 27);
            this.idTxtDireccAlumno.TabIndex = 6;
            // 
            // aLUMNOSDataGridView
            // 
            this.aLUMNOSDataGridView.AutoGenerateColumns = false;
            this.aLUMNOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aLUMNOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.aLUMNOSDataGridView.DataSource = this.aLUMNOSBindingSource;
            this.aLUMNOSDataGridView.Location = new System.Drawing.Point(33, 4);
            this.aLUMNOSDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.aLUMNOSDataGridView.Name = "aLUMNOSDataGridView";
            this.aLUMNOSDataGridView.RowHeadersWidth = 51;
            this.aLUMNOSDataGridView.Size = new System.Drawing.Size(966, 238);
            this.aLUMNOSDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pROFESORESDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1068, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PROFESORES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1035, 577);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ASIGNATURA";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1035, 577);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CONSULTAS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // aLUMNOSBindingSource
            // 
            this.aLUMNOSBindingSource.DataMember = "ALUMNOS";
            this.aLUMNOSBindingSource.DataSource = this.db_profesorDataSet;
            // 
            // db_profesorDataSet
            // 
            this.db_profesorDataSet.DataSetName = "db_profesorDataSet";
            this.db_profesorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLUMNOSTableAdapter
            // 
            this.aLUMNOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALUMNOSTableAdapter = this.aLUMNOSTableAdapter;
            this.tableAdapterManager.ASIGNATURATableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PROFESORESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Acces_db_02.db_profesorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DNI";
            this.dataGridViewTextBoxColumn1.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIRECCION";
            this.dataGridViewTextBoxColumn3.HeaderText = "DIRECCION";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TELEFONO";
            this.dataGridViewTextBoxColumn4.HeaderText = "TELEFONO";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "F_NACIM";
            this.dataGridViewTextBoxColumn5.HeaderText = "F_NACIM";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // pROFESORESBindingSource
            // 
            this.pROFESORESBindingSource.DataMember = "PROFESORES";
            this.pROFESORESBindingSource.DataSource = this.db_profesorDataSet;
            // 
            // pROFESORESTableAdapter
            // 
            this.pROFESORESTableAdapter.ClearBeforeFill = true;
            // 
            // pROFESORESDataGridView
            // 
            this.pROFESORESDataGridView.AutoGenerateColumns = false;
            this.pROFESORESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pROFESORESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pROFESORESDataGridView.DataSource = this.pROFESORESBindingSource;
            this.pROFESORESDataGridView.Location = new System.Drawing.Point(7, 7);
            this.pROFESORESDataGridView.Name = "pROFESORESDataGridView";
            this.pROFESORESDataGridView.RowHeadersWidth = 51;
            this.pROFESORESDataGridView.RowTemplate.Height = 24;
            this.pROFESORESDataGridView.Size = new System.Drawing.Size(493, 352);
            this.pROFESORESDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DNI";
            this.dataGridViewTextBoxColumn6.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn7.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 170;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DEPARTAMENTO";
            this.dataGridViewTextBoxColumn8.HeaderText = "DEPARTAMENTO";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 170;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1038, 610);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EJERCICIO DE BASE DE DATOS ACCESS – C# ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelAlumno.ResumeLayout(false);
            this.panelAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_profesorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESORESDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private db_profesorDataSet db_profesorDataSet;
        private System.Windows.Forms.BindingSource aLUMNOSBindingSource;
        private db_profesorDataSetTableAdapters.ALUMNOSTableAdapter aLUMNOSTableAdapter;
        private db_profesorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelAlumno;
        private System.Windows.Forms.TextBox idTxtDniAlumno;
        private System.Windows.Forms.DateTimePicker f_NACIMDateTimePicker;
        private System.Windows.Forms.TextBox idTxtTlfnAlumno;
        private System.Windows.Forms.TextBox idTxtNombreAlumno;
        private System.Windows.Forms.TextBox idTxtDireccAlumno;
        private System.Windows.Forms.DataGridView aLUMNOSDataGridView;
        private System.Windows.Forms.Button idBtnDelAlumno;
        private System.Windows.Forms.Button idBtnModifAlumno;
        private System.Windows.Forms.Button idBtnGuardarAlumno;
        private System.Windows.Forms.Button idBtnAddAlumno;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource pROFESORESBindingSource;
        private db_profesorDataSetTableAdapters.PROFESORESTableAdapter pROFESORESTableAdapter;
        private System.Windows.Forms.DataGridView pROFESORESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}


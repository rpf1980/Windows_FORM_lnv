namespace Access_bd_01
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
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label f_nacimLabel;
            System.Windows.Forms.Label dniLabel1;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label departamentoLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.idTabAlumno = new System.Windows.Forms.TabPage();
            this.idBtnEliminar = new System.Windows.Forms.Button();
            this.idBtnGuardar = new System.Windows.Forms.Button();
            this.idBtnModificar = new System.Windows.Forms.Button();
            this.idBtnAdd = new System.Windows.Forms.Button();
            this.panelAlumno = new System.Windows.Forms.Panel();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.aLUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdatosDataSet = new Access_bd_01.bdatosDataSet();
            this.f_nacimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.idBtnSalir = new System.Windows.Forms.Button();
            this.aLUMNOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTabProfesores = new System.Windows.Forms.TabPage();
            this.idTabAsignatura = new System.Windows.Forms.TabPage();
            this.idTabConsultas = new System.Windows.Forms.TabPage();
            this.aLUMNOSTableAdapter = new Access_bd_01.bdatosDataSetTableAdapters.ALUMNOSTableAdapter();
            this.tableAdapterManager = new Access_bd_01.bdatosDataSetTableAdapters.TableAdapterManager();
            this.pROFESORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROFESORESTableAdapter = new Access_bd_01.bdatosDataSetTableAdapters.PROFESORESTableAdapter();
            this.pROFESORESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniTextProf = new System.Windows.Forms.TextBox();
            this.nombreTextProf = new System.Windows.Forms.TextBox();
            this.departamentoTextBox = new System.Windows.Forms.TextBox();
            this.panelProf = new System.Windows.Forms.Panel();
            this.idBtnAddProf = new System.Windows.Forms.Button();
            this.idBtnGuardarProf = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idBtnEliminarProf = new System.Windows.Forms.Button();
            this.idBtnSalirProf = new System.Windows.Forms.Button();
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            f_nacimLabel = new System.Windows.Forms.Label();
            dniLabel1 = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.idTabAlumno.SuspendLayout();
            this.panelAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSDataGridView)).BeginInit();
            this.idTabProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESORESDataGridView)).BeginInit();
            this.panelProf.SuspendLayout();
            this.SuspendLayout();
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dniLabel.Location = new System.Drawing.Point(21, 20);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(38, 18);
            dniLabel.TabIndex = 4;
            dniLabel.Text = "Dni:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(21, 48);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(73, 18);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(21, 76);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(85, 18);
            direccionLabel.TabIndex = 8;
            direccionLabel.Text = "Dirección:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(21, 104);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(79, 18);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "Teléfono:";
            // 
            // f_nacimLabel
            // 
            f_nacimLabel.AutoSize = true;
            f_nacimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            f_nacimLabel.Location = new System.Drawing.Point(21, 133);
            f_nacimLabel.Name = "f_nacimLabel";
            f_nacimLabel.Size = new System.Drawing.Size(91, 18);
            f_nacimLabel.TabIndex = 12;
            f_nacimLabel.Text = "Fecha nac:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.idTabAlumno);
            this.tabControl1.Controls.Add(this.idTabProfesores);
            this.tabControl1.Controls.Add(this.idTabAsignatura);
            this.tabControl1.Controls.Add(this.idTabConsultas);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1291, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // idTabAlumno
            // 
            this.idTabAlumno.AutoScroll = true;
            this.idTabAlumno.Controls.Add(this.idBtnEliminar);
            this.idTabAlumno.Controls.Add(this.idBtnGuardar);
            this.idTabAlumno.Controls.Add(this.idBtnModificar);
            this.idTabAlumno.Controls.Add(this.idBtnAdd);
            this.idTabAlumno.Controls.Add(this.panelAlumno);
            this.idTabAlumno.Controls.Add(this.idBtnSalir);
            this.idTabAlumno.Controls.Add(this.aLUMNOSDataGridView);
            this.idTabAlumno.Location = new System.Drawing.Point(4, 25);
            this.idTabAlumno.Name = "idTabAlumno";
            this.idTabAlumno.Padding = new System.Windows.Forms.Padding(3);
            this.idTabAlumno.Size = new System.Drawing.Size(1283, 507);
            this.idTabAlumno.TabIndex = 0;
            this.idTabAlumno.Text = "ALUMNOS";
            this.idTabAlumno.UseVisualStyleBackColor = true;
            // 
            // idBtnEliminar
            // 
            this.idBtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnEliminar.Location = new System.Drawing.Point(887, 243);
            this.idBtnEliminar.Name = "idBtnEliminar";
            this.idBtnEliminar.Size = new System.Drawing.Size(145, 43);
            this.idBtnEliminar.TabIndex = 18;
            this.idBtnEliminar.Text = "ELIMINAR";
            this.idBtnEliminar.UseVisualStyleBackColor = true;
            // 
            // idBtnGuardar
            // 
            this.idBtnGuardar.Enabled = false;
            this.idBtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnGuardar.Location = new System.Drawing.Point(414, 430);
            this.idBtnGuardar.Name = "idBtnGuardar";
            this.idBtnGuardar.Size = new System.Drawing.Size(145, 43);
            this.idBtnGuardar.TabIndex = 17;
            this.idBtnGuardar.Text = "GUARDAR";
            this.idBtnGuardar.UseVisualStyleBackColor = true;
            this.idBtnGuardar.Click += new System.EventHandler(this.idBtnGuardar_Click);
            // 
            // idBtnModificar
            // 
            this.idBtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnModificar.Location = new System.Drawing.Point(634, 243);
            this.idBtnModificar.Name = "idBtnModificar";
            this.idBtnModificar.Size = new System.Drawing.Size(145, 43);
            this.idBtnModificar.TabIndex = 16;
            this.idBtnModificar.Text = "MODIFICAR";
            this.idBtnModificar.UseVisualStyleBackColor = true;
            this.idBtnModificar.Click += new System.EventHandler(this.idBtnModificar_Click);
            // 
            // idBtnAdd
            // 
            this.idBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnAdd.Location = new System.Drawing.Point(6, 430);
            this.idBtnAdd.Name = "idBtnAdd";
            this.idBtnAdd.Size = new System.Drawing.Size(145, 43);
            this.idBtnAdd.TabIndex = 15;
            this.idBtnAdd.Text = "AÑADIR";
            this.idBtnAdd.UseVisualStyleBackColor = true;
            this.idBtnAdd.Click += new System.EventHandler(this.idBtnAdd_Click);
            // 
            // panelAlumno
            // 
            this.panelAlumno.Controls.Add(this.dniTextBox);
            this.panelAlumno.Controls.Add(dniLabel);
            this.panelAlumno.Controls.Add(this.f_nacimDateTimePicker);
            this.panelAlumno.Controls.Add(f_nacimLabel);
            this.panelAlumno.Controls.Add(nombreLabel);
            this.panelAlumno.Controls.Add(this.telefonoTextBox);
            this.panelAlumno.Controls.Add(this.nombreTextBox);
            this.panelAlumno.Controls.Add(telefonoLabel);
            this.panelAlumno.Controls.Add(direccionLabel);
            this.panelAlumno.Controls.Add(this.direccionTextBox);
            this.panelAlumno.Enabled = false;
            this.panelAlumno.Location = new System.Drawing.Point(6, 243);
            this.panelAlumno.Name = "panelAlumno";
            this.panelAlumno.Size = new System.Drawing.Size(553, 172);
            this.panelAlumno.TabIndex = 14;
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "dni", true));
            this.dniTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniTextBox.Location = new System.Drawing.Point(118, 16);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(127, 24);
            this.dniTextBox.TabIndex = 5;
            // 
            // aLUMNOSBindingSource
            // 
            this.aLUMNOSBindingSource.DataMember = "ALUMNOS";
            this.aLUMNOSBindingSource.DataSource = this.bdatosDataSet;
            // 
            // bdatosDataSet
            // 
            this.bdatosDataSet.DataSetName = "bdatosDataSet";
            this.bdatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f_nacimDateTimePicker
            // 
            this.f_nacimDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aLUMNOSBindingSource, "f_nacim", true));
            this.f_nacimDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_nacimDateTimePicker.Location = new System.Drawing.Point(118, 128);
            this.f_nacimDateTimePicker.Name = "f_nacimDateTimePicker";
            this.f_nacimDateTimePicker.Size = new System.Drawing.Size(392, 24);
            this.f_nacimDateTimePicker.TabIndex = 13;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(118, 100);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(127, 24);
            this.telefonoTextBox.TabIndex = 11;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(118, 44);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(297, 24);
            this.nombreTextBox.TabIndex = 7;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(118, 72);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(392, 24);
            this.direccionTextBox.TabIndex = 9;
            // 
            // idBtnSalir
            // 
            this.idBtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnSalir.Location = new System.Drawing.Point(1109, 243);
            this.idBtnSalir.Name = "idBtnSalir";
            this.idBtnSalir.Size = new System.Drawing.Size(145, 43);
            this.idBtnSalir.TabIndex = 1;
            this.idBtnSalir.Text = "SALIR";
            this.idBtnSalir.UseVisualStyleBackColor = true;
            this.idBtnSalir.Click += new System.EventHandler(this.idBtnSalir_Click);
            // 
            // aLUMNOSDataGridView
            // 
            this.aLUMNOSDataGridView.AllowUserToAddRows = false;
            this.aLUMNOSDataGridView.AllowUserToOrderColumns = true;
            this.aLUMNOSDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aLUMNOSDataGridView.AutoGenerateColumns = false;
            this.aLUMNOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aLUMNOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.aLUMNOSDataGridView.DataSource = this.aLUMNOSBindingSource;
            this.aLUMNOSDataGridView.Location = new System.Drawing.Point(3, 6);
            this.aLUMNOSDataGridView.Name = "aLUMNOSDataGridView";
            this.aLUMNOSDataGridView.RowHeadersWidth = 51;
            this.aLUMNOSDataGridView.RowTemplate.Height = 24;
            this.aLUMNOSDataGridView.Size = new System.Drawing.Size(1273, 220);
            this.aLUMNOSDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dni";
            this.dataGridViewTextBoxColumn2.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIRECCION";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 280;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "TELEFONO";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "f_nacim";
            this.dataGridViewTextBoxColumn6.HeaderText = "FECHA NAC.";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // idTabProfesores
            // 
            this.idTabProfesores.AutoScroll = true;
            this.idTabProfesores.Controls.Add(this.idBtnSalirProf);
            this.idTabProfesores.Controls.Add(this.idBtnEliminarProf);
            this.idTabProfesores.Controls.Add(this.button3);
            this.idTabProfesores.Controls.Add(this.idBtnGuardarProf);
            this.idTabProfesores.Controls.Add(this.idBtnAddProf);
            this.idTabProfesores.Controls.Add(this.panelProf);
            this.idTabProfesores.Controls.Add(this.pROFESORESDataGridView);
            this.idTabProfesores.Location = new System.Drawing.Point(4, 25);
            this.idTabProfesores.Name = "idTabProfesores";
            this.idTabProfesores.Padding = new System.Windows.Forms.Padding(3);
            this.idTabProfesores.Size = new System.Drawing.Size(1283, 507);
            this.idTabProfesores.TabIndex = 1;
            this.idTabProfesores.Text = "PROFESORES";
            this.idTabProfesores.UseVisualStyleBackColor = true;
            // 
            // idTabAsignatura
            // 
            this.idTabAsignatura.Location = new System.Drawing.Point(4, 25);
            this.idTabAsignatura.Name = "idTabAsignatura";
            this.idTabAsignatura.Padding = new System.Windows.Forms.Padding(3);
            this.idTabAsignatura.Size = new System.Drawing.Size(1283, 499);
            this.idTabAsignatura.TabIndex = 2;
            this.idTabAsignatura.Text = "ASIGNATURA";
            this.idTabAsignatura.UseVisualStyleBackColor = true;
            // 
            // idTabConsultas
            // 
            this.idTabConsultas.Location = new System.Drawing.Point(4, 25);
            this.idTabConsultas.Name = "idTabConsultas";
            this.idTabConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.idTabConsultas.Size = new System.Drawing.Size(1283, 499);
            this.idTabConsultas.TabIndex = 3;
            this.idTabConsultas.Text = "CONSULTAS";
            this.idTabConsultas.UseVisualStyleBackColor = true;
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
            this.tableAdapterManager.UpdateOrder = Access_bd_01.bdatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROFESORESBindingSource
            // 
            this.pROFESORESBindingSource.DataMember = "PROFESORES";
            this.pROFESORESBindingSource.DataSource = this.bdatosDataSet;
            // 
            // pROFESORESTableAdapter
            // 
            this.pROFESORESTableAdapter.ClearBeforeFill = true;
            // 
            // pROFESORESDataGridView
            // 
            this.pROFESORESDataGridView.AllowUserToAddRows = false;
            this.pROFESORESDataGridView.AllowUserToOrderColumns = true;
            this.pROFESORESDataGridView.AutoGenerateColumns = false;
            this.pROFESORESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pROFESORESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.pROFESORESDataGridView.DataSource = this.pROFESORESBindingSource;
            this.pROFESORESDataGridView.Location = new System.Drawing.Point(8, 6);
            this.pROFESORESDataGridView.Name = "pROFESORESDataGridView";
            this.pROFESORESDataGridView.RowHeadersWidth = 51;
            this.pROFESORESDataGridView.RowTemplate.Height = 24;
            this.pROFESORESDataGridView.Size = new System.Drawing.Size(878, 219);
            this.pROFESORESDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dni";
            this.dataGridViewTextBoxColumn8.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn9.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 250;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "departamento";
            this.dataGridViewTextBoxColumn10.HeaderText = "DEPARTAMENTO";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 230;
            // 
            // dniLabel1
            // 
            dniLabel1.AutoSize = true;
            dniLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dniLabel1.Location = new System.Drawing.Point(17, 53);
            dniLabel1.Name = "dniLabel1";
            dniLabel1.Size = new System.Drawing.Size(38, 18);
            dniLabel1.TabIndex = 3;
            dniLabel1.Text = "Dni:";
            // 
            // dniTextProf
            // 
            this.dniTextProf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROFESORESBindingSource, "dni", true));
            this.dniTextProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniTextProf.Location = new System.Drawing.Point(172, 50);
            this.dniTextProf.Name = "dniTextProf";
            this.dniTextProf.Size = new System.Drawing.Size(125, 24);
            this.dniTextProf.TabIndex = 4;
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel1.Location = new System.Drawing.Point(17, 81);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(73, 18);
            nombreLabel1.TabIndex = 5;
            nombreLabel1.Text = "Nombre:";
            // 
            // nombreTextProf
            // 
            this.nombreTextProf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROFESORESBindingSource, "nombre", true));
            this.nombreTextProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextProf.Location = new System.Drawing.Point(172, 78);
            this.nombreTextProf.Name = "nombreTextProf";
            this.nombreTextProf.Size = new System.Drawing.Size(332, 24);
            this.nombreTextProf.TabIndex = 6;
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departamentoLabel.Location = new System.Drawing.Point(17, 109);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(119, 18);
            departamentoLabel.TabIndex = 7;
            departamentoLabel.Text = "Departamento:";
            // 
            // departamentoTextBox
            // 
            this.departamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROFESORESBindingSource, "departamento", true));
            this.departamentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamentoTextBox.Location = new System.Drawing.Point(172, 106);
            this.departamentoTextBox.Name = "departamentoTextBox";
            this.departamentoTextBox.Size = new System.Drawing.Size(332, 24);
            this.departamentoTextBox.TabIndex = 8;
            // 
            // panelProf
            // 
            this.panelProf.Controls.Add(dniLabel1);
            this.panelProf.Controls.Add(this.departamentoTextBox);
            this.panelProf.Controls.Add(this.dniTextProf);
            this.panelProf.Controls.Add(departamentoLabel);
            this.panelProf.Controls.Add(nombreLabel1);
            this.panelProf.Controls.Add(this.nombreTextProf);
            this.panelProf.Location = new System.Drawing.Point(8, 240);
            this.panelProf.Name = "panelProf";
            this.panelProf.Size = new System.Drawing.Size(516, 153);
            this.panelProf.TabIndex = 9;
            // 
            // idBtnAddProf
            // 
            this.idBtnAddProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnAddProf.Location = new System.Drawing.Point(8, 417);
            this.idBtnAddProf.Name = "idBtnAddProf";
            this.idBtnAddProf.Size = new System.Drawing.Size(145, 43);
            this.idBtnAddProf.TabIndex = 17;
            this.idBtnAddProf.Text = "AÑADIR";
            this.idBtnAddProf.UseVisualStyleBackColor = true;
            this.idBtnAddProf.Click += new System.EventHandler(this.idBtnAddProf_Click);
            // 
            // idBtnGuardarProf
            // 
            this.idBtnGuardarProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnGuardarProf.Location = new System.Drawing.Point(379, 417);
            this.idBtnGuardarProf.Name = "idBtnGuardarProf";
            this.idBtnGuardarProf.Size = new System.Drawing.Size(145, 43);
            this.idBtnGuardarProf.TabIndex = 18;
            this.idBtnGuardarProf.Text = "GUARDAR";
            this.idBtnGuardarProf.UseVisualStyleBackColor = true;
            this.idBtnGuardarProf.Click += new System.EventHandler(this.idBtnGuardarProf_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(892, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 43);
            this.button3.TabIndex = 19;
            this.button3.Text = "MODIFICAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idBtnEliminarProf
            // 
            this.idBtnEliminarProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnEliminarProf.Location = new System.Drawing.Point(892, 89);
            this.idBtnEliminarProf.Name = "idBtnEliminarProf";
            this.idBtnEliminarProf.Size = new System.Drawing.Size(145, 43);
            this.idBtnEliminarProf.TabIndex = 20;
            this.idBtnEliminarProf.Text = "ELIMINAR";
            this.idBtnEliminarProf.UseVisualStyleBackColor = true;
            // 
            // idBtnSalirProf
            // 
            this.idBtnSalirProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnSalirProf.Location = new System.Drawing.Point(892, 182);
            this.idBtnSalirProf.Name = "idBtnSalirProf";
            this.idBtnSalirProf.Size = new System.Drawing.Size(145, 43);
            this.idBtnSalirProf.TabIndex = 21;
            this.idBtnSalirProf.Text = "SALIR";
            this.idBtnSalirProf.UseVisualStyleBackColor = true;
            this.idBtnSalirProf.Click += new System.EventHandler(this.idBtnSalirProf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "EJERCICIO DE BASE DE DATOS ACCESS – C# ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.idTabAlumno.ResumeLayout(false);
            this.panelAlumno.ResumeLayout(false);
            this.panelAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSDataGridView)).EndInit();
            this.idTabProfesores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pROFESORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROFESORESDataGridView)).EndInit();
            this.panelProf.ResumeLayout(false);
            this.panelProf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage idTabAlumno;
        private System.Windows.Forms.TabPage idTabProfesores;
        private System.Windows.Forms.TabPage idTabAsignatura;
        private System.Windows.Forms.TabPage idTabConsultas;
        private bdatosDataSet bdatosDataSet;
        private System.Windows.Forms.BindingSource aLUMNOSBindingSource;
        private bdatosDataSetTableAdapters.ALUMNOSTableAdapter aLUMNOSTableAdapter;
        private bdatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView aLUMNOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button idBtnSalir;
        private System.Windows.Forms.Panel panelAlumno;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.DateTimePicker f_nacimDateTimePicker;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Button idBtnEliminar;
        private System.Windows.Forms.Button idBtnGuardar;
        private System.Windows.Forms.Button idBtnModificar;
        private System.Windows.Forms.Button idBtnAdd;
        private System.Windows.Forms.BindingSource pROFESORESBindingSource;
        private bdatosDataSetTableAdapters.PROFESORESTableAdapter pROFESORESTableAdapter;
        private System.Windows.Forms.DataGridView pROFESORESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox dniTextProf;
        private System.Windows.Forms.TextBox nombreTextProf;
        private System.Windows.Forms.TextBox departamentoTextBox;
        private System.Windows.Forms.Panel panelProf;
        private System.Windows.Forms.Button idBtnSalirProf;
        private System.Windows.Forms.Button idBtnEliminarProf;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button idBtnGuardarProf;
        private System.Windows.Forms.Button idBtnAddProf;
    }
}


namespace BD_accessEjerEntrega
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
            this.tabAlumnos = new System.Windows.Forms.TabControl();
            this.idTabAlumnos = new System.Windows.Forms.TabPage();
            this.idTabProfesores = new System.Windows.Forms.TabPage();
            this.idTabAsignatura = new System.Windows.Forms.TabPage();
            this.idTabConsultas = new System.Windows.Forms.TabPage();
            this.bD_ejercicioAccessDataSet = new BD_accessEjerEntrega.BD_ejercicioAccessDataSet();
            this.aLUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLUMNOSTableAdapter = new BD_accessEjerEntrega.BD_ejercicioAccessDataSetTableAdapters.ALUMNOSTableAdapter();
            this.tableAdapterManager = new BD_accessEjerEntrega.BD_ejercicioAccessDataSetTableAdapters.TableAdapterManager();
            this.aLUMNOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.f_nacimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            f_nacimLabel = new System.Windows.Forms.Label();
            this.tabAlumnos.SuspendLayout();
            this.idTabAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ejercicioAccessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAlumnos
            // 
            this.tabAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAlumnos.Controls.Add(this.idTabAlumnos);
            this.tabAlumnos.Controls.Add(this.idTabProfesores);
            this.tabAlumnos.Controls.Add(this.idTabAsignatura);
            this.tabAlumnos.Controls.Add(this.idTabConsultas);
            this.tabAlumnos.Location = new System.Drawing.Point(12, 12);
            this.tabAlumnos.Name = "tabAlumnos";
            this.tabAlumnos.SelectedIndex = 0;
            this.tabAlumnos.Size = new System.Drawing.Size(1271, 451);
            this.tabAlumnos.TabIndex = 0;
            // 
            // idTabAlumnos
            // 
            this.idTabAlumnos.AutoScroll = true;
            this.idTabAlumnos.Controls.Add(this.button4);
            this.idTabAlumnos.Controls.Add(this.button3);
            this.idTabAlumnos.Controls.Add(this.button2);
            this.idTabAlumnos.Controls.Add(this.button1);
            this.idTabAlumnos.Controls.Add(this.panel1);
            this.idTabAlumnos.Controls.Add(this.aLUMNOSDataGridView);
            this.idTabAlumnos.Location = new System.Drawing.Point(4, 25);
            this.idTabAlumnos.Name = "idTabAlumnos";
            this.idTabAlumnos.Padding = new System.Windows.Forms.Padding(3);
            this.idTabAlumnos.Size = new System.Drawing.Size(1263, 422);
            this.idTabAlumnos.TabIndex = 0;
            this.idTabAlumnos.Text = "ALUMNOS";
            this.idTabAlumnos.UseVisualStyleBackColor = true;
            // 
            // idTabProfesores
            // 
            this.idTabProfesores.Location = new System.Drawing.Point(4, 25);
            this.idTabProfesores.Name = "idTabProfesores";
            this.idTabProfesores.Padding = new System.Windows.Forms.Padding(3);
            this.idTabProfesores.Size = new System.Drawing.Size(1203, 517);
            this.idTabProfesores.TabIndex = 1;
            this.idTabProfesores.Text = "PROFESORES";
            this.idTabProfesores.UseVisualStyleBackColor = true;
            // 
            // idTabAsignatura
            // 
            this.idTabAsignatura.Location = new System.Drawing.Point(4, 25);
            this.idTabAsignatura.Name = "idTabAsignatura";
            this.idTabAsignatura.Padding = new System.Windows.Forms.Padding(3);
            this.idTabAsignatura.Size = new System.Drawing.Size(1203, 517);
            this.idTabAsignatura.TabIndex = 2;
            this.idTabAsignatura.Text = "ASIGNATURAS";
            this.idTabAsignatura.UseVisualStyleBackColor = true;
            // 
            // idTabConsultas
            // 
            this.idTabConsultas.Location = new System.Drawing.Point(4, 25);
            this.idTabConsultas.Name = "idTabConsultas";
            this.idTabConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.idTabConsultas.Size = new System.Drawing.Size(1203, 517);
            this.idTabConsultas.TabIndex = 3;
            this.idTabConsultas.Text = "CONSULTAS";
            this.idTabConsultas.UseVisualStyleBackColor = true;
            // 
            // bD_ejercicioAccessDataSet
            // 
            this.bD_ejercicioAccessDataSet.DataSetName = "BD_ejercicioAccessDataSet";
            this.bD_ejercicioAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLUMNOSBindingSource
            // 
            this.aLUMNOSBindingSource.DataMember = "ALUMNOS";
            this.aLUMNOSBindingSource.DataSource = this.bD_ejercicioAccessDataSet;
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
            this.tableAdapterManager.UpdateOrder = BD_accessEjerEntrega.BD_ejercicioAccessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aLUMNOSDataGridView
            // 
            this.aLUMNOSDataGridView.AllowUserToAddRows = false;
            this.aLUMNOSDataGridView.AllowUserToDeleteRows = false;
            this.aLUMNOSDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aLUMNOSDataGridView.AutoGenerateColumns = false;
            this.aLUMNOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aLUMNOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.aLUMNOSDataGridView.DataSource = this.aLUMNOSBindingSource;
            this.aLUMNOSDataGridView.Location = new System.Drawing.Point(3, 6);
            this.aLUMNOSDataGridView.Name = "aLUMNOSDataGridView";
            this.aLUMNOSDataGridView.ReadOnly = true;
            this.aLUMNOSDataGridView.RowHeadersWidth = 51;
            this.aLUMNOSDataGridView.RowTemplate.Height = 24;
            this.aLUMNOSDataGridView.Size = new System.Drawing.Size(1246, 220);
            this.aLUMNOSDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dni";
            this.dataGridViewTextBoxColumn1.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "DIRECCION";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "TELEFONO";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "f_nacim";
            this.dataGridViewTextBoxColumn5.HeaderText = "FECHA NAC.";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(20, 16);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(35, 17);
            dniLabel.TabIndex = 1;
            dniLabel.Text = "DNI:";
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(172, 13);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(108, 22);
            this.dniTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(20, 44);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(72, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "NOMBRE:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(172, 41);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(270, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(20, 72);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(86, 17);
            direccionLabel.TabIndex = 5;
            direccionLabel.Text = "DIRECCIÓN:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(172, 69);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(270, 22);
            this.direccionTextBox.TabIndex = 6;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(20, 100);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(87, 17);
            telefonoLabel.TabIndex = 7;
            telefonoLabel.Text = "TELÉFONO:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(172, 97);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(108, 22);
            this.telefonoTextBox.TabIndex = 8;
            // 
            // f_nacimLabel
            // 
            f_nacimLabel.AutoSize = true;
            f_nacimLabel.Location = new System.Drawing.Point(20, 129);
            f_nacimLabel.Name = "f_nacimLabel";
            f_nacimLabel.Size = new System.Drawing.Size(89, 17);
            f_nacimLabel.TabIndex = 9;
            f_nacimLabel.Text = "FECHA NAC:";
            // 
            // f_nacimDateTimePicker
            // 
            this.f_nacimDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aLUMNOSBindingSource, "f_nacim", true));
            this.f_nacimDateTimePicker.Location = new System.Drawing.Point(172, 125);
            this.f_nacimDateTimePicker.Name = "f_nacimDateTimePicker";
            this.f_nacimDateTimePicker.Size = new System.Drawing.Size(270, 22);
            this.f_nacimDateTimePicker.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dniTextBox);
            this.panel1.Controls.Add(dniLabel);
            this.panel1.Controls.Add(this.f_nacimDateTimePicker);
            this.panel1.Controls.Add(f_nacimLabel);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.telefonoTextBox);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(telefonoLabel);
            this.panel1.Controls.Add(direccionLabel);
            this.panel1.Controls.Add(this.direccionTextBox);
            this.panel1.Location = new System.Drawing.Point(6, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 156);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(566, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "AÑADIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(566, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(566, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 46);
            this.button3.TabIndex = 14;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1114, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 46);
            this.button4.TabIndex = 15;
            this.button4.Text = "SALIR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 475);
            this.Controls.Add(this.tabAlumnos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ACCESO A DATOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabAlumnos.ResumeLayout(false);
            this.idTabAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bD_ejercicioAccessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAlumnos;
        private System.Windows.Forms.TabPage idTabAlumnos;
        private System.Windows.Forms.TabPage idTabProfesores;
        private System.Windows.Forms.TabPage idTabAsignatura;
        private System.Windows.Forms.TabPage idTabConsultas;
        private BD_ejercicioAccessDataSet bD_ejercicioAccessDataSet;
        private System.Windows.Forms.BindingSource aLUMNOSBindingSource;
        private BD_ejercicioAccessDataSetTableAdapters.ALUMNOSTableAdapter aLUMNOSTableAdapter;
        private BD_ejercicioAccessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView aLUMNOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.DateTimePicker f_nacimDateTimePicker;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}


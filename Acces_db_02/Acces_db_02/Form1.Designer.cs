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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.db_profesorDataSet = new Acces_db_02.db_profesorDataSet();
            this.aLUMNOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLUMNOSTableAdapter = new Acces_db_02.db_profesorDataSetTableAdapters.ALUMNOSTableAdapter();
            this.tableAdapterManager = new Acces_db_02.db_profesorDataSetTableAdapters.TableAdapterManager();
            this.aLUMNOSDataGridView = new System.Windows.Forms.DataGridView();
            this.idTxtDniAlumno = new System.Windows.Forms.TextBox();
            this.idTxtNombreAlumno = new System.Windows.Forms.TextBox();
            this.idTxtDireccAlumno = new System.Windows.Forms.TextBox();
            this.idTxtTlfnAlumno = new System.Windows.Forms.TextBox();
            this.f_NACIMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panelAlumno = new System.Windows.Forms.Panel();
            this.idBtnAddAlumno = new System.Windows.Forms.Button();
            this.idBtnGuardarAlumno = new System.Windows.Forms.Button();
            this.idBtnModifAlumno = new System.Windows.Forms.Button();
            this.idBtnDelAlumno = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            dNILabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            dIRECCIONLabel = new System.Windows.Forms.Label();
            tELEFONOLabel = new System.Windows.Forms.Label();
            f_NACIMLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_profesorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSDataGridView)).BeginInit();
            this.panelAlumno.SuspendLayout();
            this.SuspendLayout();
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
            this.tabControl.Location = new System.Drawing.Point(2, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(711, 490);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ALUMNOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PROFESORES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // db_profesorDataSet
            // 
            this.db_profesorDataSet.DataSetName = "db_profesorDataSet";
            this.db_profesorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLUMNOSBindingSource
            // 
            this.aLUMNOSBindingSource.DataMember = "ALUMNOS";
            this.aLUMNOSBindingSource.DataSource = this.db_profesorDataSet;
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
            this.aLUMNOSDataGridView.Location = new System.Drawing.Point(25, 3);
            this.aLUMNOSDataGridView.Name = "aLUMNOSDataGridView";
            this.aLUMNOSDataGridView.Size = new System.Drawing.Size(654, 193);
            this.aLUMNOSDataGridView.TabIndex = 0;
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(22, 29);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(39, 16);
            dNILabel.TabIndex = 1;
            dNILabel.Text = "DNI:";
            // 
            // idTxtDniAlumno
            // 
            this.idTxtDniAlumno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "DNI", true));
            this.idTxtDniAlumno.Location = new System.Drawing.Point(133, 25);
            this.idTxtDniAlumno.Name = "idTxtDniAlumno";
            this.idTxtDniAlumno.Size = new System.Drawing.Size(109, 23);
            this.idTxtDniAlumno.TabIndex = 2;
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(22, 55);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(74, 16);
            nOMBRELabel.TabIndex = 3;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // idTxtNombreAlumno
            // 
            this.idTxtNombreAlumno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "NOMBRE", true));
            this.idTxtNombreAlumno.Location = new System.Drawing.Point(133, 51);
            this.idTxtNombreAlumno.Name = "idTxtNombreAlumno";
            this.idTxtNombreAlumno.Size = new System.Drawing.Size(247, 23);
            this.idTxtNombreAlumno.TabIndex = 4;
            // 
            // dIRECCIONLabel
            // 
            dIRECCIONLabel.AutoSize = true;
            dIRECCIONLabel.Location = new System.Drawing.Point(22, 81);
            dIRECCIONLabel.Name = "dIRECCIONLabel";
            dIRECCIONLabel.Size = new System.Drawing.Size(94, 16);
            dIRECCIONLabel.TabIndex = 5;
            dIRECCIONLabel.Text = "DIRECCION:";
            // 
            // idTxtDireccAlumno
            // 
            this.idTxtDireccAlumno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "DIRECCION", true));
            this.idTxtDireccAlumno.Location = new System.Drawing.Point(133, 77);
            this.idTxtDireccAlumno.Name = "idTxtDireccAlumno";
            this.idTxtDireccAlumno.Size = new System.Drawing.Size(247, 23);
            this.idTxtDireccAlumno.TabIndex = 6;
            // 
            // tELEFONOLabel
            // 
            tELEFONOLabel.AutoSize = true;
            tELEFONOLabel.Location = new System.Drawing.Point(22, 107);
            tELEFONOLabel.Name = "tELEFONOLabel";
            tELEFONOLabel.Size = new System.Drawing.Size(88, 16);
            tELEFONOLabel.TabIndex = 7;
            tELEFONOLabel.Text = "TELEFONO:";
            // 
            // idTxtTlfnAlumno
            // 
            this.idTxtTlfnAlumno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOSBindingSource, "TELEFONO", true));
            this.idTxtTlfnAlumno.Location = new System.Drawing.Point(133, 103);
            this.idTxtTlfnAlumno.Name = "idTxtTlfnAlumno";
            this.idTxtTlfnAlumno.Size = new System.Drawing.Size(109, 23);
            this.idTxtTlfnAlumno.TabIndex = 8;
            // 
            // f_NACIMLabel
            // 
            f_NACIMLabel.AutoSize = true;
            f_NACIMLabel.Location = new System.Drawing.Point(22, 134);
            f_NACIMLabel.Name = "f_NACIMLabel";
            f_NACIMLabel.Size = new System.Drawing.Size(79, 16);
            f_NACIMLabel.TabIndex = 9;
            f_NACIMLabel.Text = "F_NACIM:";
            // 
            // f_NACIMDateTimePicker
            // 
            this.f_NACIMDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aLUMNOSBindingSource, "F_NACIM", true));
            this.f_NACIMDateTimePicker.Location = new System.Drawing.Point(133, 129);
            this.f_NACIMDateTimePicker.Name = "f_NACIMDateTimePicker";
            this.f_NACIMDateTimePicker.Size = new System.Drawing.Size(247, 23);
            this.f_NACIMDateTimePicker.TabIndex = 10;
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
            this.panelAlumno.Location = new System.Drawing.Point(25, 249);
            this.panelAlumno.Name = "panelAlumno";
            this.panelAlumno.Size = new System.Drawing.Size(428, 194);
            this.panelAlumno.TabIndex = 11;
            // 
            // idBtnAddAlumno
            // 
            this.idBtnAddAlumno.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnAddAlumno.Location = new System.Drawing.Point(507, 220);
            this.idBtnAddAlumno.Name = "idBtnAddAlumno";
            this.idBtnAddAlumno.Size = new System.Drawing.Size(172, 33);
            this.idBtnAddAlumno.TabIndex = 12;
            this.idBtnAddAlumno.Text = "AÑADIR";
            this.idBtnAddAlumno.UseVisualStyleBackColor = true;
            this.idBtnAddAlumno.Click += new System.EventHandler(this.idBtnAddAlumno_Click);
            // 
            // idBtnGuardarAlumno
            // 
            this.idBtnGuardarAlumno.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnGuardarAlumno.Location = new System.Drawing.Point(507, 270);
            this.idBtnGuardarAlumno.Name = "idBtnGuardarAlumno";
            this.idBtnGuardarAlumno.Size = new System.Drawing.Size(172, 33);
            this.idBtnGuardarAlumno.TabIndex = 13;
            this.idBtnGuardarAlumno.Text = "GUARDAR";
            this.idBtnGuardarAlumno.UseVisualStyleBackColor = true;
            this.idBtnGuardarAlumno.Click += new System.EventHandler(this.button2_Click);
            // 
            // idBtnModifAlumno
            // 
            this.idBtnModifAlumno.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnModifAlumno.Location = new System.Drawing.Point(507, 315);
            this.idBtnModifAlumno.Name = "idBtnModifAlumno";
            this.idBtnModifAlumno.Size = new System.Drawing.Size(172, 33);
            this.idBtnModifAlumno.TabIndex = 14;
            this.idBtnModifAlumno.Text = "MODIFICAR";
            this.idBtnModifAlumno.UseVisualStyleBackColor = true;
            this.idBtnModifAlumno.Click += new System.EventHandler(this.button3_Click);
            // 
            // idBtnDelAlumno
            // 
            this.idBtnDelAlumno.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnDelAlumno.Location = new System.Drawing.Point(507, 362);
            this.idBtnDelAlumno.Name = "idBtnDelAlumno";
            this.idBtnDelAlumno.Size = new System.Drawing.Size(172, 33);
            this.idBtnDelAlumno.TabIndex = 15;
            this.idBtnDelAlumno.Text = "ELIMINAR";
            this.idBtnDelAlumno.UseVisualStyleBackColor = true;
            this.idBtnDelAlumno.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DNI";
            this.dataGridViewTextBoxColumn1.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIRECCION";
            this.dataGridViewTextBoxColumn3.HeaderText = "DIRECCION";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TELEFONO";
            this.dataGridViewTextBoxColumn4.HeaderText = "TELEFONO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "F_NACIM";
            this.dataGridViewTextBoxColumn5.HeaderText = "F_NACIM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(507, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 33);
            this.button5.TabIndex = 16;
            this.button5.Text = "SALIR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(703, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ASIGNATURA";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(703, 464);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CONSULTAS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(717, 496);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EJERCICIO DE BASE DE DATOS ACCESS – C# ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_profesorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOSDataGridView)).EndInit();
            this.panelAlumno.ResumeLayout(false);
            this.panelAlumno.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}


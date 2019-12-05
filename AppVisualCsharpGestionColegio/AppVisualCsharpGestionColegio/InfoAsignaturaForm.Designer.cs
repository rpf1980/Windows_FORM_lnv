namespace AppVisualCsharpGestionColegio
{
    partial class InfoAsignaturaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idTextBoxID = new System.Windows.Forms.TextBox();
            this.idTbNombre = new System.Windows.Forms.TextBox();
            this.idTbDepart = new System.Windows.Forms.TextBox();
            this.idTbHoras = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(457, 245);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DEPARTAMENTO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "HORAS:";
            // 
            // idTextBoxID
            // 
            this.idTextBoxID.Location = new System.Drawing.Point(202, 105);
            this.idTextBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTextBoxID.Name = "idTextBoxID";
            this.idTextBoxID.Size = new System.Drawing.Size(76, 20);
            this.idTextBoxID.TabIndex = 6;
            // 
            // idTbNombre
            // 
            this.idTbNombre.Location = new System.Drawing.Point(202, 136);
            this.idTbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTbNombre.Name = "idTbNombre";
            this.idTbNombre.Size = new System.Drawing.Size(172, 20);
            this.idTbNombre.TabIndex = 7;
            // 
            // idTbDepart
            // 
            this.idTbDepart.Location = new System.Drawing.Point(202, 164);
            this.idTbDepart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTbDepart.Name = "idTbDepart";
            this.idTbDepart.Size = new System.Drawing.Size(172, 20);
            this.idTbDepart.TabIndex = 8;
            // 
            // idTbHoras
            // 
            this.idTbHoras.Location = new System.Drawing.Point(202, 195);
            this.idTbHoras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTbHoras.Name = "idTbHoras";
            this.idTbHoras.Size = new System.Drawing.Size(76, 20);
            this.idTbHoras.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoAsignaturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::AppVisualCsharpGestionColegio.Properties.Resources.note_297252__340;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(647, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idTbHoras);
            this.Controls.Add(this.idTbDepart);
            this.Controls.Add(this.idTbNombre);
            this.Controls.Add(this.idTextBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoAsignaturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA ASIGNATURA";
            this.Load += new System.EventHandler(this.InfoAsignaturaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTextBoxID;
        private System.Windows.Forms.TextBox idTbNombre;
        private System.Windows.Forms.TextBox idTbDepart;
        private System.Windows.Forms.TextBox idTbHoras;
        private System.Windows.Forms.Button button1;
    }
}
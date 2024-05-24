namespace ventandasybd
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
            this.botonPrueba = new System.Windows.Forms.Button();
            this.personajesdatos = new System.Windows.Forms.DataGridView();
            this.cargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownNIVELPODER = new System.Windows.Forms.NumericUpDown();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNOMBRE = new System.Windows.Forms.TextBox();
            this.botonCrear = new System.Windows.Forms.Button();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerfecha = new System.Windows.Forms.DateTimePicker();
            this.historychanel = new System.Windows.Forms.TextBox();
            this.actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personajesdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNIVELPODER)).BeginInit();
            this.SuspendLayout();
            // 
            // botonPrueba
            // 
            this.botonPrueba.Location = new System.Drawing.Point(655, 291);
            this.botonPrueba.Margin = new System.Windows.Forms.Padding(2);
            this.botonPrueba.Name = "botonPrueba";
            this.botonPrueba.Size = new System.Drawing.Size(113, 50);
            this.botonPrueba.TabIndex = 0;
            this.botonPrueba.Text = "Prueba de conexion";
            this.botonPrueba.UseVisualStyleBackColor = true;
            this.botonPrueba.Click += new System.EventHandler(this.botonPrueba_Click);
            // 
            // personajesdatos
            // 
            this.personajesdatos.BackgroundColor = System.Drawing.Color.LightCyan;
            this.personajesdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personajesdatos.GridColor = System.Drawing.Color.LightSteelBlue;
            this.personajesdatos.Location = new System.Drawing.Point(11, 275);
            this.personajesdatos.Margin = new System.Windows.Forms.Padding(2);
            this.personajesdatos.Name = "personajesdatos";
            this.personajesdatos.RowHeadersWidth = 62;
            this.personajesdatos.RowTemplate.Height = 28;
            this.personajesdatos.Size = new System.Drawing.Size(619, 194);
            this.personajesdatos.TabIndex = 1;
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(655, 427);
            this.cargar.Margin = new System.Windows.Forms.Padding(2);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(113, 42);
            this.cargar.TabIndex = 2;
            this.cargar.Text = "Cargar datos";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "POWER";
            // 
            // numericUpDownNIVELPODER
            // 
            this.numericUpDownNIVELPODER.Location = new System.Drawing.Point(99, 101);
            this.numericUpDownNIVELPODER.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownNIVELPODER.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numericUpDownNIVELPODER.Name = "numericUpDownNIVELPODER";
            this.numericUpDownNIVELPODER.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownNIVELPODER.TabIndex = 7;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(99, 20);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(105, 20);
            this.textBoxID.TabIndex = 8;
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // textBoxNOMBRE
            // 
            this.textBoxNOMBRE.Location = new System.Drawing.Point(99, 44);
            this.textBoxNOMBRE.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNOMBRE.Name = "textBoxNOMBRE";
            this.textBoxNOMBRE.Size = new System.Drawing.Size(105, 20);
            this.textBoxNOMBRE.TabIndex = 9;
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(127, 155);
            this.botonCrear.Margin = new System.Windows.Forms.Padding(2);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(77, 32);
            this.botonCrear.TabIndex = 11;
            this.botonCrear.Text = "crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(99, 68);
            this.comboBoxRaza.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(105, 21);
            this.comboBoxRaza.TabIndex = 12;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(227, 155);
            this.buttonbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(77, 30);
            this.buttonbuscar.TabIndex = 13;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(655, 359);
            this.eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(113, 42);
            this.eliminar.TabIndex = 14;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha creacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Historia";
            // 
            // dateTimePickerfecha
            // 
            this.dateTimePickerfecha.Enabled = false;
            this.dateTimePickerfecha.Location = new System.Drawing.Point(375, 20);
            this.dateTimePickerfecha.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerfecha.Name = "dateTimePickerfecha";
            this.dateTimePickerfecha.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerfecha.TabIndex = 17;
            // 
            // historychanel
            // 
            this.historychanel.Location = new System.Drawing.Point(375, 51);
            this.historychanel.Margin = new System.Windows.Forms.Padding(2);
            this.historychanel.Name = "historychanel";
            this.historychanel.Size = new System.Drawing.Size(214, 20);
            this.historychanel.TabIndex = 18;
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(21, 155);
            this.actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(75, 32);
            this.actualizar.TabIndex = 19;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(797, 572);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.historychanel);
            this.Controls.Add(this.dateTimePickerfecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.textBoxNOMBRE);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.numericUpDownNIVELPODER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.personajesdatos);
            this.Controls.Add(this.botonPrueba);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personajesdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNIVELPODER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonPrueba;
        private System.Windows.Forms.DataGridView personajesdatos;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownNIVELPODER;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNOMBRE;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerfecha;
        private System.Windows.Forms.TextBox historychanel;
        private System.Windows.Forms.Button actualizar;
    }
}


namespace EjemploGenetico
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
            this.BTN_Inicio = new System.Windows.Forms.Button();
            this.RTB_Poblacion = new System.Windows.Forms.RichTextBox();
            this.L_Poblacion = new System.Windows.Forms.Label();
            this.NUD_Poblacion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Presion = new System.Windows.Forms.NumericUpDown();
            this.RTB_NuevaPoblacion = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RTB_Cruzamiento = new System.Windows.Forms.RichTextBox();
            this.BTN_Cruzar = new System.Windows.Forms.Button();
            this.RTB_Mutados = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUD_Mutar = new System.Windows.Forms.NumericUpDown();
            this.BTN_Mutar = new System.Windows.Forms.Button();
            this.BTN_Seleccion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Funcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LABEL_Generaciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Poblacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Presion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Mutar)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Inicio
            // 
            this.BTN_Inicio.Location = new System.Drawing.Point(64, 108);
            this.BTN_Inicio.Name = "BTN_Inicio";
            this.BTN_Inicio.Size = new System.Drawing.Size(75, 23);
            this.BTN_Inicio.TabIndex = 0;
            this.BTN_Inicio.Text = "Inicializar";
            this.BTN_Inicio.UseVisualStyleBackColor = true;
            this.BTN_Inicio.Click += new System.EventHandler(this.BTN_Inicio_Click);
            // 
            // RTB_Poblacion
            // 
            this.RTB_Poblacion.Location = new System.Drawing.Point(15, 175);
            this.RTB_Poblacion.Name = "RTB_Poblacion";
            this.RTB_Poblacion.ReadOnly = true;
            this.RTB_Poblacion.Size = new System.Drawing.Size(171, 289);
            this.RTB_Poblacion.TabIndex = 1;
            this.RTB_Poblacion.Text = "";
            // 
            // L_Poblacion
            // 
            this.L_Poblacion.AutoSize = true;
            this.L_Poblacion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Poblacion.Location = new System.Drawing.Point(12, 70);
            this.L_Poblacion.Name = "L_Poblacion";
            this.L_Poblacion.Size = new System.Drawing.Size(124, 16);
            this.L_Poblacion.TabIndex = 2;
            this.L_Poblacion.Text = "Tamaño de la población:";
            // 
            // NUD_Poblacion
            // 
            this.NUD_Poblacion.Location = new System.Drawing.Point(142, 70);
            this.NUD_Poblacion.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUD_Poblacion.Name = "NUD_Poblacion";
            this.NUD_Poblacion.Size = new System.Drawing.Size(63, 20);
            this.NUD_Poblacion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descarte (%):";
            // 
            // NUD_Presion
            // 
            this.NUD_Presion.Location = new System.Drawing.Point(296, 70);
            this.NUD_Presion.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_Presion.Name = "NUD_Presion";
            this.NUD_Presion.Size = new System.Drawing.Size(63, 20);
            this.NUD_Presion.TabIndex = 5;
            this.NUD_Presion.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // RTB_NuevaPoblacion
            // 
            this.RTB_NuevaPoblacion.Location = new System.Drawing.Point(208, 175);
            this.RTB_NuevaPoblacion.Name = "RTB_NuevaPoblacion";
            this.RTB_NuevaPoblacion.ReadOnly = true;
            this.RTB_NuevaPoblacion.Size = new System.Drawing.Size(169, 289);
            this.RTB_NuevaPoblacion.TabIndex = 6;
            this.RTB_NuevaPoblacion.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Población Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Población seleccionada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Población Cruzamiento";
            // 
            // RTB_Cruzamiento
            // 
            this.RTB_Cruzamiento.Location = new System.Drawing.Point(398, 175);
            this.RTB_Cruzamiento.Name = "RTB_Cruzamiento";
            this.RTB_Cruzamiento.ReadOnly = true;
            this.RTB_Cruzamiento.Size = new System.Drawing.Size(154, 289);
            this.RTB_Cruzamiento.TabIndex = 10;
            this.RTB_Cruzamiento.Text = "";
            // 
            // BTN_Cruzar
            // 
            this.BTN_Cruzar.Enabled = false;
            this.BTN_Cruzar.Location = new System.Drawing.Point(444, 108);
            this.BTN_Cruzar.Name = "BTN_Cruzar";
            this.BTN_Cruzar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cruzar.TabIndex = 11;
            this.BTN_Cruzar.Text = "Cruzamiento";
            this.BTN_Cruzar.UseVisualStyleBackColor = true;
            this.BTN_Cruzar.Click += new System.EventHandler(this.BTN_Cruzar_Click);
            // 
            // RTB_Mutados
            // 
            this.RTB_Mutados.Location = new System.Drawing.Point(581, 175);
            this.RTB_Mutados.Name = "RTB_Mutados";
            this.RTB_Mutados.ReadOnly = true;
            this.RTB_Mutados.Size = new System.Drawing.Size(169, 289);
            this.RTB_Mutados.TabIndex = 12;
            this.RTB_Mutados.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(626, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Población Mutada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(578, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Probabilidad de mutar";
            // 
            // NUD_Mutar
            // 
            this.NUD_Mutar.DecimalPlaces = 2;
            this.NUD_Mutar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUD_Mutar.Location = new System.Drawing.Point(695, 74);
            this.NUD_Mutar.Name = "NUD_Mutar";
            this.NUD_Mutar.Size = new System.Drawing.Size(63, 20);
            this.NUD_Mutar.TabIndex = 15;
            this.NUD_Mutar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BTN_Mutar
            // 
            this.BTN_Mutar.Enabled = false;
            this.BTN_Mutar.Location = new System.Drawing.Point(629, 108);
            this.BTN_Mutar.Name = "BTN_Mutar";
            this.BTN_Mutar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Mutar.TabIndex = 16;
            this.BTN_Mutar.Text = "Mutación";
            this.BTN_Mutar.UseVisualStyleBackColor = true;
            this.BTN_Mutar.Click += new System.EventHandler(this.BTN_Mutar_Click);
            // 
            // BTN_Seleccion
            // 
            this.BTN_Seleccion.Enabled = false;
            this.BTN_Seleccion.Location = new System.Drawing.Point(253, 108);
            this.BTN_Seleccion.Name = "BTN_Seleccion";
            this.BTN_Seleccion.Size = new System.Drawing.Size(75, 23);
            this.BTN_Seleccion.TabIndex = 17;
            this.BTN_Seleccion.Text = "Selección";
            this.BTN_Seleccion.UseVisualStyleBackColor = true;
            this.BTN_Seleccion.Click += new System.EventHandler(this.BTN_Seleccion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Función objetivo:";
            // 
            // TB_Funcion
            // 
            this.TB_Funcion.Location = new System.Drawing.Point(105, 27);
            this.TB_Funcion.Name = "TB_Funcion";
            this.TB_Funcion.Size = new System.Drawing.Size(100, 20);
            this.TB_Funcion.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(421, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Numero de generaciones:";
            // 
            // LABEL_Generaciones
            // 
            this.LABEL_Generaciones.AutoSize = true;
            this.LABEL_Generaciones.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_Generaciones.Location = new System.Drawing.Point(558, 24);
            this.LABEL_Generaciones.Name = "LABEL_Generaciones";
            this.LABEL_Generaciones.Size = new System.Drawing.Size(83, 16);
            this.LABEL_Generaciones.TabIndex = 21;
            this.LABEL_Generaciones.Text = "Población Inicial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(775, 502);
            this.Controls.Add(this.LABEL_Generaciones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_Funcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTN_Seleccion);
            this.Controls.Add(this.BTN_Mutar);
            this.Controls.Add(this.NUD_Mutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RTB_Mutados);
            this.Controls.Add(this.BTN_Cruzar);
            this.Controls.Add(this.RTB_Cruzamiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RTB_NuevaPoblacion);
            this.Controls.Add(this.NUD_Presion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_Poblacion);
            this.Controls.Add(this.L_Poblacion);
            this.Controls.Add(this.RTB_Poblacion);
            this.Controls.Add(this.BTN_Inicio);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Poblacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Presion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Mutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Inicio;
        private System.Windows.Forms.RichTextBox RTB_Poblacion;
        private System.Windows.Forms.Label L_Poblacion;
        private System.Windows.Forms.NumericUpDown NUD_Poblacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_Presion;
        private System.Windows.Forms.RichTextBox RTB_NuevaPoblacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RTB_Cruzamiento;
        private System.Windows.Forms.Button BTN_Cruzar;
        private System.Windows.Forms.RichTextBox RTB_Mutados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUD_Mutar;
        private System.Windows.Forms.Button BTN_Mutar;
        private System.Windows.Forms.Button BTN_Seleccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Funcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LABEL_Generaciones;
    }
}


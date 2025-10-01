namespace GestionAvanzadaDeInformacionPersonal
{
    partial class FormPrincipal
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
            this.tcGestion = new System.Windows.Forms.TabControl();
            this.tpDatosPersonales = new System.Windows.Forms.TabPage();
            this.tpPreferencias = new System.Windows.Forms.TabPage();
            this.tpVisualizacion = new System.Windows.Forms.TabPage();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbGenero = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.mCFechaNac = new System.Windows.Forms.MonthCalendar();
            this.lbEdad = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbBoletin = new System.Windows.Forms.Label();
            this.cbSi = new System.Windows.Forms.CheckBox();
            this.cbNo = new System.Windows.Forms.CheckBox();
            this.clbIntereses = new System.Windows.Forms.CheckedListBox();
            this.lbIntereses = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lbPais = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lbCalificacion = new System.Windows.Forms.Label();
            this.pbImagenPerfil = new System.Windows.Forms.PictureBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbHora = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tcGestion.SuspendLayout();
            this.tpDatosPersonales.SuspendLayout();
            this.tpPreferencias.SuspendLayout();
            this.tpVisualizacion.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // tcGestion
            // 
            this.tcGestion.Controls.Add(this.tpDatosPersonales);
            this.tcGestion.Controls.Add(this.tpPreferencias);
            this.tcGestion.Controls.Add(this.tpVisualizacion);
            this.tcGestion.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcGestion.Location = new System.Drawing.Point(-7, 12);
            this.tcGestion.Name = "tcGestion";
            this.tcGestion.SelectedIndex = 0;
            this.tcGestion.Size = new System.Drawing.Size(812, 447);
            this.tcGestion.TabIndex = 0;
            // 
            // tpDatosPersonales
            // 
            this.tpDatosPersonales.Controls.Add(this.nudEdad);
            this.tpDatosPersonales.Controls.Add(this.lbEdad);
            this.tpDatosPersonales.Controls.Add(this.mCFechaNac);
            this.tpDatosPersonales.Controls.Add(this.lbFechaNac);
            this.tpDatosPersonales.Controls.Add(this.lbGenero);
            this.tpDatosPersonales.Controls.Add(this.panel1);
            this.tpDatosPersonales.Controls.Add(this.tbEmail);
            this.tpDatosPersonales.Controls.Add(this.tbDireccion);
            this.tpDatosPersonales.Controls.Add(this.tbNombre);
            this.tpDatosPersonales.Controls.Add(this.lbEmail);
            this.tpDatosPersonales.Controls.Add(this.lbDireccion);
            this.tpDatosPersonales.Controls.Add(this.lbNombre);
            this.tpDatosPersonales.Location = new System.Drawing.Point(4, 27);
            this.tpDatosPersonales.Name = "tpDatosPersonales";
            this.tpDatosPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosPersonales.Size = new System.Drawing.Size(804, 416);
            this.tpDatosPersonales.TabIndex = 0;
            this.tpDatosPersonales.Text = "Datos Personales";
            this.tpDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // tpPreferencias
            // 
            this.tpPreferencias.Controls.Add(this.lbCalificacion);
            this.tpPreferencias.Controls.Add(this.trackBar2);
            this.tpPreferencias.Controls.Add(this.lbPais);
            this.tpPreferencias.Controls.Add(this.cbPais);
            this.tpPreferencias.Controls.Add(this.lbIntereses);
            this.tpPreferencias.Controls.Add(this.clbIntereses);
            this.tpPreferencias.Controls.Add(this.lbBoletin);
            this.tpPreferencias.Controls.Add(this.panel2);
            this.tpPreferencias.Location = new System.Drawing.Point(4, 27);
            this.tpPreferencias.Name = "tpPreferencias";
            this.tpPreferencias.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreferencias.Size = new System.Drawing.Size(804, 416);
            this.tpPreferencias.TabIndex = 1;
            this.tpPreferencias.Text = "Preferencias";
            this.tpPreferencias.UseVisualStyleBackColor = true;
            // 
            // tpVisualizacion
            // 
            this.tpVisualizacion.Controls.Add(this.toolStrip1);
            this.tpVisualizacion.Controls.Add(this.lbHora);
            this.tpVisualizacion.Controls.Add(this.btSalir);
            this.tpVisualizacion.Controls.Add(this.btLimpiar);
            this.tpVisualizacion.Controls.Add(this.btGuardar);
            this.tpVisualizacion.Controls.Add(this.pbImagenPerfil);
            this.tpVisualizacion.Location = new System.Drawing.Point(4, 27);
            this.tpVisualizacion.Name = "tpVisualizacion";
            this.tpVisualizacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpVisualizacion.Size = new System.Drawing.Size(804, 416);
            this.tpVisualizacion.TabIndex = 2;
            this.tpVisualizacion.Text = "Visualización";
            this.tpVisualizacion.UseVisualStyleBackColor = true;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(93, 54);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(57, 17);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            this.lbNombre.Click += new System.EventHandler(this.lbNombre_Click);
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(86, 90);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(64, 17);
            this.lbDireccion.TabIndex = 1;
            this.lbDireccion.Text = "Dirección:";
            this.lbDireccion.Click += new System.EventHandler(this.lbDireccion_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(32, 129);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(118, 17);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Correo electrónico:";
            this.lbEmail.Click += new System.EventHandler(this.lbEmail_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(170, 48);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(132, 25);
            this.tbNombre.TabIndex = 3;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(170, 82);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(132, 25);
            this.tbDireccion.TabIndex = 4;
            this.tbDireccion.TextChanged += new System.EventHandler(this.tbDireccion_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(170, 121);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(132, 25);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbOtro);
            this.panel1.Controls.Add(this.rbFemenino);
            this.panel1.Controls.Add(this.rbMasculino);
            this.panel1.Location = new System.Drawing.Point(170, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 100);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(96, 219);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(54, 17);
            this.lbGenero.TabIndex = 8;
            this.lbGenero.Text = "Género:";
            this.lbGenero.Click += new System.EventHandler(this.lbGenero_Click);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(14, 13);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(86, 21);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(14, 40);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(86, 21);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            this.rbFemenino.CheckedChanged += new System.EventHandler(this.rbFemenino_CheckedChanged);
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(14, 67);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(54, 21);
            this.rbOtro.TabIndex = 2;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Location = new System.Drawing.Point(374, 54);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(118, 17);
            this.lbFechaNac.TabIndex = 9;
            this.lbFechaNac.Text = "Fecha Nacimiento:";
            this.lbFechaNac.Click += new System.EventHandler(this.lbFechaNac_Click);
            // 
            // mCFechaNac
            // 
            this.mCFechaNac.Location = new System.Drawing.Point(504, 48);
            this.mCFechaNac.Name = "mCFechaNac";
            this.mCFechaNac.TabIndex = 10;
            this.mCFechaNac.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCFechaNac_DateChanged);
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(108, 292);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(42, 17);
            this.lbEdad.TabIndex = 11;
            this.lbEdad.Text = "Edad:";
            this.lbEdad.Click += new System.EventHandler(this.lbEdad_Click);
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(170, 286);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(132, 25);
            this.nudEdad.TabIndex = 12;
            this.nudEdad.ValueChanged += new System.EventHandler(this.nudEdad_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbNo);
            this.panel2.Controls.Add(this.cbSi);
            this.panel2.Location = new System.Drawing.Point(226, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 62);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbBoletin
            // 
            this.lbBoletin.AutoSize = true;
            this.lbBoletin.Location = new System.Drawing.Point(28, 46);
            this.lbBoletin.Name = "lbBoletin";
            this.lbBoletin.Size = new System.Drawing.Size(192, 17);
            this.lbBoletin.TabIndex = 1;
            this.lbBoletin.Text = "¿Desea suscribirse al boletín?";
            this.lbBoletin.Click += new System.EventHandler(this.lbBoletin_Click);
            // 
            // cbSi
            // 
            this.cbSi.AutoSize = true;
            this.cbSi.Location = new System.Drawing.Point(3, 3);
            this.cbSi.Name = "cbSi";
            this.cbSi.Size = new System.Drawing.Size(42, 21);
            this.cbSi.TabIndex = 0;
            this.cbSi.Text = "Sí";
            this.cbSi.UseVisualStyleBackColor = true;
            this.cbSi.CheckedChanged += new System.EventHandler(this.cbSi_CheckedChanged);
            // 
            // cbNo
            // 
            this.cbNo.AutoSize = true;
            this.cbNo.Location = new System.Drawing.Point(3, 38);
            this.cbNo.Name = "cbNo";
            this.cbNo.Size = new System.Drawing.Size(136, 21);
            this.cbNo.TabIndex = 1;
            this.cbNo.Text = "En otro momento";
            this.cbNo.UseVisualStyleBackColor = true;
            this.cbNo.CheckedChanged += new System.EventHandler(this.cbNo_CheckedChanged);
            // 
            // clbIntereses
            // 
            this.clbIntereses.FormattingEnabled = true;
            this.clbIntereses.Items.AddRange(new object[] {
            "Deporte",
            "Música",
            "Salida al aire libre",
            "Hípica",
            "Gaming",
            "Compras",
            "Viajes",
            "Series",
            "Películas"});
            this.clbIntereses.Location = new System.Drawing.Point(34, 143);
            this.clbIntereses.Name = "clbIntereses";
            this.clbIntereses.Size = new System.Drawing.Size(334, 184);
            this.clbIntereses.TabIndex = 2;
            this.clbIntereses.SelectedIndexChanged += new System.EventHandler(this.clbIntereses_SelectedIndexChanged);
            // 
            // lbIntereses
            // 
            this.lbIntereses.AutoSize = true;
            this.lbIntereses.Location = new System.Drawing.Point(31, 111);
            this.lbIntereses.Name = "lbIntereses";
            this.lbIntereses.Size = new System.Drawing.Size(64, 17);
            this.lbIntereses.TabIndex = 3;
            this.lbIntereses.Text = "Intereses:";
            this.lbIntereses.Click += new System.EventHandler(this.lbIntereses_Click);
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "España",
            "Francia",
            "UK",
            "Portugal",
            "Italia",
            "EEUU",
            "Argentina",
            "México",
            "Noruega",
            "Alemania"});
            this.cbPais.Location = new System.Drawing.Point(598, 38);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(139, 25);
            this.cbPais.TabIndex = 4;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(461, 46);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(122, 17);
            this.lbPais.TabIndex = 5;
            this.lbPais.Text = "País de residencia:";
            this.lbPais.Click += new System.EventHandler(this.lbPais_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(598, 292);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(139, 56);
            this.trackBar2.TabIndex = 7;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // lbCalificacion
            // 
            this.lbCalificacion.AutoSize = true;
            this.lbCalificacion.Location = new System.Drawing.Point(410, 310);
            this.lbCalificacion.Name = "lbCalificacion";
            this.lbCalificacion.Size = new System.Drawing.Size(173, 17);
            this.lbCalificacion.TabIndex = 8;
            this.lbCalificacion.Text = "Satisfacción con el servicio:";
            this.lbCalificacion.Click += new System.EventHandler(this.lbCalificacion_Click);
            // 
            // pbImagenPerfil
            // 
            this.pbImagenPerfil.Location = new System.Drawing.Point(25, 46);
            this.pbImagenPerfil.Name = "pbImagenPerfil";
            this.pbImagenPerfil.Size = new System.Drawing.Size(100, 124);
            this.pbImagenPerfil.TabIndex = 0;
            this.pbImagenPerfil.TabStop = false;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(174, 355);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 28);
            this.btGuardar.TabIndex = 1;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(326, 355);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 28);
            this.btLimpiar.TabIndex = 2;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(470, 355);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 28);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(251, 23);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(0, 17);
            this.lbHora.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcGestion);
            this.Name = "FormPrincipal";
            this.Text = "Gestión Avanzada de Información personal";
            this.tcGestion.ResumeLayout(false);
            this.tpDatosPersonales.ResumeLayout(false);
            this.tpDatosPersonales.PerformLayout();
            this.tpPreferencias.ResumeLayout(false);
            this.tpPreferencias.PerformLayout();
            this.tpVisualizacion.ResumeLayout(false);
            this.tpVisualizacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcGestion;
        private System.Windows.Forms.TabPage tpDatosPersonales;
        private System.Windows.Forms.TabPage tpPreferencias;
        private System.Windows.Forms.TabPage tpVisualizacion;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.MonthCalendar mCFechaNac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox clbIntereses;
        private System.Windows.Forms.Label lbBoletin;
        private System.Windows.Forms.CheckBox cbNo;
        private System.Windows.Forms.CheckBox cbSi;
        private System.Windows.Forms.Label lbIntereses;
        private System.Windows.Forms.Label lbCalificacion;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.PictureBox pbImagenPerfil;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timer1;
    }
}


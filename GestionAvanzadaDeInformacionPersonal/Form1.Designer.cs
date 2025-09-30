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
            this.tcGestion = new System.Windows.Forms.TabControl();
            this.tpDatosPersonales = new System.Windows.Forms.TabPage();
            this.tpPreferencias = new System.Windows.Forms.TabPage();
            this.tpVisualizacion = new System.Windows.Forms.TabPage();
            this.tcGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcGestion
            // 
            this.tcGestion.Controls.Add(this.tpDatosPersonales);
            this.tcGestion.Controls.Add(this.tpPreferencias);
            this.tcGestion.Controls.Add(this.tpVisualizacion);
            this.tcGestion.Location = new System.Drawing.Point(-7, 12);
            this.tcGestion.Name = "tcGestion";
            this.tcGestion.SelectedIndex = 0;
            this.tcGestion.Size = new System.Drawing.Size(812, 447);
            this.tcGestion.TabIndex = 0;
            // 
            // tpDatosPersonales
            // 
            this.tpDatosPersonales.Location = new System.Drawing.Point(4, 25);
            this.tpDatosPersonales.Name = "tpDatosPersonales";
            this.tpDatosPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosPersonales.Size = new System.Drawing.Size(804, 418);
            this.tpDatosPersonales.TabIndex = 0;
            this.tpDatosPersonales.Text = "Datos Personales";
            this.tpDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // tpPreferencias
            // 
            this.tpPreferencias.Location = new System.Drawing.Point(4, 25);
            this.tpPreferencias.Name = "tpPreferencias";
            this.tpPreferencias.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreferencias.Size = new System.Drawing.Size(398, 112);
            this.tpPreferencias.TabIndex = 1;
            this.tpPreferencias.Text = "Preferencias";
            this.tpPreferencias.UseVisualStyleBackColor = true;
            // 
            // tpVisualizacion
            // 
            this.tpVisualizacion.Location = new System.Drawing.Point(4, 25);
            this.tpVisualizacion.Name = "tpVisualizacion";
            this.tpVisualizacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpVisualizacion.Size = new System.Drawing.Size(398, 112);
            this.tpVisualizacion.TabIndex = 2;
            this.tpVisualizacion.Text = "Visualización";
            this.tpVisualizacion.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcGestion;
        private System.Windows.Forms.TabPage tpDatosPersonales;
        private System.Windows.Forms.TabPage tpPreferencias;
        private System.Windows.Forms.TabPage tpVisualizacion;
    }
}


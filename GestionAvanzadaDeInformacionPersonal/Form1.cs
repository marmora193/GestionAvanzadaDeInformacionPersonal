using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionAvanzadaDeInformacionPersonal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            // Iniciamos Timer para mostrar fecha y hora actual
            timer1.Interval = 1000; //1 segundo
            timer1.Start();

            //Cargamos países en ComboBox
            cbPais.Items.AddRange(new string[] { 
                "España", "Francia", "UK", "Portugal", "Italia", "EEUU", "Argentina", "México", "Noruega", "Alemania" });

            //Cargamos los hobbies en el CheckedListBox
            clbIntereses.Items.AddRange(new string[] {
                "Deporte", "Música", "Salida al aire libre", "Hípica", "Gaming", "Compras", "Viajes", "Series", "Películas" });

            //Cargamos los tools tips
            ttGuardar.SetToolTip(btGuardar, "Haz clic para guardar los datos ingresados");
            ttLimpiar.SetToolTip(btLimpiar, "Haz clic para limpiar todos los campos");
            ttSalir.SetToolTip(btSalir, "Haz clic para cerrar la aplicación");
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbDireccion_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbGenero_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nudEdad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbEdad_Click(object sender, EventArgs e)
        {

        }

        private void lbFechaNac_Click(object sender, EventArgs e)
        {

        }

        private void mCFechaNac_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void lbBoletin_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbIntereses_Click(object sender, EventArgs e)
        {

        }

        private void clbIntereses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbPais_Click(object sender, EventArgs e)
        {

        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbCalificacion_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            // Validamos que los campos obligatorios estén completos
            if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
                string.IsNullOrWhiteSpace(tbDireccion.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) ||
                (!rbMasculino.Checked && !rbFemenino.Checked && !rbOtro.Checked) ||
                cbPais.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Mostramos un resumen de la información ingresada
            StringBuilder resumen = new StringBuilder();
            resumen.AppendLine("Nombre: " + tbNombre.Text);
            resumen.AppendLine("Dirección: " + tbDireccion.Text);
            resumen.AppendLine("Email: " + tbEmail.Text);
            resumen.AppendLine("Edad: " + nudEdad.Value);
            resumen.AppendLine("Género: " + (rbMasculino.Checked ? "Masculino" : rbFemenino.Checked ? "Femenino" : "Otro"));
            resumen.AppendLine("Fecha de Nacimiento: " + mCFechaNac.SelectionStart.ToShortDateString());
            resumen.AppendLine("País: " + cbPais.SelectedItem.ToString());
            resumen.AppendLine("Intereses: " + string.Join(", ", clbIntereses.CheckedItems.Cast<string>()));
            resumen.AppendLine("Boletín: " + (cbSi.Checked ? "Sí" : cbNo.Checked ? "No" : "No especificado"));
            resumen.AppendLine("Calificación: " + trackBar2.Value);
            MessageBox.Show(resumen.ToString(), "Resumen de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbDireccion.Clear();
            tbEmail.Clear();
            nudEdad.Value = 0;
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            rbOtro.Checked = false;
            cbPais.SelectedIndex = -1;
            clbIntereses.ClearSelected();
            for (int i = 0; i < clbIntereses.Items.Count; i++)
            {
                clbIntereses.SetItemChecked(i, false);
            }
            cbSi.Checked = false;
            cbNo.Checked = false;
            trackBar2.Value = 1;
            pbImagenPerfil.Image = null;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbImagenPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            abrirImagen.Filter = "Archivos de Imagen|*.jpg;*.png;*.bmp";
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pbImagenPerfil.Image = System.Drawing.Image.FromFile(abrirImagen.FileName);
                pbImagenPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void ttGuardar_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ttLimpiar_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ttSalir_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Final_Lab2
{
    public partial class frmListadoPorActividad : Form
    {
        public frmListadoPorActividad()
        {
            InitializeComponent();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Close();
            // Verifica si el formulario original ya está abierto
            PRINCIPAL formularioOriginal = Application.OpenForms["FormularioOriginal"] as PRINCIPAL;

            // Si el formulario original está abierto, lo muestra
            if (formularioOriginal != null)
            {
                formularioOriginal.Show();

            }
          
        }
        Actividad x = new Actividad();
        Socio s = new Socio();
        private void frmListadoPorActividad_Load(object sender, EventArgs e)
        {
            
            x.CargaActividad(cmbActividad);
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 idActividad = Convert.ToInt32(cmbActividad.SelectedValue);
            s.ListadoActividad(dgvGrilla,lblMayor,lblMenor,lblPromedio,lblTotalDeuda,idActividad);

        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 idactividad = Convert.ToInt32(cmbActividad.SelectedValue);
                saveFileDialog1.Title = "Guardar Reporte";
                saveFileDialog1.Filter = "Valores separados por comas(.csv)|*.csv";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    s.ImprimirReporteActividad(saveFileDialog1.FileName,idactividad);
                    MessageBox.Show("Reporte guardado correctamente");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error en el guardado del reporte", "Guardar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();

            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;

            prtDocumento.Print();
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Int32 id = Convert.ToInt32(cmbActividad.SelectedValue);
            s.ImprimirListadoActividad(e, cmbActividad,id);
        }
    }
}

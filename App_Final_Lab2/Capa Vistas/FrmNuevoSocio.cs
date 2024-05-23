using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // libreria para poder hacer que el formulario se mueva aunque no tenga bordes

namespace App_Final_Lab2
{
    public partial class FrmNuevoSocio : Form
    {
        public FrmNuevoSocio()
        {
            InitializeComponent();
        }
        Barrio b = new Barrio();
        Actividad a = new Actividad();
        Socio s = new Socio();
        private void FrmNuevoSocio_Load(object sender, EventArgs e)
        {
            b.CargarBarrio(cmdBarrio);
            a.CargaActividad(cmbActividad);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
        // codigos para poder hacer que el formulario se mueva desde los submenues 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelSup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtDeuda.Text!= "" && txtDNI.Text != "" && txtDireccion.Text!="" && txtDeuda.Text!= "" )
            {
                s.idsocio = Convert.ToInt32(txtDNI.Text);
                s.nom = txtNombre.Text;
                s.dire = txtDireccion.Text;
                s.idact = Convert.ToInt32(cmbActividad.SelectedValue);
                s.idbarrio = Convert.ToInt32(cmdBarrio.SelectedValue);
                s.deu = Convert.ToDecimal(txtDeuda.Text);

                s.AgregarSocio();
                MessageBox.Show("El socio se guardo correctamente", "CARGA DE SOCIO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDNI.Text = "";
                txtNombre.Text = "";
                txtDireccion.Text = "";
                cmbActividad.SelectedIndex = 0;
                cmdBarrio.SelectedIndex = 0;
                txtDeuda.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos requeridos", "NUEVO SOCIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) )
            {
                e.Handled = true;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

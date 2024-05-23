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
    public partial class frmBuscarSocio : Form
    {
        public frmBuscarSocio()
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

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            txtDeuda.Enabled = true;
            txtDireccion.Enabled = true;
            txtNombre.Enabled = true;
            cmbActividad.Enabled = true;
            cmbBarrio.Enabled = true;
            cmdIGuardar.Visible = true;
        }
        Socio s = new Socio();
        private void frmBuscarSocio_Load(object sender, EventArgs e)
        {
            
            Actividad a = new Actividad();
            Barrio b = new Barrio();
            b.CargarBarrio(cmbBarrio);
            a.CargaActividad(cmbActividad);
            cmbActividad.SelectedIndex = -1;
            cmbBarrio.SelectedIndex = -1;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdSocio.Text != "")

            {
               
                 Int32 idsocio = Convert.ToInt32(txtIdSocio.Text);
                 s.BuscarSocio(idsocio, txtNombre, txtDireccion, cmbBarrio, cmbActividad, txtDeuda,cmdModificar,cmdEliminar);
                
               
              
                
            }
            else
            {
                MessageBox.Show("Por favor ingrese un numero de socio", "BUSCAR SOCIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void cmdIGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea guardar los cambios ?", "MODIFICACION SOCIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                s.idsocio = Convert.ToInt32(txtIdSocio.Text);
                s.nom = txtNombre.Text;
                s.dire = txtDireccion.Text;
                s.idbarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
                s.idact = Convert.ToInt32(cmbActividad.SelectedValue);
                s.deu = Convert.ToDecimal(txtDeuda.Text);


                s.ModificarSocio();



                txtIdSocio.Text = "";
                txtNombre.Text = "";
                txtDireccion.Text = "";
                cmbBarrio.Text = "";
                cmbActividad.Text = "";
                txtDeuda.Text = "";
                cmdModificar.Visible = false;
                cmdEliminar.Visible = false;
                cmdIGuardar.Visible = false;
                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;
                cmbBarrio.Enabled = false;
                cmbActividad.Enabled = false;
                txtDeuda.Enabled = false;



                MessageBox.Show("Modificacion realizada correctamente", "GUARDAR CAMBIOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            
            
            
            

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Confirme si quiere eliminar al socio seleccionado", "ELIMINAR SOCIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Int32 idsocio = Convert.ToInt32(txtIdSocio.Text);
                s.EliminarSocio(idsocio);

                MessageBox.Show("Modificacion realizada correctamente", "ELIMINAR SOCIO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtIdSocio.Text = "";
                txtNombre.Text = "";
                txtDireccion.Text = "";
                cmbBarrio.Text = "";
                cmbActividad.Text = "";
                txtDeuda.Text = "";
                cmdModificar.Visible = false;
                cmdEliminar.Visible = false;
                cmdIGuardar.Visible = false;
                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;
                cmbBarrio.Enabled = false;
                cmbActividad.Enabled = false;
                txtDeuda.Enabled = false;
            }
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void txtDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtIdSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}

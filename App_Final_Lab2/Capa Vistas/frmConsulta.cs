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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        Socio s = new Socio();
        private void frmConsulta_Load(object sender, EventArgs e)
        {
            s.CargaNombreSocio(cmbNombre);
        }

        private void cmdConsulta_Click(object sender, EventArgs e)
        {
            Int32 idSocio = Convert.ToInt32(cmbNombre.SelectedValue);
            s.ConsultarSocio(idSocio,txtIdSocio,txtDireccion,txtBarrio,txtActividad,txtDeuda);
        }
    }
}

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
using System.Data.OleDb;
using System.Windows.Forms.DataVisualization.Charting;




namespace App_Final_Lab2
{
    public partial class PRINCIPAL : Form
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= BD_Clientes.mdb";
       

        public PRINCIPAL()
        {
            InitializeComponent();
            this.Activated += FormPrincipal_Activated;
        }
        
        
        Socio s = new Socio();
       
        
        private void PRINCIPAL_Load(object sender, EventArgs e)
        {
            OcultarMenues();
            timer1.Start();
            s.CantidadSocios(lblCantidadSocios);
            MostrarGrafico2();





        }
        private void FormPrincipal_Activated(object sender, EventArgs e)
        {
            // Código que deseas ejecutar cada vez que el formulario se activa
            s.CantidadSocios(lblCantidadSocios);
            MostrarGrafico2();
        }
        
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OcultarMenues() 
        {
            SubmenuListados.Visible = false;
            SubmenuSistema.Visible = false;
            SubmenuSocios.Visible = false;

        
        }
        // variable para la funcionalidad de cerrar los sub menues con doble click
        private DateTime ultimoClic = DateTime.Now;
        private void cmdSocios_Click(object sender, EventArgs e)
        {
            SubmenuSocios.Visible = true;
            //logica del doble click
            TimeSpan diferencia = DateTime.Now - ultimoClic;

            // Si la diferencia de tiempo es menor que un cierto valor (por ejemplo, 500 milisegundos), considera que es un doble clic.
            if (diferencia.TotalMilliseconds < 500)
            {
                // Realiza la acción que deseas cuando se haga doble clic en el botón.
                SubmenuSocios.Visible = false;
            }

            // Actualiza el tiempo del último clic.
            ultimoClic = DateTime.Now;

            
        }

        private void cmdListados_Click(object sender, EventArgs e)
        {
            SubmenuListados.Visible = true;
            //logica del doble click
            
            TimeSpan diferencia = DateTime.Now - ultimoClic;

            // Si la diferencia de tiempo es menor que un cierto valor (por ejemplo, 500 milisegundos), considera que es un doble clic.
            if (diferencia.TotalMilliseconds < 500)
            {
                // Realiza la acción que deseas cuando se haga doble clic en el botón.
                SubmenuListados.Visible = false;
            }

            // Actualiza el tiempo del último clic.
            ultimoClic = DateTime.Now;
        }

        private void cmdSistema_Click(object sender, EventArgs e)
        {
            SubmenuSistema.Visible = true;
            //logica del doble click
            TimeSpan diferencia = DateTime.Now - ultimoClic;
            // Si la diferencia de tiempo es menor que un cierto valor (por ejemplo, 500 milisegundos), considera que es un doble clic.
            if (diferencia.TotalMilliseconds < 500)
            {
                // Realiza la acción que deseas cuando se haga doble clic en el botón.
                SubmenuSistema.Visible = false;
            }

            // Actualiza el tiempo del último clic.
            ultimoClic = DateTime.Now;
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

        private void PanelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelLateral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmdMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cmdMinVentana.Visible = true;
            cmdMaximizar.Visible = false;

        }

        private void cmdMinVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            cmdMinVentana.Visible = false;
            cmdMaximizar.Visible = true;

          
        }

        private void cmdMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CmdNuevoSocio_Click(object sender, EventArgs e)
        {
            FrmNuevoSocio ventana = new FrmNuevoSocio();
            ventana.ShowDialog();
           

        }

        private void cmdListadoGneral_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmListaGeneral>();
            
        }

        // Codigo para abrir formularios en panel Contenedor 
        public void AbrirFormulario<NuevoForm>() where NuevoForm : Form, new()
        {
            Form Formulario; // creamos un formulario
            Formulario = panelContenedor.Controls.OfType<NuevoForm>().FirstOrDefault();// busca el formulario en la coleccion si existe o no 

            // si el formulario o instancia no existe
            if (Formulario == null)
            {

                if (panelContenedor.Controls.Count > 4)
                {
                    // Puedes mostrar un mensaje, lanzar una excepción, o realizar alguna otra acción según tus necesidades.
                    MessageBox.Show("Regrese a inicio con el boton Volver para poder realizar la accion" ,"Control Usuario",MessageBoxButtons.OK , MessageBoxIcon.Information);
                    return;

                    
                }

               

                Formulario = new NuevoForm();
                Formulario.TopLevel = false;// decimos que no es un formulario de nivel superior
                panelContenedor.Controls.Add(Formulario);
                panelContenedor.Tag = Formulario;


                
                
                Formulario.Show();
                Formulario.BringToFront();

                Formulario.Resize -= (sender, e) =>
                {
                    // Ajustar el tamaño del formulario al tamaño del panel contenedor
                    Formulario.Size = panelContenedor.Size;
                };

                // Manejar el evento SizeChanged del formulario principal (formulario padre)
                this.SizeChanged += (sender, e) =>
                {
                    // Ajustar el tamaño del formulario secundario al tamaño del panel contenedor
                    Formulario.Size = panelContenedor.Size;
                };

                if (this.WindowState == FormWindowState.Maximized)
                {
                    Formulario.Size = panelContenedor.Size;
                }
            }
            else// si el formulario existe
            {
                Formulario.BringToFront();
            }








        }

        private void cmdListaDeudores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmListadoDeudores>();
            
        }

        private void cmdListaActividad_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmListadoPorActividad>();
            
        }

        private void cmdListaBarrio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmListadoPorBarrio>();
            
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmBuscarSocio>();
            
        }

        private void cmdConsulta_Click(object sender, EventArgs e)
        {
            frmConsulta ventana = new frmConsulta();
            ventana.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmAcercaDe ventana = new frmAcercaDe();
            ventana.ShowDialog();
        }

        private void chtEstadisticas_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void PanelInferior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelLateral_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void MostrarGrafico()
        {
            try
            {
               
                string sql = "SELECT TOP 5 Nombre, Deuda FROM Socio ORDER BY Deuda DESC;";

                using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
                {
                    using (OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, conexion))
                    {
                        DataTable tablaDeudores = new DataTable();
                        adaptador.Fill(tablaDeudores);

                        // Configurar el gráfico
                        chart1.Series.Clear();
                        chart1.Series.Add("Deuda");
                        foreach (DataRow row in tablaDeudores.Rows)
                        {
                            string nombre = row["Nombre"].ToString();
                            double deuda = Convert.ToDouble(row["Deuda"]);

                            // Agregar punto al gráfico
                            chart1.Series["Deuda"].Points.AddXY(nombre, deuda);
                        }
                        

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el gráfico: " + ex.Message);
            }
        }
        private void MostrarGrafico2()
        {
            try
            {

                string sql = "SELECT TOP 5 Nombre, Deuda FROM Socio ORDER BY Deuda DESC;";
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                adaptador = new OleDbDataAdapter(sql, conexion);

                DataTable DS = new DataTable();
                adaptador.Fill(DS);
                chart1.Series.Clear();
                chart1.Series.Add("Top 5 Deudores");
                foreach (DataRow fila in DS.Rows)
                {
                    String nombre = fila["Nombre"].ToString();
                    Decimal deuda = Convert.ToDecimal(fila["Deuda"]);

                    // Agregar punto al gráfico
                    chart1.Series["Top 5 Deudores"].Points.AddXY(nombre,deuda);
                }
                
                chart1.Series["Top 5 Deudores"].ChartType = SeriesChartType.Bar;
                
                
                

              foreach (var point in chart1.Series[0].Points)
              {
                    point["PieLabelStyle"] = "Disabled";
              }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el gráfico: " + ex.Message);
            }
            finally { conexion.Close(); }
        }
    }
}

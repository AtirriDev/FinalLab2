
namespace App_Final_Lab2
{
    partial class PRINCIPAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRINCIPAL));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.cmdCerrar = new FontAwesome.Sharp.IconButton();
            this.SubmenuSistema = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.cmdSistema = new FontAwesome.Sharp.IconButton();
            this.SubmenuListados = new System.Windows.Forms.Panel();
            this.cmdListaBarrio = new FontAwesome.Sharp.IconButton();
            this.cmdListaActividad = new FontAwesome.Sharp.IconButton();
            this.cmdListaDeudores = new FontAwesome.Sharp.IconButton();
            this.cmdListadoGneral = new FontAwesome.Sharp.IconButton();
            this.cmdListados = new FontAwesome.Sharp.IconButton();
            this.SubmenuSocios = new System.Windows.Forms.Panel();
            this.cmdConsulta = new FontAwesome.Sharp.IconButton();
            this.cmdBuscar = new FontAwesome.Sharp.IconButton();
            this.CmdNuevoSocio = new FontAwesome.Sharp.IconButton();
            this.cmdSocios = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelSup = new System.Windows.Forms.Panel();
            this.cmdMinimizar = new FontAwesome.Sharp.IconButton();
            this.cmdMinVentana = new FontAwesome.Sharp.IconButton();
            this.cmdMaximizar = new FontAwesome.Sharp.IconButton();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblCantidadSocios = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelLateral.SuspendLayout();
            this.SubmenuSistema.SuspendLayout();
            this.SubmenuListados.SuspendLayout();
            this.SubmenuSocios.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelSup.SuspendLayout();
            this.PanelInferior.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelLateral.Controls.Add(this.cmdCerrar);
            this.PanelLateral.Controls.Add(this.SubmenuSistema);
            this.PanelLateral.Controls.Add(this.cmdSistema);
            this.PanelLateral.Controls.Add(this.SubmenuListados);
            this.PanelLateral.Controls.Add(this.cmdListados);
            this.PanelLateral.Controls.Add(this.SubmenuSocios);
            this.PanelLateral.Controls.Add(this.cmdSocios);
            this.PanelLateral.Controls.Add(this.PanelLogo);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(210, 800);
            this.PanelLateral.TabIndex = 0;
            this.PanelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLateral_Paint);
            this.PanelLateral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelLateral_MouseDown);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCerrar.FlatAppearance.BorderSize = 0;
            this.cmdCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cmdCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.cmdCerrar.IconColor = System.Drawing.Color.White;
            this.cmdCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdCerrar.IconSize = 40;
            this.cmdCerrar.Location = new System.Drawing.Point(3, 752);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(43, 48);
            this.cmdCerrar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cmdCerrar, "Salir de la Aplicacion");
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // SubmenuSistema
            // 
            this.SubmenuSistema.BackColor = System.Drawing.Color.DarkBlue;
            this.SubmenuSistema.Controls.Add(this.iconButton1);
            this.SubmenuSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuSistema.Location = new System.Drawing.Point(0, 612);
            this.SubmenuSistema.Name = "SubmenuSistema";
            this.SubmenuSistema.Size = new System.Drawing.Size(210, 37);
            this.SubmenuSistema.TabIndex = 8;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(210, 29);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Acerca de...";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // cmdSistema
            // 
            this.cmdSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdSistema.FlatAppearance.BorderSize = 0;
            this.cmdSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.cmdSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSistema.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSistema.ForeColor = System.Drawing.Color.White;
            this.cmdSistema.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt;
            this.cmdSistema.IconColor = System.Drawing.Color.White;
            this.cmdSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdSistema.IconSize = 25;
            this.cmdSistema.Location = new System.Drawing.Point(0, 577);
            this.cmdSistema.Name = "cmdSistema";
            this.cmdSistema.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cmdSistema.Size = new System.Drawing.Size(210, 35);
            this.cmdSistema.TabIndex = 7;
            this.cmdSistema.Text = "Sistema";
            this.cmdSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSistema.UseVisualStyleBackColor = true;
            this.cmdSistema.Click += new System.EventHandler(this.cmdSistema_Click);
            // 
            // SubmenuListados
            // 
            this.SubmenuListados.BackColor = System.Drawing.Color.DarkBlue;
            this.SubmenuListados.Controls.Add(this.cmdListaBarrio);
            this.SubmenuListados.Controls.Add(this.cmdListaActividad);
            this.SubmenuListados.Controls.Add(this.cmdListaDeudores);
            this.SubmenuListados.Controls.Add(this.cmdListadoGneral);
            this.SubmenuListados.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuListados.Location = new System.Drawing.Point(0, 419);
            this.SubmenuListados.Name = "SubmenuListados";
            this.SubmenuListados.Size = new System.Drawing.Size(210, 158);
            this.SubmenuListados.TabIndex = 6;
            // 
            // cmdListaBarrio
            // 
            this.cmdListaBarrio.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdListaBarrio.FlatAppearance.BorderSize = 0;
            this.cmdListaBarrio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdListaBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListaBarrio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListaBarrio.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmdListaBarrio.IconChar = FontAwesome.Sharp.IconChar.List;
            this.cmdListaBarrio.IconColor = System.Drawing.Color.RoyalBlue;
            this.cmdListaBarrio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdListaBarrio.IconSize = 30;
            this.cmdListaBarrio.Location = new System.Drawing.Point(0, 110);
            this.cmdListaBarrio.Name = "cmdListaBarrio";
            this.cmdListaBarrio.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cmdListaBarrio.Size = new System.Drawing.Size(210, 35);
            this.cmdListaBarrio.TabIndex = 4;
            this.cmdListaBarrio.Text = "Listado por Barrio";
            this.cmdListaBarrio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdListaBarrio.UseVisualStyleBackColor = true;
            this.cmdListaBarrio.Click += new System.EventHandler(this.cmdListaBarrio_Click);
            // 
            // cmdListaActividad
            // 
            this.cmdListaActividad.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdListaActividad.FlatAppearance.BorderSize = 0;
            this.cmdListaActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdListaActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListaActividad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListaActividad.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmdListaActividad.IconChar = FontAwesome.Sharp.IconChar.Stream;
            this.cmdListaActividad.IconColor = System.Drawing.Color.RoyalBlue;
            this.cmdListaActividad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdListaActividad.IconSize = 30;
            this.cmdListaActividad.Location = new System.Drawing.Point(0, 70);
            this.cmdListaActividad.Name = "cmdListaActividad";
            this.cmdListaActividad.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.cmdListaActividad.Size = new System.Drawing.Size(210, 40);
            this.cmdListaActividad.TabIndex = 3;
            this.cmdListaActividad.Text = "Listado por Actividad";
            this.cmdListaActividad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdListaActividad.UseVisualStyleBackColor = true;
            this.cmdListaActividad.Click += new System.EventHandler(this.cmdListaActividad_Click);
            // 
            // cmdListaDeudores
            // 
            this.cmdListaDeudores.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdListaDeudores.FlatAppearance.BorderSize = 0;
            this.cmdListaDeudores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdListaDeudores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListaDeudores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListaDeudores.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmdListaDeudores.IconChar = FontAwesome.Sharp.IconChar.ListNumeric;
            this.cmdListaDeudores.IconColor = System.Drawing.Color.RoyalBlue;
            this.cmdListaDeudores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdListaDeudores.IconSize = 30;
            this.cmdListaDeudores.Location = new System.Drawing.Point(0, 35);
            this.cmdListaDeudores.Name = "cmdListaDeudores";
            this.cmdListaDeudores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cmdListaDeudores.Size = new System.Drawing.Size(210, 35);
            this.cmdListaDeudores.TabIndex = 2;
            this.cmdListaDeudores.Text = "Listado Deudores";
            this.cmdListaDeudores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdListaDeudores.UseVisualStyleBackColor = true;
            this.cmdListaDeudores.Click += new System.EventHandler(this.cmdListaDeudores_Click);
            // 
            // cmdListadoGneral
            // 
            this.cmdListadoGneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdListadoGneral.FlatAppearance.BorderSize = 0;
            this.cmdListadoGneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdListadoGneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListadoGneral.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListadoGneral.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmdListadoGneral.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.cmdListadoGneral.IconColor = System.Drawing.Color.RoyalBlue;
            this.cmdListadoGneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdListadoGneral.IconSize = 30;
            this.cmdListadoGneral.Location = new System.Drawing.Point(0, 0);
            this.cmdListadoGneral.Name = "cmdListadoGneral";
            this.cmdListadoGneral.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cmdListadoGneral.Size = new System.Drawing.Size(210, 35);
            this.cmdListadoGneral.TabIndex = 1;
            this.cmdListadoGneral.Text = "Listado General";
            this.cmdListadoGneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdListadoGneral.UseVisualStyleBackColor = true;
            this.cmdListadoGneral.Click += new System.EventHandler(this.cmdListadoGneral_Click);
            // 
            // cmdListados
            // 
            this.cmdListados.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdListados.FlatAppearance.BorderSize = 0;
            this.cmdListados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.cmdListados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListados.ForeColor = System.Drawing.Color.White;
            this.cmdListados.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.cmdListados.IconColor = System.Drawing.Color.White;
            this.cmdListados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdListados.Location = new System.Drawing.Point(0, 369);
            this.cmdListados.Name = "cmdListados";
            this.cmdListados.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cmdListados.Size = new System.Drawing.Size(210, 50);
            this.cmdListados.TabIndex = 5;
            this.cmdListados.Text = "&Listados";
            this.cmdListados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdListados.UseVisualStyleBackColor = true;
            this.cmdListados.Click += new System.EventHandler(this.cmdListados_Click);
            // 
            // SubmenuSocios
            // 
            this.SubmenuSocios.BackColor = System.Drawing.Color.DarkBlue;
            this.SubmenuSocios.Controls.Add(this.cmdConsulta);
            this.SubmenuSocios.Controls.Add(this.cmdBuscar);
            this.SubmenuSocios.Controls.Add(this.CmdNuevoSocio);
            this.SubmenuSocios.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuSocios.Location = new System.Drawing.Point(0, 253);
            this.SubmenuSocios.Name = "SubmenuSocios";
            this.SubmenuSocios.Size = new System.Drawing.Size(210, 116);
            this.SubmenuSocios.TabIndex = 4;
            // 
            // cmdConsulta
            // 
            this.cmdConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdConsulta.FlatAppearance.BorderSize = 0;
            this.cmdConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConsulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsulta.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmdConsulta.IconChar = FontAwesome.Sharp.IconChar.UsersViewfinder;
            this.cmdConsulta.IconColor = System.Drawing.Color.RoyalBlue;
            this.cmdConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdConsulta.IconSize = 30;
            this.cmdConsulta.Location = new System.Drawing.Point(0, 70);
            this.cmdConsulta.Name = "cmdConsulta";
            this.cmdConsulta.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cmdConsulta.Size = new System.Drawing.Size(210, 35);
            this.cmdConsulta.TabIndex = 2;
            this.cmdConsulta.Text = "Consulta";
            this.cmdConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdConsulta.UseVisualStyleBackColor = true;
            this.cmdConsulta.Click += new System.EventHandler(this.cmdConsulta_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdBuscar.FlatAppearance.BorderSize = 0;
            this.cmdBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmdBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.cmdBuscar.IconColor = System.Drawing.Color.RoyalBlue;
            this.cmdBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdBuscar.IconSize = 30;
            this.cmdBuscar.Location = new System.Drawing.Point(0, 35);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.cmdBuscar.Size = new System.Drawing.Size(210, 35);
            this.cmdBuscar.TabIndex = 1;
            this.cmdBuscar.Text = "Buscar por ID";
            this.cmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // CmdNuevoSocio
            // 
            this.CmdNuevoSocio.Dock = System.Windows.Forms.DockStyle.Top;
            this.CmdNuevoSocio.FlatAppearance.BorderSize = 0;
            this.CmdNuevoSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CmdNuevoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdNuevoSocio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdNuevoSocio.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CmdNuevoSocio.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.CmdNuevoSocio.IconColor = System.Drawing.Color.RoyalBlue;
            this.CmdNuevoSocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CmdNuevoSocio.IconSize = 30;
            this.CmdNuevoSocio.Location = new System.Drawing.Point(0, 0);
            this.CmdNuevoSocio.Name = "CmdNuevoSocio";
            this.CmdNuevoSocio.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.CmdNuevoSocio.Size = new System.Drawing.Size(210, 35);
            this.CmdNuevoSocio.TabIndex = 0;
            this.CmdNuevoSocio.Text = "&Agregar";
            this.CmdNuevoSocio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdNuevoSocio.UseVisualStyleBackColor = true;
            this.CmdNuevoSocio.Click += new System.EventHandler(this.CmdNuevoSocio_Click);
            // 
            // cmdSocios
            // 
            this.cmdSocios.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdSocios.FlatAppearance.BorderSize = 0;
            this.cmdSocios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.cmdSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSocios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSocios.ForeColor = System.Drawing.Color.White;
            this.cmdSocios.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.cmdSocios.IconColor = System.Drawing.Color.White;
            this.cmdSocios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdSocios.Location = new System.Drawing.Point(0, 203);
            this.cmdSocios.Name = "cmdSocios";
            this.cmdSocios.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cmdSocios.Size = new System.Drawing.Size(210, 50);
            this.cmdSocios.TabIndex = 3;
            this.cmdSocios.Text = "&Socios";
            this.cmdSocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.cmdSocios, "Click para Abrir , Doble Click para cerrar");
            this.cmdSocios.UseVisualStyleBackColor = true;
            this.cmdSocios.Click += new System.EventHandler(this.cmdSocios_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(210, 203);
            this.PanelLogo.TabIndex = 2;
            this.PanelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelLogo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-67, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PanelSup
            // 
            this.PanelSup.BackColor = System.Drawing.Color.DarkBlue;
            this.PanelSup.Controls.Add(this.cmdMinimizar);
            this.PanelSup.Controls.Add(this.cmdMinVentana);
            this.PanelSup.Controls.Add(this.cmdMaximizar);
            this.PanelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSup.Location = new System.Drawing.Point(210, 0);
            this.PanelSup.Name = "PanelSup";
            this.PanelSup.Size = new System.Drawing.Size(890, 50);
            this.PanelSup.TabIndex = 1;
            this.PanelSup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSup_MouseDown);
            // 
            // cmdMinimizar
            // 
            this.cmdMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMinimizar.FlatAppearance.BorderSize = 0;
            this.cmdMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.cmdMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.cmdMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimizar.ForeColor = System.Drawing.Color.White;
            this.cmdMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.cmdMinimizar.IconColor = System.Drawing.Color.White;
            this.cmdMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdMinimizar.IconSize = 35;
            this.cmdMinimizar.Location = new System.Drawing.Point(787, 12);
            this.cmdMinimizar.Name = "cmdMinimizar";
            this.cmdMinimizar.Size = new System.Drawing.Size(47, 35);
            this.cmdMinimizar.TabIndex = 4;
            this.cmdMinimizar.UseVisualStyleBackColor = true;
            this.cmdMinimizar.Click += new System.EventHandler(this.cmdMinimizar_Click);
            // 
            // cmdMinVentana
            // 
            this.cmdMinVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMinVentana.FlatAppearance.BorderSize = 0;
            this.cmdMinVentana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.cmdMinVentana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.cmdMinVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinVentana.ForeColor = System.Drawing.Color.White;
            this.cmdMinVentana.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            this.cmdMinVentana.IconColor = System.Drawing.Color.White;
            this.cmdMinVentana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdMinVentana.IconSize = 35;
            this.cmdMinVentana.Location = new System.Drawing.Point(840, 12);
            this.cmdMinVentana.Name = "cmdMinVentana";
            this.cmdMinVentana.Size = new System.Drawing.Size(47, 35);
            this.cmdMinVentana.TabIndex = 3;
            this.cmdMinVentana.UseVisualStyleBackColor = true;
            this.cmdMinVentana.Visible = false;
            this.cmdMinVentana.Click += new System.EventHandler(this.cmdMinVentana_Click);
            // 
            // cmdMaximizar
            // 
            this.cmdMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMaximizar.FlatAppearance.BorderSize = 0;
            this.cmdMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.cmdMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.cmdMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMaximizar.ForeColor = System.Drawing.Color.White;
            this.cmdMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.cmdMaximizar.IconColor = System.Drawing.Color.White;
            this.cmdMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdMaximizar.IconSize = 35;
            this.cmdMaximizar.Location = new System.Drawing.Point(840, 12);
            this.cmdMaximizar.Name = "cmdMaximizar";
            this.cmdMaximizar.Size = new System.Drawing.Size(47, 35);
            this.cmdMaximizar.TabIndex = 2;
            this.cmdMaximizar.UseVisualStyleBackColor = true;
            this.cmdMaximizar.Click += new System.EventHandler(this.cmdMaximizar_Click);
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.DarkBlue;
            this.PanelInferior.Controls.Add(this.lblHora);
            this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInferior.Location = new System.Drawing.Point(210, 750);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(890, 50);
            this.PanelInferior.TabIndex = 2;
            this.PanelInferior.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelInferior_Paint);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(680, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 22);
            this.lblHora.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.chart1);
            this.panelContenedor.Controls.Add(this.lblCantidadSocios);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.iconButton2);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(210, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(890, 700);
            this.panelContenedor.TabIndex = 3;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(382, 185);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(487, 294);
            this.chart1.TabIndex = 3;
            title1.Name = "TOP 5 DEUDORES";
            this.chart1.Titles.Add(title1);
            // 
            // lblCantidadSocios
            // 
            this.lblCantidadSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCantidadSocios.AutoSize = true;
            this.lblCantidadSocios.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadSocios.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCantidadSocios.Location = new System.Drawing.Point(287, 471);
            this.lblCantidadSocios.Name = "lblCantidadSocios";
            this.lblCantidadSocios.Size = new System.Drawing.Size(45, 33);
            this.lblCantidadSocios.TabIndex = 2;
            this.lblCantidadSocios.Text = "15";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(85, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Socios Activos:";
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.iconButton2.FlatAppearance.BorderSize = 3;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton2.IconColor = System.Drawing.Color.DarkBlue;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 300;
            this.iconButton2.Location = new System.Drawing.Point(76, 203);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(268, 264);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.PanelInferior);
            this.Controls.Add(this.PanelSup);
            this.Controls.Add(this.PanelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "PRINCIPAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.PRINCIPAL_Load);
            this.PanelLateral.ResumeLayout(false);
            this.SubmenuSistema.ResumeLayout(false);
            this.SubmenuListados.ResumeLayout(false);
            this.SubmenuSocios.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelSup.ResumeLayout(false);
            this.PanelInferior.ResumeLayout(false);
            this.PanelInferior.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateral;
        private FontAwesome.Sharp.IconButton cmdSocios;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel PanelSup;
        private System.Windows.Forms.Panel SubmenuSocios;
        private FontAwesome.Sharp.IconButton CmdNuevoSocio;
        private FontAwesome.Sharp.IconButton cmdConsulta;
        private FontAwesome.Sharp.IconButton cmdBuscar;
        private FontAwesome.Sharp.IconButton cmdListados;
        private System.Windows.Forms.Panel SubmenuListados;
        private FontAwesome.Sharp.IconButton cmdListaBarrio;
        private FontAwesome.Sharp.IconButton cmdListaActividad;
        private FontAwesome.Sharp.IconButton cmdListaDeudores;
        private FontAwesome.Sharp.IconButton cmdListadoGneral;
        private System.Windows.Forms.Panel SubmenuSistema;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton cmdSistema;
        private FontAwesome.Sharp.IconButton cmdCerrar;
        private FontAwesome.Sharp.IconButton cmdMaximizar;
        private FontAwesome.Sharp.IconButton cmdMinVentana;
        private FontAwesome.Sharp.IconButton cmdMinimizar;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblCantidadSocios;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
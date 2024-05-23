
namespace App_Final_Lab2
{
    partial class frmBuscarSocio
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdSocio = new System.Windows.Forms.TextBox();
            this.PanelDatos = new System.Windows.Forms.Panel();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdEliminar = new FontAwesome.Sharp.IconButton();
            this.cmdBack = new FontAwesome.Sharp.IconButton();
            this.cmdIGuardar = new FontAwesome.Sharp.IconButton();
            this.cmdModificar = new FontAwesome.Sharp.IconButton();
            this.cmdBuscar = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PanelDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID Socio:";
            // 
            // txtIdSocio
            // 
            this.txtIdSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdSocio.Location = new System.Drawing.Point(323, 87);
            this.txtIdSocio.MaxLength = 4;
            this.txtIdSocio.Name = "txtIdSocio";
            this.txtIdSocio.Size = new System.Drawing.Size(164, 20);
            this.txtIdSocio.TabIndex = 34;
            this.txtIdSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdSocio_KeyPress);
            // 
            // PanelDatos
            // 
            this.PanelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDatos.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelDatos.Controls.Add(this.txtDeuda);
            this.PanelDatos.Controls.Add(this.cmbActividad);
            this.PanelDatos.Controls.Add(this.cmbBarrio);
            this.PanelDatos.Controls.Add(this.txtDireccion);
            this.PanelDatos.Controls.Add(this.txtNombre);
            this.PanelDatos.Controls.Add(this.label6);
            this.PanelDatos.Controls.Add(this.label4);
            this.PanelDatos.Controls.Add(this.label3);
            this.PanelDatos.Controls.Add(this.label2);
            this.PanelDatos.Controls.Add(this.label1);
            this.PanelDatos.Location = new System.Drawing.Point(142, 132);
            this.PanelDatos.Name = "PanelDatos";
            this.PanelDatos.Size = new System.Drawing.Size(495, 416);
            this.PanelDatos.TabIndex = 35;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeuda.Enabled = false;
            this.txtDeuda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeuda.Location = new System.Drawing.Point(181, 346);
            this.txtDeuda.MaxLength = 6;
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(211, 31);
            this.txtDeuda.TabIndex = 9;
            this.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeuda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeuda_KeyPress);
            // 
            // cmbActividad
            // 
            this.cmbActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbActividad.Enabled = false;
            this.cmbActividad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(181, 268);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(211, 30);
            this.cmbActividad.TabIndex = 8;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBarrio.Enabled = false;
            this.cmbBarrio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(181, 193);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(211, 30);
            this.cmbBarrio.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(181, 126);
            this.txtDireccion.MaxLength = 30;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(211, 31);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(181, 62);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 31);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Deuda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Actividad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barrio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdEliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdEliminar.FlatAppearance.BorderSize = 0;
            this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.ForeColor = System.Drawing.Color.White;
            this.cmdEliminar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.cmdEliminar.IconColor = System.Drawing.Color.DarkBlue;
            this.cmdEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdEliminar.IconSize = 35;
            this.cmdEliminar.Location = new System.Drawing.Point(675, 287);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(160, 54);
            this.cmdEliminar.TabIndex = 36;
            this.cmdEliminar.Text = "&Eliminar socio";
            this.cmdEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdEliminar.UseVisualStyleBackColor = false;
            this.cmdEliminar.Visible = false;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.cmdBack.IconColor = System.Drawing.Color.RoyalBlue;
            this.cmdBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdBack.Location = new System.Drawing.Point(12, 12);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(72, 83);
            this.cmdBack.TabIndex = 33;
            this.cmdBack.Text = "Volver";
            this.cmdBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdIGuardar
            // 
            this.cmdIGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdIGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdIGuardar.FlatAppearance.BorderSize = 0;
            this.cmdIGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIGuardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIGuardar.ForeColor = System.Drawing.Color.White;
            this.cmdIGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.cmdIGuardar.IconColor = System.Drawing.Color.DarkBlue;
            this.cmdIGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdIGuardar.IconSize = 35;
            this.cmdIGuardar.Location = new System.Drawing.Point(675, 366);
            this.cmdIGuardar.Name = "cmdIGuardar";
            this.cmdIGuardar.Size = new System.Drawing.Size(160, 55);
            this.cmdIGuardar.TabIndex = 32;
            this.cmdIGuardar.Text = "&Guardar Cambios";
            this.cmdIGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdIGuardar.UseVisualStyleBackColor = false;
            this.cmdIGuardar.Visible = false;
            this.cmdIGuardar.Click += new System.EventHandler(this.cmdIGuardar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdModificar.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdModificar.FlatAppearance.BorderSize = 0;
            this.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.ForeColor = System.Drawing.Color.White;
            this.cmdModificar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.cmdModificar.IconColor = System.Drawing.Color.DarkBlue;
            this.cmdModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdModificar.IconSize = 35;
            this.cmdModificar.Location = new System.Drawing.Point(675, 203);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(160, 39);
            this.cmdModificar.TabIndex = 31;
            this.cmdModificar.Text = "&Modificar";
            this.cmdModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdModificar.UseVisualStyleBackColor = false;
            this.cmdModificar.Visible = false;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdBuscar.FlatAppearance.BorderSize = 0;
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.ForeColor = System.Drawing.Color.White;
            this.cmdBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.cmdBuscar.IconColor = System.Drawing.Color.DarkBlue;
            this.cmdBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdBuscar.IconSize = 35;
            this.cmdBuscar.Location = new System.Drawing.Point(675, 132);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(160, 39);
            this.cmdBuscar.TabIndex = 30;
            this.cmdBuscar.Text = "&Buscar";
            this.cmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Volver al inicio";
            // 
            // frmBuscarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 661);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.PanelDatos);
            this.Controls.Add(this.txtIdSocio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdIGuardar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarSocio";
            this.Text = "frmBuscarSocio";
            this.Load += new System.EventHandler(this.frmBuscarSocio_Load);
            this.PanelDatos.ResumeLayout(false);
            this.PanelDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton cmdBack;
        private FontAwesome.Sharp.IconButton cmdIGuardar;
        private FontAwesome.Sharp.IconButton cmdModificar;
        private FontAwesome.Sharp.IconButton cmdBuscar;
        private System.Windows.Forms.TextBox txtIdSocio;
        private System.Windows.Forms.Panel PanelDatos;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton cmdEliminar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
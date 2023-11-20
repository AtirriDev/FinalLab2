
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
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.PanelSup = new System.Windows.Forms.Panel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PanelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelLateral.Controls.Add(this.iconButton1);
            this.PanelLateral.Controls.Add(this.PanelLogo);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(210, 761);
            this.PanelLateral.TabIndex = 0;
            // 
            // PanelSup
            // 
            this.PanelSup.BackColor = System.Drawing.Color.DarkBlue;
            this.PanelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSup.Location = new System.Drawing.Point(210, 0);
            this.PanelSup.Name = "PanelSup";
            this.PanelSup.Size = new System.Drawing.Size(874, 50);
            this.PanelSup.TabIndex = 1;
            // 
            // PanelLogo
            // 
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(210, 159);
            this.PanelLogo.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(36, 201);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(73, 33);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Socios";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.PanelSup);
            this.Controls.Add(this.PanelLateral);
            this.Name = "PRINCIPAL";
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.PRINCIPAL_Load);
            this.PanelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateral;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel PanelSup;
    }
}
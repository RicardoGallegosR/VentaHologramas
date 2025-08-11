namespace VentaHologramas
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pnlPrincipal = new Panel();
            tlpPrincipal = new TableLayoutPanel();
            lblVenta = new Label();
            lblPVV = new Label();
            lblUltimoAcceso = new Label();
            pnlMenu = new Panel();
            menuStrip1 = new MenuStrip();
            smiVentasMenu = new ToolStripMenuItem();
            smiVentas = new ToolStripMenuItem();
            smiDevoluciones = new ToolStripMenuItem();
            smiFacturacion = new ToolStripMenuItem();
            smiImpresionF = new ToolStripMenuItem();
            smiReportes = new ToolStripMenuItem();
            smiConfi = new ToolStripMenuItem();
            smiEstacion = new ToolStripMenuItem();
            smiClaveAcceso = new ToolStripMenuItem();
            smiCnxFinanzas = new ToolStripMenuItem();
            smiSalir = new ToolStripMenuItem();
            pnlPrincipal.SuspendLayout();
            pnlMenu.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            resources.ApplyResources(pnlPrincipal, "pnlPrincipal");
            pnlPrincipal.BackColor = Color.FromArgb(79, 194, 204);
            pnlPrincipal.Controls.Add(tlpPrincipal);
            pnlPrincipal.Controls.Add(lblVenta);
            pnlPrincipal.Controls.Add(lblPVV);
            pnlPrincipal.Name = "pnlPrincipal";
            // 
            // tlpPrincipal
            // 
            resources.ApplyResources(tlpPrincipal, "tlpPrincipal");
            tlpPrincipal.Name = "tlpPrincipal";
            // 
            // lblVenta
            // 
            resources.ApplyResources(lblVenta, "lblVenta");
            lblVenta.ForeColor = Color.FromArgb(0, 100, 123);
            lblVenta.Name = "lblVenta";
            // 
            // lblPVV
            // 
            resources.ApplyResources(lblPVV, "lblPVV");
            lblPVV.ForeColor = Color.White;
            lblPVV.Name = "lblPVV";
            // 
            // lblUltimoAcceso
            // 
            resources.ApplyResources(lblUltimoAcceso, "lblUltimoAcceso");
            lblUltimoAcceso.Name = "lblUltimoAcceso";
            // 
            // pnlMenu
            // 
            resources.ApplyResources(pnlMenu, "pnlMenu");
            pnlMenu.BackColor = Color.FromArgb(79, 194, 204);
            pnlMenu.Controls.Add(lblUltimoAcceso);
            pnlMenu.Controls.Add(menuStrip1);
            pnlMenu.Name = "pnlMenu";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { smiVentasMenu, smiFacturacion, smiReportes, smiConfi, smiSalir });
            menuStrip1.Name = "menuStrip1";
            // 
            // smiVentasMenu
            // 
            resources.ApplyResources(smiVentasMenu, "smiVentasMenu");
            smiVentasMenu.DropDownItems.AddRange(new ToolStripItem[] { smiVentas, smiDevoluciones });
            smiVentasMenu.Name = "smiVentasMenu";
            // 
            // smiVentas
            // 
            resources.ApplyResources(smiVentas, "smiVentas");
            smiVentas.Name = "smiVentas";
            // 
            // smiDevoluciones
            // 
            resources.ApplyResources(smiDevoluciones, "smiDevoluciones");
            smiDevoluciones.Name = "smiDevoluciones";
            // 
            // smiFacturacion
            // 
            resources.ApplyResources(smiFacturacion, "smiFacturacion");
            smiFacturacion.DropDownItems.AddRange(new ToolStripItem[] { smiImpresionF });
            smiFacturacion.Name = "smiFacturacion";
            // 
            // smiImpresionF
            // 
            resources.ApplyResources(smiImpresionF, "smiImpresionF");
            smiImpresionF.Name = "smiImpresionF";
            // 
            // smiReportes
            // 
            resources.ApplyResources(smiReportes, "smiReportes");
            smiReportes.Name = "smiReportes";
            // 
            // smiConfi
            // 
            resources.ApplyResources(smiConfi, "smiConfi");
            smiConfi.DropDownItems.AddRange(new ToolStripItem[] { smiEstacion, smiClaveAcceso, smiCnxFinanzas });
            smiConfi.Name = "smiConfi";
            // 
            // smiEstacion
            // 
            resources.ApplyResources(smiEstacion, "smiEstacion");
            smiEstacion.Name = "smiEstacion";
            smiEstacion.Click += smiEstacion_Click;
            // 
            // smiClaveAcceso
            // 
            resources.ApplyResources(smiClaveAcceso, "smiClaveAcceso");
            smiClaveAcceso.Name = "smiClaveAcceso";
            smiClaveAcceso.Click += smiClaveAcceso_Click;
            // 
            // smiCnxFinanzas
            // 
            resources.ApplyResources(smiCnxFinanzas, "smiCnxFinanzas");
            smiCnxFinanzas.Name = "smiCnxFinanzas";
            // 
            // smiSalir
            // 
            resources.ApplyResources(smiSalir, "smiSalir");
            smiSalir.Name = "smiSalir";
            smiSalir.Click += smiSalir_Click;
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 194, 204);
            ControlBox = false;
            Controls.Add(pnlMenu);
            Controls.Add(pnlPrincipal);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Home";
            Load += Home_Load;
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlMenu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem smiVentasMenu;
        private ToolStripMenuItem smiFacturacion;
        private ToolStripMenuItem smiReportes;
        private ToolStripMenuItem smiConfi;
        private ToolStripMenuItem smiSalir;
        private ToolStripMenuItem smiVentas;
        private ToolStripMenuItem smiDevoluciones;
        private ToolStripMenuItem smiImpresionF;
        private ToolStripMenuItem smiEstacion;
        private ToolStripMenuItem smiClaveAcceso;
        private ToolStripMenuItem smiCnxFinanzas;
        private Label lblUltimoAcceso;
        private Label lblPVV;
        private Label lblVenta;
        private TableLayoutPanel tlpPrincipal;
    }
}

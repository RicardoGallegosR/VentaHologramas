namespace VentaHologramas.Formularios.Reportes {
    partial class Reportes {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pnlPrincipalReportes = new Panel();
            gbBusqueda = new GroupBox();
            cbTipoHolograma = new ComboBox();
            dataGridView1 = new DataGridView();
            btnRegresar = new Button();
            cbCentroVerificacion = new ComboBox();
            btnGuardarExcel = new Button();
            btnBuscar = new Button();
            lblFechaFinal = new Label();
            lblFechaInicial = new Label();
            dtpFechaFinal = new DateTimePicker();
            dtpFechaInicial = new DateTimePicker();
            lblTipoCertificado = new Label();
            lblCentro = new Label();
            pnlPrincipalReportes.SuspendLayout();
            gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlPrincipalReportes
            // 
            pnlPrincipalReportes.BackColor = Color.FromArgb(79, 194, 204);
            pnlPrincipalReportes.Controls.Add(gbBusqueda);
            pnlPrincipalReportes.Location = new Point(12, 12);
            pnlPrincipalReportes.Name = "pnlPrincipalReportes";
            pnlPrincipalReportes.Size = new Size(870, 435);
            pnlPrincipalReportes.TabIndex = 0;
            // 
            // gbBusqueda
            // 
            gbBusqueda.BackColor = Color.White;
            gbBusqueda.BackgroundImageLayout = ImageLayout.Center;
            gbBusqueda.Controls.Add(cbTipoHolograma);
            gbBusqueda.Controls.Add(dataGridView1);
            gbBusqueda.Controls.Add(btnRegresar);
            gbBusqueda.Controls.Add(cbCentroVerificacion);
            gbBusqueda.Controls.Add(btnGuardarExcel);
            gbBusqueda.Controls.Add(btnBuscar);
            gbBusqueda.Controls.Add(lblFechaFinal);
            gbBusqueda.Controls.Add(lblFechaInicial);
            gbBusqueda.Controls.Add(dtpFechaFinal);
            gbBusqueda.Controls.Add(dtpFechaInicial);
            gbBusqueda.Controls.Add(lblTipoCertificado);
            gbBusqueda.Controls.Add(lblCentro);
            gbBusqueda.FlatStyle = FlatStyle.Flat;
            gbBusqueda.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            gbBusqueda.ForeColor = Color.FromArgb(0, 100, 123);
            gbBusqueda.Location = new Point(14, 16);
            gbBusqueda.Name = "gbBusqueda";
            gbBusqueda.Size = new Size(841, 390);
            gbBusqueda.TabIndex = 0;
            gbBusqueda.TabStop = false;
            gbBusqueda.Text = "REPORTES";
            // 
            // cbTipoHolograma
            // 
            cbTipoHolograma.Font = new Font("Segoe UI", 9F);
            cbTipoHolograma.ForeColor = Color.FromArgb(103, 106, 106);
            cbTipoHolograma.FormattingEnabled = true;
            cbTipoHolograma.Location = new Point(16, 101);
            cbTipoHolograma.Name = "cbTipoHolograma";
            cbTipoHolograma.Size = new Size(253, 23);
            cbTipoHolograma.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(826, 217);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(79, 194, 204);
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegresar.Location = new Point(658, 102);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(177, 31);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            // 
            // cbCentroVerificacion
            // 
            cbCentroVerificacion.Font = new Font("Segoe UI", 9F);
            cbCentroVerificacion.ForeColor = Color.FromArgb(103, 106, 106);
            cbCentroVerificacion.FormattingEnabled = true;
            cbCentroVerificacion.Location = new Point(16, 51);
            cbCentroVerificacion.Name = "cbCentroVerificacion";
            cbCentroVerificacion.Size = new Size(253, 23);
            cbCentroVerificacion.TabIndex = 1;
            // 
            // btnGuardarExcel
            // 
            btnGuardarExcel.BackColor = Color.FromArgb(0, 118, 136);
            btnGuardarExcel.FlatAppearance.BorderSize = 0;
            btnGuardarExcel.FlatStyle = FlatStyle.Flat;
            btnGuardarExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarExcel.ForeColor = Color.White;
            btnGuardarExcel.Image = Properties.Resources.excel;
            btnGuardarExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarExcel.Location = new Point(658, 66);
            btnGuardarExcel.Name = "btnGuardarExcel";
            btnGuardarExcel.Size = new Size(177, 30);
            btnGuardarExcel.TabIndex = 6;
            btnGuardarExcel.Text = "Generar Excel";
            btnGuardarExcel.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(79, 194, 204);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(658, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(177, 32);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Font = new Font("Segoe UI", 9F);
            lblFechaFinal.Location = new Point(321, 83);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(66, 15);
            lblFechaFinal.TabIndex = 0;
            lblFechaFinal.Text = "Fecha Final";
            // 
            // lblFechaInicial
            // 
            lblFechaInicial.AutoSize = true;
            lblFechaInicial.Font = new Font("Segoe UI", 9F);
            lblFechaInicial.Location = new Point(321, 31);
            lblFechaInicial.Name = "lblFechaInicial";
            lblFechaInicial.Size = new Size(72, 15);
            lblFechaInicial.TabIndex = 0;
            lblFechaInicial.Text = "Fecha Inicial";
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.CalendarFont = new Font("Segoe UI", 9F);
            dtpFechaFinal.CalendarForeColor = Color.FromArgb(0, 100, 123);
            dtpFechaFinal.CalendarTitleForeColor = Color.FromArgb(103, 106, 106);
            dtpFechaFinal.Font = new Font("Segoe UI", 9F);
            dtpFechaFinal.Location = new Point(321, 102);
            dtpFechaFinal.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dtpFechaFinal.MinDate = new DateTime(2018, 1, 1, 0, 0, 0, 0);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(298, 23);
            dtpFechaFinal.TabIndex = 4;
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.CalendarFont = new Font("Segoe UI", 9F);
            dtpFechaInicial.CalendarForeColor = Color.FromArgb(0, 100, 123);
            dtpFechaInicial.CalendarTitleForeColor = Color.FromArgb(103, 106, 106);
            dtpFechaInicial.CalendarTrailingForeColor = Color.GreenYellow;
            dtpFechaInicial.Font = new Font("Segoe UI", 9F);
            dtpFechaInicial.Location = new Point(321, 49);
            dtpFechaInicial.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dtpFechaInicial.MinDate = new DateTime(2018, 1, 1, 0, 0, 0, 0);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(298, 23);
            dtpFechaInicial.TabIndex = 3;
            // 
            // lblTipoCertificado
            // 
            lblTipoCertificado.AutoSize = true;
            lblTipoCertificado.Font = new Font("Segoe UI", 9F);
            lblTipoCertificado.Location = new Point(16, 83);
            lblTipoCertificado.Name = "lblTipoCertificado";
            lblTipoCertificado.Size = new Size(67, 15);
            lblTipoCertificado.TabIndex = 0;
            lblTipoCertificado.Text = "Holograma";
            // 
            // lblCentro
            // 
            lblCentro.AutoSize = true;
            lblCentro.Font = new Font("Segoe UI", 9F);
            lblCentro.Location = new Point(16, 33);
            lblCentro.Name = "lblCentro";
            lblCentro.Size = new Size(123, 15);
            lblCentro.TabIndex = 0;
            lblCentro.Text = "Centro de Verificación";
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 462);
            Controls.Add(pnlPrincipalReportes);
            Name = "Reportes";
            Text = "Reportes";
            pnlPrincipalReportes.ResumeLayout(false);
            gbBusqueda.ResumeLayout(false);
            gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipalReportes;
        private DataGridView dataGridView1;
        private Button btnRegresar;
        private Button btnBuscar;
        private Button btnGuardarExcel;
        private GroupBox gbBusqueda;
        private Label lblCentro;
        private DateTimePicker dtpFechaInicial;
        private Label lblTipoCertificado;
        private DateTimePicker dtpFechaFinal;
        private Label lblFechaFinal;
        private Label lblFechaInicial;
        private ComboBox cbCentroVerificacion;
        private ComboBox cbTipoHolograma;
    }
}
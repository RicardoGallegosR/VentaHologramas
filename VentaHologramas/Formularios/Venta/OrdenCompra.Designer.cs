namespace VentaHologramas.Formularios.Venta {
    partial class OrdenCompra {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlPrincipalOrdenCompra = new Panel();
            btnPreview = new Button();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            dgvLineaCaptura = new DataGridView();
            Linea = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            gbLineaCaptura = new GroupBox();
            btnValidar = new Button();
            txbLineaCaptura = new TextBox();
            gbDatosFiscales = new GroupBox();
            btnModificar = new Button();
            lblRFC = new Label();
            txbRFC = new TextBox();
            txbRazonSocial = new TextBox();
            lblRazonSocial = new Label();
            txbDireccion = new TextBox();
            cbCentroVerificacion = new ComboBox();
            lblDireccion = new Label();
            lblCentro = new Label();
            pnlPrincipalOrdenCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLineaCaptura).BeginInit();
            gbLineaCaptura.SuspendLayout();
            gbDatosFiscales.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipalOrdenCompra
            // 
            pnlPrincipalOrdenCompra.BackColor = Color.FromArgb(79, 194, 204);
            pnlPrincipalOrdenCompra.Controls.Add(btnPreview);
            pnlPrincipalOrdenCompra.Controls.Add(btnConfirmar);
            pnlPrincipalOrdenCompra.Controls.Add(btnCancelar);
            pnlPrincipalOrdenCompra.Controls.Add(dgvLineaCaptura);
            pnlPrincipalOrdenCompra.Controls.Add(gbLineaCaptura);
            pnlPrincipalOrdenCompra.Controls.Add(gbDatosFiscales);
            pnlPrincipalOrdenCompra.ForeColor = Color.DarkBlue;
            pnlPrincipalOrdenCompra.Location = new Point(12, 12);
            pnlPrincipalOrdenCompra.Name = "pnlPrincipalOrdenCompra";
            pnlPrincipalOrdenCompra.Size = new Size(870, 435);
            pnlPrincipalOrdenCompra.TabIndex = 1;
            // 
            // btnPreview
            // 
            btnPreview.BackColor = Color.FromArgb(0, 118, 136);
            btnPreview.FlatAppearance.BorderSize = 0;
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPreview.ForeColor = Color.White;
            btnPreview.ImageAlign = ContentAlignment.MiddleLeft;
            btnPreview.Location = new Point(590, 280);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(253, 32);
            btnPreview.TabIndex = 5;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(0, 118, 136);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.Location = new Point(590, 330);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(253, 32);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(0, 118, 136);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(590, 232);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(253, 32);
            btnCancelar.TabIndex = 0;
            btnCancelar.TabStop = false;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dgvLineaCaptura
            // 
            dgvLineaCaptura.BackgroundColor = Color.FromArgb(79, 194, 204);
            dgvLineaCaptura.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLineaCaptura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLineaCaptura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLineaCaptura.Columns.AddRange(new DataGridViewColumn[] { Linea, Monto });
            dgvLineaCaptura.GridColor = Color.FromArgb(0, 118, 136);
            dgvLineaCaptura.Location = new Point(15, 232);
            dgvLineaCaptura.Name = "dgvLineaCaptura";
            dgvLineaCaptura.Size = new Size(553, 200);
            dgvLineaCaptura.TabIndex = 0;
            dgvLineaCaptura.TabStop = false;
            // 
            // Linea
            // 
            Linea.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(103, 106, 106);
            Linea.DefaultCellStyle = dataGridViewCellStyle2;
            Linea.FillWeight = 70F;
            Linea.HeaderText = "Línea Captura";
            Linea.Name = "Linea";
            Linea.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(103, 106, 106);
            Monto.DefaultCellStyle = dataGridViewCellStyle3;
            Monto.FillWeight = 30F;
            Monto.HeaderText = "Importe $";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // gbLineaCaptura
            // 
            gbLineaCaptura.BackColor = Color.White;
            gbLineaCaptura.BackgroundImageLayout = ImageLayout.Center;
            gbLineaCaptura.Controls.Add(btnValidar);
            gbLineaCaptura.Controls.Add(txbLineaCaptura);
            gbLineaCaptura.FlatStyle = FlatStyle.Flat;
            gbLineaCaptura.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            gbLineaCaptura.ForeColor = Color.FromArgb(0, 100, 123);
            gbLineaCaptura.Location = new Point(15, 160);
            gbLineaCaptura.Name = "gbLineaCaptura";
            gbLineaCaptura.Size = new Size(841, 66);
            gbLineaCaptura.TabIndex = 0;
            gbLineaCaptura.TabStop = false;
            gbLineaCaptura.Text = "LÍNEA CAPTURA";
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.FromArgb(79, 194, 204);
            btnValidar.FlatAppearance.BorderSize = 0;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnValidar.ForeColor = Color.White;
            btnValidar.ImageAlign = ContentAlignment.MiddleLeft;
            btnValidar.Location = new Point(575, 24);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(253, 32);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            // 
            // txbLineaCaptura
            // 
            txbLineaCaptura.Font = new Font("Segoe UI", 9F);
            txbLineaCaptura.ForeColor = Color.FromArgb(103, 106, 106);
            txbLineaCaptura.Location = new Point(16, 31);
            txbLineaCaptura.Name = "txbLineaCaptura";
            txbLineaCaptura.Size = new Size(537, 23);
            txbLineaCaptura.TabIndex = 2;
            // 
            // gbDatosFiscales
            // 
            gbDatosFiscales.BackColor = Color.White;
            gbDatosFiscales.BackgroundImageLayout = ImageLayout.Center;
            gbDatosFiscales.Controls.Add(btnModificar);
            gbDatosFiscales.Controls.Add(lblRFC);
            gbDatosFiscales.Controls.Add(txbRFC);
            gbDatosFiscales.Controls.Add(txbRazonSocial);
            gbDatosFiscales.Controls.Add(lblRazonSocial);
            gbDatosFiscales.Controls.Add(txbDireccion);
            gbDatosFiscales.Controls.Add(cbCentroVerificacion);
            gbDatosFiscales.Controls.Add(lblDireccion);
            gbDatosFiscales.Controls.Add(lblCentro);
            gbDatosFiscales.FlatStyle = FlatStyle.Flat;
            gbDatosFiscales.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            gbDatosFiscales.ForeColor = Color.FromArgb(0, 100, 123);
            gbDatosFiscales.Location = new Point(15, 3);
            gbDatosFiscales.Name = "gbDatosFiscales";
            gbDatosFiscales.Size = new Size(841, 151);
            gbDatosFiscales.TabIndex = 0;
            gbDatosFiscales.TabStop = false;
            gbDatosFiscales.Text = "DATOS FISCALES";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(79, 194, 204);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(575, 88);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(253, 32);
            btnModificar.TabIndex = 0;
            btnModificar.TabStop = false;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Visible = false;
            // 
            // lblRFC
            // 
            lblRFC.AutoSize = true;
            lblRFC.Font = new Font("Segoe UI", 9F);
            lblRFC.Location = new Point(300, 28);
            lblRFC.Name = "lblRFC";
            lblRFC.Size = new Size(37, 15);
            lblRFC.TabIndex = 6;
            lblRFC.Text = "R.F.C.";
            // 
            // txbRFC
            // 
            txbRFC.Font = new Font("Segoe UI", 9F);
            txbRFC.ForeColor = Color.FromArgb(103, 106, 106);
            txbRFC.Location = new Point(300, 46);
            txbRFC.Name = "txbRFC";
            txbRFC.Size = new Size(253, 23);
            txbRFC.TabIndex = 0;
            txbRFC.TabStop = false;
            // 
            // txbRazonSocial
            // 
            txbRazonSocial.Font = new Font("Segoe UI", 9F);
            txbRazonSocial.ForeColor = Color.FromArgb(103, 106, 106);
            txbRazonSocial.Location = new Point(16, 46);
            txbRazonSocial.Name = "txbRazonSocial";
            txbRazonSocial.Size = new Size(253, 23);
            txbRazonSocial.TabIndex = 0;
            txbRazonSocial.TabStop = false;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Font = new Font("Segoe UI", 9F);
            lblRazonSocial.Location = new Point(16, 28);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(73, 15);
            lblRazonSocial.TabIndex = 3;
            lblRazonSocial.Text = "Razón Social";
            // 
            // txbDireccion
            // 
            txbDireccion.Font = new Font("Segoe UI", 9F);
            txbDireccion.ForeColor = Color.FromArgb(103, 106, 106);
            txbDireccion.Location = new Point(16, 95);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(537, 23);
            txbDireccion.TabIndex = 0;
            txbDireccion.TabStop = false;
            // 
            // cbCentroVerificacion
            // 
            cbCentroVerificacion.Font = new Font("Segoe UI", 9F);
            cbCentroVerificacion.ForeColor = Color.FromArgb(103, 106, 106);
            cbCentroVerificacion.FormattingEnabled = true;
            cbCentroVerificacion.Location = new Point(575, 46);
            cbCentroVerificacion.Name = "cbCentroVerificacion";
            cbCentroVerificacion.Size = new Size(253, 23);
            cbCentroVerificacion.TabIndex = 1;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9F);
            lblDireccion.Location = new Point(16, 77);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 0;
            lblDireccion.Text = "Dirección";
            // 
            // lblCentro
            // 
            lblCentro.AutoSize = true;
            lblCentro.Font = new Font("Segoe UI", 9F);
            lblCentro.Location = new Point(575, 28);
            lblCentro.Name = "lblCentro";
            lblCentro.Size = new Size(123, 15);
            lblCentro.TabIndex = 0;
            lblCentro.Text = "Centro de Verificación";
            // 
            // OrdenCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 463);
            Controls.Add(pnlPrincipalOrdenCompra);
            Name = "OrdenCompra";
            Text = "OrdenCompra";
            pnlPrincipalOrdenCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLineaCaptura).EndInit();
            gbLineaCaptura.ResumeLayout(false);
            gbLineaCaptura.PerformLayout();
            gbDatosFiscales.ResumeLayout(false);
            gbDatosFiscales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipalOrdenCompra;
        private GroupBox gbDatosFiscales;
        private ComboBox cbCentroVerificacion;
        private Label lblDireccion;
        private Label lblCentro;
        private TextBox txbDireccion;
        private Label lblRFC;
        private TextBox txbRFC;
        private TextBox txbRazonSocial;
        private Label lblRazonSocial;
        private GroupBox gbLineaCaptura;
        private Button btnValidar;
        private TextBox txbLineaCaptura;
        private DataGridView dgvLineaCaptura;
        private DataGridViewTextBoxColumn Linea;
        private DataGridViewTextBoxColumn Monto;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Button btnModificar;
        private Button btnPreview;
    }
}
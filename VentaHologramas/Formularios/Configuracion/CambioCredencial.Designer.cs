namespace VentaHologramas.Formularios.Configuracion {
    partial class CambioCredencial {
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
            pnlPrincipalCambioPassword = new Panel();
            pnlContenedor = new Panel();
            lblConfirmar = new Label();
            lblNuevaContraseña = new Label();
            lblContraseñaActual = new Label();
            lblCambioContraseñaTitulo = new Label();
            btnGuardar = new Button();
            txbConfirmarNuevaContraseña = new TextBox();
            txbContraseñaAnterior = new TextBox();
            txbNuevaContraseña = new TextBox();
            pnlPrincipalCambioPassword.SuspendLayout();
            pnlContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipalCambioPassword
            // 
            pnlPrincipalCambioPassword.BackColor = Color.FromArgb(79, 194, 204);
            pnlPrincipalCambioPassword.Controls.Add(pnlContenedor);
            pnlPrincipalCambioPassword.Location = new Point(12, 12);
            pnlPrincipalCambioPassword.Name = "pnlPrincipalCambioPassword";
            pnlPrincipalCambioPassword.Size = new Size(870, 435);
            pnlPrincipalCambioPassword.TabIndex = 0;
            pnlPrincipalCambioPassword.Paint += panel1_Paint;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.White;
            pnlContenedor.Controls.Add(lblConfirmar);
            pnlContenedor.Controls.Add(lblNuevaContraseña);
            pnlContenedor.Controls.Add(lblContraseñaActual);
            pnlContenedor.Controls.Add(lblCambioContraseñaTitulo);
            pnlContenedor.Controls.Add(btnGuardar);
            pnlContenedor.Controls.Add(txbConfirmarNuevaContraseña);
            pnlContenedor.Controls.Add(txbContraseñaAnterior);
            pnlContenedor.Controls.Add(txbNuevaContraseña);
            pnlContenedor.Location = new Point(165, 95);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(540, 240);
            pnlContenedor.TabIndex = 0;
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.ForeColor = Color.FromArgb(0, 100, 123);
            lblConfirmar.Location = new Point(120, 145);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(161, 15);
            lblConfirmar.TabIndex = 0;
            lblConfirmar.Text = "Confirmar Nueva Contraseña";
            // 
            // lblNuevaContraseña
            // 
            lblNuevaContraseña.AutoSize = true;
            lblNuevaContraseña.ForeColor = Color.FromArgb(0, 100, 123);
            lblNuevaContraseña.Location = new Point(120, 96);
            lblNuevaContraseña.Name = "lblNuevaContraseña";
            lblNuevaContraseña.Size = new Size(104, 15);
            lblNuevaContraseña.TabIndex = 0;
            lblNuevaContraseña.Text = "Nueva Contraseña";
            // 
            // lblContraseñaActual
            // 
            lblContraseñaActual.AutoSize = true;
            lblContraseñaActual.FlatStyle = FlatStyle.Flat;
            lblContraseñaActual.ForeColor = Color.FromArgb(0, 100, 123);
            lblContraseñaActual.Location = new Point(120, 44);
            lblContraseñaActual.Name = "lblContraseñaActual";
            lblContraseñaActual.Size = new Size(104, 15);
            lblContraseñaActual.TabIndex = 0;
            lblContraseñaActual.Text = "Contraseña Actual";
            // 
            // lblCambioContraseñaTitulo
            // 
            lblCambioContraseñaTitulo.AutoSize = true;
            lblCambioContraseñaTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCambioContraseñaTitulo.ForeColor = Color.FromArgb(0, 100, 123);
            lblCambioContraseñaTitulo.Location = new Point(3, 0);
            lblCambioContraseñaTitulo.Name = "lblCambioContraseñaTitulo";
            lblCambioContraseñaTitulo.Size = new Size(209, 21);
            lblCambioContraseñaTitulo.TabIndex = 4;
            lblCambioContraseñaTitulo.Text = "CAMBIO DE CONTRASEÑA";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 100, 123);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(120, 196);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(300, 37);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txbConfirmarNuevaContraseña
            // 
            txbConfirmarNuevaContraseña.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txbConfirmarNuevaContraseña.ForeColor = Color.FromArgb(103, 106, 106);
            txbConfirmarNuevaContraseña.Location = new Point(120, 163);
            txbConfirmarNuevaContraseña.Name = "txbConfirmarNuevaContraseña";
            txbConfirmarNuevaContraseña.Size = new Size(300, 25);
            txbConfirmarNuevaContraseña.TabIndex = 3;
            txbConfirmarNuevaContraseña.UseSystemPasswordChar = true;
            // 
            // txbContraseñaAnterior
            // 
            txbContraseñaAnterior.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txbContraseñaAnterior.ForeColor = Color.FromArgb(103, 106, 106);
            txbContraseñaAnterior.Location = new Point(120, 62);
            txbContraseñaAnterior.Name = "txbContraseñaAnterior";
            txbContraseñaAnterior.Size = new Size(300, 25);
            txbContraseñaAnterior.TabIndex = 1;
            txbContraseñaAnterior.UseSystemPasswordChar = true;
            // 
            // txbNuevaContraseña
            // 
            txbNuevaContraseña.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txbNuevaContraseña.ForeColor = Color.FromArgb(103, 106, 106);
            txbNuevaContraseña.Location = new Point(120, 114);
            txbNuevaContraseña.Name = "txbNuevaContraseña";
            txbNuevaContraseña.Size = new Size(300, 25);
            txbNuevaContraseña.TabIndex = 2;
            txbNuevaContraseña.UseSystemPasswordChar = true;
            // 
            // CambioCredencial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 458);
            Controls.Add(pnlPrincipalCambioPassword);
            Name = "CambioCredencial";
            Text = "CambioCredencial";
            pnlPrincipalCambioPassword.ResumeLayout(false);
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipalCambioPassword;
        private Panel pnlContenedor;
        private Button btnGuardar;
        private TextBox txbConfirmarNuevaContraseña;
        private TextBox txbContraseñaAnterior;
        private TextBox txbNuevaContraseña;
        private Label lblConfirmar;
        private Label lblNuevaContraseña;
        private Label lblContraseñaActual;
        private Label lblCambioContraseñaTitulo;
    }
}
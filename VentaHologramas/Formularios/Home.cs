
using Sivev.Core.RegEdit;

namespace VentaHologramas {
    public partial class Home : Form {

        public Home() {
            InitializeComponent();
            //this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void Home_Load(object sender, EventArgs e) {
            AgregarBotonesMenu();
            Limitar();
            /*try {
                using var reg = new RegWin();
                string estacionId = reg.EstacionId?.Trim();
                string ip = reg.IpAddress?.Trim();

                if (string.IsNullOrEmpty(estacionId) || estacionId == "00000000-0000-0000-0000-000000000000" || string.IsNullOrWhiteSpace(ip)) {
                    MessageBox.Show("Estación no configurada. Contacte al administrador.", "Error de configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close(); // o Application.Exit();
                    return;
                }
                //MessageBox.Show($"Estación OK: {estacionId}, IP: {ip}");
                //Console.WriteLine($"Estación OK: {estacionId}, IP: {ip}");
            } catch (Exception ex) {
                MessageBox.Show($"Error al leer configuración del registro:\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close(); // o Application.Exit();
            }*/
        }
        private void AgregarBotonesMenu() {
            tlpPrincipal.Controls.Add(CrearBotonMenu("   Venta rápida", Properties.Resources.Holograma), 0, 0);
            tlpPrincipal.Controls.Add(CrearBotonMenu("    Facturas", Properties.Resources.bill), 1, 0);
            tlpPrincipal.Controls.Add(CrearBotonMenu("  Devoluciones", Properties.Resources._return), 0, 1);
            tlpPrincipal.Controls.Add(CrearBotonMenu(" Reportes", Properties.Resources.reportes), 1, 1);
        }
        private void Home_Resize(object sender, EventArgs e) {
            float baseWidth = 1024f; // resolución base de diseño
            float scale = this.Width / baseWidth;

            foreach (Control ctrl in tlpPrincipal.Controls) {
                ctrl.Font = new Font("Segoe UI", 10F * scale, FontStyle.Regular);
            }
        }


        private Button CrearBotonMenu(string texto, Image icono) {
            var boton = new Button    {
                Text = texto,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleRight,
                ImageAlign = ContentAlignment.MiddleLeft,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                Padding = new Padding(20, 5, 20, 5),
                Size = new Size(180, 70),
                Anchor = AnchorStyles.None,
                UseVisualStyleBackColor = false,
                Image = icono
            };

            boton.FlatAppearance.BorderSize = 0;
            return boton;
        }

        private void smiSalir_Click(object sender, EventArgs e) {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2 );
            if (resultado == DialogResult.Yes) {
                Application.Exit();
            }
        }
        private void Limitar() {
            foreach (ToolStripMenuItem item in menuStrip1.Items) {
                if (item.Name != "smiSalir" && item.Name != "smiConfi")
                    item.Enabled = false;
            }
            foreach (ToolStripItem subItem in smiConfi.DropDownItems) {
                if (subItem.Name != "smiEstacion")
                    subItem.Enabled = false;
            }
        }

        private void smiEstacion_Click(object sender, EventArgs e) {

        }

        private void smiClaveAcceso_Click(object sender, EventArgs e) {

        }
    }
}

using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VentaHologramas.Formularios.Venta {
    
    public partial class OrdenCompra : Form {
        public OrdenCompra() {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e) {
            var razonSocial = txbRazonSocial.Text;
            var rfc = txbRFC.Text;
            var centro = cbCentroVerificacion.Text;
            var direccion = txbDireccion.Text;
            var lineaCaptura = txbLineaCaptura.Text;

            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ReporteCentros.pdf");
            GenerarPdfOrdenCompra(ruta);

            MessageBox.Show($"PDF generado en: {ruta}");
        }

        private void GenerarPdfOrdenCompra( string rutaArchivo) {
            LocalReport reporte = new LocalReport();
            reporte.ReportEmbeddedResource = "VentaHologramas.Formularios.Facturacion.ReporteCentros.rdlc";

           // var rds = new ReportDataSource("DataSeReporteCentros", datos);
           // reporte.DataSources.Clear();
            //reporte.DataSources.Add(rds);

            // Renderizar como PDF
            try {
                byte[] pdf = reporte.Render("PDF", null, out _, out _, out _, out _, out Warning[] warns);
                if (warns != null && warns.Length > 0)
                    MessageBox.Show(string.Join(Environment.NewLine, warns.Select(w => $"{w.Code}: {w.Message}")));
                File.WriteAllBytes(rutaArchivo, pdf);
            } catch (LocalProcessingException lpex) {
                MessageBox.Show("RDLC error: " + (lpex.InnerException?.Message ?? lpex.Message));
            } catch (Exception ex) {
                MessageBox.Show("General error: " + ex.Message);
            }
        }

    }
}

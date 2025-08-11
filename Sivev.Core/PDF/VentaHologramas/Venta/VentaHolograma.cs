using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using Sivev.Core.PDF.VentaHologramas.Comisa;
using System.IO;


namespace Sivev.Core.PDF.VentaHolograma.Venta {
    public class CentroVerificacion {
        public int Remision { get; set; }
        public DateTime FechaRemision { get; set; }
        public string Direccion { get; set; }
        public string Centro { get; set; }
        public string RazonSocial { get; set; }
        public string RFC { get; set; }
        public string CentroVerificacionName { get; set; }
    }

    public class CertificadoItem {
        public int Cantidad { get; set; }
        public string TipoHolograma { get; set; }
        public int FolioInicial { get; set; }
        public int FolioFinal { get; set; }
    }

    public class LineaCapturaItem {
        public string LC { get; set; }
        public decimal Precio { get; set; }     // unitario o total (según tu operación)
        //public decimal Importe { get; set; }    // si Precio es unitario, puedes calcular aquí
        
        // Si prefieres cálculo:
        public int Cantidad { get; set; } = 1;
        public decimal Importe => Cantidad * Precio;
    }

    public class VentaHolograma {
        private readonly CentroVerificacion _cvv;
        private readonly List<CertificadoItem> _certificados;
        private readonly List<LineaCapturaItem> _lineas;
        private readonly string _headerPath;
        private readonly string _footerPath;

        public VentaHolograma(CentroVerificacion cvv, IEnumerable<LineaCapturaItem> itemsLC, List<CertificadoItem> itemsCertificado,
                              string header = @"C:\Logos\header.png",
                              string footer = @"C:\Logos\footer.png") {
            _cvv = cvv;
            _lineas = itemsLC?.ToList() ?? new();
            _certificados = itemsCertificado?.ToList() ?? new();
            _headerPath = header;
            _footerPath = footer;
        }

        public void BuildPdf(Document doc) {
            DefineStyles(doc);

            var sec = doc.AddSection();
            sec.PageSetup.PageFormat = PageFormat.Letter;
            sec.PageSetup.TopMargin = "3.5cm";
            sec.PageSetup.BottomMargin = "0.5cm";
            sec.PageSetup.LeftMargin = "1.8cm";
            sec.PageSetup.RightMargin = "1.8cm";
            sec.PageSetup.HeaderDistance = "0.5cm";
            sec.PageSetup.FooterDistance = "0.1cm";

            var contentWidth = sec.PageSetup.PageWidth - sec.PageSetup.LeftMargin - sec.PageSetup.RightMargin;

            // ===== HEADER =====
            var header = sec.Headers.Primary;
            if (!string.IsNullOrWhiteSpace(_headerPath) && File.Exists(_headerPath)) {
                var img = header.AddImage(_headerPath);
                img.LockAspectRatio = false;
                img.RelativeHorizontal = RelativeHorizontal.Page;
                img.Left = ShapePosition.Center;

                img.Width = Unit.FromCentimeter(20.12);
                img.Height = Unit.FromCentimeter(3.17);
                //img.Width = img.Width/2;              // ancho total de la página
                img.Top = 0;                                      // pegada arriba
                header.AddParagraph().Format.SpaceAfter = "0.2cm";
            } else {
                var tbl = header.AddTable();
                tbl.AddColumn("3cm"); tbl.AddColumn(contentWidth - Unit.FromCentimeter(6)); tbl.AddColumn("3cm");
                var r = tbl.AddRow();
                r.VerticalAlignment = VerticalAlignment.Center;
                var p = r.Cells[1].AddParagraph("SECRETARÍA DEL MEDIO AMBIENTE\nDIRECCIÓN GENERAL DE CALIDAD DEL AIRE");
                p.Format.Alignment = ParagraphAlignment.Center;
                p.Format.Font.Size = 11; p.Format.Font.Bold = true;
                header.AddParagraph().Format.SpaceAfter = "3.25cm";
            }

            // ===== CUERPO =====
            /*
            var rem = sec.AddParagraph($"REMISIÓN: {_cvv.Remision}");
            rem.Format.Alignment = ParagraphAlignment.Right;

            var fecha = sec.AddParagraph($"{_cvv.FechaRemision.ToString("D")}");
            fecha.Format.Alignment = ParagraphAlignment.Right;
            fecha.Format.SpaceAfter = "0.5cm";


            */
            sec.AddParagraph().AddLineBreak();
            sec.AddParagraph().AddLineBreak();
            var titulo = sec.AddParagraph($"COMPROBANTE DE ENTREGA DE CERTIFICADOS – REMISIÓN: {_cvv.Remision}");
            titulo.Format.Alignment = ParagraphAlignment.Center;
            titulo.Format.Font.Size = 14; titulo.Format.Font.Bold = true;
            titulo.Format.SpaceAfter = "0.5cm";
            
            var fecha = sec.AddParagraph($"Ciudad de México, {_cvv.FechaRemision.ToString("D")}");
            fecha.Format.Alignment = ParagraphAlignment.Right;
            fecha.Format.SpaceAfter = "0.5cm";

            // Datos Fiscales
            sec.AddParagraph("DATOS FISCALES").Format.Font.Bold = true;
            var t = sec.AddTable(); t.Borders.Width = 0.5;
            t.AddColumn("4cm"); t.AddColumn("14cm");
            void Row(string e, string v) {
                var rr = t.AddRow();
                rr.Cells[0].AddParagraph(e).Format.Font.Bold = true;
                rr.Cells[1].AddParagraph(v ?? string.Empty);
            }
            Row("Razón Social:", _cvv.RazonSocial);
            Row("RFC:", _cvv.RFC);
            Row("Centro Verificación:", _cvv.CentroVerificacionName);
            Row("Dirección:", _cvv.Direccion);

            sec.AddParagraph().AddLineBreak();
            sec.AddParagraph().AddLineBreak();
            sec.AddParagraph().AddLineBreak();



            // ===== 1) ENTREGA DE CERTIFICADOS =====
            sec.AddParagraph("ENTREGA DE CERTIFICADOS").Format.Font.Bold = true;

            var tEnt = sec.AddTable();
            tEnt.Borders.Width = 0.5;
            tEnt.AddColumn("2cm");   // Cantidad
            tEnt.AddColumn("10cm");   // Tipo de holograma
            tEnt.AddColumn("3cm");   // Folio inicial
            tEnt.AddColumn("3cm");   // Folio final

            var hdrEnt = tEnt.AddRow();
            string[] headsEnt = { "CANTIDAD","TIPO DE HOLOGRAMA","FOLIO INICIAL","FOLIO FINAL" };
            for (int i = 0; i < headsEnt.Length; i++) {
                var p = hdrEnt.Cells[i].AddParagraph(headsEnt[i]);
                hdrEnt.Cells[i].Format.Font.Bold = true;
                p.Format.Alignment = ParagraphAlignment.Center;
            }

            // _certificados: lista con Cantidad, TipoHolograma, FolioInicial, FolioFinal
            foreach (var c in _certificados) {
                var r = tEnt.AddRow();
                r.Cells[0].AddParagraph(c.Cantidad.ToString()).Format.Alignment = ParagraphAlignment.Right;
                r.Cells[1].AddParagraph(c.TipoHolograma ?? "");
                r.Cells[2].AddParagraph(c.FolioInicial.ToString()).Format.Alignment = ParagraphAlignment.Right;
                r.Cells[3].AddParagraph(c.FolioFinal.ToString()).Format.Alignment = ParagraphAlignment.Right;
            }

            // Espacio entre tablas
            sec.AddParagraph().Format.SpaceAfter = "0.4cm";


            // ===== 2) LÍNEAS DE CAPTURA =====
            sec.AddParagraph("LÍNEAS DE CAPTURA").Format.Font.Bold = true;

            var tLC = sec.AddTable();
            tLC.Borders.Width = 0.5;
            tLC.AddColumn("12cm");  // Línea de captura
            tLC.AddColumn("3cm");   // Precio
            tLC.AddColumn("3cm");   // Importe

            var hdrLC = tLC.AddRow();
            string[] headsLC = { "LÍNEA DE CAPTURA","PRECIO","IMPORTE" };
            for (int i = 0; i < headsLC.Length; i++) {
                var p = hdrLC.Cells[i].AddParagraph(headsLC[i]);
                hdrLC.Cells[i].Format.Font.Bold = true;
                p.Format.Alignment = ParagraphAlignment.Center;
            }

            decimal total = 0m;
            // _lineas: lista de LineaCapturaItem (ver clase abajo)
            foreach (var it in _lineas) {
                var r = tLC.AddRow();
                r.Cells[0].AddParagraph(it.LC ?? "");
                r.Cells[1].AddParagraph(it.Precio.ToString("C2")).Format.Alignment = ParagraphAlignment.Right;
                r.Cells[2].AddParagraph(it.Importe.ToString("C2")).Format.Alignment = ParagraphAlignment.Right;
                total += it.Importe;
            }

            // Fila de TOTAL
            var tot = tLC.AddRow();
            tot.Borders.Top.Width = 0.5;
            tot.Cells[0].MergeRight = 1;
            tot.Cells[0].AddParagraph("TOTAL").Format.Alignment = ParagraphAlignment.Right;
            tot.Cells[2].AddParagraph(total.ToString("C2")).Format.Alignment = ParagraphAlignment.Right;
            tot.Cells[0].Format.Font.Bold = true;
            tot.Cells[2].Format.Font.Bold = true;






            // ===== FOOTER =====
            var footer = sec.Footers.Primary;

            // Leyenda centrada con línea superior
            var legend = footer.AddParagraph();
            legend.AddText("He revisado y estoy conforme con los datos y las partidas incluidas en esta remisión.");
            legend.AddLineBreak();
            legend.AddText("Estoy enterado de que serán los datos que conforman la factura correspondiente.");

            legend.Format.Alignment = ParagraphAlignment.Center;
            legend.Format.SpaceBefore = "0.2cm";
            //legend.Format.Borders.Top.Width = 0.5;
            legend.Format.LeftIndent = 0;
            legend.Format.RightIndent = 0;

            // Espacio antes de la firma
            footer.AddParagraph().AddLineBreak();

            // Firma centrada
            var firma = footer.AddParagraph();
            firma.AddText("__________________________");
            firma.AddLineBreak();
            firma.AddText("Nombre y firma de conformidad");
            firma.Format.Alignment = ParagraphAlignment.Center;
            firma.Format.SpaceBefore = "0.2cm";

            // Paginación a la derecha
            //var pg = footer.AddParagraph();
            //pg.Format.Alignment = ParagraphAlignment.Right;
            //pg.AddText("Página "); pg.AddPageField(); pg.AddText(" de "); pg.AddNumPagesField();
            
            if (!string.IsNullOrWhiteSpace(_footerPath) && File.Exists(_footerPath)) {
                var imgParagraph = footer.AddParagraph();
                imgParagraph.Format.SpaceBefore = ".1cm"; // controlas cuánto la bajas

                var img = imgParagraph.AddImage(_footerPath);
                img.LockAspectRatio = true;
                img.RelativeHorizontal = RelativeHorizontal.Page;
                //img.Left = -sec.PageSetup.LeftMargin / 3;
                img.Width = sec.PageSetup.PageWidth;
            }
        }

        private static void DefineStyles(Document doc) {
            var s = doc.Styles["Normal"];
            s.Font.Name = "Arial"; s.Font.Size = 10;
        }
    }

}

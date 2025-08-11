using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
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

    public class LineaCapturaItem {
        public int Cantidad { get; set; }
        public string Concepto { get; set; }
        public int FolioInicial { get; set; }
        public int FolioFinal { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe => Cantidad * Precio;
    }

    public class VentaHolograma {
        private readonly CentroVerificacion _cvv;
        private readonly List<LineaCapturaItem> _items;
        private readonly string _headerPath;
        private readonly string _footerPath;

        public VentaHolograma(CentroVerificacion cvv, IEnumerable<LineaCapturaItem> items, 
                              string header = @"C:\Logos\header.png",
                              string footer = @"C:\Logos\footer.png") {
            _cvv = cvv;
            _items = items?.ToList() ?? new();
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
            var rem = sec.AddParagraph($"REMISIÓN: {_cvv.Remision}");
            rem.Format.Alignment = ParagraphAlignment.Right;

            var fecha = sec.AddParagraph($"{_cvv.FechaRemision.ToString("D").ToUpper()}.");
            fecha.Format.Alignment = ParagraphAlignment.Right;
            fecha.Format.SpaceAfter = "0.5cm";

            var titulo = sec.AddParagraph("ORDEN DE COMPRA");
            titulo.Format.Alignment = ParagraphAlignment.Center;
            titulo.Format.Font.Size = 14; titulo.Format.Font.Bold = true;
            titulo.Format.SpaceAfter = "0.5cm";

            // Datos Fiscales
            sec.AddParagraph("DATOS FISCALES").Format.Font.Bold = true;
            var t = sec.AddTable(); t.Borders.Width = 0.5;
            t.AddColumn("4cm"); t.AddColumn("10cm");
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

            // Líneas de captura
            sec.AddParagraph("LÍNEAS DE CAPTURA").Format.Font.Bold = true;
            var tLC = sec.AddTable(); tLC.Borders.Width = 0.5;
            tLC.AddColumn("2cm");   // Cantidad
            tLC.AddColumn("5.5cm"); // Concepto
            tLC.AddColumn("3cm");   // Folio inicial
            tLC.AddColumn("2.5cm"); // Folio final
            tLC.AddColumn("2.5cm"); // Precio
            tLC.AddColumn("2.5cm"); // Importe

            var hdr = tLC.AddRow();
            string[] heads = { "CANTIDAD","CONCEPTO","FOLIO INICIAL","FOLIO FINAL","PRECIO","IMPORTE" };
            for (int i = 0; i < heads.Length; i++) {
                hdr.Cells[i].AddParagraph(heads[i]).Format.Font.Bold = true;
            }

            decimal total = 0m;
            foreach (var it in _items) {
                var r = tLC.AddRow();
                r.Cells[0].AddParagraph(it.Cantidad.ToString()).Format.Alignment = ParagraphAlignment.Right;
                r.Cells[1].AddParagraph(it.Concepto ?? "");
                r.Cells[2].AddParagraph(it.FolioInicial.ToString()).Format.Alignment = ParagraphAlignment.Right;
                r.Cells[3].AddParagraph(it.FolioFinal.ToString()).Format.Alignment = ParagraphAlignment.Right;
                r.Cells[4].AddParagraph(it.Precio.ToString("C")).Format.Alignment = ParagraphAlignment.Right;
                r.Cells[5].AddParagraph(it.Importe.ToString("C")).Format.Alignment = ParagraphAlignment.Right;
                total += it.Importe;
            }

            var tot = tLC.AddRow();
            tot.Cells[0].MergeRight = 4;
            tot.Cells[0].AddParagraph("TOTAL").Format.Font.Bold = true;
            tot.Cells[5].AddParagraph(total.ToString("C")).Format.Font.Bold = true;
            tot.Cells[5].Format.Alignment = ParagraphAlignment.Right;

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

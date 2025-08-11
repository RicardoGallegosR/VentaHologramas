using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using Sivev.Core.PDF.VentaHolograma.Venta;
using System.IO;

namespace Sivev.Core.PDF.VentaHologramas.Comisa {
    public class CentroVerificacion {
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

    public class IngresoCertificadosSedema {
        private readonly CentroVerificacion _cvv;
        private readonly List<LineaCapturaItem> _items;
        private readonly string _headerPath;
        private readonly string _footerPath;
        private readonly int _Remision;

        public IngresoCertificadosSedema(CentroVerificacion cvv, IEnumerable<LineaCapturaItem> items, int Remision,
                              string header = @"C:\Logos\header.png",
                              string footer = @"C:\Logos\footer.png") {
            _cvv = cvv;
            _items = items?.ToList() ?? new();
            _headerPath = header;
            _footerPath = footer;
            _Remision = Remision;
        }
    }
}

using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using Sivev.Core.PDF.VentaHolograma.Venta;
using System.IO;

namespace Sivev.Core.PDF.VentaHologramas.Comisa {
    public class SEDEMA {
        public string Direccion { get; set; }
    }

    public class COMISA {
        public int Cantidad { get; set; }
        public string tipo { get; set; }
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

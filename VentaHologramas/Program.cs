namespace VentaHologramas {
    internal static class Program    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Home());
            //Application.Run(new Formularios.Reportes.Reportes());
           Application.Run(new Formularios.Venta.OrdenCompra());
           //Application.Run(new Formularios.Facturacion.FrmPreviewOrdenCompra());
        }
    }
}
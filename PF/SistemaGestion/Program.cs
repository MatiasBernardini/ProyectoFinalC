namespace SistemaGestion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static Form1 form1;
        public static ProductosForm _productosForm;
        public static ProductoVendidosForm _productosVendidosForm;
        public static VentasForm _ventaForm;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            _productosForm = new ProductosForm();
            _productosVendidosForm = new ProductoVendidosForm();
            _ventaForm = new VentasForm();
            Application.Run(form1 = new Form1());
        }
    }
}
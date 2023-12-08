using StockApp.Busines.Interface.Database;
using StockApp.WindowsForms._inicializar;
using StockApp.WindowsForms.Cadastros;
using System.Windows.Forms.Design;

namespace StockApp.Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 


        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            try
            {
                var banco = new InicializarDatabase();
            }
            catch
            {
                throw;
            }

  
           
            Application.Run(new frmCategoria());
        }
    }
}
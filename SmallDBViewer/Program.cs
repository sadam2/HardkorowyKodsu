using System.Configuration;
using System.Collections.Specialized;
using System.Data;

namespace SmallDBViewer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //internal static string ApiUrl = ConfigurationManager.AppSettings.Get("Url");
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DataFromApi.GetTables();
            Application.Run(new MainWindow());
        }
    }
}
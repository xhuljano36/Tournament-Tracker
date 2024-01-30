
using System;
using System.Configuration;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerIUU
{
    static class Program
    {
        /// <summary>
        ///  Pikënisja kryesore e programit.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Leximi i konfigurimeve nga app.config
            //string connectionString = ConfigurationManager.AppSettings["DatabaseConnectionString"];

            // Inicializimi i TrackerLibrary me stringun e lidhjes që është marrë
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.sql);

            Application.Run(new TournamentDashboardForm());
        }
    }
}
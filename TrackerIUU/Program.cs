
using System;
using System.Configuration;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerIUU
{
    static class Program
    {
        /// <summary>
        ///  Pik�nisja kryesore e programit.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Leximi i konfigurimeve nga app.config
            //string connectionString = ConfigurationManager.AppSettings["DatabaseConnectionString"];

            // Inicializimi i TrackerLibrary me stringun e lidhjes q� �sht� marr�
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.sql);

            Application.Run(new TournamentDashboardForm());
        }
    }
}
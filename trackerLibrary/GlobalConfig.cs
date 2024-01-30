using System;
using System.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        static GlobalConfig()
        {
            InitializeConfiguration();
        }

        private static void InitializeConfiguration()
        {
            // Nuk ka nevojë për këtë metodë, sepse ConfigurationManager.AppSettings
            // do të përdoret direkt për të lexuar konfigurimet nga app.config
        }

        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModel.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryFile.csv";

        public static IdataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.sql)
            {
                sqlConnector sql = new sqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            // Përdor ConfigurationManager.AppSettings për të lexuar konfigurimet nga app.config
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppKeyLookUp(string key)
        {
            // Përdor ConfigurationManager.AppSettings për të lexuar konfigurimet nga app.config
            return ConfigurationManager.AppSettings[key];
        }
    }
}

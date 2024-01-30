using System;
using System.Collections.Generic;
using System.Linq;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Configuration;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IdataConnection
    {
        private readonly string PrizesFile;
        private readonly string PeopleFile;
        private readonly string TeamFile;
        private readonly string TournamentFile;

        public TextConnector()
        {
            PrizesFile = ConfigurationManager.AppSettings["PrizesFile"];
            PeopleFile = ConfigurationManager.AppSettings["PeopleFile"];
            TeamFile = ConfigurationManager.AppSettings["TeamFile"];
            TournamentFile = ConfigurationManager.AppSettings["TournamentFile"];
        }

        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            people.Add(model);
            people.SaveToPeopleFile();
        }

        public void CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            prizes.Add(model);
            prizes.SaveToPrizeFile();
        }

        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            teams.Add(model);
            teams.SaveToTeamFile();
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            model.SaveRoundsToFile();
            tournaments.Add(model);
            tournaments.SaveToTournamentFile();
           // TournamentLogic.UpdateTournamentResults(tournament);
        }

        public List<TournamentModel> GetTournament_All()
        {
            return TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }

        public void CompleteTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
            tournaments.Remove(model);
            tournaments.SaveToTournamentFile();
           // TournamentLogic.UpdateTournamentResults(model);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    public class MatchupEntryModel
    {
        public int Id { get; set; }
        public int TeamCompetingId { get; set; }
        /// <summary>
        /// represents one team in matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represents the score for this particular team
        /// </summary>
        public double Score { get; set; }
        public int ParentMatchupId { get; set; }
        /// <summary>
        /// represents the matchup that this team came from as winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}

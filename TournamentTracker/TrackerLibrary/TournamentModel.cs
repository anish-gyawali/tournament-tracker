using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the entry fee for the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the list of entered teams
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }= new List<TeamModel>();

        /// <summary>
        /// Represent the prizes for the teams based on their place.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represent thr round of tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}

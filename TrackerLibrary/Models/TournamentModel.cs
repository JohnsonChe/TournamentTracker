using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{   /// <summary>
    /// Represents one tournament, with all of the rounds, matchings, prizes, and outcomes.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// The name given to this tournment.
        /// </summary>
        public string TournamentName { get; set; }
      
        /// <summary>
        /// The amount of money each team needs to put up to enter.
        /// </summary>
        public decimal EntryFee { get; set; }
       
        /// <summary>
        /// The set of teams that have been entered.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        
        /// <summary>
        /// The list of prizes for the various places. 
        /// </summary>
        public List<PrizeModel> Prizes { get; set; }

        /// <summary>
        /// The matchups per round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; }

        TournamentModel()
        {
            Prizes = new List<PrizeModel>();
            Rounds = new List<List<MatchupModel>>();
        }
    }
}

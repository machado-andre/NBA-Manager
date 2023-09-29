using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAManager.Classes
{
    public class Season
    {
        private DateTime startingDate;
        private DateTime finishingDate;
        private List<Game> seasonGames;
        private List<Team> teams = new List<Team>();

        public Season(/*DateTime startingDate, DateTime finishingDate,*/ List<Team> teams)
        {
            /*this.startingDate = startingDate.Date;
            this.finishingDate = finishingDate.Date;*/
            this.teams = teams;
            seasonGames = new List<Game>();
            generateSeasonGames();
        }

        public DateTime getStartingDate() { return startingDate; }
        public DateTime getFinishingDate() { return finishingDate; }

        private void generateSeasonGames()
        {
            foreach(Team team in teams)
            {
                for(int i = 0; i < teams.Count; i++)
                {
                    if(team == teams[i]) { continue; }
                    Game game = new Game(team, teams[i]);
                    seasonGames.Add(game);
                    team.addGame(game);
                }
            }
        }

        public List<Game> getSeasonGames() { return seasonGames; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAManager.Classes
{
    public class Game
    {
        private Team homeTeam;
        private Team visitorTeam;
        private DateTime gameDate;
        private Random random;
        public Game(Team homeTeam, Team visitorTeam/*, DateTime gameDate*/)
        {
            this.homeTeam = homeTeam;
            this.visitorTeam = visitorTeam;
            //this.gameDate = gameDate.Date;
        }

        public DateTime getGameDate() { return  gameDate.Date; }

        public Team getHomeTeam() { return homeTeam;}

        public Team getVisitorTeam() {  return visitorTeam;}


        private void teamScores(Team attackingTeam, Team defendingTeam)
        {
            double offenseRating = attackingTeam.getOffensiveRating();
            double defenseRating = defendingTeam.getDefensiveRating();

            //Variable to decide if the FGAttempt is a 2pt or 3pt (if above 0.35 it's a 2pt else it's a 3pt)
            double FGAttempt = random.NextDouble();
            //A bit of RNG to decide if the shot goes in or not
            double rng = random.Next(50, 71);

            if(FGAttempt > 0.35)
            {
                if((offenseRating - defenseRating / 2 * 0.55) > 64.5)
                {
                    attackingTeam.setGameScore(attackingTeam.getGameScore() + 2);
                }
            }
            else
            {
                if((offenseRating + defenseRating) / 2 * 0.35 > 35.5)
                {
                    attackingTeam.setGameScore(attackingTeam.getGameScore() + 3);
                }
            }
        }
    }
}

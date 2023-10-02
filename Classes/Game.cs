using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace NBAManager.Classes
{
    public class Game
    {
        private Team homeTeam;
        private Team visitorTeam;
        private DateTime gameDate;
        private Random random = new Random();
        private Team attackingTeam;
        private Team defendingTeam;

        public Game(Team homeTeam, Team visitorTeam/*, DateTime gameDate*/)
        {
            this.homeTeam = homeTeam;
            this.visitorTeam = visitorTeam;
            //this.gameDate = gameDate.Date;
        }

        public DateTime getGameDate() { return  gameDate.Date; }

        public Team getHomeTeam() { return homeTeam;}

        public Team getVisitorTeam() {  return visitorTeam;}

        public Team getAttackingTeam() { return attackingTeam; }

        public Team getDefendingTeam() { return defendingTeam; }

        public void jumpBall()
        {
            if (random.Next(2) == 0)
            {
                attackingTeam = homeTeam;
                defendingTeam = visitorTeam;
            }
            else
            {
                attackingTeam = visitorTeam;
                defendingTeam = homeTeam;
            }
        }


        public void runPlay(ListBox listBox)
        {
            double offenseRating = attackingTeam.getOffensiveRating();
            double defenseRating = defendingTeam.getDefensiveRating();

            //A bit of RNG to decide if the shot goes in or not

            // decide if the FGAttempt is a 2pt or 3pt(if above 0.35 it's a 2pt else it's a 3pt)
            if (random.NextDouble() > 0.30)
            {
                if(((offenseRating - defenseRating) / 2 * 0.55) + random.Next(50, 71) > 64.5)
                {
                    attackingTeam.setGameScore(attackingTeam.getGameScore() + 2);
                    playDetails(listBox, 2, attackingTeam);
                }
                else
                {
                    playDetails(listBox, 0, attackingTeam);
                }
            }
            else
            {
                if(((offenseRating + defenseRating) / 2 * 0.35) + random.Next(25, 51) > 35.5)
                {
                    attackingTeam.setGameScore(attackingTeam.getGameScore() + 3);
                    playDetails(listBox, 3, attackingTeam);
                }
                else
                {
                    playDetails(listBox, 0, attackingTeam);
                }
            }
            changeAttacker();
        }

        private void changeAttacker()
        {
            var aux = attackingTeam;
            attackingTeam = defendingTeam;
            defendingTeam = aux;
        }

        private void playDetails(ListBox listBox, int ptsScored, Team attackingTeam)
        {
            if(ptsScored == 2)
            {
                switch (random.Next(10))
                {
                    case 0:
                        listBox.Items.Add(attackingTeam.getStartingFive()[0].getLastName() + " with the jumper!");
                        break;
                    case 1:
                        listBox.Items.Add(attackingTeam.getStartingFive()[1].getLastName() + " with the jumper.");
                        break;
                    case 2:
                        listBox.Items.Add(attackingTeam.getStartingFive()[2].getLastName() + " on the fastbreak.");
                        break;
                    case 3:
                        listBox.Items.Add(attackingTeam.getStartingFive()[3].getLastName() + " with the fade-away.");
                        break;
                    case 4:
                        listBox.Items.Add(attackingTeam.getStartingFive()[4].getLastName() + " with the hook.");
                        break;
                    case 6:
                        listBox.Items.Add(attackingTeam.getStartingFive()[0].getLastName() + " slam dunk!");
                        break;
                    case 7:
                        listBox.Items.Add(attackingTeam.getStartingFive()[4].getLastName() + " slam dunk!");
                        break;
                    default:
                        listBox.Items.Add(attackingTeam.getStartingFive()[random.Next(5)].getLastName() + " with the layup!");
                        break;
                }
            }
            else if (ptsScored == 3)
            {
                switch (random.Next(10))
                {
                    case 0:
                        listBox.Items.Add(attackingTeam.getStartingFive()[0].getLastName() + " from deep!");
                        break;
                    case 1:
                        listBox.Items.Add(attackingTeam.getStartingFive()[1].getLastName() + " with the splash!");
                        break;
                    case 2:
                        listBox.Items.Add(attackingTeam.getStartingFive()[2].getLastName() + " from downtown!");
                        break;
                    case 3:
                        listBox.Items.Add(attackingTeam.getStartingFive()[3].getLastName() + " for three.");
                        break;
                    default:
                        listBox.Items.Add(attackingTeam.getStartingFive()[random.Next(3)].getLastName() + " with the trey!");
                        break;
                }
            }
            else
            {
                listBox.Items.Add(attackingTeam.getStartingFive()[random.Next(5)].getLastName() + " missed his shot.");
            }
        }
    }
}

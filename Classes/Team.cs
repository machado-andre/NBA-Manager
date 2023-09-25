using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAManager.Classes
{
    public class Team
    {
        private string name;
        private int rating;
        private List<Player> players;
        private string location;
        private short wins, losses;

        public Team(string name, string location)
        {
            this.name = name;
            this.location = location;
            this.wins = 0;
            this.losses = 0;
            players = new List<Player>();
        }

        public string getName() { return this.name; }

        public int getRating() { return this.rating; }
        public void setRating(int rating) { this.rating = rating; }

        public string getLocation() { return this.location; }

        public List<Player> getPlayers() { return this.players; }

        public void addPlayer(Player player) { players.Add(player); }

        public void addWin() { this.wins++; }
        public void addLoss() { this.losses++;}
        public void resetRecord() { this.losses=0; this.wins = 0; }

        public override string ToString()
        {
            return this.name + "\t\t" + this.wins + "\t\t" + this.losses + "\t\t." + calcWinPercentage();
        }

        private float calcWinPercentage()
        {
            if (this.wins + this.losses == 0)
                return 0;

            return this.wins / (this.wins + this.losses);
        }
    }
}

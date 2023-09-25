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

        public Team(string name, string location)
        {
            this.name = name;
            this.location = location;
            players = new List<Player>();
        }

        public string getName() { return this.name; }

        public int getRating() { return this.rating; }
        public void setRating(int rating) { this.rating = rating; }

        public List<Player> getPlayers() { return this.players; }

        public void addPlayer(Player player) { players.Add(player); }
    }
}

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
        private double offensiveRating = 0;
        private double defensiveRating = 0;
        private List<Player> players;
        private List<Player> starting5;
        private string location;
        private short wins, losses;
        private int gameScore = 0;
        private List<Game> games;

        public Team(string name, string location)
        {
            this.name = name;
            this.location = location;
            this.wins = 0;
            this.losses = 0;
            players = new List<Player>();
            games = new List<Game>();
            starting5 = new List<Player>();
        }

        public string getName() { return this.name; }

        public double getOffensiveRating()
        {
            offensiveRating = 0;
            foreach(Player player in players)
            {
                offensiveRating += player.getOffense();
            }
            return offensiveRating / players.Count;
        }
        public double getDefensiveRating()
        {
            defensiveRating = 0;
            foreach (Player player in players)
            {
                defensiveRating += player.getDefense();
            }
            return defensiveRating / players.Count;
        }

        public double getOverall() { return ((this.offensiveRating + this.defensiveRating) / 2) + 1; }

        public string getLocation() { return this.location; }

        public List<Player> getPlayers() { return this.players; }

        public void addPlayer(Player player) { players.Add(player); }

        public void addWin() { this.wins++; }
        public void addLoss() { this.losses++;}
        public void resetRecord() { this.losses=0; this.wins = 0; }

        public void setGameScore(int score) { gameScore = score; }

        public int getGameScore() { return gameScore; }

        public List<Game> GetGames() { return this.games; }

        public Game getGame(int index) { return this.games.ElementAt(index); }

        public void addGame(Game game) { games.Add(game); }

        public List<Player> getStartingFive() { return starting5; }

        public void addToStartingFive(Player player) { starting5.Add(player); }

        public Player removeFromStartingFive(Player player) { starting5.Remove(player); return player; }

        public Game removeGameToBePlayed(Game game) { games.Remove(game); return game; }

        public override string ToString()
        {
            return this.name + "\t\t" + this.wins + "\t\t" + this.losses + "\t\t." + calcWinPercentage();
        }

        public List<Player> getPlayersByPosition(Position position)
        {
            List<Player> playersFromPosition = new List<Player>();
            foreach (Player player in players)
            {
                if(player.getPosition() == position)
                {
                    playersFromPosition.Add(player);
                }
            }

            return playersFromPosition;
        }

        private float calcWinPercentage()
        {
            if (this.wins + this.losses == 0)
                return 0;

            return this.wins / (this.wins + this.losses);
        }
    }
}

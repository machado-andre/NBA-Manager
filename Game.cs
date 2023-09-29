using NBAManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBAManager
{
    public partial class Game : Form
    {
        private List<Player> players = new List<Player>();
        private List<Team> teams = new List<Team>();
        Random random = new Random();
        //int to iterate through positions and select a position for each random crated player iteratively
        int positionIndex = 0;

        public Game()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            generateTeamsAndPlayers();
            initializeGraphComponent();
        }

        public void generateTeamsAndPlayers()
        {
            #region Teams
            Team california = new Team("California", "W");
            teams.Add(california);
            Team oakland = new Team("Oakland", "W");
            teams.Add(oakland);
            Team portland = new Team("Portland", "W");
            teams.Add(portland);
            Team oklahoma = new Team("Oklahoma", "W");
            teams.Add(oklahoma);
            Team phoenix = new Team("Phoenix", "W");
            teams.Add(phoenix);

            Team chicago = new Team("Chicago", "E");
            teams.Add(chicago);
            Team philadelphia = new Team("Philadelphia", "E");
            teams.Add(philadelphia);
            Team milwaukee = new Team("Milwaukee", "E");
            teams.Add(milwaukee);
            Team miami = new Team("Miami", "E");
            teams.Add(miami);
            Team boston = new Team("Boston", "E");
            teams.Add(boston);
            #endregion

            #region Players
            Player LabrounJaimes = new Player("Labroun", "Jaaimes", 37, 99, 99, Position.SF);
            california.addPlayer(LabrounJaimes);
            players.Add(LabrounJaimes);
            LabrounJaimes.setTeam(california);
            Player KevinhoDurant = new Player("Kevinho", "Durant", 35, 95, 88, Position.SF);
            phoenix.addPlayer(KevinhoDurant);
            players.Add(KevinhoDurant);
            KevinhoDurant.setTeam(phoenix);
            Player ChefCurry = new Player("Chef", "Curry", 35, 96, 85, Position.PG);
            oakland.addPlayer(ChefCurry);
            players.Add(ChefCurry);
            ChefCurry.setTeam(oakland);
            Player RafaelRico = new Player("Rafael", "Rico", 23, 99, 99, Position.SG);
            portland.addPlayer(RafaelRico);
            players.Add(RafaelRico);
            RafaelRico.setTeam(portland);
            Player AndreMachado = new Player("Andre", "Machado", 22, 99, 99, Position.PG);
            oklahoma.addPlayer(AndreMachado);
            players.Add(AndreMachado);
            AndreMachado.setTeam(oklahoma);

            Player TomasBalau = new Player("Tomas", "Balau", 23, 99, 99, Position.SF);
            chicago.addPlayer(TomasBalau);
            players.Add(TomasBalau);
            TomasBalau.setTeam(chicago);
            Player JoelCarnachide = new Player("Joel", "Carnachide", 28, 95, 90, Position.C);
            philadelphia.addPlayer(JoelCarnachide);
            players.Add(JoelCarnachide);
            JoelCarnachide.setTeam(philadelphia);
            Player GiannisAckampumpu = new Player("Giannis", "Ackampumpu", 28, 95, 95, Position.PF);
            milwaukee.addPlayer(GiannisAckampumpu);
            players.Add(GiannisAckampumpu);
            GiannisAckampumpu.setTeam(milwaukee);
            Player JimmyBuckets = new Player("Jimmy", "Buckets", 32, 92, 90, Position.SG);
            miami.addPlayer(JimmyBuckets);
            players.Add(JimmyBuckets);
            JimmyBuckets.setTeam(miami);
            Player JaysonTaint = new Player("Jayson", "Taint", 25, 88, 85, Position.SF);
            boston.addPlayer(JaysonTaint);
            players.Add(JaysonTaint);
            JaysonTaint.setTeam(boston);


            for (int i = 1; i <= 130; i++)
            {
                Player player = new Player("Negão", "".Insert(0, i.ToString()), 22, random.Next(68, 81), random.Next(68, 81), returnPosition(positionIndex));
                players.Add(player);
                if (i < 13) { california.addPlayer(player); player.setTeam(california); continue; }
                if (i < 26) { oakland.addPlayer(player); player.setTeam(oakland); continue; }
                if (i < 39) { portland.addPlayer(player); player.setTeam(portland); continue; }
                if (i < 52) { oklahoma.addPlayer(player); player.setTeam(oklahoma); continue; }
                if (i < 65) { phoenix.addPlayer(player); player.setTeam(phoenix); continue; }
                if (i < 78) { chicago.addPlayer(player); player.setTeam(chicago); continue; }
                if (i < 91) { milwaukee.addPlayer(player); player.setTeam(milwaukee); continue; }
                if (i < 104) { philadelphia.addPlayer(player); player.setTeam(philadelphia); continue; }
                if (i < 117) { miami.addPlayer(player); player.setTeam(miami); continue; }
                boston.addPlayer(player);
                player.setTeam(boston);
            }
            #endregion
        }

        public void initializeGraphComponent()
        {
            label1.Text = teams.ElementAt(0).getName();
            label2.Text = teams.ElementAt(1).getName();
            label3.Text = teams.ElementAt(2).getName();
            label4.Text = teams.ElementAt(3).getName();
            label5.Text = teams.ElementAt(4).getName();
            label6.Text = teams.ElementAt(5).getName();
            label7.Text = teams.ElementAt(6).getName();
            label8.Text = teams.ElementAt(7).getName();
            label9.Text = teams.ElementAt(8).getName();
            label10.Text = teams.ElementAt(9).getName();

            fillListBoxes();

        }

        private void fillListBoxes()
        {
            foreach(Player player in players)
            {
                switch (player.getTeam().getName())
                {
                    case "California":
                        listBoxTeam1.Items.Add(player);
                        break;
                    case "Oakland":
                        listBoxTeam2.Items.Add(player);
                        break;
                    case "Portland":
                        listBoxTeam3.Items.Add(player);
                        break;
                    case "Oklahoma":
                        listBoxTeam4.Items.Add(player);
                        break;
                    case "Phoenix":
                        listBoxTeam5.Items.Add(player);
                        break;
                    case "Chicago":
                        listBoxTeam6.Items.Add(player);
                        break;
                    case "Philadelphia":
                        listBoxTeam7.Items.Add(player);
                        break;
                    case "Milwaukee":
                        listBoxTeam8.Items.Add(player);
                        break;
                    case "Miami":
                        listBoxTeam9.Items.Add(player);
                        break;
                    case "Boston":
                        listBoxTeam10.Items.Add(player);
                        break;
                }
            }
        }

        private void listBoxTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTeam6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Team teamSelected = teams.ElementAt(comboBox.SelectedIndex);
            TeamScreen teamScreen = new TeamScreen(teamSelected, players, teams);
            this.Close();
            teamScreen.ShowDialog();
        }

        private Position returnPosition(int index)
        {
            Position position = Position.Bench;
            switch(index)
            {
                case 0:
                    index++;
                    position = Position.PG;
                    break;
                case 1:
                    index++;
                    position = Position.SG;
                    break;
                case 2:
                    index++;
                    position = Position.SF;
                    break;
                case 3:
                    index++;
                    position = Position.PF;
                    break;
                case 4:
                    index++;
                    position = Position.C;
                    break;
            }
            if(index == 4) { positionIndex = 0; }
            return position;
        }
    }
}

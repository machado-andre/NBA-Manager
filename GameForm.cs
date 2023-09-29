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
    public partial class GameForm : Form
    {
        Team teamSelected = null;
        Team opponent = null;
        Game currentGame = null;
        Season currentSeason = null;
        private Timer timer3;
        Random random = new Random();
        private int minute = 12, second = 0;
        public GameForm(Team _teamSelected, Game _currentGame, Season _season)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            teamSelected = _teamSelected;
            currentGame = _currentGame;
            currentSeason = _season;

            generateOpponentStartingFive();
            fillGUI();
        }

        private void generateOpponentStartingFive()
        {
            if(currentGame.getHomeTeam() != teamSelected)
            {
                opponent = currentGame.getHomeTeam();
            }
            else
            {
                opponent = currentGame.getVisitorTeam();
            }

            selectOpponentStartingFive(opponent);
        }

        private void selectOpponentStartingFive(Team opponent)
        {
            foreach (Player player in opponent.getPlayers())
            {
                switch(player.getPosition())
                {
                    case Position.PG:
                        addPlayerWithHighestOverall(opponent);
                        break;
                    case Position.SG:
                        addPlayerWithHighestOverall(opponent);
                        break;
                    case Position.SF:
                        addPlayerWithHighestOverall(opponent);
                        break;
                    case Position.PF:
                        addPlayerWithHighestOverall(opponent);
                        break;
                    case Position.C:
                        addPlayerWithHighestOverall(opponent);
                        break;
                }
            }
        }

        private void addPlayerWithHighestOverall(Team opponent)
        {
            // get highest Overall from team Position
            double highestOverall = opponent.getPlayers().Max(x => x.getOverall());
            // get player with that overall
            opponent.addToStartingFive(opponent.getPlayers().First(x => x.getOverall() == highestOverall));
        }

        private void fillGUI()
        {
            labelHome.Text = currentGame.getHomeTeam().getName();
            labelVisitor.Text = currentGame.getVisitorTeam().getName();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;

            timer3 = new Timer();
            timer3.Interval = 3000;
            timer3.Tick += Timer3_Tick;
            timer3.Start();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            int secsPassed = random.Next(10, 25);

            labelTimer.Text = minute.ToString() + ":" + second.ToString();
        }

        private bool checkTimerMinuteChange()
        {
            return true;
        }
    }
}

using Guna.UI2.WinForms;
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
        Random random = new Random();
        Team homeTeam = null;
        Team visitorTeam = null;
        private int minute = 12, second = 0;
        List<Guna2ComboBox> comboBoxes = new List<Guna2ComboBox>();
        public GameForm(Team _teamSelected, Game _currentGame, Season _season)
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            teamSelected = _teamSelected;
            currentGame = _currentGame;
            currentSeason = _season;
            generateOpponentStartingFive();
            disableComboBoxes();
            comboBoxes.Add(comboBoxPG);
            comboBoxes.Add(comboBoxSG);
            comboBoxes.Add(comboBoxSF);
            comboBoxes.Add(comboBoxPF);
            comboBoxes.Add(comboBoxCenter);
            loadPlayerList();
            fillGUI();
        }

        private void generateOpponentStartingFive()
        {
            if(currentGame.getHomeTeam() != teamSelected)
            {
                opponent = currentGame.getHomeTeam();
                homeTeam = opponent;
                visitorTeam = teamSelected;
            }
            else
            {
                opponent = currentGame.getVisitorTeam();
                homeTeam = teamSelected;
                visitorTeam = opponent;
            }

            selectOpponentStartingFive(opponent);
        }

        private void selectOpponentStartingFive(Team opponent)
        {
            addPlayerWithHighestOverall(opponent, Position.PG);
            addPlayerWithHighestOverall(opponent, Position.SG);
            addPlayerWithHighestOverall(opponent, Position.SF);
            addPlayerWithHighestOverall(opponent, Position.PF);
            addPlayerWithHighestOverall(opponent, Position.C);
        }

        private void addPlayerWithHighestOverall(Team opponent, Position position)
        {
            List<Player> players = new List<Player>();
            players = opponent.getPlayersByPosition(position);
            // get highest Overall from team Position
            double highestOverall = players.Max(x => x.getOverall());
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
            if (btnStart.Text == "Play Game")
            {
                btnStart.Text = "Stop";
                Timer3.Start();
                Timer3.Enabled = true;
                disableComboBoxes();
            }
            else
            {
                btnStart.Text = "Play Game";
                Timer3.Stop();
                enableComboBoxes();
            }

        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            int secsPassed = random.Next(10, 25);
            currentGame.runPlay(listBoxGamePlays);
            updateTimer(secsPassed);
            updateScores();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            currentGame.jumpBall();
        }

        private void updateTimer(int secsPassed)
        {
            if (second - secsPassed < 0)
            {
                minute--;
                //Saves the seconds that went below 0 So i can subtract from 60 and get a correct value
                int secondsBelowZero = second - secsPassed;
                second = 60 + secondsBelowZero;
                labelTimer.Text = minute.ToString() + ":" + second.ToString();
            }
            else if(second - secsPassed == 0)
            {
                second = 0;
                labelTimer.Text = minute.ToString() + ":" + second.ToString() + "0";
            }
            else
            {
                second -= secsPassed;
                labelTimer.Text = minute.ToString() + ":" + second.ToString();
                if (second < 10)
                {
                    labelTimer.Text = minute.ToString() + ":0" + second.ToString();
                }
            }
        }

        private void disableComboBoxes()
        {
            comboBoxPG.Enabled = false;
            comboBoxSG.Enabled = false;
            comboBoxSF.Enabled = false;
            comboBoxPF.Enabled = false;
            comboBoxCenter.Enabled = false;
        }

        private void enableComboBoxes()
        {
            comboBoxPG.Enabled = true;
            comboBoxSG.Enabled = true;
            comboBoxSF.Enabled = true;
            comboBoxPF.Enabled = true;
            comboBoxCenter.Enabled = true;
        }

        private void loadPlayerList()
        {
            foreach (Player player in teamSelected.getPlayers())
            {
                switch (player.getPosition())
                {
                    case Position.PG:
                        comboBoxPG.Items.Add(player);
                        comboBoxPG.SelectedItem = teamSelected.getStartingFive()[0];
                        break;
                    case Position.SG:
                        comboBoxSG.Items.Add(player);
                        comboBoxSG.SelectedItem = teamSelected.getStartingFive()[1];
                        break;
                    case Position.SF:
                        comboBoxSF.Items.Add(player);
                        comboBoxSF.SelectedItem = teamSelected.getStartingFive()[2];
                        break;
                    case Position.PF:
                        comboBoxPF.Items.Add(player);
                        comboBoxPF.SelectedItem = teamSelected.getStartingFive()[3];
                        break;
                    case Position.C:
                        comboBoxCenter.Items.Add(player);
                        comboBoxCenter.SelectedItem = teamSelected.getStartingFive()[4];
                        break;
                }
            }
        }

        private void updateScores()
        {
            labelHomeScore.Text = homeTeam.getGameScore().ToString();
            labelVisitorScore.Text = visitorTeam.getGameScore().ToString();
        }
    }
}

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
    public partial class TeamScreenForm : Form
    {
        List<Player> players = new List<Player>();
        List<Team> teams = new List<Team>();
        Team teamSelected = null;
        Season season;
        public int gamesPlayed = 0;
        List<Guna2ComboBox> comboBoxes = new List<Guna2ComboBox> ();

        public TeamScreenForm(Team _teamSelected, List<Player> _players, List<Team> _teams)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            players = _players;
            teams = _teams;
            season = new Season(teams);
            populateTeamListBoxes();
            teamSelected = _teamSelected;
            labelTeam1.Text = teamSelected.getName();
            labelTeam2.Text = teamSelected.getGame(0).getVisitorTeam().getName();
            loadPlayerList();
            comboBoxes.Add(comboBoxPG);
            comboBoxes.Add(comboBoxSG);
            comboBoxes.Add(comboBoxSF);
            comboBoxes.Add(comboBoxPF);
            comboBoxes.Add(comboBoxCenter);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            clearBtnBorders();
            btnHome.BorderThickness = 1;
        }


        private void clearBtnBorders()
        {
            btnHome.BorderThickness = 0;
            btnSquad.BorderThickness = 0;
            btnTraining.BorderThickness = 0;
            btnTrades.BorderThickness = 0;
            btnSettings.BorderThickness = 0;
        }

        private void populateTeamListBoxes()
        {
            foreach(Team team in teams)
            {
                if(team.getLocation() == "W")
                {
                    listBoxWest.Items.Add(team);
                }
                else
                {
                    listBoxEast.Items.Add(team);
                }
            }
        }

        private void btnHome_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void loadPlayerList()
        {
            foreach(Player player in teamSelected.getPlayers())
            {
                switch (player.getPosition())
                {
                    case Position.PG:
                        comboBoxPG.Items.Add(player);
                        break;
                    case Position.SG:
                        comboBoxSG.Items.Add(player);
                        break;
                    case Position.SF:
                        comboBoxSF.Items.Add(player);
                        break;
                    case Position.PF:
                        comboBoxPF.Items.Add(player);
                        break;
                    case Position.C:
                        comboBoxCenter.Items.Add(player);
                        break;
                }                
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            foreach(Guna2ComboBox comboBox in comboBoxes)
            {
                if(comboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please Select your starting 5.");
                    return;
                }
                teamSelected.addToStartingFive((Player)comboBox.SelectedItem);
            }

            GameForm gameForm = new GameForm(teamSelected, teamSelected.getGame(0), season);
            
            this.Hide();
            this.Close();
            gameForm.ShowDialog();
        }
    }
}

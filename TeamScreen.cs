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
    public partial class TeamScreen : Form
    {
        List<Player> players = new List<Player>();
        List<Team> teams = new List<Team>();
        Team teamSelected = null;

        public TeamScreen(Team _teamSelected, List<Player> _players, List<Team> _teams)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            players = _players;
            teams = _teams;
            populateTeamListBoxes();
            teamSelected = _teamSelected;
            labelTeam1.Text = teamSelected.getName();
            loadPlayerList();
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

        private void generateSeasonGames()
        {

        }

    }
}

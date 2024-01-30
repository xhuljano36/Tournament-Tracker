
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerIUU
{
    public partial class CreateTournament : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> avaibleTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournament()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = avaibleTeams;
            selectTeamDropDown.DisplayMember = "TeamName";
            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";
            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoundLabel_Click(object sender, EventArgs e)
        {

        }

        private void TournamentPlayersList_Click(object sender, EventArgs e)
        {

        }

        private void prizesLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateTournament_Load(object sender, EventArgs e)
        {

        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);
            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid entry fee", "Invalid fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TournamentModel tm = new TournamentModel();
          
          
            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;
            TournamentLogic.CreateRounds(tm);
            GlobalConfig.Connection.CreateTournament(tm);
            tm.AlertUsersToNewRound();
            TournamentLogic.UpdateTournamentResults(tm);
          
            TournamentVIewerForm frm = new TournamentVIewerForm(tm);

            frm.Show();
            this.Close();


        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;
            if (t != null)
            {
                avaibleTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeam frm = new CreateTeam(this);
            frm.Show();
        }

        private void deleteSelectedPlayerButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                avaibleTeams.Add(t);
                WireUpLists();
            }
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }
        }
    }
}

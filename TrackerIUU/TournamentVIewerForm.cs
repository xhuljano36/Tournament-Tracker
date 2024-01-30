using Microsoft.Extensions.Configuration;
using System.ComponentModel;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerIUU
{
    public partial class TournamentVIewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();


        public TournamentVIewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;
            tournament.OnTournamentComplete += Tournament_OnTournamentComplete;
            WireUpLists();
            LoadFormData();
            LoadRounds();
        }

        private void Tournament_OnTournamentComplete(object? sender, DateTime e)
        {
            this.Close();
        }

        private void LoadFormData()
        {
            TournamentName.Text = tournament.TournamentName;
        }
        private void WireUpLists()
        {


            RoundDropdown.DataSource = rounds;
            MatchupListbox.DataSource = selectedMatchups;
            MatchupListbox.DisplayMember = "DisplayName";



        }

        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);

            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                    if (matchups.First().MatchupRound > currRound)
                    {
                        currRound = matchups.First().MatchupRound;
                        rounds.Add(currRound);
                    }
            }
            LoadMatchups(1);
        }

        private void RoundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadMatchups((int)RoundDropdown.SelectedItem);

        }
        private void LoadMatchups(int round)
        {

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                    if (matchups.First().MatchupRound == round)
                    {
                        selectedMatchups.Clear();
                        foreach (MatchupModel m in matchups)
                        {
                            if (m.Winner == null || !unplayedOnlyCheckBox.Checked)
                            {
                                selectedMatchups.Add(m);
                            }
                        }
                    }
            }
            if (selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First());
            }

            DisplayMatchupInfo();
           
        }
        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);
            Team1Name.Visible = isVisible;
            Team1ScoreLabel.Visible = isVisible;
            Team1ScoreValue.Visible = isVisible;
            Team2Name.Visible = isVisible;
            Team2ScoreLabel.Visible = isVisible;
            Team2ScoreValue.Visible = isVisible;
            VsLabel.Visible = isVisible;
            ScoreButton.Visible = isVisible;
            

        }
      
        private void LoadMatchup(MatchupModel m)
        {

            if (m != null)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            Team1Name.Text = m.Entries[0].TeamCompeting.TeamName;
                            Team1ScoreValue.Text = m.Entries[0].Score.ToString();
                            Team2Name.Text = "<byes>";
                            Team2ScoreValue.Text = "0";
                        }
                        else
                        {
                            Team1Name.Text = "Not Yet set";
                            Team1ScoreValue.Text = "";
                        }
                    }

                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            Team2Name.Text = m.Entries[1].TeamCompeting.TeamName;
                            Team2ScoreValue.Text = m.Entries[1].Score.ToString();
                        }
                    }
                    else
                    {
                        Team2Name.Text = "Not Yet set";
                        Team2ScoreValue.Text = "";
                    }

                }

            }
        }

        private void MatchupListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            LoadMatchup((MatchupModel)MatchupListbox.SelectedItem);
        }

        private void unplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropdown.SelectedItem);
        }
        private string ValidateData()
        {
            string output = "";
            double teamOneScore = 0;
            double teamTwoScore = 0;
            bool scoreOneValid = double.TryParse(Team1ScoreValue.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(Team2ScoreValue.Text, out teamTwoScore);
            if(!scoreOneValid)
            {
                output = "The score one value is not a valid number";
            }
            else if (!scoreTwoValid)
            {
                output = "The score two value is not a valid number";
            }
            else if (teamOneScore==0 && teamTwoScore==0)
            {
                output = "You did not enter a score for either team";
            }
           else if(teamOneScore==teamTwoScore)
            {
                output = "We do not allow ties in this application";
                
            }
            return output;
        }

        private void ScoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();
            if(errorMessage.Length>0)
            {
                MessageBox.Show($"Input error:{errorMessage}");
                return;
            }
            MatchupModel m = (MatchupModel)MatchupListbox.SelectedItem;

            double teamOneScore = 0;
            double teamTwoScore = 0;

            // Përpuno pikët për secilën skuadër
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0 && m.Entries[0].TeamCompeting != null)
                {
                    bool scoreValid = double.TryParse(Team1ScoreValue.Text, out teamOneScore);

                    if (scoreValid)
                    {
                        m.Entries[0].Score = teamOneScore;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid value for team 1");
                        return;
                    }
                }

                if (i == 1 && m.Entries[1].TeamCompeting != null)
                {
                    bool scoreValid = double.TryParse(Team2ScoreValue.Text, out teamTwoScore);

                    if (scoreValid)
                    {
                        m.Entries[1].Score = teamTwoScore;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid value for team 2");
                        return;
                    }
                }
            }
            try
            {
      
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"The applocation had the following error:{ex.Message}");
                return;
            }
           
            LoadMatchups((int)RoundDropdown.SelectedItem);

            
        }

    }
}
    




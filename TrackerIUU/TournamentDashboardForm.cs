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
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();

        public TournamentDashboardForm()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            LoadExistingTournamentDropdown.DataSource = tournaments;
            LoadExistingTournamentDropdown.DisplayMember = "TournamentName";
        }
        private void LoadExistingTournamentLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournament frm = new CreateTournament();
            frm.Show();
        }

        private void LoadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)LoadExistingTournamentDropdown.SelectedItem;
            TournamentVIewerForm frm = new TournamentVIewerForm(tm);
            frm.Show();
        }

        private void LoadExistingTournamentDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

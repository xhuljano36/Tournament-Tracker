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
    public partial class CreateTeam : Form
    {
        private List<PersonModel> avaibleTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private object selectTeamMemberDropdown = new object();
        private ITeamRequester callingForm;
        public CreateTeam(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            // CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            avaibleTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            avaibleTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Store" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });

        }
        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = avaibleTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";
            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SelectTeamMemberLabel_Click(object sender, EventArgs e)
        {

        }

        private void TeamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTeam_Load(object sender, EventArgs e)
        {

        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers; 
            GlobalConfig.Connection.CreateTeam(t);
            callingForm.TeamComplete(t);
            this.Close();


        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellPhone = cellPhoneValue.Text;
                GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);
                WireUpLists();
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }
        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellPhoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void createTeamLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                avaibleTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpLists();
            }


        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p != null)
            {

                selectedTeamMembers.Remove(p);
                avaibleTeamMembers.Add(p);
                WireUpLists();
            }
        }
    }
}

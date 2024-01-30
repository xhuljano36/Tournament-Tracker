namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        public TournamentViewerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            HeaderLabel = new Label();
            TournamentName = new Label();
            RoundLabel = new Label();
            RoundDropDown = new ComboBox();
            UnplayedOnlyCheckBox = new CheckBox();
            MatchupListBox = new ListBox();
            Team1Name = new Label();
            Team1ScoreLabel = new Label();
            Team1ScoreValue = new TextBox();
            Team2ScoreValue = new TextBox();
            Team2ScoreLabel = new Label();
            Team2Name = new Label();
            VersusLabel = new Label();
            ScoreButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.ForeColor = Color.FromArgb(51, 153, 255);
            HeaderLabel.Location = new Point(31, 26);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(310, 74);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Tournament";
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentName.ForeColor = Color.FromArgb(51, 153, 255);
            TournamentName.Location = new Point(347, 26);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(223, 74);
            TournamentName.TabIndex = 1;
            TournamentName.Text = "<none>";
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RoundLabel.ForeColor = Color.FromArgb(51, 153, 255);
            RoundLabel.Location = new Point(49, 141);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.Size = new Size(123, 48);
            RoundLabel.TabIndex = 2;
            RoundLabel.Text = "Round";
            // 
            // RoundDropDown
            // 
            RoundDropDown.FormattingEnabled = true;
            RoundDropDown.Location = new Point(178, 156);
            RoundDropDown.Name = "RoundDropDown";
            RoundDropDown.Size = new Size(294, 33);
            RoundDropDown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckBox
            // 
            UnplayedOnlyCheckBox.AutoSize = true;
            UnplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            UnplayedOnlyCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            UnplayedOnlyCheckBox.ForeColor = Color.FromArgb(51, 153, 255);
            UnplayedOnlyCheckBox.Location = new Point(178, 210);
            UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            UnplayedOnlyCheckBox.Size = new Size(294, 58);
            UnplayedOnlyCheckBox.TabIndex = 4;
            UnplayedOnlyCheckBox.Text = "UnplayedOnly";
            UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchupListBox
            // 
            MatchupListBox.BorderStyle = BorderStyle.FixedSingle;
            MatchupListBox.FormattingEnabled = true;
            MatchupListBox.ItemHeight = 25;
            MatchupListBox.Location = new Point(49, 292);
            MatchupListBox.Name = "MatchupListBox";
            MatchupListBox.Size = new Size(423, 252);
            MatchupListBox.TabIndex = 5;
            // 
            // Team1Name
            // 
            Team1Name.AutoSize = true;
            Team1Name.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Team1Name.ForeColor = Color.FromArgb(51, 153, 255);
            Team1Name.Location = new Point(531, 220);
            Team1Name.Name = "Team1Name";
            Team1Name.Size = new Size(169, 48);
            Team1Name.TabIndex = 6;
            Team1Name.Text = "<team1>";
            // 
            // Team1ScoreLabel
            // 
            Team1ScoreLabel.AutoSize = true;
            Team1ScoreLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Team1ScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            Team1ScoreLabel.Location = new Point(531, 268);
            Team1ScoreLabel.Name = "Team1ScoreLabel";
            Team1ScoreLabel.Size = new Size(109, 48);
            Team1ScoreLabel.TabIndex = 7;
            Team1ScoreLabel.Text = "Score";
            // 
            // Team1ScoreValue
            // 
            Team1ScoreValue.Location = new Point(646, 284);
            Team1ScoreValue.Name = "Team1ScoreValue";
            Team1ScoreValue.Size = new Size(118, 31);
            Team1ScoreValue.TabIndex = 8;
            // 
            // Team2ScoreValue
            // 
            Team2ScoreValue.Location = new Point(646, 482);
            Team2ScoreValue.Name = "Team2ScoreValue";
            Team2ScoreValue.Size = new Size(118, 31);
            Team2ScoreValue.TabIndex = 11;
            // 
            // Team2ScoreLabel
            // 
            Team2ScoreLabel.AutoSize = true;
            Team2ScoreLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Team2ScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            Team2ScoreLabel.Location = new Point(531, 465);
            Team2ScoreLabel.Name = "Team2ScoreLabel";
            Team2ScoreLabel.Size = new Size(109, 48);
            Team2ScoreLabel.TabIndex = 10;
            Team2ScoreLabel.Text = "Score";
            // 
            // Team2Name
            // 
            Team2Name.AutoSize = true;
            Team2Name.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Team2Name.ForeColor = Color.FromArgb(51, 153, 255);
            Team2Name.Location = new Point(512, 417);
            Team2Name.Name = "Team2Name";
            Team2Name.Size = new Size(169, 48);
            Team2Name.TabIndex = 9;
            Team2Name.Text = "<team2>";
            // 
            // VersusLabel
            // 
            VersusLabel.AutoSize = true;
            VersusLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            VersusLabel.ForeColor = Color.FromArgb(51, 153, 255);
            VersusLabel.Location = new Point(591, 350);
            VersusLabel.Name = "VersusLabel";
            VersusLabel.Size = new Size(68, 48);
            VersusLabel.TabIndex = 12;
            VersusLabel.Text = ".vs.";
            // 
            // ScoreButton
            // 
            ScoreButton.FlatAppearance.BorderColor = Color.Silver;
            ScoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            ScoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            ScoreButton.FlatStyle = FlatStyle.Flat;
            ScoreButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ScoreButton.ForeColor = Color.FromArgb(51, 153, 255);
            ScoreButton.Location = new Point(761, 350);
            ScoreButton.Name = "ScoreButton";
            ScoreButton.Size = new Size(144, 48);
            ScoreButton.TabIndex = 13;
            ScoreButton.Text = "Score";
            ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(933, 570);
            Controls.Add(ScoreButton);
            Controls.Add(VersusLabel);
            Controls.Add(Team2ScoreValue);
            Controls.Add(Team2ScoreLabel);
            Controls.Add(Team2Name);
            Controls.Add(Team1ScoreValue);
            Controls.Add(Team1ScoreLabel);
            Controls.Add(Team1Name);
            Controls.Add(MatchupListBox);
            Controls.Add(UnplayedOnlyCheckBox);
            Controls.Add(RoundDropDown);
            Controls.Add(RoundLabel);
            Controls.Add(TournamentName);
            Controls.Add(HeaderLabel);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label HeaderLabel;
        private Label RoundLabel;
        private ComboBox RoundDropDown;
        private CheckBox UnplayedOnlyCheckBox;
        private ListBox MatchupListBox;
        private Label Team1Name;
        private Label Team1ScoreLabel;
        private TextBox Team1ScoreValue;
        private TextBox Team2ScoreValue;
        private Label Team2ScoreLabel;
        private Label Team2Name;
        private Label VersusLabel;
        private Button ScoreButton;
        private Label TournamentName;
    }
}
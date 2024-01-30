namespace TrackerIUU
{
    partial class TournamentVIewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            TournamentName = new Label();
            RoundLabel = new Label();
            RoundDropdown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            MatchupListbox = new ListBox();
            Team1Name = new Label();
            Team2Name = new Label();
            Team1ScoreLabel = new Label();
            Team1ScoreValue = new TextBox();
            Team2ScoreValue = new TextBox();
            Team2ScoreLabel = new Label();
            VsLabel = new Label();
            ScoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(12, 39);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(190, 45);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament";
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentName.ForeColor = Color.FromArgb(51, 153, 255);
            TournamentName.Location = new Point(208, 39);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(136, 45);
            TournamentName.TabIndex = 1;
            TournamentName.Text = "<none>";
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            RoundLabel.ForeColor = Color.FromArgb(51, 153, 255);
            RoundLabel.Location = new Point(-1, 134);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.Size = new Size(139, 54);
            RoundLabel.TabIndex = 2;
            RoundLabel.Text = "Round";
            // 
            // RoundDropdown
            // 
            RoundDropdown.FormattingEnabled = true;
            RoundDropdown.Location = new Point(144, 144);
            RoundDropdown.Name = "RoundDropdown";
            RoundDropdown.Size = new Size(283, 33);
            RoundDropdown.TabIndex = 3;
            RoundDropdown.SelectedIndexChanged += RoundDropdown_SelectedIndexChanged;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckBox.ForeColor = Color.FromArgb(51, 153, 255);
            unplayedOnlyCheckBox.Location = new Point(144, 195);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(295, 58);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "unplayedOnly";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            unplayedOnlyCheckBox.CheckedChanged += unplayedOnlyCheckBox_CheckedChanged;
            // 
            // MatchupListbox
            // 
            MatchupListbox.BorderStyle = BorderStyle.FixedSingle;
            MatchupListbox.FormattingEnabled = true;
            MatchupListbox.ItemHeight = 25;
            MatchupListbox.Location = new Point(25, 304);
            MatchupListbox.Name = "MatchupListbox";
            MatchupListbox.Size = new Size(283, 252);
            MatchupListbox.TabIndex = 5;
            MatchupListbox.SelectedIndexChanged += MatchupListbox_SelectedIndexChanged;
            // 
            // Team1Name
            // 
            Team1Name.AutoSize = true;
            Team1Name.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Team1Name.ForeColor = Color.FromArgb(51, 153, 255);
            Team1Name.Location = new Point(545, 123);
            Team1Name.Name = "Team1Name";
            Team1Name.Size = new Size(137, 54);
            Team1Name.TabIndex = 6;
            Team1Name.Text = "Team1";
            // 
            // Team2Name
            // 
            Team2Name.AutoSize = true;
            Team2Name.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Team2Name.ForeColor = Color.FromArgb(51, 153, 255);
            Team2Name.Location = new Point(545, 401);
            Team2Name.Name = "Team2Name";
            Team2Name.Size = new Size(137, 54);
            Team2Name.TabIndex = 7;
            Team2Name.Text = "Team2";
            // 
            // Team1ScoreLabel
            // 
            Team1ScoreLabel.AutoSize = true;
            Team1ScoreLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Team1ScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            Team1ScoreLabel.Location = new Point(545, 199);
            Team1ScoreLabel.Name = "Team1ScoreLabel";
            Team1ScoreLabel.Size = new Size(120, 54);
            Team1ScoreLabel.TabIndex = 8;
            Team1ScoreLabel.Text = "Score";
            // 
            // Team1ScoreValue
            // 
            Team1ScoreValue.Location = new Point(671, 216);
            Team1ScoreValue.Name = "Team1ScoreValue";
            Team1ScoreValue.Size = new Size(150, 31);
            Team1ScoreValue.TabIndex = 9;
            // 
            // Team2ScoreValue
            // 
            Team2ScoreValue.Location = new Point(671, 496);
            Team2ScoreValue.Name = "Team2ScoreValue";
            Team2ScoreValue.Size = new Size(150, 31);
            Team2ScoreValue.TabIndex = 11;
            // 
            // Team2ScoreLabel
            // 
            Team2ScoreLabel.AutoSize = true;
            Team2ScoreLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Team2ScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            Team2ScoreLabel.Location = new Point(545, 479);
            Team2ScoreLabel.Name = "Team2ScoreLabel";
            Team2ScoreLabel.Size = new Size(120, 54);
            Team2ScoreLabel.TabIndex = 10;
            Team2ScoreLabel.Text = "Score";
            // 
            // VsLabel
            // 
            VsLabel.AutoSize = true;
            VsLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            VsLabel.ForeColor = Color.FromArgb(51, 153, 255);
            VsLabel.Location = new Point(581, 304);
            VsLabel.Name = "VsLabel";
            VsLabel.Size = new Size(77, 54);
            VsLabel.TabIndex = 12;
            VsLabel.Text = ".vs.";
            // 
            // ScoreButton
            // 
            ScoreButton.FlatAppearance.BorderColor = Color.Silver;
            ScoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            ScoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            ScoreButton.FlatStyle = FlatStyle.Flat;
            ScoreButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ScoreButton.ForeColor = Color.FromArgb(51, 153, 255);
            ScoreButton.Location = new Point(776, 303);
            ScoreButton.Name = "ScoreButton";
            ScoreButton.Size = new Size(142, 55);
            ScoreButton.TabIndex = 13;
            ScoreButton.Text = "Score";
            ScoreButton.UseVisualStyleBackColor = true;
            ScoreButton.Click += ScoreButton_Click;
            // 
            // TournamentVIewerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 580);
            Controls.Add(ScoreButton);
            Controls.Add(VsLabel);
            Controls.Add(Team2ScoreValue);
            Controls.Add(Team2ScoreLabel);
            Controls.Add(Team1ScoreValue);
            Controls.Add(Team1ScoreLabel);
            Controls.Add(Team2Name);
            Controls.Add(Team1Name);
            Controls.Add(MatchupListbox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(RoundDropdown);
            Controls.Add(RoundLabel);
            Controls.Add(TournamentName);
            Controls.Add(headerLabel);
            Name = "TournamentVIewerForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label TournamentName;
        private Label RoundLabel;
        private ComboBox RoundDropdown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox MatchupListbox;
        private Label Team1Name;
        private Label Team2Name;
        private Label Team1ScoreLabel;
        private TextBox Team1ScoreValue;
        private TextBox Team2ScoreValue;
        private Label Team2ScoreLabel;
        private Label VsLabel;
        private Button ScoreButton;
    }
}
namespace TrackerIUU
{
    partial class CreateTournament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            createTournamentLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentTeamsListBox = new ListBox();
            tournamentPlayersList = new Label();
            removeSelectedPlayerButton = new Button();
            removeSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentLabel.Location = new Point(45, 27);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(361, 54);
            createTournamentLabel.TabIndex = 1;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(49, 149);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(407, 50);
            tournamentNameValue.TabIndex = 11;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentNameLabel.Location = new Point(45, 92);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(351, 54);
            tournamentNameLabel.TabIndex = 10;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(228, 224);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(131, 50);
            entryFeeValue.TabIndex = 13;
            entryFeeValue.Text = "0";
            entryFeeValue.TextChanged += textBox1_TextChanged;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            entryFeeLabel.Location = new Point(45, 220);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(186, 54);
            entryFeeLabel.TabIndex = 12;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(49, 364);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(393, 53);
            selectTeamDropDown.TabIndex = 15;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamLabel.Location = new Point(45, 297);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(231, 54);
            selectTeamLabel.TabIndex = 14;
            selectTeamLabel.Text = "Select Team";
            selectTeamLabel.Click += RoundLabel_Click;
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(282, 307);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(185, 45);
            createNewTeamLink.TabIndex = 16;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "Create New";
            createNewTeamLink.LinkClicked += createNewTeamLink_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            addTeamButton.Location = new Point(147, 432);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(202, 55);
            addTeamButton.TabIndex = 17;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(147, 505);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(212, 55);
            createPrizeButton.TabIndex = 18;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 45;
            tournamentTeamsListBox.Location = new Point(508, 66);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(393, 227);
            tournamentTeamsListBox.TabIndex = 19;
            // 
            // tournamentPlayersList
            // 
            tournamentPlayersList.AutoSize = true;
            tournamentPlayersList.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersList.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentPlayersList.Location = new Point(508, 9);
            tournamentPlayersList.Name = "tournamentPlayersList";
            tournamentPlayersList.Size = new Size(293, 54);
            tournamentPlayersList.TabIndex = 20;
            tournamentPlayersList.Text = "Teams / Players";
            tournamentPlayersList.Click += TournamentPlayersList_Click;
            // 
            // removeSelectedPlayerButton
            // 
            removeSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedPlayerButton.ForeColor = Color.FromArgb(51, 153, 255);
            removeSelectedPlayerButton.Location = new Point(934, 66);
            removeSelectedPlayerButton.Name = "removeSelectedPlayerButton";
            removeSelectedPlayerButton.Size = new Size(163, 110);
            removeSelectedPlayerButton.TabIndex = 21;
            removeSelectedPlayerButton.Text = "Remove Selected";
            removeSelectedPlayerButton.UseVisualStyleBackColor = true;
            removeSelectedPlayerButton.Click += deleteSelectedPlayerButton_Click;
            // 
            // removeSelectedPrizeButton
            // 
            removeSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            removeSelectedPrizeButton.Location = new Point(934, 364);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new Size(163, 109);
            removeSelectedPrizeButton.TabIndex = 24;
            removeSelectedPrizeButton.Text = "Remove Selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizesLabel.Location = new Point(508, 307);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(125, 54);
            prizesLabel.TabIndex = 23;
            prizesLabel.Text = "Prizes";
            prizesLabel.Click += prizesLabel_Click;
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 45;
            prizesListBox.Location = new Point(508, 364);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(393, 227);
            prizesListBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentButton.Location = new Point(934, 533);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(366, 104);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // CreateTournament
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1440, 810);
            Controls.Add(createTournamentButton);
            Controls.Add(removeSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(removeSelectedPlayerButton);
            Controls.Add(tournamentPlayersList);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(createTournamentLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "CreateTournament";
            Text = "CreateTournament";
            Load += CreateTournament_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentTeamsListBox;
        private Label tournamentPlayersList;
        private Button deleteSelectedPlayerButton;
        private Button deletePrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
        private Button removeSelectedPlayerButton;
        private Button removeSelectedPrizeButton;
    }
}
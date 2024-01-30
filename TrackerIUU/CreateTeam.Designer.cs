namespace TrackerIUU
{
    partial class CreateTeam
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            addMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            cellPhoneValue = new TextBox();
            cellPhoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(44, 121);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(407, 50);
            teamNameValue.TabIndex = 14;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamNameLabel.Location = new Point(44, 73);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(189, 45);
            teamNameLabel.TabIndex = 13;
            teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamLabel.Location = new Point(46, 19);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(241, 54);
            createTeamLabel.TabIndex = 12;
            createTeamLabel.Text = "Create Team";
            createTeamLabel.Click += createTeamLabel_Click;
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            addMemberButton.Location = new Point(141, 281);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(234, 55);
            addMemberButton.TabIndex = 21;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(44, 222);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(393, 53);
            selectTeamMemberDropDown.TabIndex = 19;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamMemberLabel.Location = new Point(44, 174);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(319, 45);
            selectTeamMemberLabel.TabIndex = 18;
            selectTeamMemberLabel.Text = "Select Team Member";
            selectTeamMemberLabel.Click += SelectTeamMemberLabel_Click;
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellPhoneValue);
            addNewMemberGroupBox.Controls.Add(cellPhoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            addNewMemberGroupBox.ForeColor = Color.FromArgb(51, 153, 255);
            addNewMemberGroupBox.Location = new Point(46, 330);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(434, 339);
            addNewMemberGroupBox.TabIndex = 22;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            addNewMemberGroupBox.Enter += groupBox1_Enter;
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            createMemberButton.Location = new Point(77, 262);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(272, 55);
            createMemberButton.TabIndex = 22;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellPhoneValue
            // 
            cellPhoneValue.Location = new Point(189, 206);
            cellPhoneValue.Name = "cellPhoneValue";
            cellPhoneValue.Size = new Size(186, 50);
            cellPhoneValue.TabIndex = 17;
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cellPhoneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            cellPhoneLabel.Location = new Point(0, 191);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new Size(172, 45);
            cellPhoneLabel.TabIndex = 16;
            cellPhoneLabel.Text = "Cell Phone";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(189, 150);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(186, 50);
            emailValue.TabIndex = 15;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.FromArgb(51, 153, 255);
            emailLabel.Location = new Point(13, 139);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(96, 45);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(189, 94);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(186, 50);
            lastNameValue.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            lastNameLabel.Location = new Point(13, 94);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(170, 45);
            lastNameLabel.TabIndex = 12;
            lastNameLabel.Text = "Last Name";
            lastNameLabel.Click += lastNameLabel_Click;
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(189, 37);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(186, 50);
            firstNameValue.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            firstNameLabel.Location = new Point(13, 37);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(174, 45);
            firstNameLabel.TabIndex = 10;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 45;
            teamMembersListBox.Location = new Point(535, 79);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(322, 407);
            teamMembersListBox.TabIndex = 23;
            teamMembersListBox.SelectedIndexChanged += TeamMembersListBox_SelectedIndexChanged;
            // 
            // removeSelectedMemberButton
            // 
            removeSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            removeSelectedMemberButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            removeSelectedMemberButton.Location = new Point(934, 272);
            removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            removeSelectedMemberButton.Size = new Size(163, 110);
            removeSelectedMemberButton.TabIndex = 24;
            removeSelectedMemberButton.Text = "Remove Selected";
            removeSelectedMemberButton.UseVisualStyleBackColor = true;
            removeSelectedMemberButton.Click += removeSelectedMemberButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamButton.Location = new Point(590, 511);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(324, 103);
            createTeamButton.TabIndex = 25;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeam
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1262, 837);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "CreateTeam";
            Text = "Create Team";
            Load += CreateTeam_Load;
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox cellPhoneValue;
        private Label cellPhoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button removeSelectedMemberButton;
        private Button createTeamButton;
    }
}
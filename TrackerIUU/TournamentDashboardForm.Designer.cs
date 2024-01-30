namespace TrackerIUU
{
    partial class TournamentDashboardForm
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
            CreatePrizeLabel = new Label();
            LoadExistingTournamentDropdown = new ComboBox();
            LoadExistingTournamentLabel = new Label();
            LoadTournamentButton = new Button();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // CreatePrizeLabel
            // 
            CreatePrizeLabel.AutoSize = true;
            CreatePrizeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CreatePrizeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            CreatePrizeLabel.Location = new Point(145, 33);
            CreatePrizeLabel.Margin = new Padding(2, 0, 2, 0);
            CreatePrizeLabel.Name = "CreatePrizeLabel";
            CreatePrizeLabel.Size = new Size(439, 54);
            CreatePrizeLabel.TabIndex = 3;
            CreatePrizeLabel.Text = "Tournament Dashboard";
            // 
            // LoadExistingTournamentDropdown
            // 
            LoadExistingTournamentDropdown.FormattingEnabled = true;
            LoadExistingTournamentDropdown.Location = new Point(181, 206);
            LoadExistingTournamentDropdown.Margin = new Padding(2);
            LoadExistingTournamentDropdown.Name = "LoadExistingTournamentDropdown";
            LoadExistingTournamentDropdown.Size = new Size(348, 33);
            LoadExistingTournamentDropdown.TabIndex = 21;
            LoadExistingTournamentDropdown.SelectedIndexChanged += LoadExistingTournamentDropdown_SelectedIndexChanged;
            // 
            // LoadExistingTournamentLabel
            // 
            LoadExistingTournamentLabel.AutoSize = true;
            LoadExistingTournamentLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LoadExistingTournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            LoadExistingTournamentLabel.Location = new Point(122, 124);
            LoadExistingTournamentLabel.Margin = new Padding(2, 0, 2, 0);
            LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            LoadExistingTournamentLabel.Size = new Size(479, 54);
            LoadExistingTournamentLabel.TabIndex = 20;
            LoadExistingTournamentLabel.Text = "Load Existing Tournament";
            LoadExistingTournamentLabel.Click += LoadExistingTournamentLabel_Click;
            // 
            // LoadTournamentButton
            // 
            LoadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            LoadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            LoadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            LoadTournamentButton.FlatStyle = FlatStyle.Flat;
            LoadTournamentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LoadTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            LoadTournamentButton.Location = new Point(181, 259);
            LoadTournamentButton.Margin = new Padding(2);
            LoadTournamentButton.Name = "LoadTournamentButton";
            LoadTournamentButton.Size = new Size(310, 66);
            LoadTournamentButton.TabIndex = 26;
            LoadTournamentButton.Text = "Load Tournament";
            LoadTournamentButton.UseVisualStyleBackColor = true;
            LoadTournamentButton.Click += LoadTournamentButton_Click;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            CreateTournamentButton.Location = new Point(181, 353);
            CreateTournamentButton.Margin = new Padding(2);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(386, 104);
            CreateTournamentButton.TabIndex = 27;
            CreateTournamentButton.Text = "Create Tournament\r\n";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            CreateTournamentButton.Click += CreateTournamentButton_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(803, 521);
            Controls.Add(CreateTournamentButton);
            Controls.Add(LoadTournamentButton);
            Controls.Add(LoadExistingTournamentDropdown);
            Controls.Add(LoadExistingTournamentLabel);
            Controls.Add(CreatePrizeLabel);
            ForeColor = Color.Black;
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreatePrizeLabel;
        private ComboBox LoadExistingTournamentDropdown;
        private Label LoadExistingTournamentLabel;
        private Button LoadTournamentButton;
        private Button CreateTournamentButton;
    }
}
namespace TrackerIUU
{
    partial class CreatePrizeForm
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
            createPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeLabel.Location = new Point(31, 30);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(223, 54);
            createPrizeLabel.TabIndex = 13;
            createPrizeLabel.Text = "CreatePrize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(308, 99);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(210, 50);
            placeNumberValue.TabIndex = 15;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNumberLabel.Location = new Point(26, 95);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(271, 54);
            placeNumberLabel.TabIndex = 14;
            placeNumberLabel.Text = "Place Number";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(308, 211);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(210, 50);
            prizeAmountValue.TabIndex = 17;
            prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizeAmountLabel.Location = new Point(24, 203);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(262, 54);
            prizeAmountLabel.TabIndex = 16;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(308, 155);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(210, 50);
            placeNameValue.TabIndex = 19;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNameLabel.Location = new Point(24, 149);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(230, 54);
            placeNameLabel.TabIndex = 18;
            placeNameLabel.Text = "Place Name";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(325, 359);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(210, 50);
            prizePercentageValue.TabIndex = 21;
            prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizePercentageLabel.Location = new Point(3, 355);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(316, 54);
            prizePercentageLabel.TabIndex = 20;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = Color.FromArgb(51, 153, 255);
            orLabel.Location = new Point(243, 281);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(103, 54);
            orLabel.TabIndex = 22;
            orLabel.Text = " -or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(207, 454);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(272, 95);
            createPrizeButton.TabIndex = 26;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(622, 591);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}
namespace TrackerUI
{
    partial class TournamentViewForm
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
            System.Windows.Forms.Label teamOneName;
            System.Windows.Forms.Label teamOneScoreLabel;
            System.Windows.Forms.Label teamTwoScoreLabel;
            System.Windows.Forms.Label teamTwoName;
            System.Windows.Forms.Label versusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.scoreButton = new System.Windows.Forms.Button();
            teamOneName = new System.Windows.Forms.Label();
            teamOneScoreLabel = new System.Windows.Forms.Label();
            teamTwoScoreLabel = new System.Windows.Forms.Label();
            teamTwoName = new System.Windows.Forms.Label();
            versusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            teamOneName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            teamOneName.Location = new System.Drawing.Point(350, 189);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new System.Drawing.Size(172, 37);
            teamOneName.TabIndex = 6;
            teamOneName.Text = " <team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            teamOneScoreLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            teamOneScoreLabel.Location = new System.Drawing.Point(350, 226);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            teamTwoScoreLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            teamTwoScoreLabel.Location = new System.Drawing.Point(350, 372);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new System.Drawing.Size(82, 37);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            teamTwoName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            teamTwoName.Location = new System.Drawing.Point(350, 335);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new System.Drawing.Size(172, 37);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = " <team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            versusLabel.ForeColor = System.Drawing.Color.Black;
            versusLabel.Location = new System.Drawing.Point(412, 287);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new System.Drawing.Size(70, 37);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "-VS-";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.headerLabel.Location = new System.Drawing.Point(11, 8);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(214, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tournamentName.Location = new System.Drawing.Point(216, 8);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(150, 50);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.roundLabel.Location = new System.Drawing.Point(12, 76);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(94, 37);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(111, 76);
            this.roundDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(209, 36);
            this.roundDropdown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(111, 117);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(209, 41);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 28;
            this.matchupListBox.Location = new System.Drawing.Point(20, 189);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(301, 226);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(438, 229);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(100, 34);
            this.teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(438, 375);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(100, 34);
            this.teamTwoScoreValue.TabIndex = 11;
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.ForeColor = System.Drawing.Color.Blue;
            this.scoreButton.Location = new System.Drawing.Point(566, 285);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(108, 46);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 437);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(versusLabel);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(teamTwoScoreLabel);
            this.Controls.Add(teamTwoName);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(teamOneScoreLabel);
            this.Controls.Add(teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        private System.Windows.Forms.Button scoreButton;
    }
}


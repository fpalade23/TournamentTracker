namespace TrackerUI
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
            System.Windows.Forms.Label placeNumberLabel;
            System.Windows.Forms.Label placeNameLabel;
            System.Windows.Forms.Label prizeAmountLabel;
            System.Windows.Forms.Label prizePercentageLabel;
            System.Windows.Forms.Label orLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.createPrizeButton = new System.Windows.Forms.Button();
            placeNumberLabel = new System.Windows.Forms.Label();
            placeNameLabel = new System.Windows.Forms.Label();
            prizeAmountLabel = new System.Windows.Forms.Label();
            prizePercentageLabel = new System.Windows.Forms.Label();
            orLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            placeNumberLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            placeNumberLabel.Location = new System.Drawing.Point(45, 68);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new System.Drawing.Size(183, 37);
            placeNumberLabel.TabIndex = 13;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            placeNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            placeNameLabel.Location = new System.Drawing.Point(45, 120);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new System.Drawing.Size(157, 37);
            placeNameLabel.TabIndex = 15;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prizeAmountLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            prizeAmountLabel.Location = new System.Drawing.Point(45, 171);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new System.Drawing.Size(176, 37);
            prizeAmountLabel.TabIndex = 17;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prizePercentageLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            prizePercentageLabel.Location = new System.Drawing.Point(45, 288);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new System.Drawing.Size(212, 37);
            prizePercentageLabel.TabIndex = 19;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orLabel.ForeColor = System.Drawing.Color.Black;
            orLabel.Location = new System.Drawing.Point(234, 231);
            orLabel.Name = "orLabel";
            orLabel.Size = new System.Drawing.Size(64, 37);
            orLabel.TabIndex = 21;
            orLabel.Text = "-or-";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(209, 50);
            this.headerLabel.TabIndex = 12;
            this.headerLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(257, 70);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(275, 35);
            this.placeNumberValue.TabIndex = 14;
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(257, 122);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(275, 35);
            this.placeNameValue.TabIndex = 16;
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(257, 173);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(275, 35);
            this.prizeAmountValue.TabIndex = 18;
            this.prizeAmountValue.Text = "0";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Location = new System.Drawing.Point(257, 290);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(275, 35);
            this.prizePercentageValue.TabIndex = 20;
            this.prizePercentageValue.Text = "0";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.Blue;
            this.createPrizeButton.Location = new System.Drawing.Point(152, 385);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(251, 54);
            this.createPrizeButton.TabIndex = 26;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 476);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(orLabel);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(prizePercentageLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(prizeAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(placeNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(placeNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Button createPrizeButton;
    }
}
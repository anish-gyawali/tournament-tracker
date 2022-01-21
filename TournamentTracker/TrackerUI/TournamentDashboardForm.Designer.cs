﻿namespace TrackerUI
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.loadExisitingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadExisitingTournamentLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(124, 38);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(413, 54);
            this.headerLabel.TabIndex = 13;
            this.headerLabel.Text = "Tournament Dashboard";
            // 
            // loadExisitingTournamentDropDown
            // 
            this.loadExisitingTournamentDropDown.FormattingEnabled = true;
            this.loadExisitingTournamentDropDown.Location = new System.Drawing.Point(100, 151);
            this.loadExisitingTournamentDropDown.Name = "loadExisitingTournamentDropDown";
            this.loadExisitingTournamentDropDown.Size = new System.Drawing.Size(460, 45);
            this.loadExisitingTournamentDropDown.TabIndex = 20;
            // 
            // loadExisitingTournamentLabel
            // 
            this.loadExisitingTournamentLabel.AutoSize = true;
            this.loadExisitingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExisitingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadExisitingTournamentLabel.Location = new System.Drawing.Point(129, 103);
            this.loadExisitingTournamentLabel.Name = "loadExisitingTournamentLabel";
            this.loadExisitingTournamentLabel.Size = new System.Drawing.Size(402, 45);
            this.loadExisitingTournamentLabel.TabIndex = 19;
            this.loadExisitingTournamentLabel.Text = "Load Exisiting Tournament";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadTournamentButton.Location = new System.Drawing.Point(199, 218);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(262, 55);
            this.loadTournamentButton.TabIndex = 21;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(169, 298);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(326, 89);
            this.createTournamentButton.TabIndex = 27;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 428);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExisitingTournamentDropDown);
            this.Controls.Add(this.loadExisitingTournamentLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox loadExisitingTournamentDropDown;
        private System.Windows.Forms.Label loadExisitingTournamentLabel;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}
namespace Yahtzee
{
  partial class ScoreboardGlobalPlayerView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
			this.winLoseLabel = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.playerLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// winLoseLabel
			// 
			this.winLoseLabel.AutoSize = true;
			this.winLoseLabel.Location = new System.Drawing.Point(41, 88);
			this.winLoseLabel.Name = "winLoseLabel";
			this.winLoseLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.winLoseLabel.Size = new System.Drawing.Size(41, 23);
			this.winLoseLabel.TabIndex = 3;
			this.winLoseLabel.Text = "Winner";
			this.winLoseLabel.Visible = false;
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Location = new System.Drawing.Point(39, 48);
			this.lblScore.Name = "lblScore";
			this.lblScore.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.lblScore.Size = new System.Drawing.Size(47, 23);
			this.lblScore.TabIndex = 2;
			this.lblScore.Text = "Score: 0";
			// 
			// playerLabel
			// 
			this.playerLabel.AutoSize = true;
			this.playerLabel.Location = new System.Drawing.Point(40, 19);
			this.playerLabel.Name = "playerLabel";
			this.playerLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.playerLabel.Size = new System.Drawing.Size(36, 23);
			this.playerLabel.TabIndex = 4;
			this.playerLabel.Text = "Player";
			// 
			// ScoreboardGlobalPlayerView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.playerLabel);
			this.Controls.Add(this.winLoseLabel);
			this.Controls.Add(this.lblScore);
			this.Name = "ScoreboardGlobalPlayerView";
			this.Size = new System.Drawing.Size(133, 152);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label winLoseLabel;
    private System.Windows.Forms.Label lblScore;
    private System.Windows.Forms.Label playerLabel;
  }
}

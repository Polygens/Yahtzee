using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Yahtzee {
	public partial class YahtzeeStart : Form {

		private int amountOfPlayers;
		private List<ScoreboardGlobalPlayerController> scoreboardControl = new List<ScoreboardGlobalPlayerController>();
		public List<YahtzeeController> yahtzeeControl = new List<YahtzeeController>();
		private bool playing = false;

		public YahtzeeStart()
		{
			InitializeComponent();
		}

		private void startGame_Click(object sender, EventArgs e)
		{
			if (!playing) {
				if (Int32.TryParse(numberInput.Text, out amountOfPlayers)) //Als je geen geldig nummer intypt, speel je alleen.
				{
					if (amountOfPlayers > 5) //Max. aantal spelers is 5
					{
						amountOfPlayers = 5;
					}
					amntLabel.Text = "You have chosen " + amountOfPlayers + " player(s).";
				}
				else {
					amountOfPlayers = 1;
					amntLabel.Text = "You have chosen " + amountOfPlayers + " player.";
				}

				for (int i = 0; i < amountOfPlayers; i++) {
					yahtzeeControl.Add(new YahtzeeController());
					AddScoreboardPlayer();
				}
				playing = true;
			}
		}

		public void AddScoreboardPlayer()
		{
			for (int i = 0; i < amountOfPlayers; i++) {
				scoreboardControl.Add(new ScoreboardGlobalPlayerController(i, this));
				ScoreboardGlobalPlayerView scoreboardView = scoreboardControl[i].getView();
				scoreboardView.Location = new System.Drawing.Point(i * scoreboardView.Width, 150);
				Controls.Add(scoreboardView); //alignmentTable.Controls.Add(scoreboardView);		
			}
		}

		public void DecideWinOrLose()
		{
			if (amountOfPlayers > 1) {
				int highestScore = 0;
				int playerHighSc = 0;

				for (int i = 0; i < amountOfPlayers; i++) {
					if (scoreboardControl[i].model.Score > highestScore) {
						highestScore = scoreboardControl[i].model.Score;
						playerHighSc = i;
					}
				}
				scoreboardControl[playerHighSc].model.Win = true;
				scoreboardControl[playerHighSc].getView().WinOrLoseChangeText();
			}
		}


	}
}

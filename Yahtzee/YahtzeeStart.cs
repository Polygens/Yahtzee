using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Yahtzee {
	public partial class YahtzeeStart : Form {

		private int amountOfPlayers;
		public List<ScoreboardGlobalPlayerController> scoreboardControl = new List<ScoreboardGlobalPlayerController>();
		public List<YahtzeeController> yahtzeeControl = new List<YahtzeeController>();
		private bool playing = false;

		public YahtzeeStart()
		{
			InitializeComponent();
		}

		private void startGame_Click(object sender, EventArgs e)
		{
			if (!playing) {
				Restart();  //Bij herstart moeten enkele dingen verwijderd worden.
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
			
			for (int i = 0; i < amountOfPlayers; i++) {  //Yahtzees worden aangemaakt per speler.
				yahtzeeControl.Add(new YahtzeeController(i, this));
				AddScoreboardPlayer();
			}
			playing = true;
		}
		}

		public void AddScoreboardPlayer() //Elke speler krijgt een persoonlijke scoreboard.
		{
			for (int i = 0; i < amountOfPlayers; i++) {
				scoreboardControl.Add(new ScoreboardGlobalPlayerController(i, this));
				ScoreboardGlobalPlayerView scoreboardView = scoreboardControl[i].getView();
				scoreboardView.Location = new System.Drawing.Point(i * scoreboardView.Width, 150); 
				scoreTablePl.Controls.Add(scoreboardView);
			}
		}

		public void DecideWinOrLose() //De speler met de hoogste score krijgt een tekst erbij dat hij gewonnen heeft.
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

		public void CheckEndGame()  //Er wordt gecheckt of er nog andere spelers aan het spelen zijn. Indien niet, dan wordt bepaalt wie er wint en kan je terug op de Startknop duwen.
		{
			for (int i = 0; i < amountOfPlayers; i++) {
				if (yahtzeeControl[i].model.Playing) {
						return;
				}
			}
			DecideWinOrLose();
			playing = false;

			for (int i = 0; i < amountOfPlayers; i++) { //Alle YahtzeeControllers verdwijnen en worden verwijderd uit de lijst.
				yahtzeeControl[i].getView().Hide();
			}
			yahtzeeControl.Clear(); 
		}

		private void Restart()  //Alle eerder gemaakte Player scoreboards verdwijnen bij herstart.
		{
				for (int i = 0; i < amountOfPlayers; i++) {
				scoreboardControl[i].getView().Hide();
				}
				scoreboardControl.Clear();
		}
	}
}


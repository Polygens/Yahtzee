using System;
using System.Drawing;
using System.Windows.Forms;

namespace Yahtzee
{
	public partial class YahtzeeStart : Form
	{
		private int amountOfPlayers;

		public YahtzeeStart()
		{
			InitializeComponent();
		}

		private void startGame_Click(object sender, EventArgs e)
		{
			if (Int32.TryParse(numberInput.Text, out amountOfPlayers)) //Als je geen geldig nummer intypt, speel je alleen.
			{
				if (amountOfPlayers > 5)
				{ //Max. aantal spelers is 5
					amountOfPlayers = 5;
				}
				amntLabel.Text = "You have chosen " + amountOfPlayers + " player(s).";
			}
			else
			{
				amountOfPlayers = 1;
				amntLabel.Text = "You have chosen " + amountOfPlayers + " player.";
			}

			for (int i = 0; i < amountOfPlayers; i++)
			{
				YahtzeeController controller = new YahtzeeController();

				//controller.model.AantalTeerlingen = amountOfDice; //Waarschijnlijk nutteloos als we met echte scoresysteem gaan werken.

				//ShowPlayerScores();
			}
		}

		public void ShowPlayerScores() //Moet naar controller van ScoreboardGlobalPlayer
		{
			//int[] players = new int[amountOfPlayers];
			for (int i = 0; i < amountOfPlayers; i++)
			{
				//players.Add(new ScoreboardGlobalPlayerController(i, this));
				//ScoreboardGlobalPlayerView scoreboardView = players[i].getView();
				ScoreboardGlobalPlayerView scoreboardView = new ScoreboardGlobalPlayerView();
				scoreboardView.Location = new System.Drawing.Point(i * scoreboardView.Width, 150);
				Controls.Add(scoreboardView);
				Size = new Size(Size.Width, Size.Width);
			}
		}
	}
}

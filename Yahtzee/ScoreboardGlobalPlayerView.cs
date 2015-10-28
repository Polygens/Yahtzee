using System;
using System.Windows.Forms;

namespace Yahtzee
{
	public partial class ScoreboardGlobalPlayerView : UserControl
	{
		private ScoreboardGlobalPlayerController controller;

		public ScoreboardGlobalPlayerView(ScoreboardGlobalPlayerController c)
		{
			InitializeComponent();
			controller = c;
			playerLabel.Text = "Player " + (controller.model.PlayerNumber + 1);
		}

		public void UpdateScore()
		{
			lblScore.Text = "Score: " + controller.model.Score;
		}

		public void WinOrLoseChangeText()
		{
				winLoseLabel.Text = "Winner!";	
		}

	}
}

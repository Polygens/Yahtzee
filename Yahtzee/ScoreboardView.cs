using System.Windows.Forms;

namespace Yahtzee
{
	public partial class ScoreboardView : UserControl
	{
		private ScoreboardController controller;

		public ScoreboardView(ScoreboardController c)
		{
			InitializeComponent();
			controller = c;
		}

		public void ChangeScore()
		{
			lblScore.Text = "Score: " + controller.model.Score;
		}

		public void ChangeHighscore()
		{
			lblHighscore.Text = "Highscore: " + controller.model.Highscore;
		}
	}
}

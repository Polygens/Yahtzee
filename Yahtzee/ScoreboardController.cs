namespace Yahtzee
{
	public class ScoreboardController
	{
		private ScoreboardView view;
		public ScoreboardModel model;

		public ScoreboardController()
		{
			view = new ScoreboardView(this);
			model = new ScoreboardModel();
		}

		public ScoreboardView getView()
		{
			return view;
		}

		public void ChangeScore(int teerling, int ogen)
		{
			model.Numbers[teerling] = ogen;
		}

		public void UpdateScore()
		{
			int score = 0;
			for (int i = 0; i < model.Numbers.Length; i++)
			{
				score += model.Numbers[i];
			}
			model.Score = score;
			view.ChangeScore();

			if (model.Highscore < model.Score)
			{
				model.Highscore = model.Score;
				view.ChangeHighscore();
			}
		}
	}
}

namespace Yahtzee
{
	public class ScoreboardGlobalPlayerController
	{
		private ScoreboardGlobalPlayerView view;
		public ScoreboardGlobalPlayerModel model;
		private YahtzeeStart yahtzeeStart;   //Gebruik dit wel momenteel niet!

		public ScoreboardGlobalPlayerController(int i, YahtzeeStart ys)
		{
			model = new ScoreboardGlobalPlayerModel(); //Moet voor de view worden aangemaakt in dit geval.
			model.PlayerNumber = i;
			view = new ScoreboardGlobalPlayerView(this);
			yahtzeeStart = ys;
		}

		public ScoreboardGlobalPlayerView getView()
		{
			return view;
		}

		public void KeepingScore()
		{
			int Plnumber = model.PlayerNumber;
			model.Score = yahtzeeStart.yahtzeeControl[Plnumber].GetScoreContr().model.Score;
			view.UpdateScore();
		}
	}
}

namespace Yahtzee
{
	public class ScoreboardGlobalPlayerController
	{
		private ScoreboardGlobalPlayerView view;
		public ScoreboardGlobalPlayerModel model;
		private YahtzeeStart yahtzeeStart; 

		public ScoreboardGlobalPlayerController(int i, YahtzeeStart ys)
		{
			model = new ScoreboardGlobalPlayerModel(); 
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
			model.Score = yahtzeeStart.yahtzeeControl[Plnumber].GetScoreContr().model.Score; //Haalt via de YahtzeeStart, via de correcte YahtzeeController het Scoreboard op en haalt dan de score van de speler via het model.
			view.UpdateScore();
		}
	}
}

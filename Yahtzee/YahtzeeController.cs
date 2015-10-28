using System.Collections.Generic;
using System.Windows.Forms;

namespace Yahtzee
{
	public class YahtzeeController
	{
		private YahtzeeView view;
		public YahtzeeModel model;
		private ScoreboardController scoreboard;
		public YahtzeeStart startController;

		public YahtzeeController(int plNum, YahtzeeStart ys)
		{
			scoreboard = new ScoreboardController(this);
			model = new YahtzeeModel();
			model.PlayerNumber = plNum;
			view = new YahtzeeView(this);
			startController = ys;

			view.Show();  //Laat form verschijnen

			scoreboard.model.Dice = new int[model.AantalTeerlingen];

			for (int i = 0; i < model.AantalTeerlingen; i++)
			{
				//Maak instantie aan van TeerlingController
				//Voeg teerling toe aan het formulier via YahtzeeView
				model.Teerlingen.Add(new TeerlingController(i, this));
				TeerlingView teerlingView = model.Teerlingen[i].getView();
				view.MakeDice(teerlingView, i);
			}
		}

		public YahtzeeView getView() 
		{
			return view;
		}

		public ScoreboardView GetScoreView() //Haalt ScoreboardView vanuit ScoreboardController
		{
			return scoreboard.getView();
		}

		public ScoreboardController GetScoreContr()
		{
			return scoreboard;
		}

		public void ScoreChanged(int indexOfTeerling) //Verandert score van één teerling
		{
			scoreboard.ChangeScore(indexOfTeerling, model.Teerlingen[indexOfTeerling].model.AantalOgen);
		}

		public void ScoreChangedAll() //Verandert score van alle teerlingen
		{
			for (int i = 0; i < model.AantalTeerlingen; i++)
			{
				model.Teerlingen[i].getView().SetText();
				scoreboard.ChangeScore(i, model.Teerlingen[i].model.AantalOgen);
			}
		}

		public void RefreshGame()
		{
			scoreboard.ResetScore();

			//teerlingen
			for (int i = 0; i < model.AantalTeerlingen; i++)
			{
				model.Teerlingen[i].getView().AbleThrow();
			}
		}

		public void Forfeit()
		{
				model.Playing = false;
				startController.CheckEndGame();
		}
	}
}

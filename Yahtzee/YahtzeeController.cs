using System.Collections.Generic;

namespace Yahtzee
{
	public class YahtzeeController
	{
		private YahtzeeView view;
		public YahtzeeModel model;
		private ScoreboardController scoreboard = new ScoreboardController();

		private List<TeerlingController> teerlingen = new List<TeerlingController>();
		private int aantalTeerlingen;

		public YahtzeeController()
		{
			view = new YahtzeeView(this);

			//view.Location = new System.Drawing.Point(view.Width + view.Width, view.Location.Y + view.Location.Y);  //Moet nog verder werken om de schermen op andere plaatsen te laten verschijnen.
			view.Show();  //Laat form verschijnen
			model = new YahtzeeModel();

			aantalTeerlingen = model.AantalTeerlingen;
			scoreboard.model.Numbers = new int[aantalTeerlingen];

			for (int i = 0; i < aantalTeerlingen; i++)
			{
				//Maak instantie aan van TeerlingController
				//Voeg teerling toe aan het formulier via YahtzeeView
				teerlingen.Add(new TeerlingController(i, this));
				TeerlingView teerlingView = teerlingen[i].getView();
				view.MakeDice(teerlingView, i);
			}
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
			scoreboard.ChangeScore(indexOfTeerling, teerlingen[indexOfTeerling].model.AantalOgen);

		}

		public void ScoreChangedAll() //Verandert score van alle teerlingen
		{
			for (int i = 0; i < aantalTeerlingen; i++)
			{
				teerlingen[i].getView().SetText();
				scoreboard.ChangeScore(i, teerlingen[i].model.AantalOgen);
			}
		}
	}
}

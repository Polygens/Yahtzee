using System;

namespace Yahtzee
{
	public class TeerlingController
	{
		private static int seed = 0;

		//member die de view opvangt
		private TeerlingView view;

		public TeerlingModel model;
		private YahtzeeController yahtzeeController;
		private int throwns;

		public TeerlingController(int i, YahtzeeController y)
		{
			view = new TeerlingView(this);
			model = new TeerlingModel();
			model.IndexOfTeerling = i;
			view.SetIndexOfTeerling();
			yahtzeeController = y;
			throwns = model.AantalWorpen;
		}

		public TeerlingView getView()
		{
			return view;
		}

		public void Werp()
		{
			throwns++;
			model.AantalWorpen = throwns;

			if (!model.Vastgezet)
			{
				//Nieuwe instantie van Random object genereren
				Random random = new Random(seed++);

				//Random getal genereren tussen 1 & 6
				int aantalOgen = random.Next(1, 7);

				//Het model updaten
				model.AantalOgen = aantalOgen;
			}

			if (throwns == 3)
			{
				view.DisableThrow();
			}
		}

		public void Vastzetten()
		{
			model.KleurTeerling = System.Drawing.Color.Red;
			model.Vastgezet = true;
			model.isBtnVisible = false;
		}

    public void Losmaken()
    {
      model.KleurTeerling = System.Drawing.Color.Black;
      model.Vastgezet = false;
      model.isBtnVisible = true;
      ThrowsToZero();
    }

    public void ThrowsToZero(){
      throwns = 0;
    }

		public void ScoreChanged()
		{
			yahtzeeController.ScoreChanged(model.IndexOfTeerling);
		}
	}
}

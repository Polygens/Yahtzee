using System.Text.RegularExpressions;

namespace Yahtzee
{
	public class ScoreboardController
	{
		private ScoreboardView view;
		public ScoreboardModel model;
		private YahtzeeController yahtzeeController;

		private string strThreeOK = @"[3]";
		private string strFourOK = @"[4]";
		private string strYahtzee = @"[5]";
		private string strFullHouse = @"[20*3|30*2]";
		private string strlStraight = @"[1]";
		private string strsStraight = @"[[12]{4}]";

		public ScoreboardController(YahtzeeController y)
		{
			view = new ScoreboardView(this);
			model = new ScoreboardModel();
			yahtzeeController = y;
		}

		public ScoreboardView getView()
		{
			return view;
		}

		public void ChangeScore(int die, int eyes)
		{
			model.Dice[die] = eyes;

			foreach (var item in model.LabelNamesArr_LowerSection)
			{
				view.SetText(item, CalculateScoreOfCategory(item));
			}

			foreach (var item in model.LabelNamesArr_UpperSection)
			{
				view.SetText(item, CalculateScoreOfCategory(item));
			}
		}

		public void ClickCategory(string nameLbl)
		{
			int points = CalculateScoreOfCategory(nameLbl);
            SetScoreOfCategory(nameLbl, points);
			UpdateTotalScores(nameLbl, points);

			model.AmntOfRounds++;   //Even vlug erbij gezet.
			EndingGame();
		}

		public void UpdateTotalScores(string nameLbl, int points)
		{
			model.SubTotal1 = model.Ace + model.Two + model.Three + model.Four + model.Five + model.Six;
			model.SubTotal2 = model.ThreeOK + model.FourOK + model.FullHouse + model.SStraight + model.LStraight + model.YahtzeeSc + model.Chance;
			model.Score = model.SubTotal1 + model.SubTotal2;
			CheckForBonus();
			view.SetText(nameLbl, points);
			view.SetText("totalPointsLbl_Upper", model.SubTotal1);
			view.SetText("totalPointsLbl_Lower", model.SubTotal2);
			view.SetText("totalPointsLbl", model.Score);

			yahtzeeController.startController.scoreboardControl[yahtzeeController.model.PlayerNumber].KeepingScore(); //Gaat via de YahtzeeController en YahtzeeStart naar de globale ScoreboardController om daar de Methode om de Score te Updaten in het YahtzeeStart scherm aan te halen. Elke YahtzeeController heeft een player number en zo weet de YahtzeeStart welke speler de score wilt updaten.
		}

		public void CheckForBonus()
		{
			if (model.SubTotal1 >= 63)
			{
				model.Bonus = model.PtBonus;
				view.SetText("bonusPointsLbl", model.Bonus);
				model.SubTotal1 += model.Bonus;
			}
		}

		//Counts the amount of thrown dice for each possible amount of eyes
		public void CountDice()
		{
			System.Array.Clear(model.DiceNumOfEye, 0, model.DiceNumOfEye.Length);
			for (int i = 0; i < model.Dice.Length; i++)
			{
				if (model.Dice[i] > 0)
				{
					model.DiceNumOfEye[model.Dice[i] - 1]++;
				}
			}
		}

		//Converts an int array to a string
		public string ArrayToString(int[] array)
		{
			string diceString = "";
			for (int i = 0; i < array.Length; i++)
			{
				diceString += array[i];
			}
			return diceString;
		}

		//Returns the sum of the same dice with a given value
		private int SumOfEye(int eye)
		{
			int sumEye = 0;
			for (int i = 0; i < model.Dice.Length; i++)
			{
				if (model.Dice[i] == eye)
				{
					sumEye += eye;
				}
			}
			return sumEye;
		}

		//Returns the sum of all the dice
		public int SumOfAllEyes()
		{
			int sumAllEyes = 0;
			for (int i = 0; i < model.Dice.Length; i++)
			{
				sumAllEyes += model.Dice[i];
			}
			return sumAllEyes;
		}

		private int CalculateScoreOfCategory(string nameLbl)
		{
			int points = 0;
			Regex rgx;
			CountDice();
			switch (nameLbl)
			{
				case "acesPointsLbl":
					points = SumOfEye(1);
					break;

				case "twosPointsLbl":
					points = SumOfEye(2);
					break;

				case "threesPointsLbl":
					points = SumOfEye(3);
					break;

				case "foursPointsLbl":
					points = SumOfEye(4);
					break;

				case "fivesPointsLbl":
					points = SumOfEye(5);
					break;

				case "sixesPointsLbl":
					points = SumOfEye(6);
					break;

				case "threeOKPointsLbl":
					rgx = new Regex(strThreeOK);
					if (rgx.Matches(ArrayToString(model.DiceNumOfEye)).Count > 0)
					{
						points = SumOfAllEyes();
					}
					break;

				case "fourOKPointsLbl":
					rgx = new Regex(strFourOK);
					if (rgx.Matches(ArrayToString(model.DiceNumOfEye)).Count > 0)
					{
						points = SumOfAllEyes();
					}
					break;

				case "fullHousePointsLbl":
					rgx = new Regex(strFullHouse);
					if (rgx.Matches(ArrayToString(model.DiceNumOfEye)).Count > 0)
					{
						points = model.PtFullHouse;
					}
					break;

				case "sStraightPointsLbl":
					rgx = new Regex(strsStraight);
					if (rgx.Matches(ArrayToString(model.DiceNumOfEye)).Count > 0)
					{
						points = model.PtLStraight;
					}
					break;

				case "lStraightPointsLbl":
					rgx = new Regex(strlStraight);
					if (rgx.Matches(ArrayToString(model.DiceNumOfEye)).Count >= 5)
					{
						points = model.PtLStraight;
					}
					break;

				case "yahtzeePointsLbl":
					rgx = new Regex(strYahtzee);
					if (rgx.Matches(ArrayToString(model.DiceNumOfEye)).Count > 0)
					{
						points = SumOfAllEyes();
					}
					break;

				case "chancePointsLbl":
					points = SumOfAllEyes();
					break;

				default:
					break;
			}
			return points;
		}

		private void SetScoreOfCategory(string nameLbl, int points)
		{
			switch (nameLbl)
			{
				case "acesPointsLbl":
					model.Ace = points;
					break;

				case "twosPointsLbl":
					model.Two = points;
					break;

				case "threesPointsLbl":
					model.Three = points;
					break;

				case "foursPointsLbl":
					model.Four = points;
					break;

				case "fivesPointsLbl":
					model.Five = points;
					break;

				case "sixesPointsLbl":
					model.Six = points;
					break;

				case "threeOKPointsLbl":
					model.ThreeOK = points;
					break;

				case "fourOKPointsLbl":
					model.FourOK = points;
					break;

				case "fullHousePointsLbl":
					model.FullHouse = points;
					break;

				case "sStraightPointsLbl":
					model.SStraight = points;
					break;

				case "lStraightPointsLbl":
					model.LStraight = points;
					break;

				case "yahtzeePointsLbl":
					model.YahtzeeSc = points;
					break;

				case "chancePointsLbl":
					model.Chance = points;
					break;

				default:
					break;
			}
		}

		public void EndingGame()  //Checkt of de spel ten einde is. Even vlug erbij gezet...
		{
			if (model.AmntOfRounds == 13)
			{
				yahtzeeController.model.Playing = false;
				yahtzeeController.startController.CheckEndGame();
			}
		}
	}
}

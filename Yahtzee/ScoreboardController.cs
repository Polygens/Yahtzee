using System.Text.RegularExpressions;

namespace Yahtzee
{
	public class ScoreboardController
	{
		private ScoreboardView view;
		public ScoreboardModel model;
		private YahtzeeController yahtzeeController;

		private string strThreeOK = @"3|4|5";
		private string strFourOK = @"4|5";
		private string strFullHouse_2 = @"2";
		private string strFullHouse_3 = @"3";
		private string strsStraight = @"1111";
		private string strlStraight = @"11111";
		private string strYahtzee = @"5";

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
			SetScoreOfCategory(nameLbl, CalculateScoreOfCategory(nameLbl));
			UpdateTotalScores();
			for (int i = 0; i < yahtzeeController.model.AantalTeerlingen; i++)
			{
				yahtzeeController.model.Teerlingen[i].Losmaken();
            }
			yahtzeeController.ScoreChangedAll();
			model.AmntOfRounds++;
			EndingGame();
		}

		public void UpdateTotalScores()
		{
			CheckForBonus();
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
					if (rgx.Match(ArrayToString(model.DiceNumOfEye)).Success)
					{
						points = SumOfAllEyes();
					}
					break;

				case "fourOKPointsLbl":
					rgx = new Regex(strFourOK);
					if (rgx.Match(ArrayToString(model.DiceNumOfEye)).Success)
					{
						points = SumOfAllEyes();
					}
					break;

				case "fullHousePointsLbl":
					rgx = new Regex(strFullHouse_2);
					Regex rgx2 = new Regex(strFullHouse_3);
					if (rgx.Match(ArrayToString(model.DiceNumOfEye)).Success && rgx2.Match(ArrayToString(model.DiceNumOfEye)).Success)
					{
						points = model.PtFullHouse;
					}
					break;

				case "sStraightPointsLbl":
					rgx = new Regex(strsStraight);
					if (rgx.Match(ArrayToString(model.DiceNumOfEye)).Success)
					{
						points = model.PtSStraight;
					}
					break;

				case "lStraightPointsLbl":
					rgx = new Regex(strlStraight);
					if (rgx.Match(ArrayToString(model.DiceNumOfEye)).Success)
					{
						points = model.PtLStraight;
					}
					break;

				case "yahtzeePointsLbl":
					rgx = new Regex(strYahtzee);
					if (rgx.Match(ArrayToString(model.DiceNumOfEye)).Success)
					{
						points = model.PtYahtzee;
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

		// score reseten
		public void ResetScore()
		{
			model.Ace = 0;
			model.Two = 0;
			model.Three = 0;
			model.Four = 0;
			model.Five = 0;
			model.Six = 0;
			model.Bonus = 0;
			model.ThreeOK = 0;
			model.FourOK = 0;
			model.FullHouse = 0;
			model.SStraight = 0;
			model.LStraight = 0;
			model.YahtzeeSc = 0;
			model.Chance = 0;
			UpdateTotalScores();
      view.ChangeText();
			model.AmntOfRounds = 0;
		}
	}
}

namespace Yahtzee
{
	public class ScoreboardModel
	{
		private int amntOfRounds;
		private int[] dice;
		private int[] diceNumOfEye = new int[6];
		private string[] labelNamesArr_UpperSection = new string[] { "acesPointsLbl", "twosPointsLbl", "threesPointsLbl", "foursPointsLbl", "fivesPointsLbl", "sixesPointsLbl" };
		private string[] labelNamesArr_LowerSection = new string[] { "threeOKPointsLbl", "fourOKPointsLbl", "fullHousePointsLbl", "sStraightPointsLbl", "lStraightPointsLbl", "yahtzeePointsLbl", "chancePointsLbl" };

		private int score, highscore, ace, two, three, four, five, six, bonus,
			subTotal1, threeOK, fourOK, fullHouse, sStraight, lStraight,
			yahtzeeSc, chance, subTotal2;

		private int ptBonus = 35, ptFullHouse = 25, ptSStraight = 30, ptLStraight = 40, ptYahtzee = 50;

		public int PtBonus
		{
			get { return ptBonus; }
		}

		public int PtFullHouse
		{
			get { return ptFullHouse; }
		}

		public int PtSStraight
		{
			get { return ptSStraight; }
		}

		public int PtLStraight
		{
			get { return ptLStraight; }
		}

		public int PtYahtzee
		{
			get { return ptYahtzee; }
		}

		public int Ace
		{
			get { return ace; }
			set { ace = value; }
		}

		public int Two
		{
			get { return two; }
			set { two = value; }
		}

		public int Three
		{
			get { return three; }
			set { three = value; }
		}

		public int Four
		{
			get { return four; }
			set { four = value; }
		}

		public int Five
		{
			get { return five; }
			set { five = value; }
		}

		public int Six
		{
			get { return six; }
			set { six = value; }
		}

		public int Bonus
		{
			get { return bonus; }
			set { bonus = value; }
		}

		public int SubTotal1
		{
			get { return subTotal1 = Ace + Two + Three + Four + Five + Six; }
		}

		public int ThreeOK
		{
			get { return threeOK; }
			set { threeOK = value; }
		}

		public int FourOK
		{
			get { return fourOK; }
			set { fourOK = value; }
		}

		public int FullHouse
		{
			get { return fullHouse; }
			set { fullHouse = value; }
		}

		public int SStraight
		{
			get { return sStraight; }
			set { sStraight = value; }
		}

		public int LStraight
		{
			get { return lStraight; }
			set { lStraight = value; }
		}

		public int YahtzeeSc
		{
			get { return yahtzeeSc; }
			set { yahtzeeSc = value; }
		}

		public int Chance
		{
			get { return chance; }
			set { chance = value; }
		}

		public int SubTotal2
		{
			get { return subTotal2 = ThreeOK + FourOK + FullHouse + SStraight + LStraight + YahtzeeSc + Chance; }
		}

		public int Score
		{
			get { return score = SubTotal1 + SubTotal2; }
		}

		public int Highscore
		{
			get { return highscore; }
			set { highscore = value; }
		}

		public int[] Dice
		{
			get { return dice; }
			set { dice = value; }
		}

		public int[] DiceNumOfEye
		{
			get { return diceNumOfEye; }
			set { diceNumOfEye = value; }
		}

		public int AmntOfRounds
		{
			get { return amntOfRounds; }
			set { amntOfRounds = value; }
		}

		public string[] LabelNamesArr_LowerSection
		{
			get { return labelNamesArr_LowerSection; }
			set { labelNamesArr_LowerSection = value; }
		}

		public string[] LabelNamesArr_UpperSection
		{
			get { return labelNamesArr_UpperSection; }
			set { labelNamesArr_UpperSection = value; }
		}
	}
}

namespace Yahtzee
{
	public class ScoreboardModel
	{
		private int[] numbers;
		private int[] diceCount = new int[6];

		private int score, highscore, ace, two, three, four, five, six, bonus,
			subTotal1, threeOK, fourOK, fullHouse, sStraight, lStraight,
			yahtzeeSc, chance, subTotal2;

		private int ptBonus = 35, ptFullHouse = 25, ptSStraight = 30, ptLStraight = 40;

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


		public int Score
		{
			get { return score; }
			set { score = value; }
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
			get { return subTotal1; }
			set { subTotal1 = value; }
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
			get { return subTotal2; }
			set { subTotal2 = value; }
		}

		public int Highscore
		{
			get { return highscore; }
			set { highscore = value; }
		}

		public int[] Numbers
		{
			get { return numbers; }
			set { numbers = value; }
		}

		public int[] DiceCount
		{
			get { return diceCount; }
			set { diceCount = value; }
		}

	}
}

namespace Yahtzee
{
	public class YahtzeeModel
	{
		private int aantalTeerlingen = 5;
		private int playerNumber = 0;
		private bool playing = true;

		public int AantalTeerlingen
		{
			get { return aantalTeerlingen; }
			set { aantalTeerlingen = value; }
		}

		public int PlayerNumber
		{
			get { return playerNumber; }
			set { playerNumber = value; }
		}

		public bool Playing
		{
			get { return playing; }
			set { playing = value; }
		}

	}
}

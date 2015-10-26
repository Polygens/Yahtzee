using System.Collections.Generic;

namespace Yahtzee
{
	public class YahtzeeModel
	{
		private int aantalTeerlingen = 5;
		private int playerNumber = 0;
		private bool playing = true;

		private List<TeerlingController> teerlingen = new List<TeerlingController>();

		public int AantalTeerlingen
		{
			get { return aantalTeerlingen; }
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

		public List<TeerlingController> Teerlingen
		{
			get { return teerlingen; }
			set { teerlingen = value; }
		}
	}
}

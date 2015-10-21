using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
	public class ScoreboardGlobalPlayerModel
	{
		private int playerNumber = 0;
		private int score = 0;
		private bool win = false;
		private bool playing = true;

		public int PlayerNumber
		{
			get { return playerNumber; }
			set { playerNumber = value; }
		}

		public int Score
		{
			get { return score; }
			set { score = value; }
		}

		public bool Win
		{
			get { return win; }
			set { win = value; }
		}

		public bool Playing
		{
			get { return playing; }
			set { playing = value; }
		}


	}
}

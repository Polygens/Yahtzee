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

	}
}

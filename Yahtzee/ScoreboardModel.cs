namespace Yahtzee
{
	public class ScoreboardModel
	{
		private int[] numbers;
		private int score, highscore;

		public int Score
		{
			get { return score; }
			set { score = value; }
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
	}
}

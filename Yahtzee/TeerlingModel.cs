using System.Drawing;

namespace Yahtzee
{
	public class TeerlingModel
	{
		private int aantalOgen;
		private Color kleurTeerling;
		private bool vastgezet = false;
		private bool btnIsVisible = true;
		private int indexOfTeerling = 0;
		private int aantalWorpen = 0;

		public int AantalOgen
		{
			get { return aantalOgen; }
			set { aantalOgen = value; }
		}

		public Color KleurTeerling
		{
			get { return kleurTeerling; }
			set { kleurTeerling = value; }
		}

		public bool Vastgezet
		{
			get { return vastgezet; }
			set { vastgezet = value; }
		}

		public bool isBtnVisible
		{
			get { return btnIsVisible; }
			set { btnIsVisible = value; }
		}

		public int IndexOfTeerling
		{
			get { return indexOfTeerling; }
			set { indexOfTeerling = value; }
		}

		public int AantalWorpen
		{
			get { return aantalWorpen; }
			set { aantalWorpen = value; }
		}
	}
}

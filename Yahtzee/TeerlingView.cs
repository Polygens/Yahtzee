using System;
using System.Windows.Forms;

namespace Yahtzee
{
	public partial class TeerlingView : UserControl
	{
		private TeerlingController controller;

		public TeerlingView(TeerlingController c)
		{
			InitializeComponent();
			controller = c;
		}

		private void TeerlingWerpen_Click(object sender, EventArgs e)
		{
			SetText();
			controller.ScoreChanged();
		}

		public void SetText()
		{
			controller.Werp();
			int nieuwAantalOgen = controller.model.AantalOgen;
			TeerlingLabel.Text = nieuwAantalOgen.ToString();
		}

		public void DisableThrow()
		{
			controller.Vastzetten();
			TeerlingLabel.ForeColor = controller.model.KleurTeerling;
			if (!controller.model.isBtnVisible)
			{
				TeerlingWerpen.Hide();
			}
		}

		public void AbleThrow()
		{
			controller.Losmaken();
			TeerlingLabel.ForeColor = controller.model.KleurTeerling;
			if (controller.model.isBtnVisible)
			{
				TeerlingWerpen.Show();
			}
		}

		private void TeerlingLabel_Click(object sender, EventArgs e)
		{
			DisableThrow();
		}

		public void SetIndexOfTeerling()
		{
			label1.Text = "Teerling: " + (controller.model.IndexOfTeerling + 1);
		}

		//cheat knoppen verschijnen
		public void MakeButtonsVisible()
		{
			nr1.Show();
			nr2.Show();
			nr3.Show();
			nr4.Show();
			nr5.Show();
			nr6.Show();
		}

		// cheat knop waarde doorgeven
		public void CheatButtonValue(int value)
		{
			TeerlingLabel.Text = value.ToString();
			controller.model.AantalOgen = value;
		}

		private void nr1_Click(object sender, EventArgs e)
		{
			CheatButtonValue(1);
		}

		private void nr2_Click(object sender, EventArgs e)
		{
			CheatButtonValue(2);
		}

		private void nr3_Click(object sender, EventArgs e)
		{
			CheatButtonValue(3);
		}

		private void nr4_Click(object sender, EventArgs e)
		{
			CheatButtonValue(4);
		}

		private void nr5_Click(object sender, EventArgs e)
		{
			CheatButtonValue(5);
		}

		private void nr6_Click(object sender, EventArgs e)
		{
			CheatButtonValue(6);
		}
	}
}

using System.Drawing;
using System.Windows.Forms;

namespace Yahtzee
{
	public partial class ScoreboardView : UserControl
	{
		private ScoreboardController controller;

		public ScoreboardView(ScoreboardController c)
		{
			InitializeComponent();
			controller = c;
		}

		private void scoresheetClick(object sender, System.EventArgs e)
		{
			Control tempLbl = (Control)sender;

			
			tempLbl.BackColor = Color.Beige;
			tempLbl.ForeColor = Color.Black;
			controller.ClickCategory(tempLbl.Name);
			tempLbl.Click -= scoresheetClick;
		}

		public void resetLbl(string name)
		{
			Control ctn = Scoresheet.Controls[name];
			ctn.BackColor = Color.Transparent;
			ctn.ForeColor = Color.DarkGray;
			ctn.Click -= scoresheetClick;
			ctn.Click += scoresheetClick;
		}

		public void SetText(string name, int points)
		{

			Control ctn = Scoresheet.Controls[name];
			if (ctn.BackColor != Color.Beige)
			{
				ctn.Text = points.ToString();
			}
			
		}

		public void ChangeText()
		{
			foreach (var item in controller.model.LabelNamesArr_LowerSection)
			{
				Scoresheet.Controls[item].Text = "0";
				resetLbl(item);
			}

			foreach (var item in controller.model.LabelNamesArr_UpperSection)
			{
				Scoresheet.Controls[item].Text = "0";
				resetLbl(item);
			}
		}
	}
}

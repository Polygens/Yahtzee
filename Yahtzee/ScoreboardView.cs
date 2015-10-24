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
			System.Windows.Forms.Control tempLbl;
			tempLbl = (Control)sender;
			//MessageBox.Show(tempLbl.Name);
			controller.ClickCategory(tempLbl.Name);
			tempLbl.BackColor = Color.Beige;
			tempLbl.Click -= scoresheetClick;
		}

		public void SetText(string name, int points)
		{
			Control ctn = Scoresheet.Controls[name];
			ctn.Text = points.ToString();
			
        }

    public void ChangeText()
    {

      acesPointsLbl.Text = "0";
      twosPointsLbl.Text = "0";
      threesPointsLbl.Text = "0";
      foursPointsLbl.Text = "0";
      fivesPointsLbl.Text = "0";
      sixesPointsLbl.Text = "0";
      fullHousePointsLbl.Text = "0";
      fourOKPointsLbl.Text = "0";
      threeOKPointsLbl.Text = "0";
      lStraightPointsLbl.Text = "0";
      sStraightPointsLbl.Text = "0";
      yahtzeePointsLbl.Text = "0";
      chancePointsLbl.Text = "0";
      totalPointsLbl_Lower.Text = "0";
      totalPointsLbl.Text = "0";
      totalPointsLbl_Upper.Text = "0";
    }



	}
}

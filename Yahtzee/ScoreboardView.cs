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
			tempLbl.ForeColor = Color.Black;
			tempLbl.Click -= scoresheetClick;
		}

		public void SetText(string name, int points)
		{
			Control ctn = Scoresheet.Controls[name];
			ctn.Text = points.ToString();
			
        }
	}
}

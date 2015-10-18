namespace Yahtzee
{
  partial class YahtzeeStart
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
			this.numberInput = new System.Windows.Forms.TextBox();
			this.questionPlayerLabel = new System.Windows.Forms.Label();
			this.startGame = new System.Windows.Forms.Button();
			this.welcomeLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.amntLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// numberInput
			// 
			this.numberInput.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.numberInput.Location = new System.Drawing.Point(127, 49);
			this.numberInput.Name = "numberInput";
			this.numberInput.Size = new System.Drawing.Size(30, 20);
			this.numberInput.TabIndex = 2;
			this.numberInput.Text = "1";
			this.numberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// questionPlayerLabel
			// 
			this.questionPlayerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.questionPlayerLabel.AutoSize = true;
			this.questionPlayerLabel.Location = new System.Drawing.Point(87, 23);
			this.questionPlayerLabel.Name = "questionPlayerLabel";
			this.questionPlayerLabel.Padding = new System.Windows.Forms.Padding(5);
			this.questionPlayerLabel.Size = new System.Drawing.Size(109, 23);
			this.questionPlayerLabel.TabIndex = 3;
			this.questionPlayerLabel.Text = "How many players?";
			// 
			// startGame
			// 
			this.startGame.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.startGame.Location = new System.Drawing.Point(104, 75);
			this.startGame.Name = "startGame";
			this.startGame.Size = new System.Drawing.Size(75, 23);
			this.startGame.TabIndex = 0;
			this.startGame.Text = "Start";
			this.startGame.UseVisualStyleBackColor = true;
			this.startGame.Click += new System.EventHandler(this.startGame_Click);
			// 
			// welcomeLabel
			// 
			this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.welcomeLabel.AutoSize = true;
			this.welcomeLabel.Location = new System.Drawing.Point(82, 0);
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.Padding = new System.Windows.Forms.Padding(5);
			this.welcomeLabel.Size = new System.Drawing.Size(119, 23);
			this.welcomeLabel.TabIndex = 4;
			this.welcomeLabel.Text = "Welcome to Yahtzee!";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.welcomeLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.numberInput, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.startGame, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.questionPlayerLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.amntLabel, 0, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 196);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// amntLabel
			// 
			this.amntLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.amntLabel.AutoSize = true;
			this.amntLabel.Location = new System.Drawing.Point(142, 142);
			this.amntLabel.Name = "amntLabel";
			this.amntLabel.Size = new System.Drawing.Size(0, 13);
			this.amntLabel.TabIndex = 5;
			// 
			// YahtzeeStart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 196);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "YahtzeeStart";
			this.Text = "Yahtzee";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox numberInput;
    private System.Windows.Forms.Label questionPlayerLabel;
    private System.Windows.Forms.Button startGame;
    private System.Windows.Forms.Label welcomeLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label amntLabel;
	}
}
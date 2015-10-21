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
			this.amntLabel = new System.Windows.Forms.Label();
			this.numberInput = new System.Windows.Forms.TextBox();
			this.questionPlayerLabel = new System.Windows.Forms.Label();
			this.startGame = new System.Windows.Forms.Button();
			this.welcomeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// amntLabel
			// 
			this.amntLabel.AutoSize = true;
			this.amntLabel.Location = new System.Drawing.Point(60, 114);
			this.amntLabel.Name = "amntLabel";
			this.amntLabel.Size = new System.Drawing.Size(0, 13);
			this.amntLabel.TabIndex = 1;
			// 
			// numberInput
			// 
			this.numberInput.Location = new System.Drawing.Point(109, 77);
			this.numberInput.Name = "numberInput";
			this.numberInput.Size = new System.Drawing.Size(40, 20);
			this.numberInput.TabIndex = 2;
			// 
			// questionPlayerLabel
			// 
			this.questionPlayerLabel.AutoSize = true;
			this.questionPlayerLabel.Location = new System.Drawing.Point(80, 53);
			this.questionPlayerLabel.Name = "questionPlayerLabel";
			this.questionPlayerLabel.Size = new System.Drawing.Size(99, 13);
			this.questionPlayerLabel.TabIndex = 3;
			this.questionPlayerLabel.Text = "How many players?";
			// 
			// startGame
			// 
			this.startGame.Location = new System.Drawing.Point(94, 140);
			this.startGame.Name = "startGame";
			this.startGame.Size = new System.Drawing.Size(75, 23);
			this.startGame.TabIndex = 0;
			this.startGame.Text = "Start";
			this.startGame.UseVisualStyleBackColor = true;
			this.startGame.Click += new System.EventHandler(this.startGame_Click);
			// 
			// welcomeLabel
			// 
			this.welcomeLabel.AutoSize = true;
			this.welcomeLabel.Location = new System.Drawing.Point(75, 22);
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.Size = new System.Drawing.Size(109, 13);
			this.welcomeLabel.TabIndex = 4;
			this.welcomeLabel.Text = "Welcome to Yahtzee!";
			// 
			// YahtzeeStart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(284, 196);
			this.Controls.Add(this.welcomeLabel);
			this.Controls.Add(this.questionPlayerLabel);
			this.Controls.Add(this.numberInput);
			this.Controls.Add(this.amntLabel);
			this.Controls.Add(this.startGame);
			this.Name = "YahtzeeStart";
			this.Text = "Yahtzee";
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label amntLabel;
    private System.Windows.Forms.TextBox numberInput;
    private System.Windows.Forms.Label questionPlayerLabel;
    private System.Windows.Forms.Button startGame;
    private System.Windows.Forms.Label welcomeLabel;

  }
}
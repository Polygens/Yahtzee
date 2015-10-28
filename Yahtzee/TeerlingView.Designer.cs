using System.Collections.Generic;

namespace Yahtzee
{
	partial class TeerlingView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.TeerlingLabel = new System.Windows.Forms.Label();
      this.TeerlingWerpen = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.nr1 = new System.Windows.Forms.Button();
      this.nr2 = new System.Windows.Forms.Button();
      this.nr3 = new System.Windows.Forms.Button();
      this.nr4 = new System.Windows.Forms.Button();
      this.nr5 = new System.Windows.Forms.Button();
      this.nr6 = new System.Windows.Forms.Button();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // TeerlingLabel
      // 
      this.TeerlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TeerlingLabel.Location = new System.Drawing.Point(3, 23);
      this.TeerlingLabel.Name = "TeerlingLabel";
      this.TeerlingLabel.Size = new System.Drawing.Size(128, 128);
      this.TeerlingLabel.TabIndex = 2;
      this.TeerlingLabel.Text = "Teerling";
      this.TeerlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.TeerlingLabel.Click += new System.EventHandler(this.TeerlingLabel_Click);
      // 
      // TeerlingWerpen
      // 
      this.TeerlingWerpen.Location = new System.Drawing.Point(3, 154);
      this.TeerlingWerpen.Name = "TeerlingWerpen";
      this.TeerlingWerpen.Size = new System.Drawing.Size(128, 35);
      this.TeerlingWerpen.TabIndex = 3;
      this.TeerlingWerpen.Text = "Werp";
      this.TeerlingWerpen.UseVisualStyleBackColor = true;
      this.TeerlingWerpen.Click += new System.EventHandler(this.TeerlingWerpen_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(128, 23);
      this.label1.TabIndex = 4;
      this.label1.Text = "TeerlingIndex";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.AutoSize = true;
      this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.flowLayoutPanel1.Controls.Add(this.label1);
      this.flowLayoutPanel1.Controls.Add(this.TeerlingLabel);
      this.flowLayoutPanel1.Controls.Add(this.TeerlingWerpen);
      this.flowLayoutPanel1.Controls.Add(this.nr1);
      this.flowLayoutPanel1.Controls.Add(this.nr2);
      this.flowLayoutPanel1.Controls.Add(this.nr3);
      this.flowLayoutPanel1.Controls.Add(this.nr4);
      this.flowLayoutPanel1.Controls.Add(this.nr5);
      this.flowLayoutPanel1.Controls.Add(this.nr6);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(134, 387);
      this.flowLayoutPanel1.TabIndex = 5;
      // 
      // nr1
      // 
      this.nr1.Location = new System.Drawing.Point(3, 195);
      this.nr1.Name = "nr1";
      this.nr1.Size = new System.Drawing.Size(75, 23);
      this.nr1.TabIndex = 5;
      this.nr1.Text = "1";
      this.nr1.Visible = false;
      this.nr1.Click += new System.EventHandler(this.nr1_Click);
      // 
      // nr2
      // 
      this.nr2.Location = new System.Drawing.Point(3, 224);
      this.nr2.Name = "nr2";
      this.nr2.Size = new System.Drawing.Size(75, 23);
      this.nr2.TabIndex = 6;
      this.nr2.Text = "2";
      this.nr2.Visible = false;
      this.nr2.Click += new System.EventHandler(this.nr2_Click);
      // 
      // nr3
      // 
      this.nr3.Location = new System.Drawing.Point(3, 253);
      this.nr3.Name = "nr3";
      this.nr3.Size = new System.Drawing.Size(75, 23);
      this.nr3.TabIndex = 7;
      this.nr3.Text = "3";
      this.nr3.Visible = false;
      this.nr3.Click += new System.EventHandler(this.nr3_Click);
      // 
      // nr4
      // 
      this.nr4.Location = new System.Drawing.Point(3, 282);
      this.nr4.Name = "nr4";
      this.nr4.Size = new System.Drawing.Size(75, 23);
      this.nr4.TabIndex = 8;
      this.nr4.Text = "4";
      this.nr4.Visible = false;
      this.nr4.Click += new System.EventHandler(this.nr4_Click);
      // 
      // nr5
      // 
      this.nr5.Location = new System.Drawing.Point(3, 311);
      this.nr5.Name = "nr5";
      this.nr5.Size = new System.Drawing.Size(75, 23);
      this.nr5.TabIndex = 9;
      this.nr5.Text = "5";
      this.nr5.Visible = false;
      this.nr5.Click += new System.EventHandler(this.nr5_Click);
      // 
      // nr6
      // 
      this.nr6.Location = new System.Drawing.Point(3, 340);
      this.nr6.Name = "nr6";
      this.nr6.Size = new System.Drawing.Size(75, 23);
      this.nr6.TabIndex = 10;
      this.nr6.Text = "6";
      this.nr6.Visible = false;
      this.nr6.Click += new System.EventHandler(this.nr6_Click);
      // 
      // TeerlingView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.flowLayoutPanel1);
      this.Name = "TeerlingView";
      this.Size = new System.Drawing.Size(134, 387);
      this.flowLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TeerlingLabel;
		private System.Windows.Forms.Button TeerlingWerpen;
		private System.Windows.Forms.Label label1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Button nr2;
    private System.Windows.Forms.Button nr3;
    private System.Windows.Forms.Button nr1;
    private System.Windows.Forms.Button nr4;
    private System.Windows.Forms.Button nr5;
    private System.Windows.Forms.Button nr6;
	}
}

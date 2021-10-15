
namespace WinFormsApp3
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.hour0 = new WinFormsApp3.DigitDisplay();
			this.hour1 = new WinFormsApp3.DigitDisplay();
			this.min0 = new WinFormsApp3.DigitDisplay();
			this.min1 = new WinFormsApp3.DigitDisplay();
			this.sec1 = new WinFormsApp3.DigitDisplay();
			this.sec0 = new WinFormsApp3.DigitDisplay();
			this.SuspendLayout();
			// 
			// hour0
			// 
			this.hour0.Location = new System.Drawing.Point(12, 41);
			this.hour0.Name = "hour0";
			this.hour0.Size = new System.Drawing.Size(186, 361);
			this.hour0.TabIndex = 0;
			// 
			// hour1
			// 
			this.hour1.Location = new System.Drawing.Point(204, 41);
			this.hour1.Name = "hour1";
			this.hour1.Size = new System.Drawing.Size(186, 361);
			this.hour1.TabIndex = 1;
			// 
			// min0
			// 
			this.min0.Location = new System.Drawing.Point(503, 41);
			this.min0.Name = "min0";
			this.min0.Size = new System.Drawing.Size(186, 361);
			this.min0.TabIndex = 2;
			// 
			// min1
			// 
			this.min1.Location = new System.Drawing.Point(695, 41);
			this.min1.Name = "min1";
			this.min1.Size = new System.Drawing.Size(186, 361);
			this.min1.TabIndex = 3;
			// 
			// sec1
			// 
			this.sec1.Location = new System.Drawing.Point(1189, 41);
			this.sec1.Name = "sec1";
			this.sec1.Size = new System.Drawing.Size(186, 361);
			this.sec1.TabIndex = 5;
			// 
			// sec0
			// 
			this.sec0.Location = new System.Drawing.Point(997, 41);
			this.sec0.Name = "sec0";
			this.sec0.Size = new System.Drawing.Size(186, 361);
			this.sec0.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1401, 450);
			this.Controls.Add(this.sec1);
			this.Controls.Add(this.sec0);
			this.Controls.Add(this.min1);
			this.Controls.Add(this.min0);
			this.Controls.Add(this.hour1);
			this.Controls.Add(this.hour0);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private DigitDisplay hour0;
		private DigitDisplay hour1;
		private DigitDisplay min0;
		private DigitDisplay min1;
		private DigitDisplay sec1;
		private DigitDisplay sec0;
	}
}


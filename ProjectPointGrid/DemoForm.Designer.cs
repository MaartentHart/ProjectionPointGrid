
namespace ProjectPointGrid
{
	partial class DemoForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.numGeneration = new System.Windows.Forms.NumericUpDown();
			this.numIndex = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.lblAmount = new System.Windows.Forms.Label();
			this.tbPoint = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numGeneration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numIndex)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Generation:";
			// 
			// numGeneration
			// 
			this.numGeneration.Location = new System.Drawing.Point(101, 7);
			this.numGeneration.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
			this.numGeneration.Name = "numGeneration";
			this.numGeneration.Size = new System.Drawing.Size(120, 22);
			this.numGeneration.TabIndex = 1;
			this.numGeneration.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.numGeneration.ValueChanged += new System.EventHandler(this.NumGeneration_ValueChanged);
			// 
			// numIndex
			// 
			this.numIndex.Location = new System.Drawing.Point(101, 35);
			this.numIndex.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.numIndex.Name = "numIndex";
			this.numIndex.Size = new System.Drawing.Size(120, 22);
			this.numIndex.TabIndex = 3;
			this.numIndex.ValueChanged += new System.EventHandler(this.NumIndex_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Index:";
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.Location = new System.Drawing.Point(227, 37);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(84, 17);
			this.lblAmount.TabIndex = 4;
			this.lblAmount.Text = "of ... indices";
			// 
			// tbPoint
			// 
			this.tbPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPoint.Location = new System.Drawing.Point(101, 63);
			this.tbPoint.Name = "tbPoint";
			this.tbPoint.ReadOnly = true;
			this.tbPoint.Size = new System.Drawing.Size(446, 22);
			this.tbPoint.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Point:";
			// 
			// DemoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 99);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbPoint);
			this.Controls.Add(this.lblAmount);
			this.Controls.Add(this.numIndex);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numGeneration);
			this.Controls.Add(this.label1);
			this.Name = "DemoForm";
			this.Text = "Projection Point Geodesic Grid Demo";
			((System.ComponentModel.ISupportInitialize)(this.numGeneration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numIndex)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numGeneration;
		private System.Windows.Forms.NumericUpDown numIndex;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.TextBox tbPoint;
		private System.Windows.Forms.Label label4;
	}
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPointGrid
{
	public partial class DemoForm : Form
	{
		public GridParameters Parameters { get; set; }
		public int Generation => (int)numGeneration.Value;
		public long Index => (long)numIndex.Value; 
		public DemoForm()
		{
			InitializeComponent();
			SetIndicesCount();
		}

		private void SetIndicesCount()
		{
			Parameters = GridParameters.GetGridParameters(Generation);
			lblAmount.Text = "of " + Parameters.PointCount + " indices";
			numIndex.Value = 0; 
			numIndex.Maximum = Parameters.PointCount - 1;
			SetPoint(); 
		}

		private void SetPoint()
		{
			GridPoint point = new GridPoint(Generation, Index);
			tbPoint.Text = point.Point.ToString(); 
		}

		private void NumGeneration_ValueChanged(object sender, EventArgs e)
		{
			SetIndicesCount(); 
		}

		private void NumIndex_ValueChanged(object sender, EventArgs e)
		{
			SetPoint(); 
		}
	}
}

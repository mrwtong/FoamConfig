using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoamCongfig.ConfigPanels
{
	public partial class SolutionLineatSubPanel : UserControl
	{
		public SolutionLineatSubPanel()
		{
			InitializeComponent();
			this.sweepcomboBox1.SelectedIndex = 0;
			this.perconditionercomboBox.SelectedIndex = 0;
			this.smoothercomboBox.SelectedIndex = 0;
			this.solvercomboBox.SelectedIndex = 0;
		}
		public SolutionLineatSubPanel(System.Windows.Forms.Panel container)
		{
			container.Controls.Add(this);
			InitializeComponent();
			this.sweepcomboBox1.SelectedIndex = 0;
		    this.perconditionercomboBox.SelectedIndex = 0;
			this.smoothercomboBox.SelectedIndex = 0;
			this.solvercomboBox.SelectedIndex = 0;
		}

		private void solvercomboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.solvercomboBox.SelectedIndex==1|| this.solvercomboBox.SelectedIndex == 2|| this.solvercomboBox.SelectedIndex == 3)
			{
				this.perconditionercomboBox.Enabled = true;
				this.perconditionerLabel.Enabled = true;

			}
			else
			{
				this.perconditionercomboBox.Enabled = false;
				this.perconditionerLabel.Enabled = false;
			}
		}

		private void smoothercomboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.smoothercomboBox.SelectedIndex != 0)
			{
				this.sweepcomboBox1.Enabled = true;
				this.sweeplable.Enabled = true;

			}
			else
			{
				this.sweepcomboBox1.Enabled = false;
				this.sweeplable.Enabled = false;
			}
		}

		
	}
}

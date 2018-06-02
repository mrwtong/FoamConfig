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
	public partial class SolutionNonLinear : UserControl
	{
		public SolutionNonLinear()
		{
			InitializeComponent();
			this.momentumPredictorboBox1.SelectedIndex = 1;

		}

		private void SolutionNonLinear_Load(object sender, EventArgs e)
		{
			this.nonlinermethondcomboBox.SelectedIndex = 0;
		}

		private void nonlinermethondcomboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.nonlinermethondcomboBox.SelectedIndex==2)
			{
				this.nOuterCorrectorsLabel.Enabled = true;
				this.nOuterCorrectorsLabeltextBox.Enabled = true;
			}
			else
			{
				this.nOuterCorrectorsLabel.Enabled = false;
				this.nOuterCorrectorsLabeltextBox.Enabled = false;
			}
			if(this.nonlinermethondcomboBox.SelectedIndex==0)
			{
				this.nCorrectorslabel.Enabled = true;
				this.nCorrectorstextBox.Enabled = true;

			}
			else
			{
				this.nCorrectorslabel.Enabled = false;
				this.nCorrectorstextBox.Enabled = false;
			}

		}
	}
}

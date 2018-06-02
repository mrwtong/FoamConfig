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
	public partial class SolutionLinear : UserControl
	{
		public SolutionLinear()
		{
			InitializeComponent();
		}

		private void linerfieldComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.linersettingPanel.Controls.Clear();
			this.linersettingPanel.Controls.Add(linearsolversetting[this.linerfieldComboBox.SelectedIndex]);
			
		}

		private void SolutionLinear_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < ModelParameter.fieldNumber; i++)
			{

				this.linerfieldComboBox.Items.Add(ModelParameter.Field[i]);
				if (linearsolversetting[i] == null)
					linearsolversetting[i] = new SolutionLineatSubPanel(this.linersettingPanel)
					{
						Dock = System.Windows.Forms.DockStyle.Fill
					};

			}
			this.linerfieldComboBox.SelectedIndex = 0;
		}
	}
}

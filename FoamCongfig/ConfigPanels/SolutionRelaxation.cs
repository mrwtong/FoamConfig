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
	public partial class SolutionRelaxation : UserControl
	{
		public SolutionRelaxation()
		{
			InitializeComponent();
		}

		private void SolutionRelaxation_Load(object sender, EventArgs e)
		{
			
			for (int i = 0; i < ModelParameter.fieldNumber; i++)
			{
				fieldRelaxations[i] = new fieldRelaxation();
				this.fieldComboBox.Items.Add(ModelParameter.Field[i]);
			}
			this.fieldComboBox.SelectedIndex = 0;
		}

		private void fieldComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.settingPanel.Controls.Clear();
			if (fieldRelaxations[this.fieldComboBox.SelectedIndex] == null)
				fieldRelaxations[this.fieldComboBox.SelectedIndex]=new fieldRelaxation();
			this.AddComponent(fieldRelaxations[this.fieldComboBox.SelectedIndex]);
		}
		
	}
}

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
	public partial class SchemeGradientPanel : UserControl
	{
		public SchemeGradientPanel()
		{
			InitializeComponent();
		}

		private void SchemeGradientPanel_Load(object sender, EventArgs e)
		{
			this.gradientDefaultcomboBox.SelectedIndex = 0;
			this.gradSngradcomboBox.SelectedIndex = 0;
		}

		private void gradientDefaultcheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if(this.gradientDefaultcheckBox.Checked==false)
			{
				this.gradientDefaultlabel.Enabled= false;
				this.gradientDefaultcomboBox.Enabled = false;
				this.gradSngradcomboBox.Enabled = false;
				this.gradSnDefaultlabel.Enabled = false;
				this.snCorrectedtextBox.Enabled = false;
				this.snCorrectlabel.Enabled = false;
			}
			else
			{
				this.gradientDefaultlabel.Enabled = true;
				this.gradientDefaultcomboBox.Enabled = true;
				this.gradSngradcomboBox.Enabled = true;
				this.gradSnDefaultlabel.Enabled = true;
				this.snCorrectedtextBox.Enabled = true;
				this.snCorrectlabel.Enabled = true;
			}
		}

		private void gradSngradcomboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.gradSngradcomboBox.SelectedIndex==0|| this.gradSngradcomboBox.SelectedIndex == 2)
			{
				this.snCorrectlabel.Enabled = true;
				this.snCorrectedtextBox.Enabled = true;
			}
			else
			{
				this.snCorrectlabel.Enabled = false;
				this.snCorrectedtextBox.Enabled = false;
			}
		}
	}
}


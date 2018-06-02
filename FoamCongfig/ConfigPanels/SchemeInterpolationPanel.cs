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
	public partial class SchemeInterpolationPanel : UserControl
	{
		public SchemeInterpolationPanel()
		{
			InitializeComponent();
		}

		private void InterpolationDefaultcheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if(this.InterpolationDefaultcheckBox.Checked==false)
			{
				this.InterpolationDefaultcomboBox.Enabled = false;
				this.InterpolationDefaultlabel.Enabled = false;

			}
			else
			{
				this.InterpolationDefaultcomboBox.Enabled = true;
				this.InterpolationDefaultlabel.Enabled = true;
			}
		}

		private void SchemeInterpolationPanel_Load(object sender, EventArgs e)
		{
			this.InterpolationDefaultcomboBox.SelectedIndex = 0;
		}
	}
}

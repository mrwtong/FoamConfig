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
	public partial class SchemeLaplacianPanel : UserControl
	{
		public SchemeLaplacianPanel()
		{
			InitializeComponent();
		}

		private void SchemeLaplacianPanel_Load(object sender, EventArgs e)
		{
			this.laplacianDefaultcomboBox.SelectedIndex = 0;
		}

		private void laplacianDefaultcheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.laplacianDefaultcheckBox.Checked == false)
			{
				this.laplacianDefaultcomboBox.Enabled = false;
				this.laplacianDefaultlabel.Enabled = false;
			}
			else
			{
				this.laplacianDefaultcomboBox.Enabled = true;
				this.laplacianDefaultlabel.Enabled = true;
			}
		}
	}
}

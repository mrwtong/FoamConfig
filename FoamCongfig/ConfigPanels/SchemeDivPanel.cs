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
	public partial class SchemeDivPanel : UserControl
	{
		public SchemeDivPanel()
		{
			InitializeComponent();
		}

		private void SchemesFirst_Load(object sender, EventArgs e)
		{
			this.divDefaultcomboBox.SelectedIndex = 0;
		}

		private void divDefaultcheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if(this.divDefaultcheckBox.Checked==false)
			{
				this.divDefaultlabel.Enabled = false;
				this.divDefaultcomboBox.Enabled = false;
			}
			else
			{
				this.divDefaultcomboBox.Enabled = true;
				this.divDefaultlabel.Enabled = true;
			}
		}
	}
}

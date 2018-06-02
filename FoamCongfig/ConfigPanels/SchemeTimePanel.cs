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
	public partial class SchemeTimePanel : UserControl
	{
		public SchemeTimePanel()
		{
			InitializeComponent();
		}

		
		private void SchemeTimePanel_Load(object sender, EventArgs e)
		{
			this.timeDefaultcomboBox.SelectedIndex = 0;
			
		}

		private void timeDefaultcheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if(this.timeDefaultcheckBox.Checked==false)
			{
				this.timedefaultlabel.Enabled = false;
				this.timeDefaultcomboBox.Enabled = false;
				this.CrankNicolsonlabel.Enabled = false;
				this.CrankNicolsontextBox.Enabled = false;

			}
			else
			{
				this.timedefaultlabel.Enabled = true;
				this.timeDefaultcomboBox.Enabled = true;
				this.CrankNicolsonlabel.Enabled = true;
				this.CrankNicolsontextBox.Enabled = true;
			}
		}

		private void timeDefaultcomboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.timeDefaultcomboBox.SelectedIndex==3)
			{
				this.CrankNicolsonlabel.Enabled = true;
				this.CrankNicolsontextBox.Enabled = true;
			}
			else
			{
				this.CrankNicolsonlabel.Enabled = false;
				this.CrankNicolsontextBox.Enabled = false;
			}
		}

		private void timeSplitgroupBox_Enter(object sender, EventArgs e)
		{

		}

		private void defaultlabel_Click(object sender, EventArgs e)
		{

		}
	}
}

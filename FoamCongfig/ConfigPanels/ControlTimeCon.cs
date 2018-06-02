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
	public partial class ControlTimeCon : UserControl
	{
		public ControlTimeCon()
		{
			InitializeComponent();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			//限制输入，只能为整数
			if ((e.KeyChar <= 48 || e.KeyChar >= 57) && (e.KeyChar != 8) && (e.KeyChar != 46))
				e.Handled = true;
			//48代表0，57代表9，8代表空格，46代表小数点  
		}

		private void ControlTimeCon_Load(object sender, EventArgs e)
		{
		
			//combobox default selected item
			this.startFromCombo.SelectedIndex = 1;
			this.stopAtCombo.SelectedIndex = 0;
			this.startTimeUnitCombo.SelectedIndex = 0;
			this.endTimeUnitCombo.SelectedIndex = 0;
			this.timeStepCombo.SelectedIndex = 0;

		}

		private void ComboStartFrom_SelectedIndexChanged(object sender, EventArgs e)
		{
			if((String)this.startFromCombo.SelectedItem!= "start Time")
			{
				this.startTimeLable.Enabled = false;
				this.startTimeTextbox.Enabled = false;
				this.startTimeUnitCombo.Enabled = false;
			}else
			{
				this.startTimeLable.Enabled = true;
				this.startTimeTextbox.Enabled = true;
				this.startTimeUnitCombo.Enabled = true
					;
			}
		}

		private void stopAtCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((String)this.stopAtCombo.SelectedItem != "end Time")
			{
				this.endTimeLable.Enabled = false;
				this.endTimeTextBox.Enabled = false;
				this.endTimeUnitCombo.Enabled = false;
			}
			else
			{
				this.endTimeLable.Enabled = true;
				this.endTimeTextBox.Enabled = true;
				this.endTimeUnitCombo.Enabled = true;
			}
		}
	}
}

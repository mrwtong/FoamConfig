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
	public partial class ControlDataWriting : UserControl
	{
		public ControlDataWriting()
		{
			InitializeComponent();
		}

		private void ControlDataWriting_Load(object sender, EventArgs e)
		{
			this.comboCompression.SelectedIndex = 1;
			this.comboGraphFormat.SelectedIndex = 0;
			this.comboTimeFormat.SelectedIndex = 0;
			this.comboWritePrecision.SelectedIndex = 0;
			this.ComboWriteFormat.SelectedIndex = 0;
			this.comboTimePrecision.SelectedIndex = 0;
	
		}

		private void writeIntervalTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			//限制输入，只能为整数
			if ((e.KeyChar <= 48 || e.KeyChar >= 57) && (e.KeyChar != 8) && (e.KeyChar != 46))
				e.Handled = true;
			//48代表0，57代表9，8代表空格，46代表小数点  
		}

		private void writeIntervalTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void writeIntervalTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			//限制输入，只能为整数
			if ((e.KeyChar <= 48 || e.KeyChar >= 57) && (e.KeyChar != 8) && (e.KeyChar != 46))
				e.Handled = true;
			//48代表0，57代表9，8代表空格，46代表小数点  
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoamCongfig
{
	public partial class Launcher : Form
	{
		public Launcher()
		{
			InitializeComponent();
		}
			

		private void button2_Click(object sender, EventArgs e)
		{
			CasePath.casePath = this.textBox1.Text;
			if (CasePath.casePath!=null && System.IO.Directory.Exists((CasePath.casePath)))
			{
				if(ParallelButton.Checked==true)
				DecomposeParDict.numberOfSubdomains = (int)numericUpDown1.Value;
				this.DialogResult = DialogResult.OK;

			}
			else if(CasePath.casePath == null)
			{
				MessageBox.Show("No Path Is Selected");
			}
			else if(CasePath.casePath != null && !System.IO.Directory.Exists((CasePath.casePath)))
			{
				MessageBox.Show("Invalid Path");
			}
		}
		

		private void button1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.Description = "Select Case Dir Path";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				CasePath.casePath = dialog.SelectedPath;
				this.textBox1.Text = CasePath.casePath;
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if(this.SerialButton.Checked== false)
			{
				this.ProcessesLable.Enabled = true;
				this.numericUpDown1.Enabled = true;
			}
			if(this.SerialButton.Checked == true)
			{
				this.ProcessesLable.Enabled = false;
				this.numericUpDown1.Enabled = false;
			}
		}

		private void Launcher_Load(object sender, EventArgs e)
		{

		}
	}
}
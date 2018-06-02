using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoamCongfig
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		
		static void Main()
		{

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
		    Launcher laucher = new Launcher();
			laucher.ShowDialog();
			if (laucher.DialogResult == DialogResult.OK)
			{
				laucher.Dispose();
				Application.Run(new MainForm());
			}
			
			

		}

		

	}
	

}


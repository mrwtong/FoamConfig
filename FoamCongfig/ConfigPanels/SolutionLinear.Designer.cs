namespace FoamCongfig.ConfigPanels
{
	partial class SolutionLinear
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.linersettingPanel = new System.Windows.Forms.Panel();
			this.timeSplitgroupBox = new System.Windows.Forms.GroupBox();
			this.linerfieldComboBox = new System.Windows.Forms.ComboBox();
			this.linerselectedFieldlabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// linersettingPanel
			// 
			this.linersettingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.linersettingPanel.Location = new System.Drawing.Point(0, 60);
			this.linersettingPanel.Name = "linersettingPanel";
			this.linersettingPanel.Size = new System.Drawing.Size(620, 396);
			this.linersettingPanel.TabIndex = 26;
			// 
			// timeSplitgroupBox
			// 
			this.timeSplitgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timeSplitgroupBox.Location = new System.Drawing.Point(13, 44);
			this.timeSplitgroupBox.Name = "timeSplitgroupBox";
			this.timeSplitgroupBox.Size = new System.Drawing.Size(594, 10);
			this.timeSplitgroupBox.TabIndex = 25;
			this.timeSplitgroupBox.TabStop = false;
			// 
			// linerfieldComboBox
			// 
			this.linerfieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.linerfieldComboBox.FormattingEnabled = true;
			this.linerfieldComboBox.Location = new System.Drawing.Point(92, 15);
			this.linerfieldComboBox.Name = "linerfieldComboBox";
			this.linerfieldComboBox.Size = new System.Drawing.Size(96, 23);
			this.linerfieldComboBox.TabIndex = 24;
			this.linerfieldComboBox.SelectedIndexChanged += new System.EventHandler(this.linerfieldComboBox_SelectedIndexChanged);
			// 
			// linerselectedFieldlabel
			// 
			this.linerselectedFieldlabel.AutoSize = true;
			this.linerselectedFieldlabel.Location = new System.Drawing.Point(17, 18);
			this.linerselectedFieldlabel.Name = "linerselectedFieldlabel";
			this.linerselectedFieldlabel.Size = new System.Drawing.Size(55, 15);
			this.linerselectedFieldlabel.TabIndex = 23;
			this.linerselectedFieldlabel.Text = "Fields";
			// 
			// SolutionLinear
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.linersettingPanel);
			this.Controls.Add(this.timeSplitgroupBox);
			this.Controls.Add(this.linerfieldComboBox);
			this.Controls.Add(this.linerselectedFieldlabel);
			this.MinimumSize = new System.Drawing.Size(620, 456);
			this.Name = "SolutionLinear";
			this.Size = new System.Drawing.Size(620, 456);
			this.Load += new System.EventHandler(this.SolutionLinear_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel linersettingPanel;
		private System.Windows.Forms.GroupBox timeSplitgroupBox;
		public System.Windows.Forms.ComboBox linerfieldComboBox;
		private System.Windows.Forms.Label linerselectedFieldlabel;
		public SolutionLineatSubPanel[] linearsolversetting = new SolutionLineatSubPanel[ModelParameter.fieldNumber]; 
	}
}

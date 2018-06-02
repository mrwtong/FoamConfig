namespace FoamCongfig.ConfigPanels
{
	partial class SchemeInterpolationPanel
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
			this.timeSplitgroupBox = new System.Windows.Forms.GroupBox();
			this.InterpolationDefaultcomboBox = new System.Windows.Forms.ComboBox();
			this.InterpolationDefaultcheckBox = new System.Windows.Forms.CheckBox();
			this.InterpolationDefaultlabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timeSplitgroupBox
			// 
			this.timeSplitgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timeSplitgroupBox.Location = new System.Drawing.Point(5, 57);
			this.timeSplitgroupBox.Name = "timeSplitgroupBox";
			this.timeSplitgroupBox.Size = new System.Drawing.Size(594, 10);
			this.timeSplitgroupBox.TabIndex = 18;
			this.timeSplitgroupBox.TabStop = false;
			// 
			// InterpolationDefaultcomboBox
			// 
			this.InterpolationDefaultcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.InterpolationDefaultcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InterpolationDefaultcomboBox.FormattingEnabled = true;
			this.InterpolationDefaultcomboBox.Items.AddRange(new object[] {
            "Gauss linear",
            "Gauss cubic"});
			this.InterpolationDefaultcomboBox.Location = new System.Drawing.Point(446, 23);
			this.InterpolationDefaultcomboBox.Name = "InterpolationDefaultcomboBox";
			this.InterpolationDefaultcomboBox.Size = new System.Drawing.Size(151, 23);
			this.InterpolationDefaultcomboBox.TabIndex = 17;
			// 
			// InterpolationDefaultcheckBox
			// 
			this.InterpolationDefaultcheckBox.AutoSize = true;
			this.InterpolationDefaultcheckBox.Checked = true;
			this.InterpolationDefaultcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.InterpolationDefaultcheckBox.Location = new System.Drawing.Point(23, 22);
			this.InterpolationDefaultcheckBox.Name = "InterpolationDefaultcheckBox";
			this.InterpolationDefaultcheckBox.Size = new System.Drawing.Size(189, 19);
			this.InterpolationDefaultcheckBox.TabIndex = 16;
			this.InterpolationDefaultcheckBox.Text = "Set Terms As Default";
			this.InterpolationDefaultcheckBox.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.InterpolationDefaultcheckBox.UseVisualStyleBackColor = true;
			this.InterpolationDefaultcheckBox.CheckedChanged += new System.EventHandler(this.InterpolationDefaultcheckBox_CheckedChanged);
			// 
			// InterpolationDefaultlabel
			// 
			this.InterpolationDefaultlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.InterpolationDefaultlabel.AutoSize = true;
			this.InterpolationDefaultlabel.Location = new System.Drawing.Point(371, 26);
			this.InterpolationDefaultlabel.Name = "InterpolationDefaultlabel";
			this.InterpolationDefaultlabel.Size = new System.Drawing.Size(63, 15);
			this.InterpolationDefaultlabel.TabIndex = 15;
			this.InterpolationDefaultlabel.Text = "Default";
			// 
			// SchemeInterpolationPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.timeSplitgroupBox);
			this.Controls.Add(this.InterpolationDefaultcomboBox);
			this.Controls.Add(this.InterpolationDefaultcheckBox);
			this.Controls.Add(this.InterpolationDefaultlabel);
			this.MinimumSize = new System.Drawing.Size(620, 456);
			this.Name = "SchemeInterpolationPanel";
			this.Size = new System.Drawing.Size(620, 456);
			this.Load += new System.EventHandler(this.SchemeInterpolationPanel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox timeSplitgroupBox;
		public System.Windows.Forms.ComboBox InterpolationDefaultcomboBox;
		public System.Windows.Forms.CheckBox InterpolationDefaultcheckBox;
		private System.Windows.Forms.Label InterpolationDefaultlabel;
	}
}

namespace FoamCongfig.ConfigPanels
{
	partial class SchemeDivPanel
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
			this.divDefaultcomboBox = new System.Windows.Forms.ComboBox();
			this.divDefaultcheckBox = new System.Windows.Forms.CheckBox();
			this.divDefaultlabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timeSplitgroupBox
			// 
			this.timeSplitgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timeSplitgroupBox.Location = new System.Drawing.Point(12, 55);
			this.timeSplitgroupBox.Name = "timeSplitgroupBox";
			this.timeSplitgroupBox.Size = new System.Drawing.Size(594, 10);
			this.timeSplitgroupBox.TabIndex = 10;
			this.timeSplitgroupBox.TabStop = false;
			// 
			// divDefaultcomboBox
			// 
			this.divDefaultcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.divDefaultcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.divDefaultcomboBox.FormattingEnabled = true;
			this.divDefaultcomboBox.Items.AddRange(new object[] {
            "Gauss linear",
            "Gauss upwind",
            "Gauss limitedLinear",
            "Gauss LUST",
            "Gauss linearUpwind"});
			this.divDefaultcomboBox.Location = new System.Drawing.Point(385, 21);
			this.divDefaultcomboBox.Name = "divDefaultcomboBox";
			this.divDefaultcomboBox.Size = new System.Drawing.Size(207, 23);
			this.divDefaultcomboBox.TabIndex = 9;
			// 
			// divDefaultcheckBox
			// 
			this.divDefaultcheckBox.AutoSize = true;
			this.divDefaultcheckBox.Checked = true;
			this.divDefaultcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.divDefaultcheckBox.Location = new System.Drawing.Point(30, 20);
			this.divDefaultcheckBox.Name = "divDefaultcheckBox";
			this.divDefaultcheckBox.Size = new System.Drawing.Size(189, 19);
			this.divDefaultcheckBox.TabIndex = 8;
			this.divDefaultcheckBox.Text = "Set Terms As Default";
			this.divDefaultcheckBox.UseVisualStyleBackColor = true;
			this.divDefaultcheckBox.CheckedChanged += new System.EventHandler(this.divDefaultcheckBox_CheckedChanged);
			// 
			// divDefaultlabel
			// 
			this.divDefaultlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.divDefaultlabel.AutoSize = true;
			this.divDefaultlabel.Location = new System.Drawing.Point(316, 24);
			this.divDefaultlabel.Name = "divDefaultlabel";
			this.divDefaultlabel.Size = new System.Drawing.Size(63, 15);
			this.divDefaultlabel.TabIndex = 7;
			this.divDefaultlabel.Text = "Default";
			// 
			// SchemeDivPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.timeSplitgroupBox);
			this.Controls.Add(this.divDefaultcomboBox);
			this.Controls.Add(this.divDefaultcheckBox);
			this.Controls.Add(this.divDefaultlabel);
			this.MinimumSize = new System.Drawing.Size(620, 456);
			this.Name = "SchemeDivPanel";
			this.Size = new System.Drawing.Size(620, 456);
			this.Load += new System.EventHandler(this.SchemesFirst_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox timeSplitgroupBox;
		public System.Windows.Forms.ComboBox divDefaultcomboBox;
		public System.Windows.Forms.CheckBox divDefaultcheckBox;
		private System.Windows.Forms.Label divDefaultlabel;
	}
}

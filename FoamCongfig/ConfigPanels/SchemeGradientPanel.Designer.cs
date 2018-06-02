namespace FoamCongfig.ConfigPanels
{
	partial class SchemeGradientPanel
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
			this.gradientDefaultcomboBox = new System.Windows.Forms.ComboBox();
			this.gradientDefaultcheckBox = new System.Windows.Forms.CheckBox();
			this.gradientDefaultlabel = new System.Windows.Forms.Label();
			this.timeSplitgroupBox = new System.Windows.Forms.GroupBox();
			this.gradSnDefaultlabel = new System.Windows.Forms.Label();
			this.gradSngradcomboBox = new System.Windows.Forms.ComboBox();
			this.snCorrectlabel = new System.Windows.Forms.Label();
			this.snCorrectedtextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// gradientDefaultcomboBox
			// 
			this.gradientDefaultcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gradientDefaultcomboBox.FormattingEnabled = true;
			this.gradientDefaultcomboBox.Items.AddRange(new object[] {
            "Gauss linear",
            "cellLimited Gauss linear",
            "least Squares",
            "Gauss cubic:"});
			this.gradientDefaultcomboBox.Location = new System.Drawing.Point(384, 38);
			this.gradientDefaultcomboBox.Name = "gradientDefaultcomboBox";
			this.gradientDefaultcomboBox.Size = new System.Drawing.Size(207, 23);
			this.gradientDefaultcomboBox.TabIndex = 5;
			// 
			// gradientDefaultcheckBox
			// 
			this.gradientDefaultcheckBox.AutoSize = true;
			this.gradientDefaultcheckBox.Checked = true;
			this.gradientDefaultcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.gradientDefaultcheckBox.Location = new System.Drawing.Point(29, 37);
			this.gradientDefaultcheckBox.Name = "gradientDefaultcheckBox";
			this.gradientDefaultcheckBox.Size = new System.Drawing.Size(189, 19);
			this.gradientDefaultcheckBox.TabIndex = 4;
			this.gradientDefaultcheckBox.Text = "Set Terms As Default";
			this.gradientDefaultcheckBox.UseVisualStyleBackColor = true;
			this.gradientDefaultcheckBox.CheckedChanged += new System.EventHandler(this.gradientDefaultcheckBox_CheckedChanged);
			// 
			// gradientDefaultlabel
			// 
			this.gradientDefaultlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gradientDefaultlabel.AutoSize = true;
			this.gradientDefaultlabel.Location = new System.Drawing.Point(281, 41);
			this.gradientDefaultlabel.Name = "gradientDefaultlabel";
			this.gradientDefaultlabel.Size = new System.Drawing.Size(95, 15);
			this.gradientDefaultlabel.TabIndex = 3;
			this.gradientDefaultlabel.Text = "GradDefault";
			// 
			// timeSplitgroupBox
			// 
			this.timeSplitgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timeSplitgroupBox.Location = new System.Drawing.Point(12, 135);
			this.timeSplitgroupBox.Name = "timeSplitgroupBox";
			this.timeSplitgroupBox.Size = new System.Drawing.Size(594, 10);
			this.timeSplitgroupBox.TabIndex = 6;
			this.timeSplitgroupBox.TabStop = false;
			// 
			// gradSnDefaultlabel
			// 
			this.gradSnDefaultlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gradSnDefaultlabel.AutoSize = true;
			this.gradSnDefaultlabel.Location = new System.Drawing.Point(263, 79);
			this.gradSnDefaultlabel.Name = "gradSnDefaultlabel";
			this.gradSnDefaultlabel.Size = new System.Drawing.Size(111, 15);
			this.gradSnDefaultlabel.TabIndex = 3;
			this.gradSnDefaultlabel.Text = "snGradDefault";
			// 
			// gradSngradcomboBox
			// 
			this.gradSngradcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.gradSngradcomboBox.FormattingEnabled = true;
			this.gradSngradcomboBox.Items.AddRange(new object[] {
            "corrected",
            "uncorrected",
            "limited corrected ",
            "orthogonal"});
			this.gradSngradcomboBox.Location = new System.Drawing.Point(384, 76);
			this.gradSngradcomboBox.Name = "gradSngradcomboBox";
			this.gradSngradcomboBox.Size = new System.Drawing.Size(207, 23);
			this.gradSngradcomboBox.TabIndex = 5;
			this.gradSngradcomboBox.SelectedIndexChanged += new System.EventHandler(this.gradSngradcomboBox_SelectedIndexChanged);
			// 
			// snCorrectlabel
			// 
			this.snCorrectlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.snCorrectlabel.AutoSize = true;
			this.snCorrectlabel.Location = new System.Drawing.Point(263, 117);
			this.snCorrectlabel.Name = "snCorrectlabel";
			this.snCorrectlabel.Size = new System.Drawing.Size(95, 15);
			this.snCorrectlabel.TabIndex = 3;
			this.snCorrectlabel.Text = "snCorrected";
			// 
			// snCorrectedtextBox
			// 
			this.snCorrectedtextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.snCorrectedtextBox.Location = new System.Drawing.Point(547, 109);
			this.snCorrectedtextBox.Name = "snCorrectedtextBox";
			this.snCorrectedtextBox.Size = new System.Drawing.Size(44, 25);
			this.snCorrectedtextBox.TabIndex = 7;
			this.snCorrectedtextBox.Text = "0.33";
			// 
			// SchemeGradientPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.snCorrectedtextBox);
			this.Controls.Add(this.timeSplitgroupBox);
			this.Controls.Add(this.gradSngradcomboBox);
			this.Controls.Add(this.gradientDefaultcomboBox);
			this.Controls.Add(this.snCorrectlabel);
			this.Controls.Add(this.gradSnDefaultlabel);
			this.Controls.Add(this.gradientDefaultcheckBox);
			this.Controls.Add(this.gradientDefaultlabel);
			this.MinimumSize = new System.Drawing.Size(620, 456);
			this.Name = "SchemeGradientPanel";
			this.Size = new System.Drawing.Size(620, 456);
			this.Load += new System.EventHandler(this.SchemeGradientPanel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.ComboBox gradientDefaultcomboBox;
		public System.Windows.Forms.CheckBox gradientDefaultcheckBox;
		private System.Windows.Forms.Label gradientDefaultlabel;
		private System.Windows.Forms.GroupBox timeSplitgroupBox;
		private System.Windows.Forms.Label gradSnDefaultlabel;
		public System.Windows.Forms.ComboBox gradSngradcomboBox;
		private System.Windows.Forms.Label snCorrectlabel;
		public System.Windows.Forms.TextBox snCorrectedtextBox;
	}
}

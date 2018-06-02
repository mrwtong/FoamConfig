namespace FoamCongfig.ConfigPanels
{
	partial class SchemeLaplacianPanel
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
			this.laplacianDefaultcomboBox = new System.Windows.Forms.ComboBox();
			this.laplacianDefaultcheckBox = new System.Windows.Forms.CheckBox();
			this.laplacianDefaultlabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timeSplitgroupBox
			// 
			this.timeSplitgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timeSplitgroupBox.Location = new System.Drawing.Point(6, 63);
			this.timeSplitgroupBox.Name = "timeSplitgroupBox";
			this.timeSplitgroupBox.Size = new System.Drawing.Size(594, 10);
			this.timeSplitgroupBox.TabIndex = 14;
			this.timeSplitgroupBox.TabStop = false;
			// 
			// laplacianDefaultcomboBox
			// 
			this.laplacianDefaultcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.laplacianDefaultcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.laplacianDefaultcomboBox.FormattingEnabled = true;
			this.laplacianDefaultcomboBox.Items.AddRange(new object[] {
            "Gauss linear corrected",
            "Gauss linear limited corrected",
            "Gauss linear orthogonal",
            "Gauss linear uncorrected;"});
			this.laplacianDefaultcomboBox.Location = new System.Drawing.Point(346, 29);
			this.laplacianDefaultcomboBox.Name = "laplacianDefaultcomboBox";
			this.laplacianDefaultcomboBox.Size = new System.Drawing.Size(259, 23);
			this.laplacianDefaultcomboBox.TabIndex = 13;
			// 
			// laplacianDefaultcheckBox
			// 
			this.laplacianDefaultcheckBox.AutoSize = true;
			this.laplacianDefaultcheckBox.Checked = true;
			this.laplacianDefaultcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.laplacianDefaultcheckBox.Location = new System.Drawing.Point(24, 28);
			this.laplacianDefaultcheckBox.Name = "laplacianDefaultcheckBox";
			this.laplacianDefaultcheckBox.Size = new System.Drawing.Size(189, 19);
			this.laplacianDefaultcheckBox.TabIndex = 12;
			this.laplacianDefaultcheckBox.Text = "Set Terms As Default";
			this.laplacianDefaultcheckBox.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.laplacianDefaultcheckBox.UseVisualStyleBackColor = true;
			this.laplacianDefaultcheckBox.CheckedChanged += new System.EventHandler(this.laplacianDefaultcheckBox_CheckedChanged);
			// 
			// laplacianDefaultlabel
			// 
			this.laplacianDefaultlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.laplacianDefaultlabel.AutoSize = true;
			this.laplacianDefaultlabel.Location = new System.Drawing.Point(284, 32);
			this.laplacianDefaultlabel.Name = "laplacianDefaultlabel";
			this.laplacianDefaultlabel.Size = new System.Drawing.Size(63, 15);
			this.laplacianDefaultlabel.TabIndex = 11;
			this.laplacianDefaultlabel.Text = "Default";
			// 
			// SchemeLaplacianPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.timeSplitgroupBox);
			this.Controls.Add(this.laplacianDefaultcomboBox);
			this.Controls.Add(this.laplacianDefaultcheckBox);
			this.Controls.Add(this.laplacianDefaultlabel);
			this.MinimumSize = new System.Drawing.Size(620, 456);
			this.Name = "SchemeLaplacianPanel";
			this.Size = new System.Drawing.Size(620, 456);
			this.Load += new System.EventHandler(this.SchemeLaplacianPanel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox timeSplitgroupBox;
		public System.Windows.Forms.ComboBox laplacianDefaultcomboBox;
		public System.Windows.Forms.CheckBox laplacianDefaultcheckBox;
		private System.Windows.Forms.Label laplacianDefaultlabel;
	}
}

namespace FoamCongfig.ConfigPanels
{
	partial class SchemeTimePanel
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
			this.timedefaultlabel = new System.Windows.Forms.Label();
			this.timeDefaultcheckBox = new System.Windows.Forms.CheckBox();
			this.timeDefaultcomboBox = new System.Windows.Forms.ComboBox();
			this.CrankNicolsontextBox = new System.Windows.Forms.TextBox();
			this.CrankNicolsonlabel = new System.Windows.Forms.Label();
			this.timeSplitgroupBox = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// timedefaultlabel
			// 
			this.timedefaultlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.timedefaultlabel.AutoSize = true;
			this.timedefaultlabel.Location = new System.Drawing.Point(313, 38);
			this.timedefaultlabel.Name = "timedefaultlabel";
			this.timedefaultlabel.Size = new System.Drawing.Size(63, 15);
			this.timedefaultlabel.TabIndex = 0;
			this.timedefaultlabel.Text = "Default";
			this.timedefaultlabel.Click += new System.EventHandler(this.defaultlabel_Click);
			// 
			// timeDefaultcheckBox
			// 
			this.timeDefaultcheckBox.AutoSize = true;
			this.timeDefaultcheckBox.Checked = true;
			this.timeDefaultcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.timeDefaultcheckBox.Location = new System.Drawing.Point(27, 34);
			this.timeDefaultcheckBox.Name = "timeDefaultcheckBox";
			this.timeDefaultcheckBox.Size = new System.Drawing.Size(189, 19);
			this.timeDefaultcheckBox.TabIndex = 1;
			this.timeDefaultcheckBox.Text = "Set Terms As Default";
			this.timeDefaultcheckBox.UseVisualStyleBackColor = true;
			this.timeDefaultcheckBox.CheckedChanged += new System.EventHandler(this.timeDefaultcheckBox_CheckedChanged);
			// 
			// timeDefaultcomboBox
			// 
			this.timeDefaultcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.timeDefaultcomboBox.FormattingEnabled = true;
			this.timeDefaultcomboBox.Items.AddRange(new object[] {
            "Eluer",
            "steady State",
            "backward",
            "Crank Nicolson",
            "localEuler"});
			this.timeDefaultcomboBox.Location = new System.Drawing.Point(410, 35);
			this.timeDefaultcomboBox.Name = "timeDefaultcomboBox";
			this.timeDefaultcomboBox.Size = new System.Drawing.Size(179, 23);
			this.timeDefaultcomboBox.TabIndex = 2;
			this.timeDefaultcomboBox.SelectedIndexChanged += new System.EventHandler(this.timeDefaultcomboBox_SelectedIndexChanged);
			// 
			// CrankNicolsontextBox
			// 
			this.CrankNicolsontextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CrankNicolsontextBox.Location = new System.Drawing.Point(545, 85);
			this.CrankNicolsontextBox.Name = "CrankNicolsontextBox";
			this.CrankNicolsontextBox.Size = new System.Drawing.Size(44, 25);
			this.CrankNicolsontextBox.TabIndex = 3;
			this.CrankNicolsontextBox.Text = "0.9";
			// 
			// CrankNicolsonlabel
			// 
			this.CrankNicolsonlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CrankNicolsonlabel.AutoSize = true;
			this.CrankNicolsonlabel.Location = new System.Drawing.Point(313, 88);
			this.CrankNicolsonlabel.Name = "CrankNicolsonlabel";
			this.CrankNicolsonlabel.Size = new System.Drawing.Size(119, 15);
			this.CrankNicolsonlabel.TabIndex = 4;
			this.CrankNicolsonlabel.Text = "Crank Nicolson";
			// 
			// timeSplitgroupBox
			// 
			this.timeSplitgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timeSplitgroupBox.Location = new System.Drawing.Point(9, 116);
			this.timeSplitgroupBox.Name = "timeSplitgroupBox";
			this.timeSplitgroupBox.Size = new System.Drawing.Size(594, 10);
			this.timeSplitgroupBox.TabIndex = 5;
			this.timeSplitgroupBox.TabStop = false;
			this.timeSplitgroupBox.Enter += new System.EventHandler(this.timeSplitgroupBox_Enter);
			// 
			// SchemeTimePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.timeSplitgroupBox);
			this.Controls.Add(this.CrankNicolsonlabel);
			this.Controls.Add(this.CrankNicolsontextBox);
			this.Controls.Add(this.timeDefaultcomboBox);
			this.Controls.Add(this.timeDefaultcheckBox);
			this.Controls.Add(this.timedefaultlabel);
			this.MinimumSize = new System.Drawing.Size(620, 456);
			this.Name = "SchemeTimePanel";
			this.Size = new System.Drawing.Size(620, 456);
			this.Load += new System.EventHandler(this.SchemeTimePanel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label timedefaultlabel;
		public System.Windows.Forms.CheckBox timeDefaultcheckBox;
		public System.Windows.Forms.ComboBox timeDefaultcomboBox;
		public System.Windows.Forms.TextBox CrankNicolsontextBox;
		private System.Windows.Forms.Label CrankNicolsonlabel;
		private System.Windows.Forms.GroupBox timeSplitgroupBox;
	}
}

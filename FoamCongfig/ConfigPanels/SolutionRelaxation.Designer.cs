using System;

namespace FoamCongfig.ConfigPanels
{
	partial class SolutionRelaxation
	{
		public class fieldRelaxation
		{
			public System.Windows.Forms.CheckBox relaxaFactorcheckBox;
			public System.Windows.Forms.Label relaxationFactorlabel;
			public System.Windows.Forms.TextBox CoeffitextBox;
			public fieldRelaxation()
			{
				this.relaxaFactorcheckBox = new System.Windows.Forms.CheckBox();
				this.relaxationFactorlabel = new System.Windows.Forms.Label();
				this.CoeffitextBox = new System.Windows.Forms.TextBox();
				// 
				// relaxaFactorcheckBox
				// 
				this.relaxaFactorcheckBox.AutoSize = true;
				this.relaxaFactorcheckBox.Location = new System.Drawing.Point(20, 30);
				this.relaxaFactorcheckBox.Anchor =((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
				this.relaxaFactorcheckBox.Name = "relaxaFactorcheckBox";
				this.relaxaFactorcheckBox.Size = new System.Drawing.Size(157, 19);
				this.relaxaFactorcheckBox.TabIndex = 22;
				this.relaxaFactorcheckBox.Text = "Under Relaxation";
				this.relaxaFactorcheckBox.UseVisualStyleBackColor = true;
				this.relaxaFactorcheckBox.CheckedChanged += new System.EventHandler(this.relaxaFactorcheckBox_CheckedChanged);
				// 
				// relaxationFactorlabel
				// 
				this.relaxationFactorlabel.AutoSize = true;
				this.relaxationFactorlabel.Enabled = false;
				this.relaxationFactorlabel.Location = new System.Drawing.Point(281, 30);
				this.relaxationFactorlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top));
				this.relaxationFactorlabel.Name = "relaxationFactorlabel";
				this.relaxationFactorlabel.Size = new System.Drawing.Size(183, 15);
				this.relaxationFactorlabel.TabIndex = 23;
				this.relaxationFactorlabel.Text = "Relaxation Coefficient";

				// 
				// CoeffitextBox
				// 
				this.CoeffitextBox.Enabled = false;
				this.CoeffitextBox.Location = new System.Drawing.Point(497, 30);
				this.CoeffitextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top));
				this.CoeffitextBox.Name = "CoeffitextBox";
				this.CoeffitextBox.Size = new System.Drawing.Size(46, 25);
				this.CoeffitextBox.TabIndex = 24;
				this.CoeffitextBox.Text = "0.7";
			}
			private void relaxaFactorcheckBox_CheckedChanged(object sender, EventArgs e)
			{
				if(relaxaFactorcheckBox.Checked==false)
				{
					this.CoeffitextBox.Enabled = false;
					this.relaxationFactorlabel.Enabled = false;
				}else
				{
					this.CoeffitextBox.Enabled = true;
					this.relaxationFactorlabel.Enabled = true;
				}
			}

		}

		

		private void AddComponent(fieldRelaxation temp)
		{
			this.settingPanel.Controls.Add(temp.relaxaFactorcheckBox);
			this.settingPanel.Controls.Add(temp.relaxationFactorlabel);
			this.settingPanel.Controls.Add(temp.CoeffitextBox);

		}
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
			this.fieldComboBox = new System.Windows.Forms.ComboBox();
			this.selectedFieldlabel = new System.Windows.Forms.Label();
			this.settingPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// timeSplitgroupBox
			// 
			this.timeSplitgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timeSplitgroupBox.Location = new System.Drawing.Point(13, 58);
			this.timeSplitgroupBox.Name = "timeSplitgroupBox";
			this.timeSplitgroupBox.Size = new System.Drawing.Size(594, 10);
			this.timeSplitgroupBox.TabIndex = 21;
			this.timeSplitgroupBox.TabStop = false;
			// 
			// fieldComboBox
			// 
			this.fieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fieldComboBox.FormattingEnabled = true;
			this.fieldComboBox.Location = new System.Drawing.Point(92, 29);
			this.fieldComboBox.Name = "fieldComboBox";
			this.fieldComboBox.Size = new System.Drawing.Size(96, 23);
			this.fieldComboBox.TabIndex = 20;
			this.fieldComboBox.SelectedIndexChanged += new System.EventHandler(this.fieldComboBox_SelectedIndexChanged);
			// 
			// selectedFieldlabel
			// 
			this.selectedFieldlabel.AutoSize = true;
			this.selectedFieldlabel.Location = new System.Drawing.Point(17, 32);
			this.selectedFieldlabel.Name = "selectedFieldlabel";
			this.selectedFieldlabel.Size = new System.Drawing.Size(55, 15);
			this.selectedFieldlabel.TabIndex = 19;
			this.selectedFieldlabel.Text = "Fields";
			// 
			// settingPanel
			// 
			this.settingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingPanel.Location = new System.Drawing.Point(1, 74);
			this.settingPanel.Name = "settingPanel";
			this.settingPanel.Size = new System.Drawing.Size(618, 381);
			this.settingPanel.TabIndex = 22;
			// 
			// SolutionRelaxation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.settingPanel);
			this.Controls.Add(this.timeSplitgroupBox);
			this.Controls.Add(this.fieldComboBox);
			this.Controls.Add(this.selectedFieldlabel);
			this.MinimumSize = new System.Drawing.Size(620, 456);
			this.Name = "SolutionRelaxation";
			this.Size = new System.Drawing.Size(620, 456);
			this.Load += new System.EventHandler(this.SolutionRelaxation_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox timeSplitgroupBox;
		public System.Windows.Forms.ComboBox fieldComboBox;
		private System.Windows.Forms.Label selectedFieldlabel;
		public fieldRelaxation[] fieldRelaxations = new fieldRelaxation[ModelParameter.fieldNumber];
		private System.Windows.Forms.Panel settingPanel;
	}
}

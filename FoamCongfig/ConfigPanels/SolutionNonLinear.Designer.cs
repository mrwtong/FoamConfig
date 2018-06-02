namespace FoamCongfig.ConfigPanels
{
	partial class SolutionNonLinear
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
			this.nonlinermethondcomboBox = new System.Windows.Forms.ComboBox();
			this.nonlinerselectedFieldlabel = new System.Windows.Forms.Label();
			this.momentumPredictorboBox1 = new System.Windows.Forms.ComboBox();
			this.momentumPredictorlable = new System.Windows.Forms.Label();
			this.nNonOrthogonalCorrectorsLabel = new System.Windows.Forms.Label();
			this.nCorrectorslabel = new System.Windows.Forms.Label();
			this.nOuterCorrectorsLabel = new System.Windows.Forms.Label();
			this.nCorrectorstextBox = new System.Windows.Forms.TextBox();
			this.nNonOrthogonalCorrectorstextBox = new System.Windows.Forms.TextBox();
			this.nOuterCorrectorsLabeltextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// timeSplitgroupBox
			// 
			this.timeSplitgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timeSplitgroupBox.Location = new System.Drawing.Point(15, 61);
			this.timeSplitgroupBox.Name = "timeSplitgroupBox";
			this.timeSplitgroupBox.Size = new System.Drawing.Size(594, 10);
			this.timeSplitgroupBox.TabIndex = 29;
			this.timeSplitgroupBox.TabStop = false;
			// 
			// nonlinermethondcomboBox
			// 
			this.nonlinermethondcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.nonlinermethondcomboBox.FormattingEnabled = true;
			this.nonlinermethondcomboBox.Items.AddRange(new object[] {
            "PISO",
            "SIMPLE",
            "PIMPLE",
            "IMPES"});
			this.nonlinermethondcomboBox.Location = new System.Drawing.Point(226, 27);
			this.nonlinermethondcomboBox.Name = "nonlinermethondcomboBox";
			this.nonlinermethondcomboBox.Size = new System.Drawing.Size(96, 23);
			this.nonlinermethondcomboBox.TabIndex = 28;
			this.nonlinermethondcomboBox.SelectedIndexChanged += new System.EventHandler(this.nonlinermethondcomboBox_SelectedIndexChanged);
			// 
			// nonlinerselectedFieldlabel
			// 
			this.nonlinerselectedFieldlabel.AutoSize = true;
			this.nonlinerselectedFieldlabel.Location = new System.Drawing.Point(12, 30);
			this.nonlinerselectedFieldlabel.Name = "nonlinerselectedFieldlabel";
			this.nonlinerselectedFieldlabel.Size = new System.Drawing.Size(199, 15);
			this.nonlinerselectedFieldlabel.TabIndex = 27;
			this.nonlinerselectedFieldlabel.Text = "Non-Linear Solver Method";
			// 
			// momentumPredictorboBox1
			// 
			this.momentumPredictorboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.momentumPredictorboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.momentumPredictorboBox1.FormattingEnabled = true;
			this.momentumPredictorboBox1.Items.AddRange(new object[] {
            "on",
            "off"});
			this.momentumPredictorboBox1.Location = new System.Drawing.Point(507, 173);
			this.momentumPredictorboBox1.Name = "momentumPredictorboBox1";
			this.momentumPredictorboBox1.Size = new System.Drawing.Size(78, 23);
			this.momentumPredictorboBox1.TabIndex = 32;
			// 
			// momentumPredictorlable
			// 
			this.momentumPredictorlable.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.momentumPredictorlable.AutoSize = true;
			this.momentumPredictorlable.Location = new System.Drawing.Point(335, 176);
			this.momentumPredictorlable.Name = "momentumPredictorlable";
			this.momentumPredictorlable.Size = new System.Drawing.Size(151, 15);
			this.momentumPredictorlable.TabIndex = 34;
			this.momentumPredictorlable.Text = "Momentum Predictor";
			// 
			// nNonOrthogonalCorrectorsLabel
			// 
			this.nNonOrthogonalCorrectorsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.nNonOrthogonalCorrectorsLabel.AutoSize = true;
			this.nNonOrthogonalCorrectorsLabel.Location = new System.Drawing.Point(293, 118);
			this.nNonOrthogonalCorrectorsLabel.Name = "nNonOrthogonalCorrectorsLabel";
			this.nNonOrthogonalCorrectorsLabel.Size = new System.Drawing.Size(199, 15);
			this.nNonOrthogonalCorrectorsLabel.TabIndex = 35;
			this.nNonOrthogonalCorrectorsLabel.Text = "nNonOrthogonalCorrectors";
			// 
			// nCorrectorslabel
			// 
			this.nCorrectorslabel.AutoSize = true;
			this.nCorrectorslabel.Location = new System.Drawing.Point(20, 115);
			this.nCorrectorslabel.Name = "nCorrectorslabel";
			this.nCorrectorslabel.Size = new System.Drawing.Size(95, 15);
			this.nCorrectorslabel.TabIndex = 36;
			this.nCorrectorslabel.Text = "nCorrectors";
			// 
			// nOuterCorrectorsLabel
			// 
			this.nOuterCorrectorsLabel.AutoSize = true;
			this.nOuterCorrectorsLabel.Location = new System.Drawing.Point(20, 170);
			this.nOuterCorrectorsLabel.Name = "nOuterCorrectorsLabel";
			this.nOuterCorrectorsLabel.Size = new System.Drawing.Size(135, 15);
			this.nOuterCorrectorsLabel.TabIndex = 37;
			this.nOuterCorrectorsLabel.Text = "nOuterCorrectors";
			// 
			// nCorrectorstextBox
			// 
			this.nCorrectorstextBox.Location = new System.Drawing.Point(171, 115);
			this.nCorrectorstextBox.Name = "nCorrectorstextBox";
			this.nCorrectorstextBox.Size = new System.Drawing.Size(83, 25);
			this.nCorrectorstextBox.TabIndex = 38;
			this.nCorrectorstextBox.Text = "2";
			// 
			// nNonOrthogonalCorrectorstextBox
			// 
			this.nNonOrthogonalCorrectorstextBox.Location = new System.Drawing.Point(506, 115);
			this.nNonOrthogonalCorrectorstextBox.Name = "nNonOrthogonalCorrectorstextBox";
			this.nNonOrthogonalCorrectorstextBox.Size = new System.Drawing.Size(83, 25);
			this.nNonOrthogonalCorrectorstextBox.TabIndex = 38;
			this.nNonOrthogonalCorrectorstextBox.Text = "0";
			// 
			// nOuterCorrectorsLabeltextBox
			// 
			this.nOuterCorrectorsLabeltextBox.Location = new System.Drawing.Point(171, 167);
			this.nOuterCorrectorsLabeltextBox.Name = "nOuterCorrectorsLabeltextBox";
			this.nOuterCorrectorsLabeltextBox.Size = new System.Drawing.Size(83, 25);
			this.nOuterCorrectorsLabeltextBox.TabIndex = 38;
			this.nOuterCorrectorsLabeltextBox.Text = "3";
			// 
			// SolutionNonLinear
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.nOuterCorrectorsLabeltextBox);
			this.Controls.Add(this.nNonOrthogonalCorrectorstextBox);
			this.Controls.Add(this.nCorrectorstextBox);
			this.Controls.Add(this.momentumPredictorboBox1);
			this.Controls.Add(this.momentumPredictorlable);
			this.Controls.Add(this.nNonOrthogonalCorrectorsLabel);
			this.Controls.Add(this.nCorrectorslabel);
			this.Controls.Add(this.nOuterCorrectorsLabel);
			this.Controls.Add(this.timeSplitgroupBox);
			this.Controls.Add(this.nonlinermethondcomboBox);
			this.Controls.Add(this.nonlinerselectedFieldlabel);
			this.MinimumSize = new System.Drawing.Size(620, 456);
			this.Name = "SolutionNonLinear";
			this.Size = new System.Drawing.Size(620, 456);
			this.Load += new System.EventHandler(this.SolutionNonLinear_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox timeSplitgroupBox;
		public System.Windows.Forms.ComboBox nonlinermethondcomboBox;
		private System.Windows.Forms.Label nonlinerselectedFieldlabel;
		public System.Windows.Forms.ComboBox momentumPredictorboBox1;
		private System.Windows.Forms.Label momentumPredictorlable;
		private System.Windows.Forms.Label nNonOrthogonalCorrectorsLabel;
		private System.Windows.Forms.Label nCorrectorslabel;
		private System.Windows.Forms.Label nOuterCorrectorsLabel;
		public System.Windows.Forms.TextBox nCorrectorstextBox;
		public System.Windows.Forms.TextBox nNonOrthogonalCorrectorstextBox;
		public System.Windows.Forms.TextBox nOuterCorrectorsLabeltextBox;
	}
}

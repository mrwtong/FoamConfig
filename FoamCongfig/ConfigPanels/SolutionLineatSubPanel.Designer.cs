namespace FoamCongfig.ConfigPanels
{
	partial class SolutionLineatSubPanel
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
			this.solvercomboBox = new System.Windows.Forms.ComboBox();
			this.relTolerancelaber = new System.Windows.Forms.Label();
			this.tolerancelabel = new System.Windows.Forms.Label();
			this.smoothercomboBox = new System.Windows.Forms.ComboBox();
			this.perconditionercomboBox = new System.Windows.Forms.ComboBox();
			this.perconditionerLabel = new System.Windows.Forms.Label();
			this.solverlabel = new System.Windows.Forms.Label();
			this.smootherLabel = new System.Windows.Forms.Label();
			this.tolerancetextBox1 = new System.Windows.Forms.TextBox();
			this.relTolerancetextBox1textBox = new System.Windows.Forms.TextBox();
			this.sweeplable = new System.Windows.Forms.Label();
			this.sweepcomboBox1 = new System.Windows.Forms.ComboBox();
			this.splitgroupBox = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// solvercomboBox
			// 
			this.solvercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.solvercomboBox.FormattingEnabled = true;
			this.solvercomboBox.Items.AddRange(new object[] {
            "GAMG",
            "PCG",
            "PBiCG",
            "PBiCGStab",
            "smooth Solver",
            "diagonal"});
			this.solvercomboBox.Location = new System.Drawing.Point(101, 33);
			this.solvercomboBox.Name = "solvercomboBox";
			this.solvercomboBox.Size = new System.Drawing.Size(121, 23);
			this.solvercomboBox.TabIndex = 1;
			this.solvercomboBox.SelectedIndexChanged += new System.EventHandler(this.solvercomboBox_SelectedIndexChanged);
			// 
			// relTolerancelaber
			// 
			this.relTolerancelaber.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.relTolerancelaber.AutoSize = true;
			this.relTolerancelaber.Location = new System.Drawing.Point(333, 201);
			this.relTolerancelaber.Name = "relTolerancelaber";
			this.relTolerancelaber.Size = new System.Drawing.Size(103, 15);
			this.relTolerancelaber.TabIndex = 3;
			this.relTolerancelaber.Text = "relTolerance";
			// 
			// tolerancelabel
			// 
			this.tolerancelabel.AutoSize = true;
			this.tolerancelabel.Location = new System.Drawing.Point(22, 201);
			this.tolerancelabel.Name = "tolerancelabel";
			this.tolerancelabel.Size = new System.Drawing.Size(79, 15);
			this.tolerancelabel.TabIndex = 4;
			this.tolerancelabel.Text = "Tolerance";
			// 
			// smoothercomboBox
			// 
			this.smoothercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.smoothercomboBox.FormattingEnabled = true;
			this.smoothercomboBox.Items.AddRange(new object[] {
            "none",
            "Gauss Seidel",
            "sym Gauss Seidel",
            "DIC",
            "DILU",
            "DIC Gauss Seidel"});
			this.smoothercomboBox.Location = new System.Drawing.Point(101, 87);
			this.smoothercomboBox.Name = "smoothercomboBox";
			this.smoothercomboBox.Size = new System.Drawing.Size(169, 23);
			this.smoothercomboBox.TabIndex = 5;
			this.smoothercomboBox.SelectedIndexChanged += new System.EventHandler(this.smoothercomboBox_SelectedIndexChanged);
			// 
			// perconditionercomboBox
			// 
			this.perconditionercomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.perconditionercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.perconditionercomboBox.FormattingEnabled = true;
			this.perconditionercomboBox.Items.AddRange(new object[] {
            "none",
            "DIC",
            "FDIC",
            "DILU",
            "GAMG",
            "diagonal"});
			this.perconditionercomboBox.Location = new System.Drawing.Point(454, 31);
			this.perconditionercomboBox.Name = "perconditionercomboBox";
			this.perconditionercomboBox.Size = new System.Drawing.Size(137, 23);
			this.perconditionercomboBox.TabIndex = 6;
			// 
			// perconditionerLabel
			// 
			this.perconditionerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.perconditionerLabel.AutoSize = true;
			this.perconditionerLabel.Location = new System.Drawing.Point(329, 35);
			this.perconditionerLabel.Name = "perconditionerLabel";
			this.perconditionerLabel.Size = new System.Drawing.Size(119, 15);
			this.perconditionerLabel.TabIndex = 7;
			this.perconditionerLabel.Text = "Perconditioner";
			// 
			// solverlabel
			// 
			this.solverlabel.AutoSize = true;
			this.solverlabel.Location = new System.Drawing.Point(22, 32);
			this.solverlabel.Name = "solverlabel";
			this.solverlabel.Size = new System.Drawing.Size(55, 15);
			this.solverlabel.TabIndex = 8;
			this.solverlabel.Text = "Solver";
			// 
			// smootherLabel
			// 
			this.smootherLabel.AutoSize = true;
			this.smootherLabel.Location = new System.Drawing.Point(22, 87);
			this.smootherLabel.Name = "smootherLabel";
			this.smootherLabel.Size = new System.Drawing.Size(71, 15);
			this.smootherLabel.TabIndex = 9;
			this.smootherLabel.Text = "Smoother";
			// 
			// tolerancetextBox1
			// 
			this.tolerancetextBox1.Location = new System.Drawing.Point(159, 194);
			this.tolerancetextBox1.Name = "tolerancetextBox1";
			this.tolerancetextBox1.Size = new System.Drawing.Size(63, 25);
			this.tolerancetextBox1.TabIndex = 10;
			this.tolerancetextBox1.Text = "1e6";
			// 
			// relTolerancetextBox1textBox
			// 
			this.relTolerancetextBox1textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.relTolerancetextBox1textBox.Location = new System.Drawing.Point(532, 198);
			this.relTolerancetextBox1textBox.Name = "relTolerancetextBox1textBox";
			this.relTolerancetextBox1textBox.Size = new System.Drawing.Size(63, 25);
			this.relTolerancetextBox1textBox.TabIndex = 11;
			this.relTolerancetextBox1textBox.Text = "0.05";
			// 
			// sweeplable
			// 
			this.sweeplable.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.sweeplable.AutoSize = true;
			this.sweeplable.Location = new System.Drawing.Point(329, 94);
			this.sweeplable.Name = "sweeplable";
			this.sweeplable.Size = new System.Drawing.Size(47, 15);
			this.sweeplable.TabIndex = 7;
			this.sweeplable.Text = "Sweep";
			// 
			// sweepcomboBox1
			// 
			this.sweepcomboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.sweepcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sweepcomboBox1.FormattingEnabled = true;
			this.sweepcomboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.sweepcomboBox1.Location = new System.Drawing.Point(513, 90);
			this.sweepcomboBox1.Name = "sweepcomboBox1";
			this.sweepcomboBox1.Size = new System.Drawing.Size(78, 23);
			this.sweepcomboBox1.TabIndex = 6;
			// 
			// splitgroupBox
			// 
			this.splitgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitgroupBox.Location = new System.Drawing.Point(16, 154);
			this.splitgroupBox.Name = "splitgroupBox";
			this.splitgroupBox.Size = new System.Drawing.Size(594, 10);
			this.splitgroupBox.TabIndex = 26;
			this.splitgroupBox.TabStop = false;
			// 
			// SolutionLineatSubPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitgroupBox);
			this.Controls.Add(this.solvercomboBox);
			this.Controls.Add(this.relTolerancelaber);
			this.Controls.Add(this.tolerancelabel);
			this.Controls.Add(this.smoothercomboBox);
			this.Controls.Add(this.sweepcomboBox1);
			this.Controls.Add(this.perconditionercomboBox);
			this.Controls.Add(this.sweeplable);
			this.Controls.Add(this.perconditionerLabel);
			this.Controls.Add(this.solverlabel);
			this.Controls.Add(this.smootherLabel);
			this.Controls.Add(this.tolerancetextBox1);
			this.Controls.Add(this.relTolerancetextBox1textBox);
			this.Name = "SolutionLineatSubPanel";
			this.Size = new System.Drawing.Size(620, 396);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		public System.Windows.Forms.ComboBox solvercomboBox;
		private System.Windows.Forms.Label relTolerancelaber;
		private System.Windows.Forms.Label tolerancelabel;
		public System.Windows.Forms.ComboBox smoothercomboBox;
		public System.Windows.Forms.ComboBox perconditionercomboBox;
		private System.Windows.Forms.Label perconditionerLabel;
		private System.Windows.Forms.Label solverlabel;
		private System.Windows.Forms.Label smootherLabel;
		public System.Windows.Forms.TextBox tolerancetextBox1;
		public System.Windows.Forms.TextBox relTolerancetextBox1textBox;
		private System.Windows.Forms.Label sweeplable;
		public System.Windows.Forms.ComboBox sweepcomboBox1;
		private System.Windows.Forms.GroupBox splitgroupBox;
	}
}

namespace FoamCongfig.ConfigPanels
{
	partial class ControlDataWriting
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
			this.WriteFormat = new System.Windows.Forms.Label();
			this.ComboWriteFormat = new System.Windows.Forms.ComboBox();
			this.WritePrecision = new System.Windows.Forms.Label();
			this.comboWritePrecision = new System.Windows.Forms.ComboBox();
			this.compression = new System.Windows.Forms.Label();
			this.comboCompression = new System.Windows.Forms.ComboBox();
			this.timeFormatLable = new System.Windows.Forms.Label();
			this.comboTimeFormat = new System.Windows.Forms.ComboBox();
			this.timePrecisionLabel = new System.Windows.Forms.Label();
			this.graphFormatLabel = new System.Windows.Forms.Label();
			this.comboTimePrecision = new System.Windows.Forms.ComboBox();
			this.comboGraphFormat = new System.Windows.Forms.ComboBox();
			this.writeControlLabel = new System.Windows.Forms.Label();
			this.writeControlcombo = new System.Windows.Forms.ComboBox();
			this.writeIntervalLabel = new System.Windows.Forms.Label();
			this.writeIntervalTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// WriteFormat
			// 
			this.WriteFormat.AutoSize = true;
			this.WriteFormat.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.WriteFormat.Location = new System.Drawing.Point(16, 29);
			this.WriteFormat.Name = "WriteFormat";
			this.WriteFormat.Size = new System.Drawing.Size(103, 15);
			this.WriteFormat.TabIndex = 0;
			this.WriteFormat.Text = "Write Format";
			// 
			// ComboWriteFormat
			// 
			this.ComboWriteFormat.FormattingEnabled = true;
			this.ComboWriteFormat.Items.AddRange(new object[] {
            "ascii",
            "binary"});
			this.ComboWriteFormat.Location = new System.Drawing.Point(140, 28);
			this.ComboWriteFormat.Name = "ComboWriteFormat";
			this.ComboWriteFormat.Size = new System.Drawing.Size(130, 23);
			this.ComboWriteFormat.TabIndex = 1;
			// 
			// WritePrecision
			// 
			this.WritePrecision.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.WritePrecision.AutoSize = true;
			this.WritePrecision.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.WritePrecision.Location = new System.Drawing.Point(322, 32);
			this.WritePrecision.Name = "WritePrecision";
			this.WritePrecision.Size = new System.Drawing.Size(127, 15);
			this.WritePrecision.TabIndex = 0;
			this.WritePrecision.Text = "Write Precision";
			// 
			// comboWritePrecision
			// 
			this.comboWritePrecision.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboWritePrecision.FormattingEnabled = true;
			this.comboWritePrecision.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
			this.comboWritePrecision.Location = new System.Drawing.Point(457, 29);
			this.comboWritePrecision.Name = "comboWritePrecision";
			this.comboWritePrecision.Size = new System.Drawing.Size(135, 23);
			this.comboWritePrecision.TabIndex = 1;
			// 
			// compression
			// 
			this.compression.AutoSize = true;
			this.compression.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.compression.Location = new System.Drawing.Point(16, 99);
			this.compression.Name = "compression";
			this.compression.Size = new System.Drawing.Size(95, 15);
			this.compression.TabIndex = 0;
			this.compression.Text = "Compression";
			// 
			// comboCompression
			// 
			this.comboCompression.FormattingEnabled = true;
			this.comboCompression.Items.AddRange(new object[] {
            "on",
            "off"});
			this.comboCompression.Location = new System.Drawing.Point(140, 98);
			this.comboCompression.Name = "comboCompression";
			this.comboCompression.Size = new System.Drawing.Size(130, 23);
			this.comboCompression.TabIndex = 1;
			// 
			// timeFormatLable
			// 
			this.timeFormatLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.timeFormatLable.AutoSize = true;
			this.timeFormatLable.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.timeFormatLable.Location = new System.Drawing.Point(322, 99);
			this.timeFormatLable.Name = "timeFormatLable";
			this.timeFormatLable.Size = new System.Drawing.Size(95, 15);
			this.timeFormatLable.TabIndex = 0;
			this.timeFormatLable.Text = "Time Format";
			// 
			// comboTimeFormat
			// 
			this.comboTimeFormat.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboTimeFormat.FormattingEnabled = true;
			this.comboTimeFormat.Items.AddRange(new object[] {
            "fixed",
            "scientific",
            "general"});
			this.comboTimeFormat.Location = new System.Drawing.Point(457, 96);
			this.comboTimeFormat.Name = "comboTimeFormat";
			this.comboTimeFormat.Size = new System.Drawing.Size(135, 23);
			this.comboTimeFormat.TabIndex = 1;
			// 
			// timePrecisionLabel
			// 
			this.timePrecisionLabel.AutoSize = true;
			this.timePrecisionLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.timePrecisionLabel.Location = new System.Drawing.Point(14, 183);
			this.timePrecisionLabel.Name = "timePrecisionLabel";
			this.timePrecisionLabel.Size = new System.Drawing.Size(119, 15);
			this.timePrecisionLabel.TabIndex = 0;
			this.timePrecisionLabel.Text = "Time Precision";
			// 
			// graphFormatLabel
			// 
			this.graphFormatLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.graphFormatLabel.AutoSize = true;
			this.graphFormatLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.graphFormatLabel.Location = new System.Drawing.Point(322, 183);
			this.graphFormatLabel.Name = "graphFormatLabel";
			this.graphFormatLabel.Size = new System.Drawing.Size(103, 15);
			this.graphFormatLabel.TabIndex = 0;
			this.graphFormatLabel.Text = "Graph Format";
			// 
			// comboTimePrecision
			// 
			this.comboTimePrecision.FormattingEnabled = true;
			this.comboTimePrecision.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9"});
			this.comboTimePrecision.Location = new System.Drawing.Point(140, 182);
			this.comboTimePrecision.Name = "comboTimePrecision";
			this.comboTimePrecision.Size = new System.Drawing.Size(130, 23);
			this.comboTimePrecision.TabIndex = 1;
			// 
			// comboGraphFormat
			// 
			this.comboGraphFormat.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboGraphFormat.FormattingEnabled = true;
			this.comboGraphFormat.Items.AddRange(new object[] {
            "raw",
            "gnuplot",
            "xmgr",
            "jplot"});
			this.comboGraphFormat.Location = new System.Drawing.Point(457, 180);
			this.comboGraphFormat.Name = "comboGraphFormat";
			this.comboGraphFormat.Size = new System.Drawing.Size(135, 23);
			this.comboGraphFormat.TabIndex = 1;
			// 
			// writeControlLabel
			// 
			this.writeControlLabel.AutoSize = true;
			this.writeControlLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.writeControlLabel.Location = new System.Drawing.Point(16, 250);
			this.writeControlLabel.Name = "writeControlLabel";
			this.writeControlLabel.Size = new System.Drawing.Size(111, 15);
			this.writeControlLabel.TabIndex = 0;
			this.writeControlLabel.Text = "Write Control";
			// 
			// writeControlcombo
			// 
			this.writeControlcombo.FormattingEnabled = true;
			this.writeControlcombo.Items.AddRange(new object[] {
            "time Step",
            "run Time",
            "adjustable Run Time",
            "cpu Time",
            "clock Time"});
			this.writeControlcombo.Location = new System.Drawing.Point(140, 249);
			this.writeControlcombo.Name = "writeControlcombo";
			this.writeControlcombo.Size = new System.Drawing.Size(130, 23);
			this.writeControlcombo.TabIndex = 1;
			this.writeControlcombo.Text = "time Step";
			// 
			// writeIntervalLabel
			// 
			this.writeIntervalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.writeIntervalLabel.AutoSize = true;
			this.writeIntervalLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.writeIntervalLabel.Location = new System.Drawing.Point(322, 250);
			this.writeIntervalLabel.Name = "writeIntervalLabel";
			this.writeIntervalLabel.Size = new System.Drawing.Size(119, 15);
			this.writeIntervalLabel.TabIndex = 0;
			this.writeIntervalLabel.Text = "Write Interval";
			// 
			// writeIntervalTextBox
			// 
			this.writeIntervalTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.writeIntervalTextBox.Location = new System.Drawing.Point(457, 245);
			this.writeIntervalTextBox.Name = "writeIntervalTextBox";
			this.writeIntervalTextBox.Size = new System.Drawing.Size(135, 25);
			this.writeIntervalTextBox.TabIndex = 2;
			this.writeIntervalTextBox.Text = "10";
			this.writeIntervalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.writeIntervalTextBox_KeyPress_1);
			// 
			// ControlDataWriting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.writeIntervalTextBox);
			this.Controls.Add(this.comboGraphFormat);
			this.Controls.Add(this.comboTimeFormat);
			this.Controls.Add(this.comboWritePrecision);
			this.Controls.Add(this.comboTimePrecision);
			this.Controls.Add(this.comboCompression);
			this.Controls.Add(this.writeControlcombo);
			this.Controls.Add(this.ComboWriteFormat);
			this.Controls.Add(this.graphFormatLabel);
			this.Controls.Add(this.timeFormatLable);
			this.Controls.Add(this.timePrecisionLabel);
			this.Controls.Add(this.WritePrecision);
			this.Controls.Add(this.compression);
			this.Controls.Add(this.writeIntervalLabel);
			this.Controls.Add(this.writeControlLabel);
			this.Controls.Add(this.WriteFormat);
			this.MinimumSize = new System.Drawing.Size(620, 456);
			this.Name = "ControlDataWriting";
			this.Size = new System.Drawing.Size(620, 456);
			this.Load += new System.EventHandler(this.ControlDataWriting_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label WriteFormat;
		public System.Windows.Forms.ComboBox ComboWriteFormat;
		private System.Windows.Forms.Label WritePrecision;
		private System.Windows.Forms.Label compression;
		public System.Windows.Forms.ComboBox comboCompression;
		private System.Windows.Forms.Label timeFormatLable;
		public System.Windows.Forms.ComboBox comboTimeFormat;
		private System.Windows.Forms.Label timePrecisionLabel;
		private System.Windows.Forms.Label graphFormatLabel;
		public System.Windows.Forms.ComboBox comboTimePrecision;
		public System.Windows.Forms.ComboBox comboGraphFormat;
		public System.Windows.Forms.ComboBox comboWritePrecision;
		private System.Windows.Forms.Label writeControlLabel;
		public System.Windows.Forms.ComboBox writeControlcombo;
		private System.Windows.Forms.Label writeIntervalLabel;
		public System.Windows.Forms.TextBox writeIntervalTextBox;
	}
}

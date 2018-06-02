using System.Windows.Forms;

namespace FoamCongfig.ConfigPanels
{
	partial class ControlTimeCon
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
			this.startFromCombo = new System.Windows.Forms.ComboBox();
			this.startFormLable = new System.Windows.Forms.Label();
			this.startTimeLable = new System.Windows.Forms.Label();
			this.stopAtLable = new System.Windows.Forms.Label();
			this.endTimeLable = new System.Windows.Forms.Label();
			this.stopAtCombo = new System.Windows.Forms.ComboBox();
			this.startTimeTextbox = new System.Windows.Forms.TextBox();
			this.endTimeTextBox = new System.Windows.Forms.TextBox();
			this.startTimeUnitCombo = new System.Windows.Forms.ComboBox();
			this.endTimeUnitCombo = new System.Windows.Forms.ComboBox();
			this.DeltaT = new System.Windows.Forms.Label();
			this.timeStepTextbox = new System.Windows.Forms.TextBox();
			this.timeStepCombo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// startFromCombo
			// 
			this.startFromCombo.FormattingEnabled = true;
			this.startFromCombo.Items.AddRange(new object[] {
            "first Time",
            "start Time",
            "latest Time"});
			this.startFromCombo.Location = new System.Drawing.Point(142, 42);
			this.startFromCombo.Name = "startFromCombo";
			this.startFromCombo.Size = new System.Drawing.Size(130, 23);
			this.startFromCombo.TabIndex = 3;
			this.startFromCombo.SelectedIndexChanged += new System.EventHandler(this.ComboStartFrom_SelectedIndexChanged);
			// 
			// startFormLable
			// 
			this.startFormLable.AutoSize = true;
			this.startFormLable.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.startFormLable.Location = new System.Drawing.Point(30, 45);
			this.startFormLable.Name = "startFormLable";
			this.startFormLable.Size = new System.Drawing.Size(87, 15);
			this.startFormLable.TabIndex = 2;
			this.startFormLable.Text = "Start From";
			// 
			// startTimeLable
			// 
			this.startTimeLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.startTimeLable.AutoSize = true;
			this.startTimeLable.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.startTimeLable.Location = new System.Drawing.Point(333, 45);
			this.startTimeLable.Name = "startTimeLable";
			this.startTimeLable.Size = new System.Drawing.Size(87, 15);
			this.startTimeLable.TabIndex = 2;
			this.startTimeLable.Text = "Start Time";
			// 
			// stopAtLable
			// 
			this.stopAtLable.AutoSize = true;
			this.stopAtLable.Cursor = System.Windows.Forms.Cursors.Default;
			this.stopAtLable.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.stopAtLable.Location = new System.Drawing.Point(30, 111);
			this.stopAtLable.Name = "stopAtLable";
			this.stopAtLable.Size = new System.Drawing.Size(63, 15);
			this.stopAtLable.TabIndex = 2;
			this.stopAtLable.Text = "Stop At";
			// 
			// endTimeLable
			// 
			this.endTimeLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.endTimeLable.AutoSize = true;
			this.endTimeLable.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.endTimeLable.Location = new System.Drawing.Point(333, 111);
			this.endTimeLable.Name = "endTimeLable";
			this.endTimeLable.Size = new System.Drawing.Size(71, 15);
			this.endTimeLable.TabIndex = 2;
			this.endTimeLable.Text = "End Time";
			// 
			// stopAtCombo
			// 
			this.stopAtCombo.FormattingEnabled = true;
			this.stopAtCombo.Items.AddRange(new object[] {
            "end Time",
            "write Now",
            "noWrite Now",
            "next Write"});
			this.stopAtCombo.Location = new System.Drawing.Point(142, 108);
			this.stopAtCombo.Name = "stopAtCombo";
			this.stopAtCombo.Size = new System.Drawing.Size(130, 23);
			this.stopAtCombo.TabIndex = 3;
			this.stopAtCombo.SelectedIndexChanged += new System.EventHandler(this.stopAtCombo_SelectedIndexChanged);
			// 
			// startTimeTextbox
			// 
			this.startTimeTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.startTimeTextbox.Location = new System.Drawing.Point(445, 45);
			this.startTimeTextbox.Name = "startTimeTextbox";
			this.startTimeTextbox.Size = new System.Drawing.Size(95, 25);
			this.startTimeTextbox.TabIndex = 4;
			this.startTimeTextbox.Text = "5000";
			this.startTimeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// endTimeTextBox
			// 
			this.endTimeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.endTimeTextBox.Location = new System.Drawing.Point(445, 104);
			this.endTimeTextBox.Name = "endTimeTextBox";
			this.endTimeTextBox.Size = new System.Drawing.Size(95, 25);
			this.endTimeTextBox.TabIndex = 4;
			this.endTimeTextBox.Text = "10000";
			this.endTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// startTimeUnitCombo
			// 
			this.startTimeUnitCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.startTimeUnitCombo.FormattingEnabled = true;
			this.startTimeUnitCombo.Items.AddRange(new object[] {
            "s",
            "h",
            "d",
            "m",
            "y"});
			this.startTimeUnitCombo.Location = new System.Drawing.Point(546, 45);
			this.startTimeUnitCombo.MaximumSize = new System.Drawing.Size(51, 0);
			this.startTimeUnitCombo.MinimumSize = new System.Drawing.Size(51, 0);
			this.startTimeUnitCombo.Name = "startTimeUnitCombo";
			this.startTimeUnitCombo.Size = new System.Drawing.Size(51, 23);
			this.startTimeUnitCombo.TabIndex = 3;
			// 
			// endTimeUnitCombo
			// 
			this.endTimeUnitCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.endTimeUnitCombo.FormattingEnabled = true;
			this.endTimeUnitCombo.Items.AddRange(new object[] {
            "s",
            "h",
            "d",
            "m",
            "y"});
			this.endTimeUnitCombo.Location = new System.Drawing.Point(546, 105);
			this.endTimeUnitCombo.MaximumSize = new System.Drawing.Size(51, 0);
			this.endTimeUnitCombo.MinimumSize = new System.Drawing.Size(51, 0);
			this.endTimeUnitCombo.Name = "endTimeUnitCombo";
			this.endTimeUnitCombo.Size = new System.Drawing.Size(51, 23);
			this.endTimeUnitCombo.TabIndex = 3;
			// 
			// DeltaT
			// 
			this.DeltaT.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.DeltaT.AutoSize = true;
			this.DeltaT.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.DeltaT.Location = new System.Drawing.Point(174, 190);
			this.DeltaT.Name = "DeltaT";
			this.DeltaT.Size = new System.Drawing.Size(119, 15);
			this.DeltaT.TabIndex = 2;
			this.DeltaT.Text = "Time Step Size";
			// 
			// timeStepTextbox
			// 
			this.timeStepTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.timeStepTextbox.Location = new System.Drawing.Point(307, 188);
			this.timeStepTextbox.Name = "timeStepTextbox";
			this.timeStepTextbox.Size = new System.Drawing.Size(95, 25);
			this.timeStepTextbox.TabIndex = 4;
			this.timeStepTextbox.Text = "50";
			this.timeStepTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// timeStepCombo
			// 
			this.timeStepCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.timeStepCombo.FormattingEnabled = true;
			this.timeStepCombo.Items.AddRange(new object[] {
            "s",
            "h",
            "d",
            "m",
            "y"});
			this.timeStepCombo.Location = new System.Drawing.Point(416, 189);
			this.timeStepCombo.MaximumSize = new System.Drawing.Size(51, 0);
			this.timeStepCombo.MinimumSize = new System.Drawing.Size(51, 0);
			this.timeStepCombo.Name = "timeStepCombo";
			this.timeStepCombo.Size = new System.Drawing.Size(51, 23);
			this.timeStepCombo.TabIndex = 3;
			// 
			// ControlTimeCon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.timeStepTextbox);
			this.Controls.Add(this.endTimeTextBox);
			this.Controls.Add(this.startTimeTextbox);
			this.Controls.Add(this.stopAtCombo);
			this.Controls.Add(this.timeStepCombo);
			this.Controls.Add(this.endTimeUnitCombo);
			this.Controls.Add(this.startTimeUnitCombo);
			this.Controls.Add(this.startFromCombo);
			this.Controls.Add(this.DeltaT);
			this.Controls.Add(this.endTimeLable);
			this.Controls.Add(this.stopAtLable);
			this.Controls.Add(this.startTimeLable);
			this.Controls.Add(this.startFormLable);
			this.MinimumSize = new System.Drawing.Size(610, 450);
			this.Name = "ControlTimeCon";
			this.Size = new System.Drawing.Size(620, 456);
			this.Load += new System.EventHandler(this.ControlTimeCon_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion


		public System.Windows.Forms.ComboBox startFromCombo;
		private System.Windows.Forms.Label startFormLable;
		private System.Windows.Forms.Label startTimeLable;
		private System.Windows.Forms.Label stopAtLable;
		private System.Windows.Forms.Label endTimeLable;
		public System.Windows.Forms.ComboBox stopAtCombo;
		public System.Windows.Forms.TextBox startTimeTextbox;
		public System.Windows.Forms.TextBox endTimeTextBox;
		public System.Windows.Forms.ComboBox startTimeUnitCombo;
		public System.Windows.Forms.ComboBox endTimeUnitCombo;
		private System.Windows.Forms.Label DeltaT;
		public System.Windows.Forms.TextBox timeStepTextbox;
		public System.Windows.Forms.ComboBox timeStepCombo;
		
	}
}

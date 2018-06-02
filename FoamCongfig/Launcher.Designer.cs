namespace FoamCongfig
{
	partial class Launcher
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.VersionLable = new System.Windows.Forms.Label();
			this.CaseDirLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ProcessOptions = new System.Windows.Forms.Label();
			this.ProcessesLable = new System.Windows.Forms.Label();
			this.lauchebutton = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.SerialButton = new System.Windows.Forms.RadioButton();
			this.ParallelButton = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// VersionLable
			// 
			this.VersionLable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.VersionLable.AutoSize = true;
			this.VersionLable.BackColor = System.Drawing.SystemColors.Control;
			this.VersionLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.VersionLable.Location = new System.Drawing.Point(511, 374);
			this.VersionLable.Name = "VersionLable";
			this.VersionLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.VersionLable.Size = new System.Drawing.Size(129, 20);
			this.VersionLable.TabIndex = 0;
			this.VersionLable.Text = "Version Beta";
			this.VersionLable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// CaseDirLabel
			// 
			this.CaseDirLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CaseDirLabel.AutoSize = true;
			this.CaseDirLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CaseDirLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.CaseDirLabel.Location = new System.Drawing.Point(48, 96);
			this.CaseDirLabel.Name = "CaseDirLabel";
			this.CaseDirLabel.Size = new System.Drawing.Size(139, 20);
			this.CaseDirLabel.TabIndex = 1;
			this.CaseDirLabel.Text = "Case Dirctory";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox1.Location = new System.Drawing.Point(193, 96);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(338, 25);
			this.textBox1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button1.Image = global::FoamCongfig.Properties.Resources.open_file;
			this.button1.Location = new System.Drawing.Point(556, 93);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(43, 34);
			this.button1.TabIndex = 3;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ProcessOptions
			// 
			this.ProcessOptions.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ProcessOptions.AutoSize = true;
			this.ProcessOptions.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ProcessOptions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.ProcessOptions.Location = new System.Drawing.Point(48, 182);
			this.ProcessOptions.Name = "ProcessOptions";
			this.ProcessOptions.Size = new System.Drawing.Size(189, 20);
			this.ProcessOptions.TabIndex = 1;
			this.ProcessOptions.Text = "Processing Options";
			// 
			// ProcessesLable
			// 
			this.ProcessesLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ProcessesLable.AutoSize = true;
			this.ProcessesLable.Enabled = false;
			this.ProcessesLable.Location = new System.Drawing.Point(350, 272);
			this.ProcessesLable.Name = "ProcessesLable";
			this.ProcessesLable.Size = new System.Drawing.Size(79, 15);
			this.ProcessesLable.TabIndex = 7;
			this.ProcessesLable.Text = "Processes";
			// 
			// lauchebutton
			// 
			this.lauchebutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lauchebutton.Location = new System.Drawing.Point(267, 329);
			this.lauchebutton.Name = "lauchebutton";
			this.lauchebutton.Size = new System.Drawing.Size(93, 31);
			this.lauchebutton.TabIndex = 8;
			this.lauchebutton.Text = "Launch";
			this.lauchebutton.UseVisualStyleBackColor = true;
			this.lauchebutton.Click += new System.EventHandler(this.button2_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.numericUpDown1.Enabled = false;
			this.numericUpDown1.Location = new System.Drawing.Point(446, 272);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(53, 25);
			this.numericUpDown1.TabIndex = 9;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// SerialButton
			// 
			this.SerialButton.AutoSize = true;
			this.SerialButton.Checked = true;
			this.SerialButton.Location = new System.Drawing.Point(82, 236);
			this.SerialButton.Name = "SerialButton";
			this.SerialButton.Size = new System.Drawing.Size(76, 19);
			this.SerialButton.TabIndex = 10;
			this.SerialButton.TabStop = true;
			this.SerialButton.Text = "Serial";
			this.SerialButton.UseVisualStyleBackColor = true;
			this.SerialButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// ParallelButton
			// 
			this.ParallelButton.AutoSize = true;
			this.ParallelButton.Location = new System.Drawing.Point(315, 236);
			this.ParallelButton.Name = "ParallelButton";
			this.ParallelButton.Size = new System.Drawing.Size(92, 19);
			this.ParallelButton.TabIndex = 11;
			this.ParallelButton.Text = "Parallel";
			this.ParallelButton.UseVisualStyleBackColor = true;
			// 
			// Launcher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 403);
			this.Controls.Add(this.ParallelButton);
			this.Controls.Add(this.SerialButton);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.lauchebutton);
			this.Controls.Add(this.ProcessesLable);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.ProcessOptions);
			this.Controls.Add(this.CaseDirLabel);
			this.Controls.Add(this.VersionLable);
			this.MinimumSize = new System.Drawing.Size(700, 450);
			this.Name = "Launcher";
			this.Text = "Launcher";
			this.Load += new System.EventHandler(this.Launcher_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label VersionLable;
		private System.Windows.Forms.Label CaseDirLabel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label ProcessOptions;
		private System.Windows.Forms.Button lauchebutton;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.RadioButton SerialButton;
		private System.Windows.Forms.RadioButton ParallelButton;
		private System.Windows.Forms.Label ProcessesLable;
	}
}
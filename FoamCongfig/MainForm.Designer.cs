using FoamCongfig.ConfigPanels;
namespace FoamCongfig
{

	partial class MainForm
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

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("TH");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("THM");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("THMC");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Model", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Properties");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Time Term");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Gradient Term");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Divergence Term");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Laplacian Schemes");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Interpolation Term");
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Schemes", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Solver Relaxation");
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Linear Slover");
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Non-Linear Solver");
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Solution", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
			System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Time Control");
			System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Data Write");
			System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Parallel");
			System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Control", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
			System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("ParaView");
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Gnuplot");
			System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Result", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
			this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkMeshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preprocessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.postprocessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
			this.LeftPanel = new System.Windows.Forms.Panel();
			this.configbutton = new System.Windows.Forms.Button();
			this.LeftSideTree = new System.Windows.Forms.TreeView();
			this.RightPanel1 = new System.Windows.Forms.Panel();
			this.makeFilesbutton = new System.Windows.Forms.Button();
			this.runbutton = new System.Windows.Forms.Button();
			this.TopMenuStrip.SuspendLayout();
			this.LeftPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// filesToolStripMenuItem
			// 
			this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.writeToolStripMenuItem,
            this.toolStripSeparator2,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator3});
			this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
			this.filesToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.filesToolStripMenuItem.Text = "File";
			// 
			// readToolStripMenuItem
			// 
			this.readToolStripMenuItem.Name = "readToolStripMenuItem";
			this.readToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
			this.readToolStripMenuItem.Text = "Read";
			// 
			// writeToolStripMenuItem
			// 
			this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
			this.writeToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
			this.writeToolStripMenuItem.Text = "Write";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
			this.importToolStripMenuItem.Text = "Import";
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
			this.exportToolStripMenuItem.Text = "Export";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(131, 6);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkMeshToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// checkMeshToolStripMenuItem
			// 
			this.checkMeshToolStripMenuItem.Name = "checkMeshToolStripMenuItem";
			this.checkMeshToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
			this.checkMeshToolStripMenuItem.Text = "CheckMesh";
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preprocessToolStripMenuItem,
            this.postprocessToolStripMenuItem});
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
			this.settingToolStripMenuItem.Text = "Setting";
			// 
			// preprocessToolStripMenuItem
			// 
			this.preprocessToolStripMenuItem.Name = "preprocessToolStripMenuItem";
			this.preprocessToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
			this.preprocessToolStripMenuItem.Text = "Pre-process";
			// 
			// postprocessToolStripMenuItem
			// 
			this.postprocessToolStripMenuItem.Name = "postprocessToolStripMenuItem";
			this.postprocessToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
			this.postprocessToolStripMenuItem.Text = "Post-process";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// TopMenuStrip
			// 
			this.TopMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
			this.TopMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.TopMenuStrip.Name = "TopMenuStrip";
			this.TopMenuStrip.Size = new System.Drawing.Size(842, 28);
			this.TopMenuStrip.TabIndex = 1;
			this.TopMenuStrip.Text = "menuStrip1";
			// 
			// LeftPanel
			// 
			this.LeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.LeftPanel.Controls.Add(this.configbutton);
			this.LeftPanel.Controls.Add(this.LeftSideTree);
			this.LeftPanel.Location = new System.Drawing.Point(0, 35);
			this.LeftPanel.Name = "LeftPanel";
			this.LeftPanel.Size = new System.Drawing.Size(206, 518);
			this.LeftPanel.TabIndex = 3;
			// 
			// configbutton
			// 
			this.configbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.configbutton.Location = new System.Drawing.Point(26, 467);
			this.configbutton.Name = "configbutton";
			this.configbutton.Size = new System.Drawing.Size(146, 38);
			this.configbutton.TabIndex = 1;
			this.configbutton.Text = "Config";
			this.configbutton.UseVisualStyleBackColor = true;
			this.configbutton.Click += new System.EventHandler(this.configbutton_Click);
			// 
			// LeftSideTree
			// 
			this.LeftSideTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.LeftSideTree.BackColor = System.Drawing.SystemColors.Window;
			this.LeftSideTree.Location = new System.Drawing.Point(4, 4);
			this.LeftSideTree.Name = "LeftSideTree";
			treeNode1.Checked = true;
			treeNode1.Name = "TH";
			treeNode1.Text = "TH";
			treeNode2.Name = "THM";
			treeNode2.Text = "THM";
			treeNode3.Name = "THMC";
			treeNode3.Text = "THMC";
			treeNode4.Name = "Model";
			treeNode4.Text = "Model";
			treeNode5.Name = "Properties";
			treeNode5.Text = "Properties";
			treeNode6.Name = "TimeTerm";
			treeNode6.Text = "Time Term";
			treeNode7.Name = "GradientTerm";
			treeNode7.Text = "Gradient Term";
			treeNode8.Name = "DivTrem";
			treeNode8.Text = "Divergence Term";
			treeNode9.Name = "LaplacianSchemes";
			treeNode9.Text = "Laplacian Schemes";
			treeNode10.Name = "interpolationTerm";
			treeNode10.Text = "Interpolation Term";
			treeNode11.Name = "Schemes";
			treeNode11.Text = "Schemes";
			treeNode12.Name = "SolverRelaxation";
			treeNode12.Text = "Solver Relaxation";
			treeNode13.Name = "LinearSlover";
			treeNode13.Text = "Linear Slover";
			treeNode14.Name = "NonLinearSolver";
			treeNode14.Text = "Non-Linear Solver";
			treeNode15.Name = "Solution";
			treeNode15.Text = "Solution";
			treeNode16.Name = "TimeControl";
			treeNode16.Text = "Time Control";
			treeNode17.Name = "DataWrite";
			treeNode17.Text = "Data Write";
			treeNode18.Name = "Parallel";
			treeNode18.Text = "Parallel";
			treeNode19.Name = "Control";
			treeNode19.Text = "Control";
			treeNode20.Name = "ParaView";
			treeNode20.Text = "ParaView";
			treeNode21.Name = "Gnuplot";
			treeNode21.Text = "Gnuplot";
			treeNode22.Name = "Result";
			treeNode22.Text = "Result";
			this.LeftSideTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode11,
            treeNode15,
            treeNode19,
            treeNode22});
			this.LeftSideTree.Size = new System.Drawing.Size(202, 455);
			this.LeftSideTree.TabIndex = 0;
			this.LeftSideTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.RightSideTree_AfterSelect);
			// 
			// RightPanel1
			// 
			this.RightPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RightPanel1.Location = new System.Drawing.Point(213, 36);
			this.RightPanel1.MinimumSize = new System.Drawing.Size(620, 456);
			this.RightPanel1.Name = "RightPanel1";
			this.RightPanel1.Size = new System.Drawing.Size(620, 456);
			this.RightPanel1.TabIndex = 4;
			
			// makeFilesbutton
			// 
			this.makeFilesbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.makeFilesbutton.Location = new System.Drawing.Point(498, 502);
			this.makeFilesbutton.Name = "makeFilesbutton";
			this.makeFilesbutton.Size = new System.Drawing.Size(125, 38);
			this.makeFilesbutton.TabIndex = 1;
			this.makeFilesbutton.Text = "Make Files";
			this.makeFilesbutton.UseVisualStyleBackColor = true;
			this.makeFilesbutton.Click += new System.EventHandler(this.makeFilesbutton_Click);
			// 
			// runbutton
			// 
			this.runbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.runbutton.Location = new System.Drawing.Point(676, 502);
			this.runbutton.Name = "runbutton";
			this.runbutton.Size = new System.Drawing.Size(125, 38);
			this.runbutton.TabIndex = 1;
			this.runbutton.Text = "Run";
			this.runbutton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(842, 553);
			this.Controls.Add(this.runbutton);
			this.Controls.Add(this.makeFilesbutton);
			this.Controls.Add(this.RightPanel1);
			this.Controls.Add(this.LeftPanel);
			this.Controls.Add(this.TopMenuStrip);
			this.MainMenuStrip = this.TopMenuStrip;
			this.MinimumSize = new System.Drawing.Size(860, 600);
			this.Name = "MainForm";
			this.Text = "FoamConfig";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.TopMenuStrip.ResumeLayout(false);
			this.TopMenuStrip.PerformLayout();
			this.LeftPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem checkMeshToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem preprocessToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem postprocessToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.MenuStrip TopMenuStrip;
		private System.Windows.Forms.Panel LeftPanel;
		private System.Windows.Forms.TreeView LeftSideTree;
		private System.Windows.Forms.Button configbutton;
		private System.Windows.Forms.Panel RightPanel1;
		//
		//creat CongifPanels
		//
		private ControlDataWriting dataWritingPanel = new ControlDataWriting
		{
			Dock = System.Windows.Forms.DockStyle.Fill
		};
		private ControlTimeCon timeControlPanel = new ControlTimeCon
		{
			Dock = System.Windows.Forms.DockStyle.Fill
		};
		private SchemeTimePanel timeSchemePanel = new SchemeTimePanel
		{
			Dock = System.Windows.Forms.DockStyle.Fill
		};
		private SchemeGradientPanel gradientSchemePanel = new SchemeGradientPanel
		{
			Dock = System.Windows.Forms.DockStyle.Fill
		};
		private SchemeDivPanel divSchemePanel = new SchemeDivPanel
		{
			Dock = System.Windows.Forms.DockStyle.Fill
		};
		private SchemeLaplacianPanel laplacianSchemePanel = new SchemeLaplacianPanel
		{
			Dock = System.Windows.Forms.DockStyle.Fill
		};
		private SchemeInterpolationPanel interpolationPanel = new SchemeInterpolationPanel
		{
			Dock = System.Windows.Forms.DockStyle.Fill
		};
		private SolutionRelaxation relaxationSolutionPanel = new SolutionRelaxation
		{
			Dock = System.Windows.Forms.DockStyle.Fill
		};
		private SolutionLinear linearSolverPanel = new SolutionLinear
		{
			Dock = System.Windows.Forms.DockStyle.Fill
		};
		private SolutionNonLinear nonlinearSolverPanel = new SolutionNonLinear
		{
			Dock = System.Windows.Forms.DockStyle.Fill
		};
		private System.Windows.Forms.Button makeFilesbutton;
		private System.Windows.Forms.Button runbutton;
		
		//
	}
}


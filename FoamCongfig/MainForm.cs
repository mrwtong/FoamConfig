using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FoamCongfig
{
    using ConfigPanels;
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void RightSideTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (this.LeftSideTree.SelectedNode.Name == "DataWrite")
            {

                this.RightPanel1.Controls.Clear();
                this.RightPanel1.Controls.Add(this.dataWritingPanel);

            }
            if (this.LeftSideTree.SelectedNode.Name == "TimeControl")
            {

                this.RightPanel1.Controls.Clear();
                this.RightPanel1.Controls.Add(this.timeControlPanel);

            }
            if (this.LeftSideTree.SelectedNode.Name == "TimeTerm")
            {
                this.RightPanel1.Controls.Clear();
                this.RightPanel1.Controls.Add(this.timeSchemePanel);

            }
            if (this.LeftSideTree.SelectedNode.Name == "GradientTerm")
            {
                this.RightPanel1.Controls.Clear();
                this.RightPanel1.Controls.Add(this.gradientSchemePanel);

            }
            if (this.LeftSideTree.SelectedNode.Name == "DivTrem")
            {
                this.RightPanel1.Controls.Clear();
                this.RightPanel1.Controls.Add(this.divSchemePanel);

            }
            if (this.LeftSideTree.SelectedNode.Name == "LaplacianSchemes")
            {
                this.RightPanel1.Controls.Clear();
                this.RightPanel1.Controls.Add(this.laplacianSchemePanel);

            }
            if (this.LeftSideTree.SelectedNode.Name == "interpolationTerm")
            {
                this.RightPanel1.Controls.Clear();
                this.RightPanel1.Controls.Add(this.interpolationPanel);

            }
            if (this.LeftSideTree.SelectedNode.Name == "SolverRelaxation")
            {
                this.RightPanel1.Controls.Clear();
                this.RightPanel1.Controls.Add(this.relaxationSolutionPanel);

            }
            if (this.LeftSideTree.SelectedNode.Name == "LinearSlover")
            {
                this.RightPanel1.Controls.Clear();
                this.RightPanel1.Controls.Add(this.linearSolverPanel);

            }
            if (this.LeftSideTree.SelectedNode.Name == "NonLinearSolver")
            {
                this.RightPanel1.Controls.Clear();
                this.RightPanel1.Controls.Add(this.nonlinearSolverPanel);


            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LeftSideTree.ExpandAll();
            ModelParameter.SetField();
            this.RightPanel1.Controls.Add(this.dataWritingPanel);
            ControlDict.CreatControlDict();
            FvSchemes.CreatfvschemesDict();
            FvSolution.CreatnonlinearfvSolutionDicti();
            FvSolution.CreatlinearfvSolutionDicti(ModelParameter.fieldNumber);
            //instantiate in loading
            /*
			 * this.RightPanel1.Controls.Add(this.dataWritingPanel);
			this.RightPanel1.Controls.Add(this.timeSchemePanel);
			this.RightPanel1.Controls.Add(this.timeControlPanel);
			this.RightPanel1.Controls.Add(this.gradientSchemePanel);
			this.RightPanel1.Controls.Add(this.divSchemePanel);
			this.RightPanel1.Controls.Add(this.laplacianSchemePanel);
			this.RightPanel1.Controls.Add(this.interpolationPanel);
			this.RightPanel1.Controls.Add(this.relaxationSolutionPanel);
			this.RightPanel1.Controls.Add(this.linearSolverPanel);
			this.RightPanel1.Controls.Add(this.nonlinearSolverPanel);
			this.RightPanel1.Controls.Clear();
			*/

        }

        private void configbutton_Click(object sender, EventArgs e)
        {
            //从combobox完成dictionary
            //
            //ControlDicData
            try
            {
                ControlDict.controlDictTuples["writeFormat"] = ((string)dataWritingPanel.ComboWriteFormat.SelectedItem).Replace(" ", "");
                ControlDict.controlDictTuples["writePrecision"] = ((string)dataWritingPanel.comboWritePrecision.SelectedItem).Replace(" ", "");
                ControlDict.controlDictTuples["writeCompression"] = ((string)dataWritingPanel.comboCompression.SelectedItem).Replace(" ", "");
                ControlDict.controlDictTuples["timeFormat"] = ((string)dataWritingPanel.comboTimeFormat.SelectedItem).Replace(" ", "");
                ControlDict.controlDictTuples["timePrecision"] = ((string)dataWritingPanel.comboTimePrecision.SelectedItem).Replace(" ", "");
                ControlDict.controlDictTuples["graphFormat"] = ((string)dataWritingPanel.comboGraphFormat.SelectedItem).Replace(" ", "");
                ControlDict.controlDictTuples["writeControl"] = ((string)dataWritingPanel.writeControlcombo.SelectedItem).Replace(" ", "");
                ControlDict.controlDictTuples["writeInterval"] = dataWritingPanel.writeIntervalTextBox.Text;
                /*from 
				controlDictTuples.Add("writeControl", "");
				controlDictTuples.Add("writeFormat", "");
				controlDictTuples.Add("writePrecision", "");
				controlDictTuples.Add("writeCompression", "");
				controlDictTuples.Add("timeFormat", "");
				controlDictTuples.Add("timePrecision", "");
				controlDictTuples.Add("writeInterval", "");
				controlDictTuples.Add("writeControl", "");
				//
				//timeControl
				*/
            }
            catch
            {
                MessageBox.Show("WriteControl Panel Is Not Configurated");
            }

            try
            {
                ControlDict.controlDictTuples["startFrom"] = ((string)timeControlPanel.startFromCombo.SelectedItem).Replace(" ", "");
                ControlDict.controlDictTuples["stopAt"] = ((string)timeControlPanel.stopAtCombo.SelectedItem).Replace(" ", "");
                ControlDict.controlDictTuples["deltaT"] = timeControlPanel.timeStepTextbox.Text;
                if (timeControlPanel.startFromCombo.SelectedIndex == 1)
                {
                    ControlDict.controlDictTuples["startTime"] = timeControlPanel.startTimeTextbox.Text;
                }
                if (timeControlPanel.stopAtCombo.SelectedIndex == 0)
                {
                    ControlDict.controlDictTuples["endTime"] = timeControlPanel.endTimeTextBox.Text;
                }
                /*from
			 * controlDictTuples.Add("startFrom", "");
			controlDictTuples.Add("startTime", "");
			controlDictTuples.Add("stopAt", "");
			controlDictTuples.Add("deltaT", "");
			controlDictTuples.Add("endTime", "");*/
            }
            catch
            {
                MessageBox.Show("TimeControl Panel Is Not Configurated");
            }
            //
            //schemes
            //
            try
            {
                FvSchemes.fvSchemesDictTuples["ddtSchemes"] = ((string)timeSchemePanel.timeDefaultcomboBox.SelectedItem).Replace(" ", "");
                FvSchemes.fvSchemesDictTuples["gradSchemes"] = ((string)gradientSchemePanel.gradientDefaultcomboBox.SelectedItem).Replace(" ", "");
                FvSchemes.fvSchemesDictTuples["snGradSchemes"] = ((string)gradientSchemePanel.gradSngradcomboBox.SelectedItem).Replace(" ", "");
                FvSchemes.fvSchemesDictTuples["divSchemes"] = ((string)divSchemePanel.divDefaultcomboBox.SelectedItem).Replace(" ", "");
                FvSchemes.fvSchemesDictTuples["laplacianSchemes"] = ((string)laplacianSchemePanel.laplacianDefaultcomboBox.SelectedItem).Replace(" ", "");
                FvSchemes.fvSchemesDictTuples["interpolationSchemes"] = ((string)interpolationPanel.InterpolationDefaultcomboBox.SelectedItem).Replace(" ", "");
                if (gradientSchemePanel.gradSngradcomboBox.SelectedIndex == 0)
                {
                    FvSchemes.fvSchemesDictTuples["snCorrected"] = gradientSchemePanel.snCorrectedtextBox.Text;
                }
                if (timeSchemePanel.timeDefaultcomboBox.SelectedIndex == 3)
                {
                    FvSchemes.fvSchemesDictTuples["CrankNicolson"] = timeSchemePanel.CrankNicolsontextBox.Text;
                }
                /*from
			fvSchemesDictTuples.Add("dttSchemes", "");
			fvSchemesDictTuples.Add("gradSchemes", "");
			fvSchemesDictTuples.Add("divSchemes", "");
			fvSchemesDictTuples.Add("laplacianSchemes", "");
			fvSchemesDictTuples.Add("interpolationSchemes", "");
			fvSchemesDictTuples.Add("snGradSchemes", "");
			//optionalsetting
			fvSchemesDictTuples.Add("CrankNicolson", "");
			fvSchemesDictTuples.Add("snCorrected", "");*/
            }
            catch
            {
                MessageBox.Show("Schemes Panel Is Not Configurated");
            }


            //
            //solution
            ///

            try
            {

                for (int i = 0; i < ModelParameter.fieldNumber; i++)
                {

                    FvSolution.linearfvSolutionDictTuples[i]["solver"] = ((string)linearSolverPanel.linearsolversetting[i].solvercomboBox.SelectedItem).Replace(" ", "");
                    FvSolution.linearfvSolutionDictTuples[i]["smoother"] = ((string)linearSolverPanel.linearsolversetting[i].smoothercomboBox.SelectedItem).Replace(" ", "");
                    FvSolution.linearfvSolutionDictTuples[i]["tolerance"] = linearSolverPanel.linearsolversetting[i].tolerancetextBox1.Text;
                    FvSolution.linearfvSolutionDictTuples[i]["relTol"] = linearSolverPanel.linearsolversetting[i].relTolerancetextBox1textBox.Text;
                    if (relaxationSolutionPanel.fieldRelaxations[i].relaxaFactorcheckBox.Checked == true)
                        FvSolution.linearfvSolutionDictTuples[i]["relaxationFactors"] = relaxationSolutionPanel.fieldRelaxations[i].CoeffitextBox.Text;
                    if ((linearSolverPanel.linearsolversetting[i].perconditionercomboBox.Enabled == true) &&
                        (linearSolverPanel.linearsolversetting[i].perconditionercomboBox.SelectedIndex != 0))
                    {
                        FvSolution.linearfvSolutionDictTuples[i]["preconditioner"] = ((string)linearSolverPanel.linearsolversetting[i].perconditionercomboBox.SelectedItem).Replace(" ", "");
                    }
                    if (linearSolverPanel.linearsolversetting[i].smoothercomboBox.SelectedIndex != 0)
                    {
                        FvSolution.linearfvSolutionDictTuples[i]["nSweeps"] = ((string)linearSolverPanel.linearsolversetting[i].sweepcomboBox1.SelectedItem).Replace(" ", "");
                    }
                }
                FvSolution.nonlinearfvSolutionDictTuples["method"] = (string)nonlinearSolverPanel.nonlinermethondcomboBox.SelectedItem;
                if (nonlinearSolverPanel.nCorrectorstextBox.Enabled == true)
                {
                    FvSolution.nonlinearfvSolutionDictTuples["nCorrectors"] = (string)nonlinearSolverPanel.nCorrectorstextBox.Text;
                }
                if (nonlinearSolverPanel.nNonOrthogonalCorrectorstextBox.Enabled == true)
                {
                    FvSolution.nonlinearfvSolutionDictTuples["nNonOrthogonalCorrectors"] = (string)nonlinearSolverPanel.nNonOrthogonalCorrectorstextBox.Text;
                }
                if (nonlinearSolverPanel.nOuterCorrectorsLabeltextBox.Enabled == true)
                {
                    FvSolution.nonlinearfvSolutionDictTuples["nOuterCorrectors"] = (string)nonlinearSolverPanel.nOuterCorrectorsLabeltextBox.Text;
                }
                if (nonlinearSolverPanel.momentumPredictorboBox1.Enabled == true)
                {
                    FvSolution.nonlinearfvSolutionDictTuples["momentumPredictor"] = ((string)nonlinearSolverPanel.momentumPredictorboBox1.SelectedItem).Replace(" ", "");
                }
                /*  from

            linearfvSolutionDictTuples[i].Add("solver", "");
            linearfvSolutionDictTuples[i].Add("preconditioner", "");
            linearfvSolutionDictTuples[i].Add("smoother", "");
            linearfvSolutionDictTuples[i].Add("nSweeps", "");
            linearfvSolutionDictTuples[i].Add("tolerance", "");
            linearfvSolutionDictTuples[i].Add("relTol", "");
            linearfvSolutionDictTuples[i].Add("relaxationFactors", "");
            nonlinearfvSolutionDictTuples.Add("nCorrectors", "");
            nonlinearfvSolutionDictTuples.Add("nNonOrthogonalCorrectors", "");
            nonlinearfvSolutionDictTuples.Add("nOuterCorrectors", "");
            nonlinearfvSolutionDictTuples.Add("momentumPredictor", "");*/

            }
            catch
            {
                MessageBox.Show("Solution Panel Is Not Configurated");
            }








        }

        private void makeFilesbutton_Click(object sender, EventArgs e)
        {
            string controlDictFile = CasePath.casePath + "\\controlDict";
            string fvSchemesFile = CasePath.casePath + "\\fvSchemes";
            string fvSolutionFile = CasePath.casePath + "\\fvSolution";
            FileInfo controlDictinfo = new FileInfo(controlDictFile);
            FileInfo fvSchemesinfo = new FileInfo(fvSchemesFile);
            FileInfo fvSolutioninfo = new FileInfo(fvSolutionFile);
            if (controlDictinfo.Exists || fvSchemesinfo.Exists || fvSolutioninfo.Exists)
            {

                DialogResult filexist = MessageBox.Show("Override Existed Files?", "Warning", MessageBoxButtons.OKCancel);
                if (filexist != DialogResult.OK)
                {
                    return;
                }
            }
            
            /**/
            //Debug path
            try
            {
                File.Copy(Environment.CurrentDirectory + "\\..\\..\\Resources\\headcontrolDict.txt", controlDictFile, true);
                File.Copy(Environment.CurrentDirectory + "\\..\\..\\Resources\\headfvSchemes.txt", fvSchemesFile, true);
                File.Copy(Environment.CurrentDirectory + "\\..\\..\\Resources\\headfvSolution.txt", fvSolutionFile, true);
            }
            catch
            {
                //realease path
                File.Copy(Environment.CurrentDirectory + "\\Resources\\headcontrolDict.txt", controlDictFile, true);
                File.Copy(Environment.CurrentDirectory + "\\Resources\\headfvSchemes.txt", fvSchemesFile, true);
                File.Copy(Environment.CurrentDirectory + "\\Resources\\headfvSolution.txt", fvSolutionFile, true);
            }
           
            //
            //write controldict
            FileStream controlDictStream = new FileStream(controlDictFile, FileMode.Append);
            StreamWriter controlDictStreamWrite = new StreamWriter(controlDictStream);
            controlDictStreamWrite.WriteLine("startFrom" + "       " + ControlDict.controlDictTuples["startFrom"] + ";\n");
            if (ControlDict.controlDictTuples["startFrom"] == "startTime")
                controlDictStreamWrite.WriteLine("startTime" + "       " + ControlDict.controlDictTuples["startTime"] + ";\n");
            controlDictStreamWrite.WriteLine("stopAt" + "       " + ControlDict.controlDictTuples["stopAt"] + ";\n");
            if (ControlDict.controlDictTuples["stopAt"] == "endTime")
                controlDictStreamWrite.WriteLine("endTime" + "       " + ControlDict.controlDictTuples["endTime"] + ";\n");
            controlDictStreamWrite.WriteLine("deltaT" + "       " + ControlDict.controlDictTuples["deltaT"] + ";\n");
            controlDictStreamWrite.WriteLine("writeControl" + "       " + ControlDict.controlDictTuples["writeControl"] + ";\n");
            controlDictStreamWrite.WriteLine("writeInterval" + "       " + ControlDict.controlDictTuples["writeInterval"] + ";\n");
            controlDictStreamWrite.WriteLine("writeFormat" + "       " + ControlDict.controlDictTuples["writeFormat"] + ";\n");
            controlDictStreamWrite.WriteLine("writePrecision" + "       " + ControlDict.controlDictTuples["writePrecision"] + ";\n");
            controlDictStreamWrite.WriteLine("writeCompression" + "       " + ControlDict.controlDictTuples["writeCompression"] + ";\n");
            controlDictStreamWrite.WriteLine("timeFormat" + "       " + ControlDict.controlDictTuples["timeFormat"] + ";\n");
            controlDictStreamWrite.WriteLine("timePrecision" + "       " + ControlDict.controlDictTuples["timePrecision"] + ";\n");
            controlDictStreamWrite.WriteLine("graphFormat" + "       " + ControlDict.controlDictTuples["graphFormat"] + ";\n");
            controlDictStreamWrite.Close();
            controlDictStream.Close();
            //
            //write fvSchemes
            FileStream fvSchemesStream = new FileStream(fvSchemesFile, FileMode.Append);
            StreamWriter fvSchemesStreamWrite = new StreamWriter(fvSchemesStream);
            fvSchemesStreamWrite.WriteLine("\nddtSchemes\n{\n" + "  default         " + FvSchemes.fvSchemesDictTuples["ddtSchemes"] + ";\n}\n");
            fvSchemesStreamWrite.WriteLine("\ngradSchemes\n{\n" + "  default         " + FvSchemes.fvSchemesDictTuples["gradSchemes"] + ";\n}\n");
            fvSchemesStreamWrite.WriteLine("\ndivSchemes\n{\n" + "  default         " + FvSchemes.fvSchemesDictTuples["divSchemes"] + ";\n}\n");
            fvSchemesStreamWrite.WriteLine("\nlaplacianSchemes\n{\n" + "  default         " + FvSchemes.fvSchemesDictTuples["laplacianSchemes"] + ";\n}\n");
            fvSchemesStreamWrite.WriteLine("\ninterpolationSchemes\n{\n" + "  default         " + FvSchemes.fvSchemesDictTuples["interpolationSchemes"] + ";\n}\n");
            fvSchemesStreamWrite.WriteLine("\nsnGradSchemes\n{\n" + "  default         " + FvSchemes.fvSchemesDictTuples["snGradSchemes"] + ";\n}\n");
            fvSchemesStreamWrite.Close();
            fvSchemesStream.Close();
            //
            //write fvSolution
            FileStream fvSolutionStream = new FileStream(fvSolutionFile, FileMode.Append);
            StreamWriter fvSolutionStreamWrite = new StreamWriter(fvSolutionStream);
            fvSolutionStreamWrite.WriteLine("\n\nsolver\n{");
            for (int i = 0; i < ModelParameter.fieldNumber; i++)
            {
                fvSolutionStreamWrite.WriteLine(ModelParameter.Field[i] + "\n{\n");
                fvSolutionStreamWrite.WriteLine("      solver       " + FvSolution.linearfvSolutionDictTuples[i]["solver"] + ";\n");
                if (FvSolution.linearfvSolutionDictTuples[i]["preconditioner"] != "")
                {
                    fvSolutionStreamWrite.WriteLine("      preconditioner       " + FvSolution.linearfvSolutionDictTuples[i]["preconditioner"] + ";\n");
                }
                if (FvSolution.linearfvSolutionDictTuples[i]["nSweeps"] != "")
                {
                    fvSolutionStreamWrite.WriteLine("      smoother       " + FvSolution.linearfvSolutionDictTuples[i]["smoother"] + ";\n");
                    fvSolutionStreamWrite.WriteLine("      nSweeps       " + FvSolution.linearfvSolutionDictTuples[i]["nSweeps"] + ";\n");

                }
                fvSolutionStreamWrite.WriteLine("      tolerance       " + FvSolution.linearfvSolutionDictTuples[i]["tolerance"] + ";\n");
                fvSolutionStreamWrite.WriteLine("      relTol       " + FvSolution.linearfvSolutionDictTuples[i]["relTol"] + ";\n");
                fvSolutionStreamWrite.WriteLine("}\n");
            }
            fvSolutionStreamWrite.WriteLine(FvSolution.nonlinearfvSolutionDictTuples["method"] + "\n{\n");
            if (FvSolution.nonlinearfvSolutionDictTuples["nCorrectors"] != "")
            {
                fvSolutionStreamWrite.WriteLine("nCorrectors       " + FvSolution.nonlinearfvSolutionDictTuples["nCorrectors"] + ";\n");
            }
            if (FvSolution.nonlinearfvSolutionDictTuples["nNonOrthogonalCorrectors"] != "")
            {
                fvSolutionStreamWrite.WriteLine("nNonOrthogonalCorrectors       " + FvSolution.nonlinearfvSolutionDictTuples["nNonOrthogonalCorrectors"] + ";\n");
            }
            if (FvSolution.nonlinearfvSolutionDictTuples["nOuterCorrectors"] != "")
            {
                fvSolutionStreamWrite.WriteLine("nOuterCorrectors       " + FvSolution.nonlinearfvSolutionDictTuples["nOuterCorrectors"] + ";\n");
            }
            if (FvSolution.nonlinearfvSolutionDictTuples["momentumPredictor"] != "")
            {
                fvSolutionStreamWrite.WriteLine("momentumPredictor       " + FvSolution.nonlinearfvSolutionDictTuples["momentumPredictor"] + ";\n");
            }

            fvSolutionStreamWrite.WriteLine("\n\n}");
            fvSolutionStreamWrite.Close();
            fvSolutionStream.Close();
            //
            /*from
             * for (int i = 0; i < fieldNumber; i++)
        linearfvSolutionDictTuples[i] = new Dictionary<string, string>();
        linearfvSolutionDictTuples[i].Add("solver", "");
        linearfvSolutionDictTuples[i].Add("preconditioner", "");
        linearfvSolutionDictTuples[i].Add("smoother", "");
        linearfvSolutionDictTuples[i].Add("nSweeps", "");
        linearfvSolutionDictTuples[i].Add("tolerance", "");
        linearfvSolutionDictTuples[i].Add("relTol", "");
        //relaxtion
        linearfvSolutionDictTuples[i].Add("relaxationFactors", "");
        //nonlinear
        nonlinearfvSolutionDictTuples.Add("method", "");
        nonlinearfvSolutionDictTuples.Add("nCorrectors", "");
        nonlinearfvSolutionDictTuples.Add("nNonOrthogonalCorrectors", "");
        nonlinearfvSolutionDictTuples.Add("nOuterCorrectors", "");
        nonlinearfvSolutionDictTuples.Add("momentumPredictor", "");
     * */






        }
    }
}

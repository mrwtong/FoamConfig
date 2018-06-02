using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoamCongfig
{
	public static class CasePath
	{
		public static string casePath = null;
	
	}
	public static class ControlDict
	{
		public static Dictionary<string, string> controlDictTuples = new Dictionary<string, string>();
	    public static void CreatControlDict()
		{
			//controldata writing
			controlDictTuples.Add("writeControl", "");
			controlDictTuples.Add("writeFormat", "");
			controlDictTuples.Add("writePrecision", "");
			controlDictTuples.Add("writeCompression", "");
			controlDictTuples.Add("timeFormat", "");
			controlDictTuples.Add("timePrecision", "");
			controlDictTuples.Add("writeInterval", "");
			controlDictTuples.Add("graphFormat", "");
			//
			//controltime
			controlDictTuples.Add("startFrom", "");
			controlDictTuples.Add("startTime", "");
			controlDictTuples.Add("stopAt", "");
			controlDictTuples.Add("endTime", "");
			controlDictTuples.Add("deltaT", "");

		}
	}
	public static class FvSchemes
	{
		public static Dictionary<string, string> fvSchemesDictTuples = new Dictionary<string, string>();
		public static void CreatfvschemesDict()
		{
			//defaultTremSchemes
			fvSchemesDictTuples.Add("ddtSchemes", "");
			fvSchemesDictTuples.Add("gradSchemes", "");
			fvSchemesDictTuples.Add("divSchemes", "");
			fvSchemesDictTuples.Add("laplacianSchemes", "");
			fvSchemesDictTuples.Add("interpolationSchemes", "");
			fvSchemesDictTuples.Add("snGradSchemes", "");
			//optionalsetting
			fvSchemesDictTuples.Add("CrankNicolson", "");
			fvSchemesDictTuples.Add("snCorrected", "");




		}
	}
	public static class FvSolution
	{
		public static Dictionary<string, string>[] linearfvSolutionDictTuples = new Dictionary<string, string>[ModelParameter.fieldNumber];
		public static Dictionary<string, string> nonlinearfvSolutionDictTuples = new Dictionary<string, string>();
		public static void CreatlinearfvSolutionDicti(int fieldNumber)
		{
			//basic 
			for (int i = 0; i < fieldNumber; i++)
			{
				linearfvSolutionDictTuples[i] = new Dictionary<string, string>();
				linearfvSolutionDictTuples[i].Add("solver", "");
				linearfvSolutionDictTuples[i].Add("preconditioner", "");
				linearfvSolutionDictTuples[i].Add("smoother", "");
				linearfvSolutionDictTuples[i].Add("nSweeps", "");
				linearfvSolutionDictTuples[i].Add("tolerance", "");
				linearfvSolutionDictTuples[i].Add("relTol", "");
				//relaxtion
				linearfvSolutionDictTuples[i].Add("relaxationFactors", "");
			}
		}
		public static void CreatnonlinearfvSolutionDicti()
		{
			nonlinearfvSolutionDictTuples.Add("method", "");
			nonlinearfvSolutionDictTuples.Add("nCorrectors", "");
			nonlinearfvSolutionDictTuples.Add("nNonOrthogonalCorrectors", "");
			nonlinearfvSolutionDictTuples.Add("nOuterCorrectors", "");
			nonlinearfvSolutionDictTuples.Add("momentumPredictor", "");
		}
	}
	public static class DecomposeParDict
	{
		public static int numberOfSubdomains=0;
		public static Dictionary<string, string> decomposeDictTuples = new Dictionary<string, string>();
	}
	public static class ModelParameter
	{
		public static string modelType;
		public static int fieldNumber = 4;
		public static string[] Field = new string[fieldNumber];
		public static void SetField()
		{
			Field[0] = "p";
			Field[1] = "U";
			Field[2] = "Tf";
			Field[3] = "Ts";
		}

	}




}

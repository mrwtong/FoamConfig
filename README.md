# FoamConfig
A WinForm OpenFoam GUI for T-H-M-C coupling flow in porous media(In coding now)
### 一、程序目的
该程序目的是在图形界面下配置由OpenFOAM编写的求解器，并且生成配置文件保存在Case目录下。
#### 二、程序功能
保存配置文件所在路径，在窗口中显示求解器需要配置的关键字，并且使用Combobox控件选择关键字的配置信息。并且根据关键词的配置情况动态加载选项卡和启用控件。
配置完成后程序检测配置完成情况，提示没有配置的面板，并且在Case目录下生成配置文件。
### 三、程序主要模块
（1）Launch窗口：启动窗口，选择模型所在目录，并且设置求解器运行的模式（单线程或者并行）。  
（2）主窗口：将需要配置的关键字按类别归类后使用TreeView控件显示，点击树的叶子节点来切换右侧的配置选项卡。  
（3）面板控件类：根据TreeView的点击事件来动态的加载  
（4）数据类：使6个数据类来保存配置文件中所需的关键字和关键字对应的值。使用Dictionary<string, string>作为数据存贮的容器，关键字作为键，关键字对应的值作为键值。  
关键字列表：    
1、ControlDict  
（1）、Time control  
StartFrom: firstTime, startTime, latestTime,startTime  
StopAt：endTime，writeNow，noWriteNow，nextWrite，endTime  
DeltaT
（2）Data Writing  
writeControl：timeStep，runTime，adjustableRunTime，cpuTime，clockTime  
writeFormat：ascii，binary  
writePrecision：6，7，8 etc.  
writeCompression(gzip): on /off  
timeFormat:fixed，scientific，general  
timePrecision：6，7，8 etc  
graphFormat：raw，gnuplot，xmgr，jplot  
2、fvSchemes  
TimeSchemes（dttSchemes）：steadyState; backward，CrankNicolson 0.9，Eluer，localEuler  
GradSchemes（gradSchemes）：Gauss linear，cellLimited Gauss linear，leastSquares，Gauss cubic:  
DivSchemes（divSchemes）：Gauss linear，Gauss upwind;，Gauss linearUpwind grad(U)，Gauss LUST grad(U)，Gauss LUST unlimitedGrad(U)，Gauss limitedLinear 1，Gauss upwind，Gauss limitedLinearV 1，Gauss linearUpwindV grad(U)，  
LaplacianSchemes（laplacianSchemes）：Gauss linear corrected，Gauss linear limited corrected 0.33，Gauss linear orthogonal; Gauss linear uncorrected;  
interpolationSchemes（interpolationSchemes）: default，linear  
snGradSchemes（snGradSchemes）: corrected，uncorrected; limited corrected 0.33; orthogonal  
 
3、fvSolution  
1、Solution under-relaxation  
Fields ：  
RelaxationFactors  
2、Linear Solver Control：  
（1）solver：PCG/PBiCGStab（perconditioner DIC/DILU，FDIC，diagonal，GAMG，none），PCG/PBiCG:，smoothSolver，GAMG，diagonal   
（2）、Smoother：GaussSeidel，symGaussSeidel，DIC/DILU，DICGaussSeidel  
（3）、tolerance：1e-06  
（4）、relTol：0.05  
3、Non-linear Solver Control：  
（1）SIMPLE，PISO，PIMPLE，IMPES  

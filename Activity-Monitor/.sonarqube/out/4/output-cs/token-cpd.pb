�
sC:\Users\Anton\Downloads\THE REAL SCIENCE\УППРПО\Activity-Monitor\Activity-Monitor\ActivityMonitor\Program.cs
	namespace 	
ActivityMonitor
 
{ 
class 	
Program
 
{ 
static 
void 
Main 
( 
string 
[  
]  !
args" &
)& '
{ 	
Console		 
.		 
	WriteLine		 
(		 
$str		 1
)		1 2
;		2 3
}

 	
} 
} �	
�C:\Users\Anton\Downloads\THE REAL SCIENCE\УППРПО\Activity-Monitor\Activity-Monitor\ActivityMonitor\obj\Debug\netcoreapp2.2\SpecFlow.Plus.Runner.AssemblyHooks.cs
public 
class ;
/ActivityMonitor_SpecFlowPlusRunnerAssemblyHooks <
{ 
[ 
global 
:: 
TechTalk 
. 
SpecRun 
. 
AssemblyInitialize 0
]0 1
public 

static 
void 
AssemblyInitialize )
() *
)* +
{ 
TestRunnerManager 
. 
GetTestRunner '
(' (
)( )
.) *
OnTestRunStart* 8
(8 9
)9 :
;: ;
}		 
[ 
global 
:: 
TechTalk 
. 
SpecRun 
. 
AssemblyCleanup -
]- .
public 

static 
void 
AssemblyCleanup &
(& '
)' (
{ 
TestRunnerManager 
. 
OnTestRunEnd &
(& '
)' (
;( )
} 
} 